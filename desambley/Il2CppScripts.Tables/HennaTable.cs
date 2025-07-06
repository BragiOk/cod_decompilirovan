using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class HennaTable : DataTableId<HennaEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static HennaTable()
	{
		Il2CppClassPointerStore<HennaTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "HennaTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HennaTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaTable>.NativeClassPtr, 100663698);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4846, XrefRangeEnd = 4849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HennaTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HennaTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HennaTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
