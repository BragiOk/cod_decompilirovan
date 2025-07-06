using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Tables;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.UI.Icons;

public static class IconUseHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_UseSkill_Public_Static_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseMacro_Public_Static_Void_MacrosEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseMacro_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseAction_Public_Static_Void_ActionEntry_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseAction_Public_Static_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestUseItem_Public_Static_Void_ItemState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestUnequipItem_Public_Static_Void_ItemState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestDestroyItem_Public_Static_Void_ItemState_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestEnchantItem_Public_Static_Void_ItemState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestDropItem_Public_Static_Void_ItemState_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseShortcut_Public_Static_Void_ShortCut_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseShortcut_Public_Static_Void_Int32_Int32_Boolean_Boolean_0;

	static IconUseHelper()
	{
		Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons", "IconUseHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr);
		NativeMethodInfoPtr_UseSkill_Public_Static_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666720);
		NativeMethodInfoPtr_UseMacro_Public_Static_Void_MacrosEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666721);
		NativeMethodInfoPtr_UseMacro_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666722);
		NativeMethodInfoPtr_UseAction_Public_Static_Void_ActionEntry_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666723);
		NativeMethodInfoPtr_UseAction_Public_Static_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666724);
		NativeMethodInfoPtr_RequestUseItem_Public_Static_Void_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666725);
		NativeMethodInfoPtr_RequestUnequipItem_Public_Static_Void_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666726);
		NativeMethodInfoPtr_RequestDestroyItem_Public_Static_Void_ItemState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666727);
		NativeMethodInfoPtr_RequestEnchantItem_Public_Static_Void_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666728);
		NativeMethodInfoPtr_RequestDropItem_Public_Static_Void_ItemState_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666729);
		NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666730);
		NativeMethodInfoPtr_UseShortcut_Public_Static_Void_ShortCut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666731);
		NativeMethodInfoPtr_UseShortcut_Public_Static_Void_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconUseHelper>.NativeClassPtr, 100666732);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34578, RefRangeEnd = 34579, XrefRangeStart = 34566, XrefRangeEnd = 34578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseSkill(int skillId, bool ctrl, bool shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&skillId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseSkill_Public_Static_Void_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34586, RefRangeEnd = 34587, XrefRangeStart = 34579, XrefRangeEnd = 34586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseMacro(MacrosEntry macrosEntry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosEntry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseMacro_Public_Static_Void_MacrosEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34587, XrefRangeEnd = 34593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseMacro(int macrosId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&macrosId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseMacro_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34601, RefRangeEnd = 34602, XrefRangeStart = 34593, XrefRangeEnd = 34601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseAction(ActionEntry actionEntry, bool ctrl = false, bool shift = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionEntry);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseAction_Public_Static_Void_ActionEntry_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34604, RefRangeEnd = 34605, XrefRangeStart = 34602, XrefRangeEnd = 34604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseAction(int actionId, bool ctrl, bool shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&actionId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseAction_Public_Static_Void_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34612, RefRangeEnd = 34613, XrefRangeStart = 34605, XrefRangeEnd = 34612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestUseItem(ItemState itemState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestUseItem_Public_Static_Void_ItemState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 34620, RefRangeEnd = 34622, XrefRangeStart = 34613, XrefRangeEnd = 34620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestUnequipItem(ItemState itemState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestUnequipItem_Public_Static_Void_ItemState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34622, XrefRangeEnd = 34629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestDestroyItem(ItemState itemState, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestDestroyItem_Public_Static_Void_ItemState_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34629, XrefRangeEnd = 34636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestEnchantItem(ItemState itemState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestEnchantItem_Public_Static_Void_ItemState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34636, XrefRangeEnd = 34643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestDropItem(ItemState itemState, int count, Vector3 location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestDropItem_Public_Static_Void_ItemState_Int32_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34643, XrefRangeEnd = 34653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseItem(int objectId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&objectId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 34663, RefRangeEnd = 34665, XrefRangeStart = 34653, XrefRangeEnd = 34663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseShortcut(ShortCut shortCut, bool ctrl, bool shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&shortCut);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseShortcut_Public_Static_Void_ShortCut_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 34668, RefRangeEnd = 34670, XrefRangeStart = 34665, XrefRangeEnd = 34668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseShortcut(int page, int slot, bool ctrl, bool shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&page);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseShortcut_Public_Static_Void_Int32_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IconUseHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
