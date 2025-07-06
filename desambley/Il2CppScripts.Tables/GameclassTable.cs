using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class GameclassTable : DataTableId<GameclassEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static GameclassTable()
	{
		Il2CppClassPointerStore<GameclassTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "GameclassTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameclassTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameclassTable>.NativeClassPtr, 100663696);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4843, XrefRangeEnd = 4846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameclassTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameclassTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameclassTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
