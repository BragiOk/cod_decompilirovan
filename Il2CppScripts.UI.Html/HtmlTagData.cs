using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Html.Classes;
using Il2CppScripts.UI.Html.Tags;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Html;

public class HtmlTagData : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr__htmlTags;

	private static readonly IntPtr NativeFieldInfoPtr__defaultElement;

	private static readonly IntPtr NativeFieldInfoPtr__textElement;

	private static readonly IntPtr NativeFieldInfoPtr__tagMap;

	private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_Il2CppReferenceArray_1_HtmlTagDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TagMap_Public_get_Dictionary_2_String_HtmlTagDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DefaultElement_Public_get_HtmlElement_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TextElement_Public_get_HtmlElement_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<HtmlTagDesc> _htmlTags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__htmlTags);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HtmlTagDesc>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__htmlTags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe HtmlElement _defaultElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultElement);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HtmlElement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)htmlElement));
		}
	}

	public unsafe HtmlElement _textElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textElement);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HtmlElement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)htmlElement));
		}
	}

	public unsafe Dictionary<string, HtmlTagDesc> _tagMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tagMap);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HtmlTagDesc>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tagMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppReferenceArray<HtmlTagDesc> Tags
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656, RefRangeEnd = 658, XrefRangeStart = 656, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Tags_Public_get_Il2CppReferenceArray_1_HtmlTagDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HtmlTagDesc>>(intPtr) : null;
		}
	}

	public unsafe Dictionary<string, HtmlTagDesc> TagMap
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28119, XrefRangeEnd = 28124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TagMap_Public_get_Dictionary_2_String_HtmlTagDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HtmlTagDesc>>(intPtr) : null;
		}
	}

	public unsafe HtmlElement DefaultElement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultElement_Public_get_HtmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HtmlElement>(intPtr) : null;
		}
	}

	public unsafe HtmlElement TextElement
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TextElement_Public_get_HtmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HtmlElement>(intPtr) : null;
		}
	}

	static HtmlTagData()
	{
		Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Html", "HtmlTagData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr);
		NativeFieldInfoPtr__htmlTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, "_htmlTags");
		NativeFieldInfoPtr__defaultElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, "_defaultElement");
		NativeFieldInfoPtr__textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, "_textElement");
		NativeFieldInfoPtr__tagMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, "_tagMap");
		NativeMethodInfoPtr_get_Tags_Public_get_Il2CppReferenceArray_1_HtmlTagDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, 100665963);
		NativeMethodInfoPtr_get_TagMap_Public_get_Dictionary_2_String_HtmlTagDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, 100665964);
		NativeMethodInfoPtr_get_DefaultElement_Public_get_HtmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, 100665965);
		NativeMethodInfoPtr_get_TextElement_Public_get_HtmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr, 100665967);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28124, XrefRangeEnd = 28131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HtmlTagData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlTagData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HtmlTagData(IntPtr pointer)
		: base(pointer)
	{
	}
}
