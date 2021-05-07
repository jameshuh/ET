
local function  genRuntimeCode( handler )
    local settings = handler.project:GetSettings("Publish").codeGeneration
    local codePkgName = handler:ToFilename(handler.pkg.name); --convert chinese to pinyin, remove special chars etc.
    local exportCodePath = handler.exportCodePath..'/'..codePkgName
    local namespaceName = codePkgName
    --local ns = 'fgui'
    local ns = ''
    
    if settings.packageName~=nil and settings.packageName~='' then
        namespaceName = settings.packageName..'.'..namespaceName;
    end

    --CollectClasses(stripeMemeber, stripeClass, fguiNamespace)
    local classes = handler:CollectClasses(settings.ignoreNoname, settings.ignoreNoname, ns)
    handler:SetupCodeFolder(exportCodePath, "ts") --check if target folder exists, and delete old files

    local getMemberByName = settings.getMemberByName

    local classCnt = classes.Count
    local writer = CodeWriter.new()
    for i=0,classCnt-1 do
        local classInfo = classes[i]
        local members = classInfo.members
        local references = classInfo.references
        writer:reset()

        --[[
        local refCount = references.Count
        if refCount>0 then
            for j=0,refCount-1 do
                local ref = references[j]
                writer:writeln('import %s from "./%s";', ref, ref)
            end
            writer:writeln()
        end
        ]]--

        writer:writeln('using FairyGUI;')
        writer:writeln('using FairyGUI.Utils;')
        writer:writeln()
        writer:writeln('namespace ET')
        writer:startBlock()
        writer:writeln('public partial class %s : %s', classInfo.className, classInfo.superClassName)
        writer:startBlock()

        local memberCnt = members.Count
        for j=0,memberCnt-1 do
            local memberInfo = members[j]
            writer:writeln('public %s %s;', memberInfo.type,memberInfo.varName)
        end
        writer:writeln('public const string URL = "ui://%s%s";', handler.pkg.id, classInfo.resId)
        writer:writeln()

        writer:writeln('public static %s CreateInstance()', classInfo.className)
        writer:startBlock()
        writer:writeln('return (%s) UIPackage.CreateObject("%s", "%s");', classInfo.className, handler.pkg.name, classInfo.resName)
        writer:endBlock()
        writer:writeln()
        writer:writeln('public %s()',classInfo.className)
        writer:startBlock()
        writer:endBlock()
        writer:writeln()
        writer:writeln('public override void ConstructFromXML(XML xml)')
        writer:startBlock()
        writer:writeln('base.ConstructFromXML(xml);')
        for j=0,memberCnt-1 do
            local memberInfo = members[j]
            if memberInfo.group==0 then
                if getMemberByName then
                    writer:writeln('%s = (%s)this.GetChild("%s");', memberInfo.varName, memberInfo.type, memberInfo.name)
                else
                    writer:writeln('%s = (%s)this.GetChildAt(%s);', memberInfo.varName, memberInfo.type, memberInfo.index)
                end
            elseif memberInfo.group==1 then
                if getMemberByName then
                    writer:writeln('%s = this.GetController("%s");', memberInfo.varName, memberInfo.name)
                else
                    writer:writeln('%s = this.GetControllerAt(%s);', memberInfo.varName, memberInfo.index)
                end
            else
                if getMemberByName then
                    writer:writeln('%s = this.GetTransition("%s");', memberInfo.varName, memberInfo.name)
                else
                    writer:writeln('%s = this.GetTransitionAt(%s);', memberInfo.varName, memberInfo.index)
                end
            end
        end
        writer:endBlock()

        writer:endBlock() --class

        writer:endBlock()--
        writer:save(exportCodePath..'/'..classInfo.className..'.cs')
    end

    writer:reset()

    local binderName = codePkgName..'Binder'

    writer:writeln('using FairyGUI;')
    writer:writeln('namespace ET')
    writer:startBlock()
    writer:writeln()
    writer:writeln('public class %s', binderName)
    writer:startBlock()

    writer:writeln('public static void BindAll()')
    writer:startBlock()
    for i=0,classCnt-1 do
        local classInfo = classes[i]
        writer:writeln('UIObjectFactory.SetPackageItemExtension(%s.URL,typeof( %s));', classInfo.className, classInfo.className)
    end
    writer:endBlock() --bindall

    writer:endBlock() --class
    writer:endBlock()--namespace
    writer:save(exportCodePath..'/'..binderName..'.cs')
