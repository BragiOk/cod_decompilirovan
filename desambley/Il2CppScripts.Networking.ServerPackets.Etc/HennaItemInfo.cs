using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;

namespace Il2CppScripts.Networking.ServerPackets.Etc;

public class HennaItemInfo : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__dyeItem;

	private static readonly IntPtr NativeFieldInfoPtr__adena;

	private static readonly IntPtr NativeFieldInfoPtr__currentInt;

	private static readonly IntPtr NativeFieldInfoPtr__equipInt;

	private static readonly IntPtr NativeFieldInfoPtr__currentStr;

	private static readonly IntPtr NativeFieldInfoPtr__equipStr;

	private static readonly IntPtr NativeFieldInfoPtr__currentCon;

	private static readonly IntPtr NativeFieldInfoPtr__equipCon;

	private static readonly IntPtr NativeFieldInfoPtr__currentMen;

	private static readonly IntPtr NativeFieldInfoPtr__equipMen;

	private static readonly IntPtr NativeFieldInfoPtr__currentDex;

	private static readonly IntPtr NativeFieldInfoPtr__equipDex;

	private static readonly IntPtr NativeFieldInfoPtr__currentWit;

	private static readonly IntPtr NativeFieldInfoPtr__equipWit;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ItemState _dyeItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dyeItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemState>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dyeItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState));
		}
	}

	public unsafe int _adena
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adena);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adena)) = num;
		}
	}

	public unsafe int _currentInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentInt)) = num;
		}
	}

	public unsafe int _equipInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipInt)) = num;
		}
	}

	public unsafe int _currentStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentStr);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentStr)) = num;
		}
	}

	public unsafe int _equipStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipStr);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipStr)) = num;
		}
	}

	public unsafe int _currentCon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCon);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCon)) = num;
		}
	}

	public unsafe int _equipCon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipCon);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipCon)) = num;
		}
	}

	public unsafe int _currentMen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentMen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentMen)) = num;
		}
	}

	public unsafe int _equipMen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipMen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipMen)) = num;
		}
	}

	public unsafe int _currentDex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentDex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentDex)) = num;
		}
	}

	public unsafe int _equipDex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipDex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipDex)) = num;
		}
	}

	public unsafe int _currentWit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentWit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentWit)) = num;
		}
	}

	public unsafe int _equipWit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipWit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__equipWit)) = num;
		}
	}

	static HennaItemInfo()
	{
		Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.Etc", "HennaItemInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr);
		NativeFieldInfoPtr__dyeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_dyeItem");
		NativeFieldInfoPtr__adena = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_adena");
		NativeFieldInfoPtr__currentInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentInt");
		NativeFieldInfoPtr__equipInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipInt");
		NativeFieldInfoPtr__currentStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentStr");
		NativeFieldInfoPtr__equipStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipStr");
		NativeFieldInfoPtr__currentCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentCon");
		NativeFieldInfoPtr__equipCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipCon");
		NativeFieldInfoPtr__currentMen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentMen");
		NativeFieldInfoPtr__equipMen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipMen");
		NativeFieldInfoPtr__currentDex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentDex");
		NativeFieldInfoPtr__equipDex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipDex");
		NativeFieldInfoPtr__currentWit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_currentWit");
		NativeFieldInfoPtr__equipWit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, "_equipWit");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr, 100664632);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15155, XrefRangeEnd = 15159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15159, XrefRangeEnd = 15174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HennaItemInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HennaItemInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HennaItemInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
