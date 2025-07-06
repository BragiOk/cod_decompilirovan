using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Overlay.Tooltips;

public class TooltipPanel2 : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__templateText;

	private static readonly IntPtr NativeFieldInfoPtr__nameRow;

	private static readonly IntPtr NativeFieldInfoPtr__minLimit;

	private static readonly IntPtr NativeFieldInfoPtr__maxLimit;

	private static readonly IntPtr NativeFieldInfoPtr__resetPosition;

	private static readonly IntPtr NativeFieldInfoPtr__parameters;

	private static readonly IntPtr NativeMethodInfoPtr_TooltipToTemplateParameter_Private_Static_String_TooltipField_0;

	private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Void_Dictionary_2_TooltipField_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Virtual_Final_New_Void_TooltipField_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResizeTooltip_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AlignTooltip_Private_Void_RectTransform_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_RectTransform_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideTooltip_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetFields_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TemplateText _templateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemplateText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templateText));
		}
	}

	public unsafe RectTransform _nameRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nameRow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nameRow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe float _minLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minLimit)) = num;
		}
	}

	public unsafe float _maxLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxLimit)) = num;
		}
	}

	public unsafe bool _resetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resetPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resetPosition)) = flag;
		}
	}

	public unsafe Dictionary<TooltipField, string> _parameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parameters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TooltipField, string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static TooltipPanel2()
	{
		Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.Tooltips", "TooltipPanel2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr);
		NativeFieldInfoPtr__templateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_templateText");
		NativeFieldInfoPtr__nameRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_nameRow");
		NativeFieldInfoPtr__minLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_minLimit");
		NativeFieldInfoPtr__maxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_maxLimit");
		NativeFieldInfoPtr__resetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_resetPosition");
		NativeFieldInfoPtr__parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, "_parameters");
		NativeMethodInfoPtr_TooltipToTemplateParameter_Private_Static_String_TooltipField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr_Populate_Public_Void_Dictionary_2_TooltipField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665792);
		NativeMethodInfoPtr_SetText_Public_Virtual_Final_New_Void_TooltipField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665793);
		NativeMethodInfoPtr_ResizeTooltip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_AlignTooltip_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_ShowTooltip_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_HideTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_ResetFields_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr, 100665799);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25968, RefRangeEnd = 25969, XrefRangeStart = 25940, XrefRangeEnd = 25968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TooltipToTemplateParameter(TooltipField tooltipField)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&tooltipField);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TooltipToTemplateParameter_Private_Static_String_TooltipField_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25998, RefRangeEnd = 25999, XrefRangeStart = 25969, XrefRangeEnd = 25998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Populate(Dictionary<TooltipField, string> parameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Populate_Public_Void_Dictionary_2_TooltipField_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25999, XrefRangeEnd = 26002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetText(TooltipField field, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&field);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetText_Public_Virtual_Final_New_Void_TooltipField_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26026, RefRangeEnd = 26027, XrefRangeStart = 26002, XrefRangeEnd = 26026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResizeTooltip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeTooltip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26061, RefRangeEnd = 26062, XrefRangeStart = 26027, XrefRangeEnd = 26061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AlignTooltip(RectTransform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignTooltip_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 26074, RefRangeEnd = 26077, XrefRangeStart = 26062, XrefRangeEnd = 26074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTooltip(RectTransform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowTooltip_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 26094, RefRangeEnd = 26097, XrefRangeStart = 26077, XrefRangeEnd = 26094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideTooltip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 26100, RefRangeEnd = 26103, XrefRangeStart = 26097, XrefRangeEnd = 26100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ResetFields()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFields_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26103, XrefRangeEnd = 26112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TooltipPanel2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipPanel2>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TooltipPanel2(IntPtr pointer)
		: base(pointer)
	{
	}
}
