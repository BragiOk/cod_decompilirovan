using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppScripts.UI.Icons.IconTypes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScripts.UI.Panels.Views.Game.PrivateManufacture;

public class ManufactureRecipeEntry : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__recipeItemIcon;

	private static readonly IntPtr NativeFieldInfoPtr__itemDescriptionText;

	private static readonly IntPtr NativeFieldInfoPtr__recipeId;

	private static readonly IntPtr NativeFieldInfoPtr__craftsmanId;

	private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ItemIcon _recipeItemIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeItemIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemIcon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeItemIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIcon));
		}
	}

	public unsafe TemplateText _itemDescriptionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemDescriptionText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemplateText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemDescriptionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templateText));
		}
	}

	public unsafe int _recipeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeId)) = num;
		}
	}

	public unsafe int _craftsmanId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__craftsmanId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__craftsmanId)) = num;
		}
	}

	static ManufactureRecipeEntry()
	{
		Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.PrivateManufacture", "ManufactureRecipeEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr);
		NativeFieldInfoPtr__recipeItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, "_recipeItemIcon");
		NativeFieldInfoPtr__itemDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, "_itemDescriptionText");
		NativeFieldInfoPtr__recipeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, "_recipeId");
		NativeFieldInfoPtr__craftsmanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, "_craftsmanId");
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_SetRecipe_Public_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr, 100667314);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40419, XrefRangeEnd = 40426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40454, RefRangeEnd = 40455, XrefRangeStart = 40426, XrefRangeEnd = 40454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRecipe(int craftsmanId, int itemId, int recipeId, int cost, int successChance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&craftsmanId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &itemId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &recipeId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &cost;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &successChance;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRecipe_Public_Void_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ManufactureRecipeEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManufactureRecipeEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ManufactureRecipeEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
