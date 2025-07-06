using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScripts.DataObjects;

public class SkillEffect : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_SuppressHitEffects;

	private static readonly IntPtr NativeFieldInfoPtr_EnableAttackHits;

	private static readonly IntPtr NativeFieldInfoPtr_LaunchOnAnimationEvents;

	private static readonly IntPtr NativeFieldInfoPtr_FlyingTime;

	private static readonly IntPtr NativeFieldInfoPtr_CastingActions;

	private static readonly IntPtr NativeFieldInfoPtr_ShotActions;

	private static readonly IntPtr NativeFieldInfoPtr_ExplosionActions;

	private static readonly IntPtr NativeFieldInfoPtr_ChannelingActions;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool SuppressHitEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuppressHitEffects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuppressHitEffects)) = flag;
		}
	}

	public unsafe bool EnableAttackHits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableAttackHits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableAttackHits)) = flag;
		}
	}

	public unsafe bool LaunchOnAnimationEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LaunchOnAnimationEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LaunchOnAnimationEvents)) = flag;
		}
	}

	public unsafe float FlyingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FlyingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FlyingTime)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<EffectAction> CastingActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastingActions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectAction>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastingActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<EffectAction> ShotActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShotActions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectAction>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShotActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<EffectAction> ExplosionActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExplosionActions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectAction>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExplosionActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<EffectAction> ChannelingActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChannelingActions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectAction>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChannelingActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static SkillEffect()
	{
		Il2CppClassPointerStore<SkillEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.DataObjects", "SkillEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr);
		NativeFieldInfoPtr_SuppressHitEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "SuppressHitEffects");
		NativeFieldInfoPtr_EnableAttackHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "EnableAttackHits");
		NativeFieldInfoPtr_LaunchOnAnimationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "LaunchOnAnimationEvents");
		NativeFieldInfoPtr_FlyingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "FlyingTime");
		NativeFieldInfoPtr_CastingActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "CastingActions");
		NativeFieldInfoPtr_ShotActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "ShotActions");
		NativeFieldInfoPtr_ExplosionActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "ExplosionActions");
		NativeFieldInfoPtr_ChannelingActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, "ChannelingActions");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr, 100668910);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
