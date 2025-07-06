using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class MacroIconTable : DataTableId<MacroIconEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MacroIconTable()
	{
		Il2CppClassPointerStore<MacroIconTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "MacroIconTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MacroIconTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIconTable>.NativeClassPtr, 100663711);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4876, XrefRangeEnd = 4879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MacroIconTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MacroIconTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MacroIconTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
