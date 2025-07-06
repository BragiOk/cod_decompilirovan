using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Character;

[System.Serializable]
public class Paperdoll : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SlotUnder;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotLEar;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotREar;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotNeck;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotLFinger;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotRFinger;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotRHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotLHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotGloves;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotChest;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotPetArmor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotLegs;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotFeet;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotLRHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotFullArmor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_Accessory1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Accessory2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Accessory3;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetSlot1;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetSlot2;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetSlot3;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Items;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_PaperdollSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_PaperdollSlot_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_PaperdollSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareIds_Public_Boolean_Paperdoll_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Boolean_Paperdoll_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Paperdoll_0;

	public unsafe static int SlotUnder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotUnder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotUnder, (void*)(&num));
		}
	}

	public unsafe static int SlotLEar
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotLEar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotLEar, (void*)(&num));
		}
	}

	public unsafe static int SlotREar
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotREar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotREar, (void*)(&num));
		}
	}

	public unsafe static int SlotNeck
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotNeck, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotNeck, (void*)(&num));
		}
	}

	public unsafe static int SlotLFinger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotLFinger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotLFinger, (void*)(&num));
		}
	}

	public unsafe static int SlotRFinger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotRFinger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotRFinger, (void*)(&num));
		}
	}

	public unsafe static int SlotHead
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotHead, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotHead, (void*)(&num));
		}
	}

	public unsafe static int SlotRHand
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotRHand, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotRHand, (void*)(&num));
		}
	}

	public unsafe static int SlotLHand
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotLHand, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotLHand, (void*)(&num));
		}
	}

	public unsafe static int SlotGloves
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotGloves, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotGloves, (void*)(&num));
		}
	}

	public unsafe static int SlotChest
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotChest, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotChest, (void*)(&num));
		}
	}

	public unsafe static int SlotPetArmor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotPetArmor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotPetArmor, (void*)(&num));
		}
	}

	public unsafe static int SlotLegs
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotLegs, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotLegs, (void*)(&num));
		}
	}

	public unsafe static int SlotFeet
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotFeet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotFeet, (void*)(&num));
		}
	}

	public unsafe static int SlotBack
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotBack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotBack, (void*)(&num));
		}
	}

	public unsafe static int SlotLRHand
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotLRHand, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotLRHand, (void*)(&num));
		}
	}

	public unsafe static int SlotFullArmor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotFullArmor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotFullArmor, (void*)(&num));
		}
	}

	public unsafe static int SlotHair
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotHair, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotHair, (void*)(&num));
		}
	}

	public unsafe static int Accessory1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Accessory1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Accessory1, (void*)(&num));
		}
	}

	public unsafe static int Accessory2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Accessory2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Accessory2, (void*)(&num));
		}
	}

	public unsafe static int Accessory3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Accessory3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Accessory3, (void*)(&num));
		}
	}

	public unsafe static int PetSlot1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PetSlot1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PetSlot1, (void*)(&num));
		}
	}

	public unsafe static int PetSlot2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PetSlot2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PetSlot2, (void*)(&num));
		}
	}

	public unsafe static int PetSlot3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PetSlot3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PetSlot3, (void*)(&num));
		}
	}

	public unsafe static int SlotCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotCount, (void*)(&num));
		}
	}

	public unsafe Il2CppStructArray<PaperdollSlot> Items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PaperdollSlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe PaperdollSlot this[int index]
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_PaperdollSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(PaperdollSlot*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(PaperdollSlot**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_PaperdollSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Paperdoll()
	{
		Il2CppClassPointerStore<Paperdoll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "Paperdoll");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr);
		NativeFieldInfoPtr_SlotUnder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotUnder");
		NativeFieldInfoPtr_SlotLEar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotLEar");
		NativeFieldInfoPtr_SlotREar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotREar");
		NativeFieldInfoPtr_SlotNeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotNeck");
		NativeFieldInfoPtr_SlotLFinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotLFinger");
		NativeFieldInfoPtr_SlotRFinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotRFinger");
		NativeFieldInfoPtr_SlotHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotHead");
		NativeFieldInfoPtr_SlotRHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotRHand");
		NativeFieldInfoPtr_SlotLHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotLHand");
		NativeFieldInfoPtr_SlotGloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotGloves");
		NativeFieldInfoPtr_SlotChest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotChest");
		NativeFieldInfoPtr_SlotPetArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotPetArmor");
		NativeFieldInfoPtr_SlotLegs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotLegs");
		NativeFieldInfoPtr_SlotFeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotFeet");
		NativeFieldInfoPtr_SlotBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotBack");
		NativeFieldInfoPtr_SlotLRHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotLRHand");
		NativeFieldInfoPtr_SlotFullArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotFullArmor");
		NativeFieldInfoPtr_SlotHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotHair");
		NativeFieldInfoPtr_Accessory1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "Accessory1");
		NativeFieldInfoPtr_Accessory2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "Accessory2");
		NativeFieldInfoPtr_Accessory3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "Accessory3");
		NativeFieldInfoPtr_PetSlot1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "PetSlot1");
		NativeFieldInfoPtr_PetSlot2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "PetSlot2");
		NativeFieldInfoPtr_PetSlot3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "PetSlot3");
		NativeFieldInfoPtr_SlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "SlotCount");
		NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, "Items");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668470);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_PaperdollSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668471);
		NativeMethodInfoPtr_get_Item_Public_get_PaperdollSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668472);
		NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_PaperdollSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668473);
		NativeMethodInfoPtr_CompareIds_Public_Boolean_Paperdoll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668474);
		NativeMethodInfoPtr_Compare_Public_Boolean_Paperdoll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668475);
		NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668476);
		NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668477);
		NativeMethodInfoPtr_Copy_Public_Paperdoll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr, 100668478);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 51038, RefRangeEnd = 51045, XrefRangeStart = 51035, XrefRangeEnd = 51038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Paperdoll()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51045, XrefRangeEnd = 51048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Paperdoll(Il2CppStructArray<PaperdollSlot> items)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Paperdoll>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_PaperdollSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool CompareIds(Paperdoll paperdoll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paperdoll);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareIds_Public_Boolean_Paperdoll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool Compare(Paperdoll paperdoll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paperdoll);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Boolean_Paperdoll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetSlot(int slot, int itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&slot);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetSlot(int slot, int itemId, int enchantLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&slot);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &enchantLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSlot_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 51054, RefRangeEnd = 51059, XrefRangeStart = 51048, XrefRangeEnd = 51054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Paperdoll Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Paperdoll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Paperdoll>(intPtr) : null;
	}

	public Paperdoll(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
