using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.Lib;
using Il2CppSystem;

namespace Il2CppScripts.Networking.Types;

[StructLayout(LayoutKind.Explicit)]
public struct ItemUpdate
{
	[OriginalName("Assembly-Scripts.dll", "", "Slot")]
	[System.Flags]
	public enum Slot
	{
		NONE = 0,
		UNDERWEAR = 1,
		R_EAR = 2,
		L_EAR = 4,
		NECK = 8,
		R_FINGER = 0x10,
		L_FINGER = 0x20,
		HEAD = 0x40,
		R_HAND = 0x80,
		L_HAND = 0x100,
		GLOVES = 0x200,
		CHEST = 0x400,
		LEGS = 0x800,
		FEET = 0x1000,
		BACK = 0x2000,
		LR_HAND = 0x4000,
		FULL_ARMOR = 0x8000,
		HAIR = 0x10000,
		FACE = 0x20000,
		DHAIR = 0x40000,
		LR_FINGER = 0x30,
		LR_EAR = 6
	}

	[OriginalName("Assembly-Scripts.dll", "", "Type")]
	public enum Type
	{
		Add,
		Modify,
		Remove
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Count;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Equipped;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnchantLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomType2;

	private static readonly System.IntPtr NativeFieldInfoPtr_AugmentBony;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemMana;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_BinaryMsgRead_0;

	[FieldOffset(0)]
	public Type ChangeType;

	[FieldOffset(4)]
	public int Type1;

	[FieldOffset(8)]
	public int ObjectID;

	[FieldOffset(12)]
	public int ItemID;

	[FieldOffset(16)]
	public int Count;

	[FieldOffset(20)]
	public int Type2;

	[FieldOffset(24)]
	[MarshalAs(UnmanagedType.U1)]
	public bool Equipped;

	[FieldOffset(28)]
	public int ItemSlot;

	[FieldOffset(32)]
	public int ItemLocation;

	[FieldOffset(36)]
	public int EnchantLevel;

	[FieldOffset(40)]
	public int CustomType2;

	[FieldOffset(44)]
	public int AugmentBony;

	[FieldOffset(48)]
	public int ItemMana;

	static ItemUpdate()
	{
		Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.Types", "ItemUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_ChangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ChangeType");
		NativeFieldInfoPtr_Type1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "Type1");
		NativeFieldInfoPtr_ObjectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ObjectID");
		NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ItemID");
		NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "Count");
		NativeFieldInfoPtr_Type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "Type2");
		NativeFieldInfoPtr_Equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "Equipped");
		NativeFieldInfoPtr_ItemSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ItemSlot");
		NativeFieldInfoPtr_ItemLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ItemLocation");
		NativeFieldInfoPtr_EnchantLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "EnchantLevel");
		NativeFieldInfoPtr_CustomType2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "CustomType2");
		NativeFieldInfoPtr_AugmentBony = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "AugmentBony");
		NativeFieldInfoPtr_ItemMana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, "ItemMana");
		NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr__ctor_Public_Void_Type_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, 100664331);
	}

	[CallerCount(0)]
	public unsafe ItemUpdate(Type changeType, int itemSlot, int objectId, int itemId, bool equipped, int count = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&changeType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemSlot;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &objectId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemId;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &equipped;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_Int32_Int32_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12801, RefRangeEnd = 12802, XrefRangeStart = 12788, XrefRangeEnd = 12801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemUpdate(Type updateType, BinaryMsgRead msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_BinaryMsgRead_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
