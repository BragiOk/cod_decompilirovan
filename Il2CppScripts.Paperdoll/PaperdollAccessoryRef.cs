using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.AssetSystem;

namespace Il2CppScripts.Paperdoll;

[Serializable]
public class PaperdollAccessoryRef : AssetRef<PaperdollAccessory>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PaperdollAccessoryRef()
	{
		Il2CppClassPointerStore<PaperdollAccessoryRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll", "PaperdollAccessoryRef");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaperdollAccessoryRef>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollAccessoryRef>.NativeClassPtr, 100664081);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9174, XrefRangeEnd = 9175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PaperdollAccessoryRef()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaperdollAccessoryRef>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PaperdollAccessoryRef(IntPtr pointer)
		: base(pointer)
	{
	}
}
