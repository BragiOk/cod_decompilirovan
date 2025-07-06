using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.AssetSystem;

[System.Serializable]
public class AssetRefBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static AssetRefBase()
	{
		Il2CppClassPointerStore<AssetRefBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.AssetSystem", "AssetRefBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRefBase>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefBase>.NativeClassPtr, 100670187);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetRefBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRefBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AssetRefBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
