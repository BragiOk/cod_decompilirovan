using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Networking.ClientPackets.Trade;

public class RequestPrivateStoreSell : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__playerId;

	private static readonly IntPtr NativeFieldInfoPtr__items;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_ItemState_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe int _playerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId)) = num;
		}
	}

	public unsafe List<ItemState> _items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__items);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ItemState>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RequestPrivateStoreSell()
	{
		Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Trade", "RequestPrivateStoreSell");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr);
		NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr, "_playerId");
		NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr, "_items");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr, 100664881);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr, 100664882);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17101, XrefRangeEnd = 17107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestPrivateStoreSell(int playerId, IEnumerable<ItemState> items)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestPrivateStoreSell>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&playerId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_ItemState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17107, XrefRangeEnd = 17124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestPrivateStoreSell(IntPtr pointer)
		: base(pointer)
	{
	}
}
