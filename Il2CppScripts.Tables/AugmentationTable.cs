using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class AugmentationTable : DataTableId<AugmentationEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static AugmentationTable()
	{
		Il2CppClassPointerStore<AugmentationTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "AugmentationTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AugmentationTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentationTable>.NativeClassPtr, 100663668);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4276, XrefRangeEnd = 4279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AugmentationTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AugmentationTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AugmentationTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
