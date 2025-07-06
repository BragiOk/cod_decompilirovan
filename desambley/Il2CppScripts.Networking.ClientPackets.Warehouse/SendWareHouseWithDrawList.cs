using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Networking.ClientPackets.Warehouse;

public class SendWareHouseWithDrawList : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__warehouseType;

	private static readonly IntPtr NativeFieldInfoPtr__items;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IReadOnlyList_1_ItemState_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe int _warehouseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__warehouseType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__warehouseType)) = num;
		}
	}

	public unsafe IReadOnlyList<ItemState> _items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__items);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<ItemState>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlyList));
		}
	}

	static SendWareHouseWithDrawList()
	{
		Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Warehouse", "SendWareHouseWithDrawList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr);
		NativeFieldInfoPtr__warehouseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr, "_warehouseType");
		NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr, "_items");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_IReadOnlyList_1_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr, 100664857);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr, 100664858);
	}

	[CallerCount(0)]
	public unsafe SendWareHouseWithDrawList(int warehouseType, IReadOnlyList<ItemState> items)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendWareHouseWithDrawList>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&warehouseType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_IReadOnlyList_1_ItemState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17031, XrefRangeEnd = 17049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SendWareHouseWithDrawList(IntPtr pointer)
		: base(pointer)
	{
	}
}
