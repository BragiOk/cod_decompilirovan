using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Elements.Layout;
using Il2CppScripts.UI.Html.Classes;
using UnityEngine.UI;

namespace Il2CppScripts.UI.Html.Tags;

public class HtmlTableData : HtmlElement
{
	private static readonly IntPtr NativeFieldInfoPtr__verticalLayout;

	private static readonly IntPtr NativeFieldInfoPtr__fitter;

	private static readonly IntPtr NativeFieldInfoPtr__hasWidth;

	private static readonly IntPtr NativeFieldInfoPtr__width;

	private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Fitter_Public_get_LimitedSizeFitter_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyLayoutProperties_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyHtmlStyle_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetupHtmlElement_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe VerticalLayoutGroup _verticalLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verticalLayout);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verticalLayout)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verticalLayoutGroup));
		}
	}

	public unsafe LimitedSizeFitter _fitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fitter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LimitedSizeFitter>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fitter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)limitedSizeFitter));
		}
	}

	public unsafe bool _hasWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasWidth)) = flag;
		}
	}

	public unsafe float _width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__width);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__width)) = num;
		}
	}

	public unsafe float Width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe LimitedSizeFitter Fitter
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Fitter_Public_get_LimitedSizeFitter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LimitedSizeFitter>(intPtr) : null;
		}
	}

	static HtmlTableData()
	{
		Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Html.Tags", "HtmlTableData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr);
		NativeFieldInfoPtr__verticalLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, "_verticalLayout");
		NativeFieldInfoPtr__fitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, "_fitter");
		NativeFieldInfoPtr__hasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, "_hasWidth");
		NativeFieldInfoPtr__width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, "_width");
		NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666014);
		NativeMethodInfoPtr_get_Fitter_Public_get_LimitedSizeFitter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666015);
		NativeMethodInfoPtr_ApplyLayoutProperties_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666016);
		NativeMethodInfoPtr_ApplyHtmlStyle_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666017);
		NativeMethodInfoPtr_SetupHtmlElement_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666018);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr, 100666019);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28590, XrefRangeEnd = 28616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ApplyLayoutProperties(HtmlRenderBox container, HtmlNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyLayoutProperties_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28616, XrefRangeEnd = 28629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ApplyHtmlStyle(HtmlRenderBox container, HtmlNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyHtmlStyle_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28629, XrefRangeEnd = 28643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetupHtmlElement(HtmlRenderBox container, HtmlNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetupHtmlElement_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HtmlTableData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlTableData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HtmlTableData(IntPtr pointer)
		: base(pointer)
	{
	}
}
