using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

[Serializable]
public class MacroIconEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_Icon;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string Icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Icon);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Icon)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static MacroIconEntry()
	{
		Il2CppClassPointerStore<MacroIconEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "MacroIconEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MacroIconEntry>.NativeClassPtr);
		NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIconEntry>.NativeClassPtr, "Icon");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIconEntry>.NativeClassPtr, 100663710);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MacroIconEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MacroIconEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MacroIconEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
