using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Tables;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScripts.UI.Icons.IconTypes;

public class EffectIcon : IconHandle
{
	private static readonly IntPtr NativeFieldInfoPtr__ShortCut_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_ShowCountdown;

	private static readonly IntPtr NativeFieldInfoPtr__debuffOverlay;

	private static readonly IntPtr NativeFieldInfoPtr__debuffFlicker;

	private static readonly IntPtr NativeFieldInfoPtr__durationCountdown;

	private static readonly IntPtr NativeFieldInfoPtr__chargesCounter;

	private static readonly IntPtr NativeFieldInfoPtr__magicEffect;

	private static readonly IntPtr NativeFieldInfoPtr__skillEntry;

	private static readonly IntPtr NativeFieldInfoPtr__skillLevel;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Skill_Public_get_SkillEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_SkillLevel_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ExpireTime_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateDebuffCountdown_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetEffect_Public_Void_MagicEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShortCut _ShortCut_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShortCut_k__BackingField);
			return *(ShortCut*)num;
		}
		set
		{
			*(ShortCut*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShortCut_k__BackingField)) = shortCut;
		}
	}

	public unsafe bool ShowCountdown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowCountdown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowCountdown)) = flag;
		}
	}

	public unsafe Image _debuffOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debuffOverlay);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debuffOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe SpriteAnimator _debuffFlicker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debuffFlicker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteAnimator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__debuffFlicker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAnimator));
		}
	}

	public unsafe TextMeshProUGUI _durationCountdown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__durationCountdown);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__durationCountdown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _chargesCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chargesCounter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chargesCounter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe MagicEffect _magicEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magicEffect);
			return *(MagicEffect*)num;
		}
		set
		{
			*(MagicEffect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magicEffect)) = magicEffect;
		}
	}

	public unsafe SkillEntry _skillEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEntry);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillEntry>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillEntry));
		}
	}

	public unsafe SkillLevel _skillLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillLevel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillLevel));
		}
	}

	public unsafe override ShortCut ShortCut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ShortCut*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe SkillEntry Skill
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Skill_Public_get_SkillEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillEntry>(intPtr) : null;
		}
	}

	public unsafe SkillLevel Level
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Level_Public_get_SkillLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillLevel>(intPtr) : null;
		}
	}

	public unsafe float ExpireTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ExpireTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static EffectIcon()
	{
		Il2CppClassPointerStore<EffectIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons.IconTypes", "EffectIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr);
		NativeFieldInfoPtr__ShortCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "<ShortCut>k__BackingField");
		NativeFieldInfoPtr_ShowCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "ShowCountdown");
		NativeFieldInfoPtr__debuffOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_debuffOverlay");
		NativeFieldInfoPtr__debuffFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_debuffFlicker");
		NativeFieldInfoPtr__durationCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_durationCountdown");
		NativeFieldInfoPtr__chargesCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_chargesCounter");
		NativeFieldInfoPtr__magicEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_magicEffect");
		NativeFieldInfoPtr__skillEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_skillEntry");
		NativeFieldInfoPtr__skillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, "_skillLevel");
		NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666851);
		NativeMethodInfoPtr_get_Skill_Public_get_SkillEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666852);
		NativeMethodInfoPtr_get_Level_Public_get_SkillLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666853);
		NativeMethodInfoPtr_get_ExpireTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666854);
		NativeMethodInfoPtr_UpdateDebuffCountdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666855);
		NativeMethodInfoPtr_SetEffect_Public_Void_MagicEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666856);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666857);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr, 100666858);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35463, XrefRangeEnd = 35471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDebuffCountdown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDebuffCountdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 35506, RefRangeEnd = 35509, XrefRangeStart = 35471, XrefRangeEnd = 35506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEffect(MagicEffect magicEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&magicEffect);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEffect_Public_Void_MagicEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectIcon>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectIcon(IntPtr pointer)
		: base(pointer)
	{
	}
}
