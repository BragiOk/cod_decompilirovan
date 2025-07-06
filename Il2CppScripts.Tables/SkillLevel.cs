using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.Tables;

[System.Serializable]
public class SkillLevel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_desc_ru;

	private static readonly System.IntPtr NativeFieldInfoPtr_desc_en;

	private static readonly System.IntPtr NativeFieldInfoPtr_enchant_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_enchant_desc_ru;

	private static readonly System.IntPtr NativeFieldInfoPtr_enchant_desc_en;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = num;
		}
	}

	public unsafe string desc_ru
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_ru);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_ru)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string desc_en
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_en);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_en)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int enchant_level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_level)) = num;
		}
	}

	public unsafe string enchant_desc_ru
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_desc_ru);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_desc_ru)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string enchant_desc_en
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_desc_en);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enchant_desc_en)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SkillLevel()
	{
		Il2CppClassPointerStore<SkillLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "SkillLevel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr);
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "level");
		NativeFieldInfoPtr_desc_ru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "desc_ru");
		NativeFieldInfoPtr_desc_en = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "desc_en");
		NativeFieldInfoPtr_enchant_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "enchant_level");
		NativeFieldInfoPtr_enchant_desc_ru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "enchant_desc_ru");
		NativeFieldInfoPtr_enchant_desc_en = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, "enchant_desc_en");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr, 100663724);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillLevel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillLevel>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillLevel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
