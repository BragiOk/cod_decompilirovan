using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace Il2CppScripts.UI.Elements.Utility;

public class WarmupChildElements : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__wholeTree;

	private static readonly IntPtr NativeFieldInfoPtr__forceLayout;

	private static readonly IntPtr NativeMethodInfoPtr_Warmup_Private_Void_Il2CppReferenceArray_1_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _wholeTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wholeTree);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wholeTree)) = flag;
		}
	}

	public unsafe bool _forceLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceLayout);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forceLayout)) = flag;
		}
	}

	static WarmupChildElements()
	{
		Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.Utility", "WarmupChildElements");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr);
		NativeFieldInfoPtr__wholeTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr, "_wholeTree");
		NativeFieldInfoPtr__forceLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr, "_forceLayout");
		NativeMethodInfoPtr_Warmup_Private_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr, 100666497);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr, 100666498);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr, 100666499);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32376, RefRangeEnd = 32377, XrefRangeStart = 32360, XrefRangeEnd = 32376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Warmup(Il2CppReferenceArray<Transform> transforms)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warmup_Private_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32377, XrefRangeEnd = 32387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WarmupChildElements()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarmupChildElements>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WarmupChildElements(IntPtr pointer)
		: base(pointer)
	{
	}
}
