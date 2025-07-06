using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class SkillTable : DataTableId<SkillEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SkillTable()
	{
		Il2CppClassPointerStore<SkillTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "SkillTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillTable>.NativeClassPtr, 100663729);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4933, XrefRangeEnd = 4936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
