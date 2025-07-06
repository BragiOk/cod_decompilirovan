using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.UI.Html.Classes;

namespace Il2CppScripts.UI.Html.Tags;

public class HtmlRoot : HtmlElement
{
	private static readonly IntPtr NativeMethodInfoPtr_ApplyHtmlStyle_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static HtmlRoot()
	{
		Il2CppClassPointerStore<HtmlRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Html.Tags", "HtmlRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlRoot>.NativeClassPtr);
		NativeMethodInfoPtr_ApplyHtmlStyle_Public_Virtual_Void_HtmlRenderBox_HtmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlRoot>.NativeClassPtr, 100666008);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlRoot>.NativeClassPtr, 100666009);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28468, XrefRangeEnd = 28471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HtmlRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlRoot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HtmlRoot(IntPtr pointer)
		: base(pointer)
	{
	}
}
