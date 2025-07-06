using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Common;
using Il2CppScripts.Emitters;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.DataObjects;

[System.Serializable]
public class EffectAction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__displayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttachOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttachToCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttachBoneName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CubicId;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMultiTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_RelativeToCylinder;

	private static readonly System.IntPtr NativeFieldInfoPtr_SizeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpawnOnTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_TargetCaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseCharacterRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_InheritVerticalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_RelativeRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_EtcEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_EtcEffectInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScaleSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileUseCustomAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileCustomAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileMirrorCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_Effect;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string _displayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__displayName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe AttachMethod AttachOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachOn);
			return *(AttachMethod*)num;
		}
		set
		{
			*(AttachMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachOn)) = attachMethod;
		}
	}

	public unsafe bool AttachToCharacter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachToCharacter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachToCharacter)) = flag;
		}
	}

	public unsafe string AttachBoneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachBoneName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachBoneName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int CubicId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicId)) = num;
		}
	}

	public unsafe bool OnMultiTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMultiTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMultiTarget)) = flag;
		}
	}

	public unsafe bool RelativeToCylinder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeToCylinder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeToCylinder)) = flag;
		}
	}

	public unsafe bool SizeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale)) = flag;
		}
	}

	public unsafe bool SpawnOnTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpawnOnTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpawnOnTarget)) = flag;
		}
	}

	public unsafe bool TargetCaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCaster);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetCaster)) = flag;
		}
	}

	public unsafe bool UseCharacterRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCharacterRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCharacterRotation)) = flag;
		}
	}

	public unsafe bool InheritVerticalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InheritVerticalRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InheritVerticalRotation)) = flag;
		}
	}

	public unsafe Quaternion RelativeRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeRotation)) = quaternion;
		}
	}

	public unsafe Vector3 Offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset)) = vector;
		}
	}

	public unsafe EtcEffectType EtcEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EtcEffect);
			return *(EtcEffectType*)num;
		}
		set
		{
			*(EtcEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EtcEffect)) = etcEffectType;
		}
	}

	public unsafe EtcEffectParam EtcEffectInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EtcEffectInfo);
			return *(EtcEffectParam*)num;
		}
		set
		{
			*(EtcEffectParam*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EtcEffectInfo)) = etcEffectParam;
		}
	}

	public unsafe float ScaleSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleSize)) = num;
		}
	}

	public unsafe float SpawnDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpawnDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpawnDelay)) = num;
		}
	}

	public unsafe bool ProjectileUseCustomAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileUseCustomAngle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileUseCustomAngle)) = flag;
		}
	}

	public unsafe float ProjectileCustomAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileCustomAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileCustomAngle)) = num;
		}
	}

	public unsafe bool ProjectileMirrorCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileMirrorCurve);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectileMirrorCurve)) = flag;
		}
	}

	public unsafe EmitterGroup Effect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Effect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EmitterGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Effect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)emitterGroup));
		}
	}

	static EffectAction()
	{
		Il2CppClassPointerStore<EffectAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.DataObjects", "EffectAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectAction>.NativeClassPtr);
		NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "_displayName");
		NativeFieldInfoPtr_AttachOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "AttachOn");
		NativeFieldInfoPtr_AttachToCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "AttachToCharacter");
		NativeFieldInfoPtr_AttachBoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "AttachBoneName");
		NativeFieldInfoPtr_CubicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "CubicId");
		NativeFieldInfoPtr_OnMultiTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "OnMultiTarget");
		NativeFieldInfoPtr_RelativeToCylinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "RelativeToCylinder");
		NativeFieldInfoPtr_SizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "SizeScale");
		NativeFieldInfoPtr_SpawnOnTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "SpawnOnTarget");
		NativeFieldInfoPtr_TargetCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "TargetCaster");
		NativeFieldInfoPtr_UseCharacterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "UseCharacterRotation");
		NativeFieldInfoPtr_InheritVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "InheritVerticalRotation");
		NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "RelativeRotation");
		NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "Offset");
		NativeFieldInfoPtr_EtcEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "EtcEffect");
		NativeFieldInfoPtr_EtcEffectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "EtcEffectInfo");
		NativeFieldInfoPtr_ScaleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "ScaleSize");
		NativeFieldInfoPtr_SpawnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "SpawnDelay");
		NativeFieldInfoPtr_ProjectileUseCustomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "ProjectileUseCustomAngle");
		NativeFieldInfoPtr_ProjectileCustomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "ProjectileCustomAngle");
		NativeFieldInfoPtr_ProjectileMirrorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "ProjectileMirrorCurve");
		NativeFieldInfoPtr_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, "Effect");
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, 100668907);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, 100668908);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAction>.NativeClassPtr, 100668909);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55212, XrefRangeEnd = 55223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe EffectAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectAction>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectAction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
