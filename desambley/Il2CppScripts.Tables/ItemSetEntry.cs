using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScripts.Tables;

[Serializable]
public class ItemSetEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_item_ids;

	private static readonly IntPtr NativeFieldInfoPtr_bonus_desc;

	private static readonly IntPtr NativeFieldInfoPtr_item_ids_extra;

	private static readonly IntPtr NativeFieldInfoPtr_extra_desc;

	private static readonly IntPtr NativeFieldInfoPtr_special_enchant_amount;

	private static readonly IntPtr NativeFieldInfoPtr_special_enchant_desc;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<int> item_ids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item_ids);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item_ids)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string bonus_desc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonus_desc);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonus_desc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppStructArray<int> item_ids_extra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item_ids_extra);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item_ids_extra)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string extra_desc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extra_desc);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extra_desc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int special_enchant_amount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_special_enchant_amount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_special_enchant_amount)) = num;
		}
	}

	public unsafe string special_enchant_desc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_special_enchant_desc);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_special_enchant_desc)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ItemSetEntry()
	{
		Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "ItemSetEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr);
		NativeFieldInfoPtr_item_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "item_ids");
		NativeFieldInfoPtr_bonus_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "bonus_desc");
		NativeFieldInfoPtr_item_ids_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "item_ids_extra");
		NativeFieldInfoPtr_extra_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "extra_desc");
		NativeFieldInfoPtr_special_enchant_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "special_enchant_amount");
		NativeFieldInfoPtr_special_enchant_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, "special_enchant_desc");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, 100663699);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemSetEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemSetEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
