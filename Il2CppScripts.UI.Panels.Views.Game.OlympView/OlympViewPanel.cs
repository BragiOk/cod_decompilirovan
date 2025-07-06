using System;
using System.Runtime.CompilerServices;
using Il2CppGameTypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.OlympView;

public class OlympViewPanel : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__olympBattleEnemy;

	private static readonly IntPtr NativeFieldInfoPtr__spectatorModeContainer;

	private static readonly IntPtr NativeFieldInfoPtr__spectate_fighter01;

	private static readonly IntPtr NativeFieldInfoPtr__spectate_fighter02;

	private static readonly IntPtr NativeFieldInfoPtr__olympiadMode;

	private static readonly IntPtr NativeFieldInfoPtr__partyMemberProperties;

	private static readonly IntPtr NativeFieldInfoPtr__magicEffects;

	private static readonly IntPtr NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_PartyMemberProperties_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMagicEffects_Public_Void_Int32_IEnumerable_1_MagicEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOpponentPanel_Private_OlympOpponentStatus_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe OlympOpponentStatus _olympBattleEnemy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__olympBattleEnemy);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OlympOpponentStatus>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__olympBattleEnemy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympOpponentStatus));
		}
	}

	public unsafe RectTransform _spectatorModeContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectatorModeContainer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectatorModeContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe OlympOpponentStatus _spectate_fighter01
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectate_fighter01);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OlympOpponentStatus>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectate_fighter01)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympOpponentStatus));
		}
	}

	public unsafe OlympOpponentStatus _spectate_fighter02
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectate_fighter02);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OlympOpponentStatus>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spectate_fighter02)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympOpponentStatus));
		}
	}

	public unsafe OlympiadMode _olympiadMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__olympiadMode);
			return *(OlympiadMode*)num;
		}
		set
		{
			*(OlympiadMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__olympiadMode)) = olympiadMode;
		}
	}

	public unsafe Il2CppReferenceArray<PartyMemberProperties> _partyMemberProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__partyMemberProperties);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PartyMemberProperties>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__partyMemberProperties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<IEnumerable<Il2CppScripts.GameTypes.MagicEffect>> _magicEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magicEffects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEnumerable<Il2CppScripts.GameTypes.MagicEffect>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__magicEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static OlympViewPanel()
	{
		Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.OlympView", "OlympViewPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr);
		NativeFieldInfoPtr__olympBattleEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_olympBattleEnemy");
		NativeFieldInfoPtr__spectatorModeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_spectatorModeContainer");
		NativeFieldInfoPtr__spectate_fighter01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_spectate_fighter01");
		NativeFieldInfoPtr__spectate_fighter02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_spectate_fighter02");
		NativeFieldInfoPtr__olympiadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_olympiadMode");
		NativeFieldInfoPtr__partyMemberProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_partyMemberProperties");
		NativeFieldInfoPtr__magicEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, "_magicEffects");
		NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, 100667586);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_PartyMemberProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, 100667587);
		NativeMethodInfoPtr_SetMagicEffects_Public_Void_Int32_IEnumerable_1_MagicEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, 100667588);
		NativeMethodInfoPtr_GetOpponentPanel_Private_OlympOpponentStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, 100667589);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr, 100667590);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42896, RefRangeEnd = 42897, XrefRangeStart = 42858, XrefRangeEnd = 42896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOlympiadMode(OlympiadMode olympiadMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&olympiadMode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42902, RefRangeEnd = 42904, XrefRangeStart = 42897, XrefRangeEnd = 42902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int index, PartyMemberProperties properties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)properties);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_PartyMemberProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 42914, RefRangeEnd = 42918, XrefRangeStart = 42904, XrefRangeEnd = 42914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMagicEffects(int index, IEnumerable<Il2CppScripts.GameTypes.MagicEffect> magicEffects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)magicEffects);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMagicEffects_Public_Void_Int32_IEnumerable_1_MagicEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe OlympOpponentStatus GetOpponentPanel(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpponentPanel_Private_OlympOpponentStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OlympOpponentStatus>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42918, XrefRangeEnd = 42927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OlympViewPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OlympViewPanel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OlympViewPanel(IntPtr pointer)
		: base(pointer)
	{
	}
}
