using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensorDevice : ExplosiveDevice
	{
		[Ordinal(126)] 
		[RED("attitudeAgent")] 
		public CHandle<gameAttitudeAgent> AttitudeAgent
		{
			get => GetPropertyValue<CHandle<gameAttitudeAgent>>();
			set => SetPropertyValue<CHandle<gameAttitudeAgent>>(value);
		}

		[Ordinal(127)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get => GetPropertyValue<CHandle<senseComponent>>();
			set => SetPropertyValue<CHandle<senseComponent>>(value);
		}

		[Ordinal(128)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetPropertyValue<CHandle<senseVisibleObjectComponent>>();
			set => SetPropertyValue<CHandle<senseVisibleObjectComponent>>(value);
		}

		[Ordinal(129)] 
		[RED("forwardFaceSlotComponent")] 
		public CHandle<entSlotComponent> ForwardFaceSlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(130)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(131)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		[Ordinal(132)] 
		[RED("cameraComponentInverted")] 
		public CHandle<gameCameraComponent> CameraComponentInverted
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(133)] 
		[RED("targets")] 
		public CArray<CHandle<Target>> Targets
		{
			get => GetPropertyValue<CArray<CHandle<Target>>>();
			set => SetPropertyValue<CArray<CHandle<Target>>>(value);
		}

		[Ordinal(134)] 
		[RED("currentlyFollowedTarget")] 
		public CWeakHandle<gameObject> CurrentlyFollowedTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(135)] 
		[RED("currentLookAtEventVert")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventVert
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(136)] 
		[RED("currentLookAtEventHor")] 
		public CHandle<entLookAtAddEvent> CurrentLookAtEventHor
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(137)] 
		[RED("HPListenersList")] 
		public CArray<CHandle<TargetedObjectDeathListener>> HPListenersList
		{
			get => GetPropertyValue<CArray<CHandle<TargetedObjectDeathListener>>>();
			set => SetPropertyValue<CArray<CHandle<TargetedObjectDeathListener>>>(value);
		}

		[Ordinal(138)] 
		[RED("sensorDeviceState")] 
		public CEnum<ESensorDeviceStates> SensorDeviceState
		{
			get => GetPropertyValue<CEnum<ESensorDeviceStates>>();
			set => SetPropertyValue<CEnum<ESensorDeviceStates>>(value);
		}

		[Ordinal(139)] 
		[RED("sensorWakeState")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeState
		{
			get => GetPropertyValue<CEnum<ESensorDeviceWakeState>>();
			set => SetPropertyValue<CEnum<ESensorDeviceWakeState>>(value);
		}

		[Ordinal(140)] 
		[RED("sensorWakeStatePrevious")] 
		public CEnum<ESensorDeviceWakeState> SensorWakeStatePrevious
		{
			get => GetPropertyValue<CEnum<ESensorDeviceWakeState>>();
			set => SetPropertyValue<CEnum<ESensorDeviceWakeState>>(value);
		}

		[Ordinal(141)] 
		[RED("targetingDelayEventID")] 
		public gameDelayID TargetingDelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(142)] 
		[RED("hack_isTargetingDelayEventFilled")] 
		public CBool Hack_isTargetingDelayEventFilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(143)] 
		[RED("currentResolveDelayEventID")] 
		public gameDelayID CurrentResolveDelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(144)] 
		[RED("hack_isResolveDelayEventFilled")] 
		public CBool Hack_isResolveDelayEventFilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(145)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeatureData
		{
			get => GetPropertyValue<CHandle<AnimFeature_SensorDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SensorDevice>>(value);
		}

		[Ordinal(146)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(147)] 
		[RED("targetLostBySensesDelayEventID")] 
		public gameDelayID TargetLostBySensesDelayEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(148)] 
		[RED("hack_isTargetLostBySensesDelEvtFilled")] 
		public CBool Hack_isTargetLostBySensesDelEvtFilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(149)] 
		[RED("initialAttitude")] 
		public CName InitialAttitude
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(150)] 
		[RED("detectionFactorMultiplier")] 
		public CFloat DetectionFactorMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(151)] 
		[RED("taggedListenerCallback")] 
		public CHandle<redCallbackObject> TaggedListenerCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(152)] 
		[RED("lightScanRefs")] 
		public CArray<CHandle<gameLightComponent>> LightScanRefs
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(153)] 
		[RED("lightAttitudeRefs")] 
		public CArray<CHandle<gameLightComponent>> LightAttitudeRefs
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(154)] 
		[RED("lightInfoRefs")] 
		public CArray<CHandle<gameLightComponent>> LightInfoRefs
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(155)] 
		[RED("lightColors")] 
		public LedColors_SensorDevice LightColors
		{
			get => GetPropertyValue<LedColors_SensorDevice>();
			set => SetPropertyValue<LedColors_SensorDevice>(value);
		}

		[Ordinal(156)] 
		[RED("deviceFXRecord")] 
		public CHandle<gamedataDeviceFX_Record> DeviceFXRecord
		{
			get => GetPropertyValue<CHandle<gamedataDeviceFX_Record>>();
			set => SetPropertyValue<CHandle<gamedataDeviceFX_Record>>(value);
		}

		[Ordinal(157)] 
		[RED("scanGameEffect")] 
		public CHandle<gameEffectInstance> ScanGameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(158)] 
		[RED("scanFXSlotName")] 
		public CName ScanFXSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(159)] 
		[RED("visionConeEffectInstance")] 
		public CHandle<gameEffectInstance> VisionConeEffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(160)] 
		[RED("idleGameEffectInstance")] 
		public CHandle<gameEffectInstance> IdleGameEffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(161)] 
		[RED("targetForcedFormTagKill")] 
		public CBool TargetForcedFormTagKill
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(162)] 
		[RED("hasSupport")] 
		public CBool HasSupport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(163)] 
		[RED("defaultSensePreset")] 
		public TweakDBID DefaultSensePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(164)] 
		[RED("keepHostilityTowardsPlayerHostiles")] 
		public CBool KeepHostilityTowardsPlayerHostiles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(165)] 
		[RED("hostileUpdateTowardsPlayerHostilesDelayed")] 
		public CBool HostileUpdateTowardsPlayerHostilesDelayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(166)] 
		[RED("elementsToHideOnTCS")] 
		public CArray<CName> ElementsToHideOnTCS
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(167)] 
		[RED("elementsToHideOnTCSRefs")] 
		public CArray<CHandle<entIPlacedComponent>> ElementsToHideOnTCSRefs
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(168)] 
		[RED("previoustagKillList")] 
		public CArray<CWeakHandle<gameObject>> PrevioustagKillList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(169)] 
		[RED("playIdleSoundOnIdle")] 
		public CBool PlayIdleSoundOnIdle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(170)] 
		[RED("idleSound")] 
		public CName IdleSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(171)] 
		[RED("idleSoundStop")] 
		public CName IdleSoundStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(172)] 
		[RED("soundDeviceON")] 
		public CName SoundDeviceON
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(173)] 
		[RED("soundDeviceOFF")] 
		public CName SoundDeviceOFF
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(174)] 
		[RED("idleSoundIsPlaying")] 
		public CBool IdleSoundIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(175)] 
		[RED("soundDeviceDestroyed")] 
		public CName SoundDeviceDestroyed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(176)] 
		[RED("soundDetectionLoop")] 
		public CName SoundDetectionLoop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(177)] 
		[RED("soundDetectionLoopStop")] 
		public CName SoundDetectionLoopStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(178)] 
		[RED("isPLAYERSAFETargetLock")] 
		public CBool IsPLAYERSAFETargetLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(179)] 
		[RED("playerDetected")] 
		public CBool PlayerDetected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(180)] 
		[RED("clientForceSetAnimFeature")] 
		public CBool ClientForceSetAnimFeature
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(181)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get => GetPropertyValue<PlayerControlDeviceData>();
			set => SetPropertyValue<PlayerControlDeviceData>(value);
		}

		[Ordinal(182)] 
		[RED("engineTimeInSec")] 
		public CFloat EngineTimeInSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(183)] 
		[RED("TCExitEngineTime")] 
		public CFloat TCExitEngineTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(184)] 
		[RED("hack_wasTargetReevaluated")] 
		public CBool Hack_wasTargetReevaluated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(185)] 
		[RED("hack_wasSSOutupFromSelf")] 
		public CBool Hack_wasSSOutupFromSelf
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(186)] 
		[RED("degbu_SS_inputsSend")] 
		public CInt32 Degbu_SS_inputsSend
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(187)] 
		[RED("debug_SS_inputsSendTargetLock")] 
		public CInt32 Debug_SS_inputsSendTargetLock
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(188)] 
		[RED("debug_SS_inputsSendIntresting")] 
		public CInt32 Debug_SS_inputsSendIntresting
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(189)] 
		[RED("debug_SS_inputsSendLoseTarget")] 
		public CInt32 Debug_SS_inputsSendLoseTarget
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(190)] 
		[RED("debug_SS_outputRecieved")] 
		public CInt32 Debug_SS_outputRecieved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(191)] 
		[RED("debug_SS_outputFormSelfRecieved")] 
		public CInt32 Debug_SS_outputFormSelfRecieved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(192)] 
		[RED("debug_SS_outputFromElseRecieved")] 
		public CInt32 Debug_SS_outputFromElseRecieved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(193)] 
		[RED("debug_SS_reevaluatesDone")] 
		public CInt32 Debug_SS_reevaluatesDone
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(194)] 
		[RED("debug_SS_trespassingRecieved")] 
		public CInt32 Debug_SS_trespassingRecieved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(195)] 
		[RED("debug_SS_TargetAssessmentRequest")] 
		public CInt32 Debug_SS_TargetAssessmentRequest
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(196)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(197)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(198)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(199)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SensorDevice()
		{
			Targets = new();
			HPListenersList = new();
			SensorDeviceState = Enums.ESensorDeviceStates.IDLE;
			SensorWakeState = Enums.ESensorDeviceWakeState.NONE;
			TargetingDelayEventID = new gameDelayID();
			CurrentResolveDelayEventID = new gameDelayID();
			TargetLostBySensesDelayEventID = new gameDelayID();
			LightScanRefs = new();
			LightAttitudeRefs = new();
			LightInfoRefs = new();
			LightColors = new LedColors_SensorDevice { Off = new ScriptLightSettings { Color = new CColor() }, Red = new ScriptLightSettings { Color = new CColor() }, Green = new ScriptLightSettings { Color = new CColor() }, Blue = new ScriptLightSettings { Color = new CColor() }, Yellow = new ScriptLightSettings { Color = new CColor() }, White = new ScriptLightSettings { Color = new CColor() } };
			ScanFXSlotName = "laser";
			DefaultSensePreset = "Senses.BasicCamera";
			ElementsToHideOnTCS = new();
			ElementsToHideOnTCSRefs = new();
			PrevioustagKillList = new();
			PlayIdleSoundOnIdle = true;
			PlayerControlData = new PlayerControlDeviceData();
			MinPitch = -70.000000F;
			MaxPitch = 70.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
