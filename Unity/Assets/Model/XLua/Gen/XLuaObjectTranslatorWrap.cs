#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class XLuaObjectTranslatorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.ObjectTranslator);
			Utils.BeginObjectRegister(type, L, translator, 0, 250, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineVector2", _m_PushUnityEngineVector2);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Get", _m_Get);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineVector2", _m_UpdateUnityEngineVector2);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineVector3", _m_PushUnityEngineVector3);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineVector3", _m_UpdateUnityEngineVector3);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineVector4", _m_PushUnityEngineVector4);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineVector4", _m_UpdateUnityEngineVector4);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineColor", _m_PushUnityEngineColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineColor", _m_UpdateUnityEngineColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineQuaternion", _m_PushUnityEngineQuaternion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineQuaternion", _m_UpdateUnityEngineQuaternion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineRay", _m_PushUnityEngineRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineRay", _m_UpdateUnityEngineRay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineBounds", _m_PushUnityEngineBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineBounds", _m_UpdateUnityEngineBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushUnityEngineRay2D", _m_PushUnityEngineRay2D);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUnityEngineRay2D", _m_UpdateUnityEngineRay2D);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonBsonBinarySubType", _m_PushMongoDBBsonBsonBinarySubType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonBsonBinarySubType", _m_UpdateMongoDBBsonBsonBinarySubType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonBsonType", _m_PushMongoDBBsonBsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonBsonType", _m_UpdateMongoDBBsonBsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonDuplicateNameHandling", _m_PushMongoDBBsonDuplicateNameHandling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonDuplicateNameHandling", _m_UpdateMongoDBBsonDuplicateNameHandling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonGuidRepresentation", _m_PushMongoDBBsonGuidRepresentation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonGuidRepresentation", _m_UpdateMongoDBBsonGuidRepresentation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonSerializationOptionsDictionaryRepresentation", _m_PushMongoDBBsonSerializationOptionsDictionaryRepresentation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonSerializationOptionsDictionaryRepresentation", _m_UpdateMongoDBBsonSerializationOptionsDictionaryRepresentation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonSerializationOptionsTimeSpanUnits", _m_PushMongoDBBsonSerializationOptionsTimeSpanUnits);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonSerializationOptionsTimeSpanUnits", _m_UpdateMongoDBBsonSerializationOptionsTimeSpanUnits);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonIOBsonReaderState", _m_PushMongoDBBsonIOBsonReaderState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonIOBsonReaderState", _m_UpdateMongoDBBsonIOBsonReaderState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonIOBsonWriterState", _m_PushMongoDBBsonIOBsonWriterState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonIOBsonWriterState", _m_UpdateMongoDBBsonIOBsonWriterState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonIOContextType", _m_PushMongoDBBsonIOContextType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonIOContextType", _m_UpdateMongoDBBsonIOContextType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonIOJsonOutputMode", _m_PushMongoDBBsonIOJsonOutputMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonIOJsonOutputMode", _m_UpdateMongoDBBsonIOJsonOutputMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMongoDBBsonIOJsonTokenType", _m_PushMongoDBBsonIOJsonTokenType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMongoDBBsonIOJsonTokenType", _m_UpdateMongoDBBsonIOJsonTokenType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelChannelType", _m_PushDCETModelChannelType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelChannelType", _m_UpdateDCETModelChannelType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelNetworkProtocol", _m_PushDCETModelNetworkProtocol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelNetworkProtocol", _m_UpdateDCETModelNetworkProtocol);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelParserState", _m_PushDCETModelParserState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelParserState", _m_UpdateDCETModelParserState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushLitJsonJsonType", _m_PushLitJsonJsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateLitJsonJsonType", _m_UpdateLitJsonJsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushLitJsonJsonToken", _m_PushLitJsonJsonToken);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateLitJsonJsonToken", _m_UpdateLitJsonJsonToken);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelNumericType", _m_PushDCETModelNumericType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelNumericType", _m_UpdateDCETModelNumericType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelCoroutineLockType", _m_PushDCETModelCoroutineLockType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelCoroutineLockType", _m_UpdateDCETModelCoroutineLockType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFHeuristicOptimizationMode", _m_PushPFHeuristicOptimizationMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFHeuristicOptimizationMode", _m_UpdatePFHeuristicOptimizationMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFGraphUpdateThreading", _m_PushPFGraphUpdateThreading);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFGraphUpdateThreading", _m_UpdatePFGraphUpdateThreading);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFThreadCount", _m_PushPFThreadCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFThreadCount", _m_UpdatePFThreadCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFPathState", _m_PushPFPathState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFPathState", _m_UpdatePFPathState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFPathCompleteState", _m_PushPFPathCompleteState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFPathCompleteState", _m_UpdatePFPathCompleteState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFCloseToDestinationMode", _m_PushPFCloseToDestinationMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFCloseToDestinationMode", _m_UpdatePFCloseToDestinationMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFSide", _m_PushPFSide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFSide", _m_UpdatePFSide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFInspectorGridMode", _m_PushPFInspectorGridMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFInspectorGridMode", _m_UpdatePFInspectorGridMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFGraphDebugMode", _m_PushPFGraphDebugMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFGraphDebugMode", _m_UpdatePFGraphDebugMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFPathLog", _m_PushPFPathLog);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFPathLog", _m_UpdatePFPathLog);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFHeuristic", _m_PushPFHeuristic);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFHeuristic", _m_UpdatePFHeuristic);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingRVOMovementPlane", _m_PushPathfindingRVOMovementPlane);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingRVOMovementPlane", _m_UpdatePathfindingRVOMovementPlane);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingRVORVOLayer", _m_PushPathfindingRVORVOLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingRVORVOLayer", _m_UpdatePathfindingRVORVOLayer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushAstarPathAstarDistribution", _m_PushAstarPathAstarDistribution);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateAstarPathAstarDistribution", _m_UpdateAstarPathAstarDistribution);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFMultiTargetPathHeuristicMode", _m_PushPFMultiTargetPathHeuristicMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFMultiTargetPathHeuristicMode", _m_UpdatePFMultiTargetPathHeuristicMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPFRecastGraphRelevantGraphSurfaceMode", _m_PushPFRecastGraphRelevantGraphSurfaceMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePFRecastGraphRelevantGraphSurfaceMode", _m_UpdatePFRecastGraphRelevantGraphSurfaceMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingSeekerModifierPass", _m_PushPathfindingSeekerModifierPass);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingSeekerModifierPass", _m_UpdatePathfindingSeekerModifierPass);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingGraphModifierEventType", _m_PushPathfindingGraphModifierEventType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingGraphModifierEventType", _m_UpdatePathfindingGraphModifierEventType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingRaycastModifierQuality", _m_PushPathfindingRaycastModifierQuality);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingRaycastModifierQuality", _m_UpdatePathfindingRaycastModifierQuality);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingSimpleSmoothModifierSmoothType", _m_PushPathfindingSimpleSmoothModifierSmoothType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingSimpleSmoothModifierSmoothType", _m_UpdatePathfindingSimpleSmoothModifierSmoothType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingStartEndModifierExactness", _m_PushPathfindingStartEndModifierExactness);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingStartEndModifierExactness", _m_UpdatePathfindingStartEndModifierExactness);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingBlockManagerBlockMode", _m_PushPathfindingBlockManagerBlockMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingBlockManagerBlockMode", _m_UpdatePathfindingBlockManagerBlockMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushPathfindingRVORVOObstacleObstacleVertexWinding", _m_PushPathfindingRVORVOObstacleObstacleVertexWinding);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdatePathfindingRVORVOObstacleObstacleVertexWinding", _m_UpdatePathfindingRVORVOObstacleObstacleVertexWinding);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushGoogleProtobufWireFormatWireType", _m_PushGoogleProtobufWireFormatWireType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateGoogleProtobufWireFormatWireType", _m_UpdateGoogleProtobufWireFormatWireType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIBlendMode", _m_PushFairyGUIBlendMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIBlendMode", _m_UpdateFairyGUIBlendMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIHitTestMode", _m_PushFairyGUIHitTestMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIHitTestMode", _m_UpdateFairyGUIHitTestMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIDestroyMethod", _m_PushFairyGUIDestroyMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIDestroyMethod", _m_UpdateFairyGUIDestroyMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIEaseType", _m_PushFairyGUIEaseType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIEaseType", _m_UpdateFairyGUIEaseType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUITweenPropType", _m_PushFairyGUITweenPropType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUITweenPropType", _m_UpdateFairyGUITweenPropType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIPackageItemType", _m_PushFairyGUIPackageItemType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIPackageItemType", _m_UpdateFairyGUIPackageItemType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIObjectType", _m_PushFairyGUIObjectType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIObjectType", _m_UpdateFairyGUIObjectType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIAlignType", _m_PushFairyGUIAlignType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIAlignType", _m_UpdateFairyGUIAlignType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIVertAlignType", _m_PushFairyGUIVertAlignType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIVertAlignType", _m_UpdateFairyGUIVertAlignType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOverflowType", _m_PushFairyGUIOverflowType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOverflowType", _m_UpdateFairyGUIOverflowType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIFillType", _m_PushFairyGUIFillType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIFillType", _m_UpdateFairyGUIFillType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIAutoSizeType", _m_PushFairyGUIAutoSizeType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIAutoSizeType", _m_UpdateFairyGUIAutoSizeType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIScrollType", _m_PushFairyGUIScrollType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIScrollType", _m_UpdateFairyGUIScrollType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIScrollBarDisplayType", _m_PushFairyGUIScrollBarDisplayType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIScrollBarDisplayType", _m_UpdateFairyGUIScrollBarDisplayType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIRelationType", _m_PushFairyGUIRelationType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIRelationType", _m_UpdateFairyGUIRelationType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIListLayoutType", _m_PushFairyGUIListLayoutType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIListLayoutType", _m_UpdateFairyGUIListLayoutType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIListSelectionMode", _m_PushFairyGUIListSelectionMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIListSelectionMode", _m_UpdateFairyGUIListSelectionMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIProgressTitleType", _m_PushFairyGUIProgressTitleType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIProgressTitleType", _m_UpdateFairyGUIProgressTitleType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIButtonMode", _m_PushFairyGUIButtonMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIButtonMode", _m_UpdateFairyGUIButtonMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUITransitionActionType", _m_PushFairyGUITransitionActionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUITransitionActionType", _m_UpdateFairyGUITransitionActionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIGroupLayoutType", _m_PushFairyGUIGroupLayoutType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIGroupLayoutType", _m_UpdateFairyGUIGroupLayoutType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIChildrenRenderOrder", _m_PushFairyGUIChildrenRenderOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIChildrenRenderOrder", _m_UpdateFairyGUIChildrenRenderOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIPopupDirection", _m_PushFairyGUIPopupDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIPopupDirection", _m_UpdateFairyGUIPopupDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIFlipType", _m_PushFairyGUIFlipType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIFlipType", _m_UpdateFairyGUIFlipType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIFillMethod", _m_PushFairyGUIFillMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIFillMethod", _m_UpdateFairyGUIFillMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOriginHorizontal", _m_PushFairyGUIOriginHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOriginHorizontal", _m_UpdateFairyGUIOriginHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOriginVertical", _m_PushFairyGUIOriginVertical);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOriginVertical", _m_UpdateFairyGUIOriginVertical);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOrigin90", _m_PushFairyGUIOrigin90);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOrigin90", _m_UpdateFairyGUIOrigin90);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOrigin180", _m_PushFairyGUIOrigin180);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOrigin180", _m_UpdateFairyGUIOrigin180);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIOrigin360", _m_PushFairyGUIOrigin360);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIOrigin360", _m_UpdateFairyGUIOrigin360);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIFitScreen", _m_PushFairyGUIFitScreen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIFitScreen", _m_UpdateFairyGUIFitScreen);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIUtilsHtmlElementType", _m_PushFairyGUIUtilsHtmlElementType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIUtilsHtmlElementType", _m_UpdateFairyGUIUtilsHtmlElementType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIUtilsXMLTagType", _m_PushFairyGUIUtilsXMLTagType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIUtilsXMLTagType", _m_UpdateFairyGUIUtilsXMLTagType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIRTLSupportDirectionType", _m_PushFairyGUIRTLSupportDirectionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIRTLSupportDirectionType", _m_UpdateFairyGUIRTLSupportDirectionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUITextFormatSpecialStyle", _m_PushFairyGUITextFormatSpecialStyle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUITextFormatSpecialStyle", _m_UpdateFairyGUITextFormatSpecialStyle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIGPathPointCurveType", _m_PushFairyGUIGPathPointCurveType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIGPathPointCurveType", _m_UpdateFairyGUIGPathPointCurveType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIControllerActionActionType", _m_PushFairyGUIControllerActionActionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIControllerActionActionType", _m_UpdateFairyGUIControllerActionActionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIUIConfigConfigKey", _m_PushFairyGUIUIConfigConfigKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIUIConfigConfigKey", _m_UpdateFairyGUIUIConfigConfigKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIUIContentScalerScaleMode", _m_PushFairyGUIUIContentScalerScaleMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIUIContentScalerScaleMode", _m_UpdateFairyGUIUIContentScalerScaleMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushFairyGUIUIContentScalerScreenMatchMode", _m_PushFairyGUIUIContentScalerScreenMatchMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateFairyGUIUIContentScalerScreenMatchMode", _m_UpdateFairyGUIUIContentScalerScreenMatchMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaGenFlag", _m_PushXLuaGenFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaGenFlag", _m_UpdateXLuaGenFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaOptimizeFlag", _m_PushXLuaOptimizeFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaOptimizeFlag", _m_UpdateXLuaOptimizeFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaHotfixFlag", _m_PushXLuaHotfixFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaHotfixFlag", _m_UpdateXLuaHotfixFlag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaLuaTypes", _m_PushXLuaLuaTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaLuaTypes", _m_UpdateXLuaLuaTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaLuaGCOptions", _m_PushXLuaLuaGCOptions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaLuaGCOptions", _m_UpdateXLuaLuaGCOptions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaLuaThreadStatus", _m_PushXLuaLuaThreadStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaLuaThreadStatus", _m_UpdateXLuaLuaThreadStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaLazyMemberTypes", _m_PushXLuaLazyMemberTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaLazyMemberTypes", _m_UpdateXLuaLazyMemberTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushXLuaTemplateEngineTokenType", _m_PushXLuaTemplateEngineTokenType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateXLuaTemplateEngineTokenType", _m_UpdateXLuaTemplateEngineTokenType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMikuLuaProfilerLuaTypes", _m_PushMikuLuaProfilerLuaTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMikuLuaProfilerLuaTypes", _m_UpdateMikuLuaProfilerLuaTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMikuLuaProfilerLuaGCOptions", _m_PushMikuLuaProfilerLuaGCOptions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMikuLuaProfilerLuaGCOptions", _m_UpdateMikuLuaProfilerLuaGCOptions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMikuLuaProfilerTK", _m_PushMikuLuaProfilerTK);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMikuLuaProfilerTK", _m_UpdateMikuLuaProfilerTK);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelAwaiterStatus", _m_PushDCETModelAwaiterStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelAwaiterStatus", _m_UpdateDCETModelAwaiterStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelEnvKey", _m_PushDCETModelEnvKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelEnvKey", _m_UpdateDCETModelEnvKey);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelLogType", _m_PushDCETModelLogType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelLogType", _m_UpdateDCETModelLogType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelEntityStatus", _m_PushDCETModelEntityStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelEntityStatus", _m_UpdateDCETModelEntityStatus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelSceneType", _m_PushDCETModelSceneType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelSceneType", _m_UpdateDCETModelSceneType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelAppType", _m_PushDCETModelAppType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelAppType", _m_UpdateDCETModelAppType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelMotionType", _m_PushDCETModelMotionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelMotionType", _m_UpdateDCETModelMotionType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType", _m_PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType", _m_UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason", _m_PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason", _m_UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDCETModelMapType", _m_PushDCETModelMapType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateDCETModelMapType", _m_UpdateDCETModelMapType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DelayWrapLoader", _m_DelayWrapLoader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddInterfaceBridgeCreator", _m_AddInterfaceBridgeCreator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryDelayWrapLoader", _m_TryDelayWrapLoader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Alias", _m_Alias);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateDelegateBridge", _m_CreateDelegateBridge);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AllDelegateBridgeReleased", _m_AllDelegateBridgeReleased);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReleaseLuaBase", _m_ReleaseLuaBase);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateInterfaceBridge", _m_CreateInterfaceBridge);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateArrayMetatable", _m_CreateArrayMetatable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateDelegateMetatable", _m_CreateDelegateMetatable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OpenLib", _m_OpenLib);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTypeOf", _m_GetTypeOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Assignable", _m_Assignable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObject", _m_GetObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParams", _m_GetParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushParams", _m_PushParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTypeId", _m_GetTypeId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PrivateAccessible", _m_PrivateAccessible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushAny", _m_PushAny);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TranslateToEnumToTop", _m_TranslateToEnumToTop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Push", _m_Push);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushObject", _m_PushObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasCustomOp", _m_HasCustomOp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PushDecimal", _m_PushDecimal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsDecimal", _m_IsDecimal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDecimal", _m_GetDecimal);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cacheRef", _g_get_cacheRef);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "cacheRef", _s_set_cacheRef);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<XLua.LuaEnv>(L, 2) && LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 3))
				{
					XLua.LuaEnv _luaenv = (XLua.LuaEnv)translator.GetObject(L, 2, typeof(XLua.LuaEnv));
					System.IntPtr _L = LuaAPI.lua_touserdata(L, 3);
					
					XLua.ObjectTranslator gen_ret = new XLua.ObjectTranslator(_luaenv, _L);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.ObjectTranslator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineVector2(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Vector2 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineVector2( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector2 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineVector2(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector3 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineVector3(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector4 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineVector4(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Color _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineColor(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Quaternion _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineQuaternion(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineRay(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Bounds _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineBounds(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray2D _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushUnityEngineRay2D(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.BsonBinarySubType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonBsonBinarySubType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.BsonType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonBsonType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.DuplicateNameHandling _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonDuplicateNameHandling(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.GuidRepresentation _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonGuidRepresentation(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.Serialization.Options.DictionaryRepresentation _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonSerializationOptionsDictionaryRepresentation(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.Serialization.Options.TimeSpanUnits _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.BsonReaderState _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonIOBsonReaderState(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.BsonWriterState _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonIOBsonWriterState(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.ContextType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonIOContextType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.JsonOutputMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonIOJsonOutputMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.JsonTokenType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMongoDBBsonIOJsonTokenType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.ChannelType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelChannelType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.NetworkProtocol _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelNetworkProtocol(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.ParserState _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelParserState(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    LitJson.JsonType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushLitJsonJsonType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    LitJson.JsonToken _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushLitJsonJsonToken(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.NumericType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelNumericType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.CoroutineLockType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelCoroutineLockType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.HeuristicOptimizationMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFHeuristicOptimizationMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.GraphUpdateThreading _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFGraphUpdateThreading(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.ThreadCount _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFThreadCount(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathState _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFPathState(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathCompleteState _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFPathCompleteState(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.CloseToDestinationMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFCloseToDestinationMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.Side _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFSide(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.InspectorGridMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFInspectorGridMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.GraphDebugMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFGraphDebugMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathLog _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFPathLog(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.Heuristic _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFHeuristic(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.MovementPlane _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingRVOMovementPlane(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.RVOLayer _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingRVORVOLayer(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    AstarPath.AstarDistribution _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushAstarPathAstarDistribution(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.MultiTargetPath.HeuristicMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFMultiTargetPathHeuristicMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.RecastGraph.RelevantGraphSurfaceMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPFRecastGraphRelevantGraphSurfaceMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.Seeker.ModifierPass _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingSeekerModifierPass(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.GraphModifier.EventType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingGraphModifierEventType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RaycastModifier.Quality _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingRaycastModifierQuality(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.SimpleSmoothModifier.SmoothType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingSimpleSmoothModifierSmoothType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.StartEndModifier.Exactness _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingStartEndModifierExactness(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.BlockManager.BlockMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingBlockManagerBlockMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushPathfindingRVORVOObstacleObstacleVertexWinding(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Google.Protobuf.WireFormat.WireType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushGoogleProtobufWireFormatWireType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.BlendMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIBlendMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.HitTestMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIHitTestMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.DestroyMethod _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIDestroyMethod(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.EaseType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIEaseType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TweenPropType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUITweenPropType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.PackageItemType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIPackageItemType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ObjectType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIObjectType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.AlignType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIAlignType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.VertAlignType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIVertAlignType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OverflowType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOverflowType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FillType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIFillType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.AutoSizeType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIAutoSizeType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ScrollType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIScrollType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ScrollBarDisplayType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIScrollBarDisplayType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.RelationType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIRelationType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ListLayoutType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIListLayoutType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ListSelectionMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIListSelectionMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ProgressTitleType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIProgressTitleType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ButtonMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIButtonMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TransitionActionType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUITransitionActionType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.GroupLayoutType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIGroupLayoutType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ChildrenRenderOrder _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIChildrenRenderOrder(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.PopupDirection _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIPopupDirection(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FlipType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIFlipType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FillMethod _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIFillMethod(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OriginHorizontal _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOriginHorizontal(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OriginVertical _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOriginVertical(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin90 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOrigin90(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin180 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOrigin180(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin360 _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIOrigin360(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FitScreen _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIFitScreen(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Utils.HtmlElementType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIUtilsHtmlElementType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Utils.XMLTagType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIUtilsXMLTagType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.RTLSupport.DirectionType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIRTLSupportDirectionType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TextFormat.SpecialStyle _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUITextFormatSpecialStyle(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.GPathPoint.CurveType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIGPathPointCurveType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ControllerAction.ActionType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIControllerActionActionType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIConfig.ConfigKey _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIUIConfigConfigKey(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIContentScaler.ScaleMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIUIContentScalerScaleMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIContentScaler.ScreenMatchMode _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.GenFlag _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaGenFlag(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.OptimizeFlag _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaOptimizeFlag(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.HotfixFlag _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaHotfixFlag(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaTypes _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaLuaTypes(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaGCOptions _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaLuaGCOptions(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaThreadStatus _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaLuaThreadStatus(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LazyMemberTypes _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaLazyMemberTypes(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.TemplateEngine.TokenType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushXLuaTemplateEngineTokenType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.LuaTypes _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMikuLuaProfilerLuaTypes(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.LuaGCOptions _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMikuLuaProfilerLuaGCOptions(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.TK _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMikuLuaProfilerTK(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.AwaiterStatus _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelAwaiterStatus(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.EnvKey _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelEnvKey(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.LogType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelLogType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.EntityStatus _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelEntityStatus(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.SceneType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelSceneType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.AppType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelAppType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.MotionType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelMotionType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.MapType _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDCETModelMapType(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    decimal _val;
                    
                    gen_to_be_invoked.Get( _L, _index, out _val );
                    translator.PushDecimal(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.ObjectTranslator.Get!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineVector2(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector2 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineVector2( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineVector3(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Vector3 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineVector3( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineVector3(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector3 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineVector3( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineVector4(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Vector4 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineVector4( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineVector4(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector4 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineVector4( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Color _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineColor( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Color _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineColor( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineQuaternion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Quaternion _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineQuaternion( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineQuaternion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Quaternion _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineQuaternion( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineRay(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Ray _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineRay( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineRay(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineRay( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineBounds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Bounds _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineBounds( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineBounds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Bounds _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineBounds( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushUnityEngineRay2D(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    UnityEngine.Ray2D _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushUnityEngineRay2D( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUnityEngineRay2D(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray2D _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateUnityEngineRay2D( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonBsonBinarySubType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.BsonBinarySubType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonBsonBinarySubType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonBsonBinarySubType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.BsonBinarySubType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonBsonBinarySubType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonBsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.BsonType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonBsonType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonBsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.BsonType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonBsonType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonDuplicateNameHandling(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.DuplicateNameHandling _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonDuplicateNameHandling( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonDuplicateNameHandling(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.DuplicateNameHandling _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonDuplicateNameHandling( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonGuidRepresentation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.GuidRepresentation _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonGuidRepresentation( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonGuidRepresentation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.GuidRepresentation _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonGuidRepresentation( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonSerializationOptionsDictionaryRepresentation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.Serialization.Options.DictionaryRepresentation _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonSerializationOptionsDictionaryRepresentation( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonSerializationOptionsDictionaryRepresentation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.Serialization.Options.DictionaryRepresentation _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonSerializationOptionsDictionaryRepresentation( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonSerializationOptionsTimeSpanUnits(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.Serialization.Options.TimeSpanUnits _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonSerializationOptionsTimeSpanUnits( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonSerializationOptionsTimeSpanUnits(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.Serialization.Options.TimeSpanUnits _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonSerializationOptionsTimeSpanUnits( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonIOBsonReaderState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.IO.BsonReaderState _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonIOBsonReaderState( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonIOBsonReaderState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.BsonReaderState _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonIOBsonReaderState( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonIOBsonWriterState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.IO.BsonWriterState _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonIOBsonWriterState( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonIOBsonWriterState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.BsonWriterState _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonIOBsonWriterState( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonIOContextType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.IO.ContextType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonIOContextType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonIOContextType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.ContextType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonIOContextType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonIOJsonOutputMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.IO.JsonOutputMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonIOJsonOutputMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonIOJsonOutputMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.JsonOutputMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonIOJsonOutputMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMongoDBBsonIOJsonTokenType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MongoDB.Bson.IO.JsonTokenType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMongoDBBsonIOJsonTokenType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMongoDBBsonIOJsonTokenType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MongoDB.Bson.IO.JsonTokenType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMongoDBBsonIOJsonTokenType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelChannelType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.ChannelType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelChannelType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelChannelType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.ChannelType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelChannelType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelNetworkProtocol(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.NetworkProtocol _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelNetworkProtocol( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelNetworkProtocol(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.NetworkProtocol _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelNetworkProtocol( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelParserState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.ParserState _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelParserState( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelParserState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.ParserState _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelParserState( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushLitJsonJsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    LitJson.JsonType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushLitJsonJsonType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateLitJsonJsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    LitJson.JsonType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateLitJsonJsonType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushLitJsonJsonToken(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    LitJson.JsonToken _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushLitJsonJsonToken( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateLitJsonJsonToken(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    LitJson.JsonToken _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateLitJsonJsonToken( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelNumericType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.NumericType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelNumericType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelNumericType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.NumericType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelNumericType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelCoroutineLockType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.CoroutineLockType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelCoroutineLockType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelCoroutineLockType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.CoroutineLockType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelCoroutineLockType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFHeuristicOptimizationMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.HeuristicOptimizationMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFHeuristicOptimizationMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFHeuristicOptimizationMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.HeuristicOptimizationMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFHeuristicOptimizationMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFGraphUpdateThreading(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.GraphUpdateThreading _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFGraphUpdateThreading( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFGraphUpdateThreading(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.GraphUpdateThreading _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFGraphUpdateThreading( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFThreadCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.ThreadCount _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFThreadCount( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFThreadCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.ThreadCount _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFThreadCount( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFPathState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.PathState _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFPathState( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFPathState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathState _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFPathState( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFPathCompleteState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.PathCompleteState _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFPathCompleteState( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFPathCompleteState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathCompleteState _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFPathCompleteState( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFCloseToDestinationMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.CloseToDestinationMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFCloseToDestinationMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFCloseToDestinationMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.CloseToDestinationMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFCloseToDestinationMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFSide(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.Side _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFSide( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFSide(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.Side _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFSide( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFInspectorGridMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.InspectorGridMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFInspectorGridMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFInspectorGridMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.InspectorGridMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFInspectorGridMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFGraphDebugMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.GraphDebugMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFGraphDebugMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFGraphDebugMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.GraphDebugMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFGraphDebugMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFPathLog(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.PathLog _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFPathLog( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFPathLog(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.PathLog _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFPathLog( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFHeuristic(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.Heuristic _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFHeuristic( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFHeuristic(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.Heuristic _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFHeuristic( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingRVOMovementPlane(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.RVO.MovementPlane _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingRVOMovementPlane( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingRVOMovementPlane(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.MovementPlane _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingRVOMovementPlane( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingRVORVOLayer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.RVO.RVOLayer _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingRVORVOLayer( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingRVORVOLayer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.RVOLayer _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingRVORVOLayer( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushAstarPathAstarDistribution(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    AstarPath.AstarDistribution _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushAstarPathAstarDistribution( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateAstarPathAstarDistribution(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    AstarPath.AstarDistribution _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateAstarPathAstarDistribution( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFMultiTargetPathHeuristicMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.MultiTargetPath.HeuristicMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFMultiTargetPathHeuristicMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFMultiTargetPathHeuristicMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.MultiTargetPath.HeuristicMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFMultiTargetPathHeuristicMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPFRecastGraphRelevantGraphSurfaceMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    PF.RecastGraph.RelevantGraphSurfaceMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPFRecastGraphRelevantGraphSurfaceMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePFRecastGraphRelevantGraphSurfaceMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    PF.RecastGraph.RelevantGraphSurfaceMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePFRecastGraphRelevantGraphSurfaceMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingSeekerModifierPass(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.Seeker.ModifierPass _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingSeekerModifierPass( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingSeekerModifierPass(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.Seeker.ModifierPass _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingSeekerModifierPass( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingGraphModifierEventType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.GraphModifier.EventType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingGraphModifierEventType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingGraphModifierEventType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.GraphModifier.EventType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingGraphModifierEventType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingRaycastModifierQuality(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.RaycastModifier.Quality _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingRaycastModifierQuality( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingRaycastModifierQuality(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RaycastModifier.Quality _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingRaycastModifierQuality( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingSimpleSmoothModifierSmoothType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.SimpleSmoothModifier.SmoothType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingSimpleSmoothModifierSmoothType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingSimpleSmoothModifierSmoothType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.SimpleSmoothModifier.SmoothType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingSimpleSmoothModifierSmoothType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingStartEndModifierExactness(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.StartEndModifier.Exactness _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingStartEndModifierExactness( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingStartEndModifierExactness(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.StartEndModifier.Exactness _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingStartEndModifierExactness( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingBlockManagerBlockMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.BlockManager.BlockMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingBlockManagerBlockMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingBlockManagerBlockMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.BlockManager.BlockMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingBlockManagerBlockMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushPathfindingRVORVOObstacleObstacleVertexWinding(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushPathfindingRVORVOObstacleObstacleVertexWinding( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdatePathfindingRVORVOObstacleObstacleVertexWinding(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdatePathfindingRVORVOObstacleObstacleVertexWinding( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushGoogleProtobufWireFormatWireType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Google.Protobuf.WireFormat.WireType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushGoogleProtobufWireFormatWireType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateGoogleProtobufWireFormatWireType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Google.Protobuf.WireFormat.WireType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateGoogleProtobufWireFormatWireType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIBlendMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.BlendMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIBlendMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIBlendMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.BlendMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIBlendMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIHitTestMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.HitTestMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIHitTestMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIHitTestMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.HitTestMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIHitTestMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIDestroyMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.DestroyMethod _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIDestroyMethod( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIDestroyMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.DestroyMethod _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIDestroyMethod( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIEaseType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.EaseType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIEaseType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIEaseType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.EaseType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIEaseType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUITweenPropType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.TweenPropType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUITweenPropType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUITweenPropType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TweenPropType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUITweenPropType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIPackageItemType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.PackageItemType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIPackageItemType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIPackageItemType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.PackageItemType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIPackageItemType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIObjectType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ObjectType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIObjectType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIObjectType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ObjectType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIObjectType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIAlignType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.AlignType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIAlignType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIAlignType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.AlignType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIAlignType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIVertAlignType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.VertAlignType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIVertAlignType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIVertAlignType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.VertAlignType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIVertAlignType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOverflowType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.OverflowType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOverflowType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOverflowType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OverflowType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOverflowType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIFillType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.FillType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIFillType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIFillType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FillType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIFillType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIAutoSizeType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.AutoSizeType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIAutoSizeType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIAutoSizeType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.AutoSizeType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIAutoSizeType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIScrollType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ScrollType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIScrollType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIScrollType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ScrollType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIScrollType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIScrollBarDisplayType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ScrollBarDisplayType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIScrollBarDisplayType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIScrollBarDisplayType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ScrollBarDisplayType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIScrollBarDisplayType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIRelationType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.RelationType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIRelationType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIRelationType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.RelationType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIRelationType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIListLayoutType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ListLayoutType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIListLayoutType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIListLayoutType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ListLayoutType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIListLayoutType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIListSelectionMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ListSelectionMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIListSelectionMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIListSelectionMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ListSelectionMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIListSelectionMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIProgressTitleType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ProgressTitleType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIProgressTitleType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIProgressTitleType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ProgressTitleType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIProgressTitleType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIButtonMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ButtonMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIButtonMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIButtonMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ButtonMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIButtonMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUITransitionActionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.TransitionActionType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUITransitionActionType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUITransitionActionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TransitionActionType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUITransitionActionType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIGroupLayoutType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.GroupLayoutType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIGroupLayoutType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIGroupLayoutType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.GroupLayoutType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIGroupLayoutType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIChildrenRenderOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ChildrenRenderOrder _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIChildrenRenderOrder( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIChildrenRenderOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ChildrenRenderOrder _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIChildrenRenderOrder( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIPopupDirection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.PopupDirection _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIPopupDirection( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIPopupDirection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.PopupDirection _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIPopupDirection( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIFlipType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.FlipType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIFlipType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIFlipType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FlipType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIFlipType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIFillMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.FillMethod _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIFillMethod( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIFillMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FillMethod _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIFillMethod( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOriginHorizontal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.OriginHorizontal _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOriginHorizontal( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOriginHorizontal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OriginHorizontal _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOriginHorizontal( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOriginVertical(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.OriginVertical _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOriginVertical( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOriginVertical(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.OriginVertical _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOriginVertical( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOrigin90(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.Origin90 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOrigin90( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOrigin90(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin90 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOrigin90( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOrigin180(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.Origin180 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOrigin180( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOrigin180(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin180 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOrigin180( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIOrigin360(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.Origin360 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIOrigin360( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIOrigin360(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Origin360 _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIOrigin360( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIFitScreen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.FitScreen _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIFitScreen( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIFitScreen(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.FitScreen _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIFitScreen( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIUtilsHtmlElementType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.Utils.HtmlElementType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIUtilsHtmlElementType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIUtilsHtmlElementType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Utils.HtmlElementType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIUtilsHtmlElementType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIUtilsXMLTagType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.Utils.XMLTagType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIUtilsXMLTagType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIUtilsXMLTagType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.Utils.XMLTagType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIUtilsXMLTagType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIRTLSupportDirectionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.RTLSupport.DirectionType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIRTLSupportDirectionType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIRTLSupportDirectionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.RTLSupport.DirectionType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIRTLSupportDirectionType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUITextFormatSpecialStyle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.TextFormat.SpecialStyle _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUITextFormatSpecialStyle( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUITextFormatSpecialStyle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.TextFormat.SpecialStyle _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUITextFormatSpecialStyle( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIGPathPointCurveType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.GPathPoint.CurveType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIGPathPointCurveType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIGPathPointCurveType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.GPathPoint.CurveType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIGPathPointCurveType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIControllerActionActionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.ControllerAction.ActionType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIControllerActionActionType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIControllerActionActionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.ControllerAction.ActionType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIControllerActionActionType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIUIConfigConfigKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.UIConfig.ConfigKey _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIUIConfigConfigKey( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIUIConfigConfigKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIConfig.ConfigKey _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIUIConfigConfigKey( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIUIContentScalerScaleMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.UIContentScaler.ScaleMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIUIContentScalerScaleMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIUIContentScalerScaleMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIContentScaler.ScaleMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIUIContentScalerScaleMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushFairyGUIUIContentScalerScreenMatchMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    FairyGUI.UIContentScaler.ScreenMatchMode _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushFairyGUIUIContentScalerScreenMatchMode( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateFairyGUIUIContentScalerScreenMatchMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    FairyGUI.UIContentScaler.ScreenMatchMode _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateFairyGUIUIContentScalerScreenMatchMode( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaGenFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.GenFlag _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaGenFlag( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaGenFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.GenFlag _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaGenFlag( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaOptimizeFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.OptimizeFlag _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaOptimizeFlag( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaOptimizeFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.OptimizeFlag _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaOptimizeFlag( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaHotfixFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.HotfixFlag _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaHotfixFlag( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaHotfixFlag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.HotfixFlag _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaHotfixFlag( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaLuaTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LuaTypes _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaLuaTypes( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaLuaTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaTypes _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaLuaTypes( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaLuaGCOptions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LuaGCOptions _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaLuaGCOptions( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaLuaGCOptions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaGCOptions _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaLuaGCOptions( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaLuaThreadStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LuaThreadStatus _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaLuaThreadStatus( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaLuaThreadStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LuaThreadStatus _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaLuaThreadStatus( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaLazyMemberTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LazyMemberTypes _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaLazyMemberTypes( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaLazyMemberTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.LazyMemberTypes _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaLazyMemberTypes( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushXLuaTemplateEngineTokenType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.TemplateEngine.TokenType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushXLuaTemplateEngineTokenType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateXLuaTemplateEngineTokenType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    XLua.TemplateEngine.TokenType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateXLuaTemplateEngineTokenType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMikuLuaProfilerLuaTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MikuLuaProfiler.LuaTypes _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMikuLuaProfilerLuaTypes( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMikuLuaProfilerLuaTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.LuaTypes _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMikuLuaProfilerLuaTypes( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMikuLuaProfilerLuaGCOptions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MikuLuaProfiler.LuaGCOptions _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMikuLuaProfilerLuaGCOptions( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMikuLuaProfilerLuaGCOptions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.LuaGCOptions _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMikuLuaProfilerLuaGCOptions( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMikuLuaProfilerTK(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    MikuLuaProfiler.TK _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMikuLuaProfilerTK( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMikuLuaProfilerTK(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    MikuLuaProfiler.TK _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMikuLuaProfilerTK( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelAwaiterStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.AwaiterStatus _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelAwaiterStatus( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelAwaiterStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.AwaiterStatus _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelAwaiterStatus( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelEnvKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.EnvKey _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelEnvKey( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelEnvKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.EnvKey _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelEnvKey( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelLogType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.LogType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelLogType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelLogType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.LogType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelLogType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelEntityStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.EntityStatus _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelEntityStatus( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelEntityStatus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.EntityStatus _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelEntityStatus( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelSceneType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.SceneType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelSceneType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelSceneType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.SceneType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelSceneType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelAppType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.AppType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelAppType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelAppType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.AppType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelAppType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelMotionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.MotionType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelMotionType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelMotionType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.MotionType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelMotionType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDCETModelMapType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    DCET.Model.MapType _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDCETModelMapType( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateDCETModelMapType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    DCET.Model.MapType _val;translator.Get(L, 4, out _val);
                    
                    gen_to_be_invoked.UpdateDCETModelMapType( _L, _index, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DelayWrapLoader(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Action<System.IntPtr> _loader = translator.GetDelegate<System.Action<System.IntPtr>>(L, 3);
                    
                    gen_to_be_invoked.DelayWrapLoader( _type, _loader );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddInterfaceBridgeCreator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Func<int, XLua.LuaEnv, XLua.LuaBase> _creator = translator.GetDelegate<System.Func<int, XLua.LuaEnv, XLua.LuaBase>>(L, 3);
                    
                    gen_to_be_invoked.AddInterfaceBridgeCreator( _type, _creator );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryDelayWrapLoader(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.TryDelayWrapLoader( _L, _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Alias(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _alias = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.Alias( _type, _alias );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDelegateBridge(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _delegateType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int _idx = LuaAPI.xlua_tointeger(L, 4);
                    
                        object gen_ret = gen_to_be_invoked.CreateDelegateBridge( _L, _delegateType, _idx );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AllDelegateBridgeReleased(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.AllDelegateBridgeReleased(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseLuaBase(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _reference = LuaAPI.xlua_tointeger(L, 3);
                    bool _is_delegate = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.ReleaseLuaBase( _L, _reference, _is_delegate );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateInterfaceBridge(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _interfaceType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int _idx = LuaAPI.xlua_tointeger(L, 4);
                    
                        object gen_ret = gen_to_be_invoked.CreateInterfaceBridge( _L, _interfaceType, _idx );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateArrayMetatable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    
                    gen_to_be_invoked.CreateArrayMetatable( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDelegateMetatable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    
                    gen_to_be_invoked.CreateDelegateMetatable( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenLib(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    
                    gen_to_be_invoked.OpenLib( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeOf(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetTypeOf( _L, _idx );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Assignable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    System.Type _type = (System.Type)translator.GetObject(L, 4, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.Assignable( _L, _index, _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    System.Type _type = (System.Type)translator.GetObject(L, 4, typeof(System.Type));
                    
                        object gen_ret = gen_to_be_invoked.GetObject( _L, _index, _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    System.Type _type = (System.Type)translator.GetObject(L, 4, typeof(System.Type));
                    
                        System.Array gen_ret = gen_to_be_invoked.GetParams( _L, _index, _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushParams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Array _ary = (System.Array)translator.GetObject(L, 3, typeof(System.Array));
                    
                    gen_to_be_invoked.PushParams( _L, _ary );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        int gen_ret = gen_to_be_invoked.GetTypeId( _L, _type );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrivateAccessible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                    gen_to_be_invoked.PrivateAccessible( _L, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushAny(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    object _o = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.PushAny( _L, _o );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TranslateToEnumToTop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int _idx = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.TranslateToEnumToTop( _L, _type, _idx );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Push(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& translator.Assignable<XLua.LuaDLL.lua_CSFunction>(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LuaDLL.lua_CSFunction _o = translator.GetDelegate<XLua.LuaDLL.lua_CSFunction>(L, 3);
                    
                    gen_to_be_invoked.Push( _L, _o );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& translator.Assignable<XLua.LuaBase>(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    XLua.LuaBase _o = (XLua.LuaBase)translator.GetObject(L, 3, typeof(XLua.LuaBase));
                    
                    gen_to_be_invoked.Push( _L, _o );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    object _o = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Push( _L, _o );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.ObjectTranslator.Push!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    object _o = translator.GetObject(L, 3, typeof(object));
                    int _type_id = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.PushObject( _L, _o, _type_id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    object _obj = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.Update( _L, _index, _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasCustomOp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.HasCustomOp( _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushDecimal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    decimal _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.PushDecimal( _L, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsDecimal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.IsDecimal( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDecimal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                        decimal gen_ret = gen_to_be_invoked.GetDecimal( _L, _index );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cacheRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.cacheRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cacheRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XLua.ObjectTranslator gen_to_be_invoked = (XLua.ObjectTranslator)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cacheRef = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
