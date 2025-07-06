using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Model;

public class ShortCuts : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NumRows;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotsPerPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortCutUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr__shortcuts;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ShortCutUpdated_Public_add_Void_Action_2_Int32_ShortCut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ShortCutUpdated_Public_rem_Void_Action_2_Int32_ShortCut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Shortcuts_Public_get_IReadOnlyList_1_ShortCut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShortcut_Public_Void_Int32_ShortCut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShortcut_Public_ShortCut_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int NumRows
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NumRows, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NumRows, (void*)(&num));
		}
	}

	public unsafe static int SlotsPerPage
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotsPerPage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotsPerPage, (void*)(&num));
		}
	}

	public unsafe Il2CppSystem.Action<int, ShortCut> ShortCutUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortCutUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, ShortCut>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortCutUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppStructArray<ShortCut> _shortcuts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcuts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShortCut>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcuts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe IReadOnlyList<ShortCut> Shortcuts
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656, RefRangeEnd = 658, XrefRangeStart = 656, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Shortcuts_Public_get_IReadOnlyList_1_ShortCut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<ShortCut>>(intPtr) : null;
		}
	}

	static ShortCuts()
	{
		Il2CppClassPointerStore<ShortCuts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Model", "ShortCuts");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr);
		NativeFieldInfoPtr_NumRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, "NumRows");
		NativeFieldInfoPtr_SlotsPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, "SlotsPerPage");
		NativeFieldInfoPtr_ShortCutUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, "ShortCutUpdated");
		NativeFieldInfoPtr__shortcuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, "_shortcuts");
		NativeMethodInfoPtr_add_ShortCutUpdated_Public_add_Void_Action_2_Int32_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668370);
		NativeMethodInfoPtr_remove_ShortCutUpdated_Public_rem_Void_Action_2_Int32_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668371);
		NativeMethodInfoPtr_get_Shortcuts_Public_get_IReadOnlyList_1_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668372);
		NativeMethodInfoPtr_SetShortcut_Public_Void_Int32_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668373);
		NativeMethodInfoPtr_GetShortcut_Public_ShortCut_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668374);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668375);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr, 100668376);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50490, XrefRangeEnd = 50498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ShortCutUpdated(Il2CppSystem.Action<int, ShortCut> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ShortCutUpdated_Public_add_Void_Action_2_Int32_ShortCut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50498, XrefRangeEnd = 50506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ShortCutUpdated(Il2CppSystem.Action<int, ShortCut> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ShortCutUpdated_Public_rem_Void_Action_2_Int32_ShortCut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetShortcut(int index, ShortCut shortCut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(ShortCut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortCut;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShortcut_Public_Void_Int32_ShortCut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe ShortCut GetShortcut(int page, int slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&page);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShortcut_Public_ShortCut_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ShortCut*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50506, XrefRangeEnd = 50507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50507, XrefRangeEnd = 50510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShortCuts()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortCuts>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShortCuts(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
