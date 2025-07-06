using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.AssetSystem;

[Serializable]
public class SkinnedMeshRef : AssetRef<SkinnedMeshRenderer>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SkinnedMeshRenderer_0;

	static SkinnedMeshRef()
	{
		Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.AssetSystem", "SkinnedMeshRef");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr, 100670199);
		NativeMethodInfoPtr__ctor_Public_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr, 100670200);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70636, XrefRangeEnd = 70637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinnedMeshRef()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70637, XrefRangeEnd = 70639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkinnedMeshRef(SkinnedMeshRenderer mesh)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRef>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkinnedMeshRef(IntPtr pointer)
		: base(pointer)
	{
	}
}
