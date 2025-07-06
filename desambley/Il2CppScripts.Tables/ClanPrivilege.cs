using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class ClanPrivilege : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_name_ru;

	private static readonly IntPtr NativeFieldInfoPtr_name_en;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string name_ru
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_ru);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_ru)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string name_en
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_en);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_en)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ClanPrivilege()
	{
		Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "ClanPrivilege");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr);
		NativeFieldInfoPtr_name_ru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr, "name_ru");
		NativeFieldInfoPtr_name_en = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr, "name_en");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr, 100663669);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClanPrivilege()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanPrivilege>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClanPrivilege(IntPtr pointer)
		: base(pointer)
	{
	}
}
