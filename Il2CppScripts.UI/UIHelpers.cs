using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScripts.UI;

public static class UIHelpers : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("Scripts.UI.UIHelpers+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MakeTMPDropdownOptions_b__16_0_Internal_OptionData_String_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Func<string, TMP_Dropdown.OptionData> __9__16_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<string, TMP_Dropdown.OptionData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__16_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__16_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665585);
			NativeMethodInfoPtr__MakeTMPDropdownOptions_b__16_0_Internal_OptionData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665586);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23338, XrefRangeEnd = 23341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Dropdown.OptionData _MakeTMPDropdownOptions_b__16_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MakeTMPDropdownOptions_b__16_0_Internal_OptionData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Dropdown.OptionData>(intPtr) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_Type_Action_2_Type_State_0<Type, State>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_Type_Action_2_Type_State_0, Il2CppClassPointerStore<UIHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<State>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_Int32_Type_Action_2_Int32_Type_Func_3_Type_RectTransform_Type_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_Int32_Type_Action_2_Int32_Type_Func_3_Type_RectTransform_Type_0, Il2CppClassPointerStore<UIHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_T_Func_2_K_T_Action_2_T_State_Func_3_T_RectTransform_T_0<T, K, State>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_T_Func_2_K_T_Action_2_T_State_Func_3_T_RectTransform_T_0, Il2CppClassPointerStore<UIHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<State>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ArrowKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasdKeys;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsClickTransparent_Public_Static_Boolean_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverRectTransform_Public_Static_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextSelectable_Public_Static_Selectable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyInputFieldSelected_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchorAndPivot_Public_Static_Void_RectTransform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildDimensions_Public_Static_Vector2_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TextWidthApproximation_Public_Static_Single_String_TMP_FontAsset_Int32_FontStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_Type_Action_2_Type_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_Int32_Type_Action_2_Int32_Type_Func_3_Type_RectTransform_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_T_Func_2_K_T_Action_2_T_State_Func_3_T_RectTransform_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleInteractable_Public_Static_Void_Toggle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonInteractable_Public_Static_Void_Button_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeTMPDropdownOptions_Public_Static_List_1_OptionData_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_RectTransform_0;

	public unsafe static Il2CppStructArray<KeyCode> ArrowKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ArrowKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ArrowKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<KeyCode> WasdKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WasdKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WasdKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static UIHelpers()
	{
		Il2CppClassPointerStore<UIHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI", "UIHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr);
		NativeFieldInfoPtr_ArrowKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, "ArrowKeys");
		NativeFieldInfoPtr_WasdKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, "WasdKeys");
		NativeMethodInfoPtr_IsClickTransparent_Public_Static_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665567);
		NativeMethodInfoPtr_IsMouseOverRectTransform_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665568);
		NativeMethodInfoPtr_GetNextSelectable_Public_Static_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665569);
		NativeMethodInfoPtr_IsAnyInputFieldSelected_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665570);
		NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665571);
		NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665572);
		NativeMethodInfoPtr_SetAnchorAndPivot_Public_Static_Void_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665573);
		NativeMethodInfoPtr_GetChildDimensions_Public_Static_Vector2_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665574);
		NativeMethodInfoPtr_TextWidthApproximation_Public_Static_Single_String_TMP_FontAsset_Int32_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665575);
		NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_Type_Action_2_Type_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665576);
		NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_Int32_Type_Action_2_Int32_Type_Func_3_Type_RectTransform_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665577);
		NativeMethodInfoPtr_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_T_Func_2_K_T_Action_2_T_State_Func_3_T_RectTransform_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665578);
		NativeMethodInfoPtr_SetToggleInteractable_Public_Static_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665579);
		NativeMethodInfoPtr_SetButtonInteractable_Public_Static_Void_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665580);
		NativeMethodInfoPtr_MakeTMPDropdownOptions_Public_Static_List_1_OptionData_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665581);
		NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelpers>.NativeClassPtr, 100665582);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23415, RefRangeEnd = 23417, XrefRangeStart = 23341, XrefRangeEnd = 23415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsClickTransparent(Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsClickTransparent_Public_Static_Boolean_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23454, RefRangeEnd = 23456, XrefRangeStart = 23417, XrefRangeEnd = 23454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMouseOverRectTransform(GameObject rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMouseOverRectTransform_Public_Static_Boolean_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23456, XrefRangeEnd = 23483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable GetNextSelectable()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextSelectable_Public_Static_Selectable_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 23526, RefRangeEnd = 23533, XrefRangeStart = 23483, XrefRangeEnd = 23526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAnyInputFieldSelected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyInputFieldSelected_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23541, RefRangeEnd = 23543, XrefRangeStart = 23533, XrefRangeEnd = 23541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetWorldRect(this RectTransform rt, Vector2 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 23549, RefRangeEnd = 23554, XrefRangeStart = 23543, XrefRangeEnd = 23549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetWorldRect(this RectTransform rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldRect_Public_Static_Rect_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 23560, RefRangeEnd = 23563, XrefRangeStart = 23554, XrefRangeEnd = 23560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAnchorAndPivot(this RectTransform rectTransform, Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnchorAndPivot_Public_Static_Void_RectTransform_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23563, XrefRangeEnd = 23594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetChildDimensions(RectTransform rectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildDimensions_Public_Static_Vector2_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23594, XrefRangeEnd = 23601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TextWidthApproximation(string text, TMP_FontAsset fontAsset, int fontSize, FontStyles style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TextWidthApproximation_Public_Static_Single_String_TMP_FontAsset_Int32_FontStyles_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 23652, RefRangeEnd = 23656, XrefRangeStart = 23601, XrefRangeEnd = 23652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateOrRetrieveElements<Type, State>(RectTransform parent, IEnumerable<State> states, Type prefab, Il2CppSystem.Action<Type, State> action = null) where Type : MonoBehaviour
	{
		//IL_0069->IL006c: Incompatible stack types: I vs Ref
		//IL_005c->IL006c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref Type reference;
		if (!typeof(Type).IsValueType)
		{
			Type val = prefab;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref prefab;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_Type_Action_2_Type_State_0<Type, State>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 23692, RefRangeEnd = 23703, XrefRangeStart = 23656, XrefRangeEnd = 23692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateOrRetrieveElements<Type>(RectTransform parent, int count, Type prefab, Il2CppSystem.Action<int, Type> action = null, Il2CppSystem.Func<Type, RectTransform, Type> instantiateCallback = null) where Type : MonoBehaviour
	{
		//IL_0065->IL0068: Incompatible stack types: I vs Ref
		//IL_0058->IL0068: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref Type reference;
		if (!typeof(Type).IsValueType)
		{
			Type val = prefab;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref prefab;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instantiateCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_Int32_Type_Action_2_Int32_Type_Func_3_Type_RectTransform_Type_0<Type>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateOrRetrieveElements<T, K, State>(RectTransform parent, IEnumerable<State> states, T prefab, Il2CppSystem.Func<K, T> remap, Il2CppSystem.Action<T, State> action = null, Il2CppSystem.Func<T, RectTransform, T> instantiateCallback = null) where T : MonoBehaviour
	{
		//IL_0069->IL006c: Incompatible stack types: I vs Ref
		//IL_005c->IL006c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = prefab;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref prefab;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instantiateCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateOrRetrieveElements_Public_Static_Void_RectTransform_IEnumerable_1_State_T_Func_2_K_T_Action_2_T_State_Func_3_T_RectTransform_T_0<T, K, State>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 23718, RefRangeEnd = 23725, XrefRangeStart = 23703, XrefRangeEnd = 23718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetToggleInteractable(Toggle toggle, bool flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetToggleInteractable_Public_Static_Void_Toggle_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23725, XrefRangeEnd = 23734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetButtonInteractable(Button button, bool flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetButtonInteractable_Public_Static_Void_Button_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 23763, RefRangeEnd = 23774, XrefRangeStart = 23734, XrefRangeEnd = 23763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<TMP_Dropdown.OptionData> MakeTMPDropdownOptions(IEnumerable<string> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeTMPDropdownOptions_Public_Static_List_1_OptionData_IEnumerable_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Dropdown.OptionData>>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 23786, RefRangeEnd = 23796, XrefRangeStart = 23774, XrefRangeEnd = 23786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshLayoutGroupsImmediateAndRecursive(RectTransform root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
