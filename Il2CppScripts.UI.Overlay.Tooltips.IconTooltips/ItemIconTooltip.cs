using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Tables;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppScripts.UI.Icons.IconTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Overlay.Tooltips.IconTooltips;

public class ItemIconTooltip : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__itemIcon;

	private static readonly IntPtr NativeFieldInfoPtr__textColorFromAmount;

	private static readonly IntPtr NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeWashed_Private_Static_String_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEtcEquipType_Private_Static_String_ItemEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWeaponEquipType_Private_Static_String_ItemEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetArmorEquipType_Private_Static_String_ItemEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipType_Private_Static_String_ItemEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_AttackSpeedToString_Private_Static_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetupTooltipFields_Public_Static_Void_ITooltip_ItemState_Boolean_Boolean_TextColorFromAmountData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ItemIcon _itemIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemIcon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIcon));
		}
	}

	public unsafe TextColorFromAmountData _textColorFromAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textColorFromAmount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextColorFromAmountData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textColorFromAmount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textColorFromAmountData));
		}
	}

	public unsafe virtual float TooltipMargin
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ItemIconTooltip()
	{
		Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.Tooltips.IconTooltips", "ItemIconTooltip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr);
		NativeFieldInfoPtr__itemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, "_itemIcon");
		NativeFieldInfoPtr__textColorFromAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, "_textColorFromAmount");
		NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_MakeWashed_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_GetEtcEquipType_Private_Static_String_ItemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_GetWeaponEquipType_Private_Static_String_ItemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_GetArmorEquipType_Private_Static_String_ItemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_GetEquipType_Private_Static_String_ItemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_AttackSpeedToString_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_SetupTooltipFields_Public_Static_Void_ITooltip_ItemState_Boolean_Boolean_TextColorFromAmountData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr, 100665821);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26183, XrefRangeEnd = 26184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PopulateTooltip(ITooltip tooltip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tooltip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 26186, RefRangeEnd = 26190, XrefRangeStart = 26184, XrefRangeEnd = 26186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeWashed(string text, bool washed)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &washed;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeWashed_Private_Static_String_String_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26190, XrefRangeEnd = 26198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEtcEquipType(ItemEntry itemEntry)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEtcEquipType_Private_Static_String_ItemEntry_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26198, XrefRangeEnd = 26213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWeaponEquipType(ItemEntry itemEntry)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeaponEquipType_Private_Static_String_ItemEntry_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26236, RefRangeEnd = 26237, XrefRangeStart = 26213, XrefRangeEnd = 26236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetArmorEquipType(ItemEntry itemEntry)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArmorEquipType_Private_Static_String_ItemEntry_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26253, RefRangeEnd = 26254, XrefRangeStart = 26237, XrefRangeEnd = 26253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEquipType(ItemEntry itemEntry)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEquipType_Private_Static_String_ItemEntry_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26254, XrefRangeEnd = 26261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AttackSpeedToString(int speed)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttackSpeedToString_Private_Static_String_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26427, RefRangeEnd = 26429, XrefRangeStart = 26261, XrefRangeEnd = 26427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupTooltipFields(ITooltip tooltip, ItemState itemState, bool verbose, bool showPrice, TextColorFromAmountData textColorFromAmountData = null)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tooltip);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &verbose;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &showPrice;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textColorFromAmountData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTooltipFields_Public_Static_Void_ITooltip_ItemState_Boolean_Boolean_TextColorFromAmountData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemIconTooltip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemIconTooltip>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemIconTooltip(IntPtr pointer)
		: base(pointer)
	{
	}
}
