using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

[Serializable]
public class ActionTable : DataTableId<ActionEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ActionTable()
	{
		Il2CppClassPointerStore<ActionTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "ActionTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTable>.NativeClassPtr, 100663663);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4270, XrefRangeEnd = 4273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActionTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
