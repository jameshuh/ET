local breakSocketHandle,debugXpCall = require("LuaDebugjit")("localhost",7003)
local timer = Timer.New(function() 
breakSocketHandle() end, 1, -1, false)
timer:Start();

require("CSharpLua.Classloader")

setmetatable(System.IO,  {__index = toluaSystem.IO})
setmetatable(System.Text, {__index = toluaSystem.Text})

require("Google ProtoBuf.manifest")("Google ProtoBuf")
require("Core.manifest")("Core")
require("Message.manifest")("Message")
require("Config.manifest")("Config")
require("BehaviorTree.manifest")("BehaviorTree")
require("FairyGUI.manifest")("FairyGUI")
require("Hotfix.manifest")("Hotfix")

function Main()					
	print("logic start")
    DCET.Hotfix.Init.Start()
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end