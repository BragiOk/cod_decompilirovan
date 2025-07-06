using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ServerPackets.Events;

public class ExOlympiadUserInfo : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__side;

	private static readonly IntPtr NativeFieldInfoPtr__playerObjectId;

	private static readonly IntPtr NativeFieldInfoPtr__name;

	private static readonly IntPtr NativeFieldInfoPtr__classId;

	private static readonly IntPtr NativeFieldInfoPtr__curHp;

	private static readonly IntPtr NativeFieldInfoPtr__maxHp;

	private static readonly IntPtr NativeFieldInfoPtr__curCp;

	private static readonly IntPtr NativeFieldInfoPtr__maxCp;

	private static readonly IntPtr NativeFieldInfoPtr__curMp;

	private static readonly IntPtr NativeFieldInfoPtr__maxMp;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _side
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__side);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__side)) = num;
		}
	}

	public unsafe int _playerObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerObjectId)) = num;
		}
	}

	public unsafe string _name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _classId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__classId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__classId)) = num;
		}
	}

	public unsafe int _curHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curHp)) = num;
		}
	}

	public unsafe int _maxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxHp)) = num;
		}
	}

	public unsafe int _curCp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curCp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curCp)) = num;
		}
	}

	public unsafe int _maxCp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxCp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxCp)) = num;
		}
	}

	public unsafe int _curMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curMp)) = num;
		}
	}

	public unsafe int _maxMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxMp)) = num;
		}
	}

	static ExOlympiadUserInfo()
	{
		Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.Events", "ExOlympiadUserInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr);
		NativeFieldInfoPtr__side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_side");
		NativeFieldInfoPtr__playerObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_playerObjectId");
		NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_name");
		NativeFieldInfoPtr__classId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_classId");
		NativeFieldInfoPtr__curHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_curHp");
		NativeFieldInfoPtr__maxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_maxHp");
		NativeFieldInfoPtr__curCp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_curCp");
		NativeFieldInfoPtr__maxCp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_maxCp");
		NativeFieldInfoPtr__curMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_curMp");
		NativeFieldInfoPtr__maxMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, "_maxMp");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr, 100664609);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15001, XrefRangeEnd = 15010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15010, XrefRangeEnd = 15018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe ExOlympiadUserInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExOlympiadUserInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExOlympiadUserInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
