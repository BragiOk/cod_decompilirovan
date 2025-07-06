using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class SystemMsgTable : DataTableId<SystemMsgEntry>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SystemMsgTable()
	{
		Il2CppClassPointerStore<SystemMsgTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "SystemMsgTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemMsgTable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemMsgTable>.NativeClassPtr, 100663732);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4936, XrefRangeEnd = 4939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SystemMsgTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemMsgTable>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SystemMsgTable(IntPtr pointer)
		: base(pointer)
	{
	}
}
