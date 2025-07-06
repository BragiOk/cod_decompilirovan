using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class ClanSubunitTable : DataTableId<ClanSubunit>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ClanSubunitTable()
	{
		Il2CppClassPointerStore<ClanSubunitTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "ClanSubunitTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanSubunitTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanSubunitTable>.NativeClassPtr, 100663672);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4282, XrefRangeEnd = 4285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClanSubunitTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanSubunitTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClanSubunitTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
