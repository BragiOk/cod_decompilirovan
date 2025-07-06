using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class GameclassEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_race;

	private static readonly IntPtr NativeFieldInfoPtr_name_ru;

	private static readonly IntPtr NativeFieldInfoPtr_name_en;

	private static readonly IntPtr NativeFieldInfoPtr_type;

	private static readonly IntPtr NativeFieldInfoPtr_male_model;

	private static readonly IntPtr NativeFieldInfoPtr_female_model;

	private static readonly IntPtr NativeFieldInfoPtr_icon;

	private static readonly IntPtr NativeFieldInfoPtr_allow_create;

	private static readonly IntPtr NativeFieldInfoPtr_desc_ru;

	private static readonly IntPtr NativeFieldInfoPtr_desc_en;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int race
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_race);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_race)) = num;
		}
	}

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

	public unsafe int type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = num;
		}
	}

	public unsafe int male_model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_male_model);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_male_model)) = num;
		}
	}

	public unsafe int female_model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_female_model);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_female_model)) = num;
		}
	}

	public unsafe string icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool allow_create
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allow_create);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allow_create)) = flag;
		}
	}

	public unsafe string desc_ru
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_ru);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_ru)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string desc_en
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_en);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc_en)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static GameclassEntry()
	{
		Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "GameclassEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr);
		NativeFieldInfoPtr_race = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "race");
		NativeFieldInfoPtr_name_ru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "name_ru");
		NativeFieldInfoPtr_name_en = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "name_en");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "type");
		NativeFieldInfoPtr_male_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "male_model");
		NativeFieldInfoPtr_female_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "female_model");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_allow_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "allow_create");
		NativeFieldInfoPtr_desc_ru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "desc_ru");
		NativeFieldInfoPtr_desc_en = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, "desc_en");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr, 100663695);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameclassEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameclassEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameclassEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