end

local function genHotfixCode(handler)
    local settings = handler.project:GetSettings("Publish").codeGeneration
    local codePkgName = handler:ToFilename(handler.pkg.name); --convert chinese to pinyin, remove special chars etc.
    local exportCodePath = handler.exportCodePath..'/'..codePkgName
    local namespaceName = settings.packageName
    
    --if settings.packageName~=nil and settings.packageName~='' then
    --    namespaceName = settings.packageName..'.'..namespaceName;
    --end

    --CollectClasses(stripeMemeber, stripeClass, fguiNamespace)
    local classes = handler:CollectClasses(settings.ignoreNoname, settings.ignoreNoname, nil)
    handler:SetupCodeFolder(exportCodePath, "cs") --check if target folder exists, and delete old files

    local getMemberByName = settings.getMemberByName

    local classCnt = classes.Count

    local writer = CodeWriter.new()
    for i=0,classCnt-1 do
        local classInfo = classes[i]
        local members = classInfo.members
        writer:reset()

        writer:writeln('using FairyGUI;')
        --writer:writeln('using FairyGUI.Utils;')

        writer:writeln()
        writer:writeln('namespace %s', namespaceName)
        writer:startBlock()
        writer:writeln('[ObjectSystem]')
        writer:writeln('public class %sAwakeSystem : AwakeSystem<%s, GObject>',classInfo.className,classInfo.className)
        writer:startBlock()
        writer:writeln('public override void Awake(%s self, GObject go)',classInfo.className)
        writer:startBlock()
        writer:writeln('self.Awake(go);')
        writer:endBlock()
        writer:endBlock()
        writer:writeln()

        writer:writeln('public sealed class %s : FGUI', classInfo.className)
        writer:startBlock()
        writer:writeln('public const string UIPackageName = "%s";',handler.pkg.name)
        writer:writeln('public const string UIResName = "%s";',classInfo.resName)
        writer:writeln()
        writer:writeln('/// <summary>')
        writer:writeln('/// %s的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。',classInfo.resName)
        writer:writeln('/// </summary>')
        writer:writeln('public %s self;',classInfo.superClassName)
        writer:writeln()

        local memberCnt = members.Count
        for j=0,memberCnt-1 do
            local memberInfo = members[j]
            writer:writeln('public %s %s;', memberInfo.type, memberInfo.varName)
        end
        writer:writeln()

        writer:writeln('public static %s CreateInstance(Scene domain)',classInfo.className)
        writer:startBlock()
        writer:writeln('return Create(domain, UIHelper.CreateGObject(domain,UIPackageName,UIResName));')
        writer:endBlock()
        writer:writeln()
        writer:writeln('public static async ETTask<%s> CreateInstanceAsync(Scene domain)',classInfo.className)
        writer:startBlock()
        writer:writeln('var go = await UIHelper.CreateGObjectAsync(domain,UIPackageName, UIResName);')
        writer:writeln('return Create(domain, go);')
        writer:endBlock()
        writer:writeln()
        writer:writeln('public static %s Create(Entity domain, GObject go)',classInfo.className)
        writer:startBlock()
        writer:writeln('return EntityFactory.Create<%s, GObject>(domain, go);',classInfo.className)
        writer:endBlock()
        writer:writeln()
        writer:writeln('/// <summary>')
        writer:writeln('/// 通过此方法获取的FGUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。')
        writer:writeln('/// </summary>')
        writer:writeln('public static %s GetFormPool(Entity domain, GObject go)',classInfo.className)
        writer:startBlock()
        writer:writeln('var fgui = go.Get<%s>();',classInfo.className)
        writer:writeln()
        writer:writeln('if(fgui == null)')
        writer:startBlock()
        writer:writeln('fgui = Create(domain, go);')
        writer:endBlock()
        writer:writeln()
        writer:writeln('fgui.isFromFGUIPool = true;')
        writer:writeln()
        writer:writeln('return fgui;')
        writer:endBlock()
        writer:writeln()
        writer:writeln('public void Awake(GObject go)')
        writer:startBlock()
        writer:writeln('if(go == null)')
        writer:startBlock()
        writer:writeln('return;')
        writer:endBlock()
        writer:writeln()
        writer:writeln('GObject = go;   ')
        writer:writeln()
        writer:writeln('if (string.IsNullOrWhiteSpace(Name))')
        writer:startBlock()
        writer:writeln('Name = Id.ToString();')
        writer:endBlock()
        writer:writeln()
        writer:writeln('self = (%s)go;',classInfo.superClassName)
        writer:writeln()
        writer:writeln('self.Add(this);')
        writer:writeln()
        writer:writeln('var com = go.asCom;')
        writer:writeln()
        writer:writeln('if(com != null)')
        writer:startBlock()
        for j=0,memberCnt-1 do
            local memberInfo = members[j]
            if memberInfo.group==0 then
                if string.sub(memberInfo.type,1,4) == "FGUI" then
                    writer:writeln('%s = %s.Create(domain, com.GetChild("%s"));', memberInfo.varName, memberInfo.type, memberInfo.name)
                else
                    if getMemberByName then
                        writer:writeln('%s = (%s)com.GetChild("%s");', memberInfo.varName, memberInfo.type, memberInfo.name)
                    else
                        writer:writeln('%s = (%s)com.GetChildAt(%s);', memberInfo.varName, memberInfo.type, memberInfo.index)
                    end
                end
            elseif memberInfo.group==1 then
                if getMemberByName then
                    writer:writeln('%s = com.GetController("%s");', memberInfo.varName, memberInfo.name)
                else
                    writer:writeln('%s = com.GetControllerAt(%s);', memberInfo.varName, memberInfo.index)
                end
            else
                if getMemberByName then
                    writer:writeln('%s = com.GetTransition("%s");', memberInfo.varName, memberInfo.name)
                else
                    writer:writeln('%s = com.GetTransitionAt(%s);', memberInfo.varName, memberInfo.index)
                end
            end
        end
        writer:endBlock()
        writer:endBlock()

       
        writer:writeln()
        writer:writeln('public override void Dispose()')
        writer:startBlock()
        writer:writeln('if(IsDisposed)')
        writer:startBlock()
        writer:writeln('return;')
        writer:endBlock()
        writer:writeln()
        writer:writeln('base.Dispose();')
        writer:writeln()
        writer:writeln('self.Remove();')
        writer:writeln('self = null;')
        for j=0,memberCnt-1 do
            local memberInfo = members[j]
            if memberInfo.group==0 then
                if string.sub(memberInfo.type,1,4) == "FGUI" then
                    writer:writeln('%s.Dispose();', memberInfo.varName)
                end
                writer:writeln('%s = null;', memberInfo.varName)
            elseif memberInfo.group==1 then
                writer:writeln('%s = null;', memberInfo.varName)
            else
                writer:writeln('%s = null;', memberInfo.varName)
            end
        end
        writer:endBlock()
        writer:writeln()
        writer:endBlock() --class
        writer:endBlock() --namepsace

        writer:save(exportCodePath..'/'..classInfo.className..'.cs')
    end

    writer:reset()

    --local binderName = codePkgName..'Binder'

    --writer:writeln('using FairyGUI;')
    --writer:writeln()
    writer:writeln('namespace %s', namespaceName)
    writer:startBlock()
    writer:writeln('public static partial class FGUIPackage')
    writer:startBlock()
    writer:writeln('public const string %s = "%s";',codePkgName,codePkgName)
    local item = handler.items
    local itemCnt = item.Count
    for i=0,itemCnt-1 do
        local itemInfo = item[i]
        if itemInfo.exported then
            writer:writeln('public const string %s_%s = "ui://%s/%s";',codePkgName,itemInfo:ToString(),codePkgName,itemInfo:ToString())
        end
    end
    --writer:writeln('public static void BindAll()')
    --writer:startBlock()
    --for i=0,classCnt-1 do
    --    local classInfo = classes[i]
    --    writer:writeln('UIObjectFactory.SetPackageItemExtension(%s.URL, typeof(%s));', classInfo.className, classInfo.className)
    --end
    --writer:endBlock() --bindall
    
    writer:endBlock() --class
    writer:endBlock() --namespace
    writer:save(exportCodePath..'/PackageHotfix.cs')
end

function onPublish(handler)
    --fprint("Handling gen code in plugin")
    if not handler.genCode then return end
    handler.genCode = false --prevent default output

    if handler.pkg.name == "Runtime" then
        genRuntimeCode(handler)
    else
        genHotfixCode(handler) 
    end
end
