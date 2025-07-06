using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Components;
using Il2CppScripts.Emitters;
using UnityEngine;

namespace Il2CppScripts.CharacterSystem;

public class CharacterConfiguration : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_ValidateVOffset;

	private static readonly IntPtr NativeFieldInfoPtr_ValidateTime;

	private static readonly IntPtr NativeFieldInfoPtr_ValidationThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_WalkValidateMaxDistance;

	private static readonly IntPtr NativeFieldInfoPtr_SoftValidateMinDistance;

	private static readonly IntPtr NativeFieldInfoPtr_SoftValidateMaxDistance;

	private static readonly IntPtr NativeFieldInfoPtr_ValidateVDistance;

	private static readonly IntPtr NativeFieldInfoPtr_ValidateTimeMovement;

	private static readonly IntPtr NativeFieldInfoPtr_MovementValidateDistance;

	private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedCorrectionFactor;

	private static readonly IntPtr NativeFieldInfoPtr_TurnSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_FallAngle;

	private static readonly IntPtr NativeFieldInfoPtr_FallSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_StepSize;

	private static readonly IntPtr NativeFieldInfoPtr_StopDistanceMargin;

	private static readonly IntPtr NativeFieldInfoPtr_FollowStopDistance;

	private static readonly IntPtr NativeFieldInfoPtr_FollowDistanceMarginSec;

	private static readonly IntPtr NativeFieldInfoPtr_MinimalDistanceDelta;

	private static readonly IntPtr NativeFieldInfoPtr_SlopeSlideSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_WalkAnimDistance;

	private static readonly IntPtr NativeFieldInfoPtr_MinimalRotationAnimAngle;

	private static readonly IntPtr NativeFieldInfoPtr_WalkToRunSpeedMultiply;

	private static readonly IntPtr NativeFieldInfoPtr_GroundCastMargin;

	private static readonly IntPtr NativeFieldInfoPtr_ForwardMoveMargin;

	private static readonly IntPtr NativeFieldInfoPtr_SitStandTime;

	private static readonly IntPtr NativeFieldInfoPtr_DeathRebirthPlayerPlaytime;

	private static readonly IntPtr NativeFieldInfoPtr_PickupPlaytime;

	private static readonly IntPtr NativeFieldInfoPtr_CannotMoveAnymoreTriggerTime;

	private static readonly IntPtr NativeFieldInfoPtr_SayDuration;

	private static readonly IntPtr NativeFieldInfoPtr_SitCollisionHeight;

	private static readonly IntPtr NativeFieldInfoPtr_DeadCollisionHeight;

	private static readonly IntPtr NativeFieldInfoPtr_RandomizeAttackSounds;

	private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

	private static readonly IntPtr NativeFieldInfoPtr_CameraPivotOffset;

	private static readonly IntPtr NativeFieldInfoPtr_WaterHeight;

	private static readonly IntPtr NativeFieldInfoPtr_NpcIdleSpWaitChance;

	private static readonly IntPtr NativeFieldInfoPtr_HitEffectBone;

	private static readonly IntPtr NativeFieldInfoPtr_HitEffectDefaultEmitter;

	private static readonly IntPtr NativeFieldInfoPtr_HitEffectBendAngle;

	private static readonly IntPtr NativeFieldInfoPtr_HitEffectBendTime;

	private static readonly IntPtr NativeFieldInfoPtr_DropLight;

	private static readonly IntPtr NativeFieldInfoPtr_HeroEffect;

	private static readonly IntPtr NativeFieldInfoPtr_RadarMarker;

	private static readonly IntPtr NativeFieldInfoPtr_LevelUpEffect;

	private static readonly IntPtr NativeFieldInfoPtr_LevelUpSound;

	private static readonly IntPtr NativeFieldInfoPtr_QuestMarker;

	private static readonly IntPtr NativeFieldInfoPtr_QuestMarkerOffset;

	private static readonly IntPtr NativeFieldInfoPtr_QuestMarkerScale;

	private static readonly IntPtr NativeFieldInfoPtr_CubicsData;

	private static readonly IntPtr NativeFieldInfoPtr_PrivateStoreBuyColor;

	private static readonly IntPtr NativeFieldInfoPtr_PrivateStoreSellColor;

	private static readonly IntPtr NativeFieldInfoPtr_PrivateStorePackageSellColor;

	private static readonly IntPtr NativeFieldInfoPtr_PrivateStoreManufactureColor;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float ValidateVOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateVOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateVOffset)) = num;
		}
	}

	public unsafe float ValidateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateTime)) = num;
		}
	}

	public unsafe float ValidationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidationThreshold)) = num;
		}
	}

	public unsafe float WalkValidateMaxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkValidateMaxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkValidateMaxDistance)) = num;
		}
	}

	public unsafe float SoftValidateMinDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoftValidateMinDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoftValidateMinDistance)) = num;
		}
	}

	public unsafe float SoftValidateMaxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoftValidateMaxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoftValidateMaxDistance)) = num;
		}
	}

	public unsafe float ValidateVDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateVDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateVDistance)) = num;
		}
	}

	public unsafe float ValidateTimeMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateTimeMovement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValidateTimeMovement)) = num;
		}
	}

	public unsafe float MovementValidateDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MovementValidateDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MovementValidateDistance)) = num;
		}
	}

	public unsafe float MoveSpeedCorrectionFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveSpeedCorrectionFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveSpeedCorrectionFactor)) = num;
		}
	}

	public unsafe float TurnSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeed)) = num;
		}
	}

	public unsafe float FallAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FallAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FallAngle)) = num;
		}
	}

	public unsafe float FallSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FallSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FallSpeed)) = num;
		}
	}

	public unsafe float StepSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StepSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StepSize)) = num;
		}
	}

	public unsafe float StopDistanceMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopDistanceMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StopDistanceMargin)) = num;
		}
	}

	public unsafe float FollowStopDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FollowStopDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FollowStopDistance)) = num;
		}
	}

	public unsafe float FollowDistanceMarginSec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FollowDistanceMarginSec);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FollowDistanceMarginSec)) = num;
		}
	}

	public unsafe float MinimalDistanceDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimalDistanceDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimalDistanceDelta)) = num;
		}
	}

	public unsafe float SlopeSlideSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlopeSlideSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlopeSlideSpeed)) = num;
		}
	}

	public unsafe float WalkAnimDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkAnimDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkAnimDistance)) = num;
		}
	}

	public unsafe float MinimalRotationAnimAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimalRotationAnimAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimalRotationAnimAngle)) = num;
		}
	}

	public unsafe float WalkToRunSpeedMultiply
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkToRunSpeedMultiply);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkToRunSpeedMultiply)) = num;
		}
	}

	public unsafe float GroundCastMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroundCastMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroundCastMargin)) = num;
		}
	}

	public unsafe float ForwardMoveMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForwardMoveMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForwardMoveMargin)) = num;
		}
	}

	public unsafe float SitStandTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SitStandTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SitStandTime)) = num;
		}
	}

	public unsafe float DeathRebirthPlayerPlaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeathRebirthPlayerPlaytime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeathRebirthPlayerPlaytime)) = num;
		}
	}

	public unsafe float PickupPlaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PickupPlaytime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PickupPlaytime)) = num;
		}
	}

	public unsafe float CannotMoveAnymoreTriggerTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CannotMoveAnymoreTriggerTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CannotMoveAnymoreTriggerTime)) = num;
		}
	}

	public unsafe float SayDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SayDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SayDuration)) = num;
		}
	}

	public unsafe float SitCollisionHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SitCollisionHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SitCollisionHeight)) = num;
		}
	}

	public unsafe float DeadCollisionHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeadCollisionHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeadCollisionHeight)) = num;
		}
	}

	public unsafe bool RandomizeAttackSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomizeAttackSounds);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomizeAttackSounds)) = flag;
		}
	}

	public unsafe float FadeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTime)) = num;
		}
	}

	public unsafe float CameraPivotOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraPivotOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraPivotOffset)) = num;
		}
	}

	public unsafe float WaterHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaterHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaterHeight)) = num;
		}
	}

	public unsafe float NpcIdleSpWaitChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcIdleSpWaitChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcIdleSpWaitChance)) = num;
		}
	}

	public unsafe string HitEffectBone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBone);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBone)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe EmitterGroup HitEffectDefaultEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectDefaultEmitter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EmitterGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectDefaultEmitter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)emitterGroup));
		}
	}

	public unsafe float HitEffectBendAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBendAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBendAngle)) = num;
		}
	}

	public unsafe float HitEffectBendTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBendTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HitEffectBendTime)) = num;
		}
	}

	public unsafe GameObject DropLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe EmitterGroup HeroEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroEffect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EmitterGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)emitterGroup));
		}
	}

	public unsafe RadarMarker RadarMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RadarMarker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RadarMarker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RadarMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radarMarker));
		}
	}

	public unsafe GameObject LevelUpEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LevelUpEffect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LevelUpEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe AudioClip LevelUpSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LevelUpSound);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LevelUpSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip));
		}
	}

	public unsafe GameObject QuestMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float QuestMarkerOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarkerOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarkerOffset)) = num;
		}
	}

	public unsafe float QuestMarkerScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarkerScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestMarkerScale)) = num;
		}
	}

	public unsafe CubicsData CubicsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicsData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CubicsData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicsData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cubicsData));
		}
	}

	public unsafe Color PrivateStoreBuyColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreBuyColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreBuyColor)) = color;
		}
	}

	public unsafe Color PrivateStoreSellColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreSellColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreSellColor)) = color;
		}
	}

	public unsafe Color PrivateStorePackageSellColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStorePackageSellColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStorePackageSellColor)) = color;
		}
	}

	public unsafe Color PrivateStoreManufactureColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreManufactureColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreManufactureColor)) = color;
		}
	}

	static CharacterConfiguration()
	{
		Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.CharacterSystem", "CharacterConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr_ValidateVOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ValidateVOffset");
		NativeFieldInfoPtr_ValidateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ValidateTime");
		NativeFieldInfoPtr_ValidationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ValidationThreshold");
		NativeFieldInfoPtr_WalkValidateMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "WalkValidateMaxDistance");
		NativeFieldInfoPtr_SoftValidateMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SoftValidateMinDistance");
		NativeFieldInfoPtr_SoftValidateMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SoftValidateMaxDistance");
		NativeFieldInfoPtr_ValidateVDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ValidateVDistance");
		NativeFieldInfoPtr_ValidateTimeMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ValidateTimeMovement");
		NativeFieldInfoPtr_MovementValidateDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "MovementValidateDistance");
		NativeFieldInfoPtr_MoveSpeedCorrectionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "MoveSpeedCorrectionFactor");
		NativeFieldInfoPtr_TurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "TurnSpeed");
		NativeFieldInfoPtr_FallAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "FallAngle");
		NativeFieldInfoPtr_FallSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "FallSpeed");
		NativeFieldInfoPtr_StepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "StepSize");
		NativeFieldInfoPtr_StopDistanceMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "StopDistanceMargin");
		NativeFieldInfoPtr_FollowStopDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "FollowStopDistance");
		NativeFieldInfoPtr_FollowDistanceMarginSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "FollowDistanceMarginSec");
		NativeFieldInfoPtr_MinimalDistanceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "MinimalDistanceDelta");
		NativeFieldInfoPtr_SlopeSlideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SlopeSlideSpeed");
		NativeFieldInfoPtr_WalkAnimDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "WalkAnimDistance");
		NativeFieldInfoPtr_MinimalRotationAnimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "MinimalRotationAnimAngle");
		NativeFieldInfoPtr_WalkToRunSpeedMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "WalkToRunSpeedMultiply");
		NativeFieldInfoPtr_GroundCastMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "GroundCastMargin");
		NativeFieldInfoPtr_ForwardMoveMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "ForwardMoveMargin");
		NativeFieldInfoPtr_SitStandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SitStandTime");
		NativeFieldInfoPtr_DeathRebirthPlayerPlaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "DeathRebirthPlayerPlaytime");
		NativeFieldInfoPtr_PickupPlaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "PickupPlaytime");
		NativeFieldInfoPtr_CannotMoveAnymoreTriggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "CannotMoveAnymoreTriggerTime");
		NativeFieldInfoPtr_SayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SayDuration");
		NativeFieldInfoPtr_SitCollisionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "SitCollisionHeight");
		NativeFieldInfoPtr_DeadCollisionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "DeadCollisionHeight");
		NativeFieldInfoPtr_RandomizeAttackSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "RandomizeAttackSounds");
		NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "FadeTime");
		NativeFieldInfoPtr_CameraPivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "CameraPivotOffset");
		NativeFieldInfoPtr_WaterHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "WaterHeight");
		NativeFieldInfoPtr_NpcIdleSpWaitChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "NpcIdleSpWaitChance");
		NativeFieldInfoPtr_HitEffectBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "HitEffectBone");
		NativeFieldInfoPtr_HitEffectDefaultEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "HitEffectDefaultEmitter");
		NativeFieldInfoPtr_HitEffectBendAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "HitEffectBendAngle");
		NativeFieldInfoPtr_HitEffectBendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "HitEffectBendTime");
		NativeFieldInfoPtr_DropLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "DropLight");
		NativeFieldInfoPtr_HeroEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "HeroEffect");
		NativeFieldInfoPtr_RadarMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "RadarMarker");
		NativeFieldInfoPtr_LevelUpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "LevelUpEffect");
		NativeFieldInfoPtr_LevelUpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "LevelUpSound");
		NativeFieldInfoPtr_QuestMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "QuestMarker");
		NativeFieldInfoPtr_QuestMarkerOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "QuestMarkerOffset");
		NativeFieldInfoPtr_QuestMarkerScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "QuestMarkerScale");
		NativeFieldInfoPtr_CubicsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "CubicsData");
		NativeFieldInfoPtr_PrivateStoreBuyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "PrivateStoreBuyColor");
		NativeFieldInfoPtr_PrivateStoreSellColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "PrivateStoreSellColor");
		NativeFieldInfoPtr_PrivateStorePackageSellColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "PrivateStorePackageSellColor");
		NativeFieldInfoPtr_PrivateStoreManufactureColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, "PrivateStoreManufactureColor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr, 100669668);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64476, XrefRangeEnd = 64479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterConfiguration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterConfiguration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CharacterConfiguration(IntPtr pointer)
		: base(pointer)
	{
	}
}
