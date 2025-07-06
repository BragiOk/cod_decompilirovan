using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppScripts.UI.Html.Classes;

public class HtmlTree : Il2CppSystem.Object
{
	[ObfuscatedName("Scripts.UI.Html.Classes.HtmlTree+<>c__DisplayClass8_0")]
	public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_tagMap;

		public unsafe Dictionary<string, HtmlTagDesc> tagMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HtmlTagDesc>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static __c__DisplayClass8_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "<>c__DisplayClass8_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr);
			NativeFieldInfoPtr_tagMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "tagMap");
		}

		public __c__DisplayClass8_0(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public __c__DisplayClass8_0()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Root;

	private static readonly System.IntPtr NativeFieldInfoPtr_Signature;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElementCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__HtmlRegex;

	private static readonly System.IntPtr NativeFieldInfoPtr__AttirbuteRegex;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecursiveBuildNodeChain_Private_Void_HtmlNode_byref_HtmlNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildNodeChainLinks_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildLayout_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHtmlTree_Public_Static_HtmlTree_String_Dictionary_2_String_HtmlTagDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_HtmlNode_byref___c__DisplayClass8_0_0;

	public unsafe HtmlNode Root
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Root);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HtmlNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Root)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)htmlNode));
		}
	}

	public unsafe int Signature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Signature);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Signature)) = num;
		}
	}

	public unsafe int ElementCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElementCount)) = num;
		}
	}

	public unsafe static Regex _HtmlRegex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HtmlRegex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HtmlRegex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	public unsafe static Regex _AttirbuteRegex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AttirbuteRegex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AttirbuteRegex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	static HtmlTree()
	{
		Il2CppClassPointerStore<HtmlTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Html.Classes", "HtmlTree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr);
		NativeFieldInfoPtr_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "Root");
		NativeFieldInfoPtr_Signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "Signature");
		NativeFieldInfoPtr_ElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "ElementCount");
		NativeFieldInfoPtr__HtmlRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "_HtmlRegex");
		NativeFieldInfoPtr__AttirbuteRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, "_AttirbuteRegex");
		NativeMethodInfoPtr_RecursiveBuildNodeChain_Private_Void_HtmlNode_byref_HtmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666028);
		NativeMethodInfoPtr_BuildNodeChainLinks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666029);
		NativeMethodInfoPtr_RebuildLayout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666030);
		NativeMethodInfoPtr_CreateHtmlTree_Public_Static_HtmlTree_String_Dictionary_2_String_HtmlTagDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666031);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666032);
		NativeMethodInfoPtr_Method_Internal_Static_HtmlNode_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr, 100666034);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 28744, RefRangeEnd = 28747, XrefRangeStart = 28735, XrefRangeEnd = 28744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecursiveBuildNodeChain(HtmlNode node, ref HtmlNode prev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prev);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecursiveBuildNodeChain_Private_Void_HtmlNode_byref_HtmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		prev = ((intPtr4 == (System.IntPtr)0) ? null : new HtmlNode(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28747, XrefRangeEnd = 28748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildNodeChainLinks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildNodeChainLinks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28748, XrefRangeEnd = 28754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildLayout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildLayout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28907, RefRangeEnd = 28908, XrefRangeStart = 28754, XrefRangeEnd = 28907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HtmlTree CreateHtmlTree(string html, Dictionary<string, HtmlTagDesc> tagMap, bool controlTags = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(html);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tagMap);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlTags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHtmlTree_Public_Static_HtmlTree_String_Dictionary_2_String_HtmlTagDesc_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HtmlTree>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HtmlTree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28917, RefRangeEnd = 28918, XrefRangeStart = 28908, XrefRangeEnd = 28917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HtmlNode Method_Internal_Static_HtmlNode_byref___c__DisplayClass8_0_0(ref __c__DisplayClass8_0 A_0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_0);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_HtmlNode_byref___c__DisplayClass8_0_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HtmlNode>(intPtr) : null;
	}

	public HtmlTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
