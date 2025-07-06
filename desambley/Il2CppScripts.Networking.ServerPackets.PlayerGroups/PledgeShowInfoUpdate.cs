using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ServerPackets.PlayerGroups;

public class PledgeShowInfoUpdate : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__clanId;

	private static readonly IntPtr NativeFieldInfoPtr__clanLevel;

	private static readonly IntPtr NativeFieldInfoPtr__fort;

	private static readonly IntPtr NativeFieldInfoPtr__hideout;

	private static readonly IntPtr NativeFieldInfoPtr__ranking;

	private static readonly IntPtr NativeFieldInfoPtr__reputation;

	private static readonly IntPtr NativeFieldInfoPtr__crestId;

	private static readonly IntPtr NativeFieldInfoPtr__allyId;

	private static readonly IntPtr NativeFieldInfoPtr__allyName;

	private static readonly IntPtr NativeFieldInfoPtr__allyCrestId;

	private static readonly IntPtr NativeFieldInfoPtr__atWar;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _clanId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clanId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clanId)) = num;
		}
	}

	public unsafe int _clanLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clanLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clanLevel)) = num;
		}
	}

	public unsafe int _fort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fort);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fort)) = num;
		}
	}

	public unsafe int _hideout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideout)) = num;
		}
	}

	public unsafe int _ranking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ranking);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ranking)) = num;
		}
	}

	public unsafe int _reputation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reputation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reputation)) = num;
		}
	}

	public unsafe int _crestId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestId)) = num;
		}
	}

	public unsafe int _allyId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyId)) = num;
		}
	}

	public unsafe string _allyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _allyCrestId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyCrestId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allyCrestId)) = num;
		}
	}

	public unsafe bool _atWar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__atWar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__atWar)) = flag;
		}
	}

	static PledgeShowInfoUpdate()
	{
		Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.PlayerGroups", "PledgeShowInfoUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr);
		NativeFieldInfoPtr__clanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_clanId");
		NativeFieldInfoPtr__clanLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_clanLevel");
		NativeFieldInfoPtr__fort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_fort");
		NativeFieldInfoPtr__hideout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_hideout");
		NativeFieldInfoPtr__ranking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_ranking");
		NativeFieldInfoPtr__reputation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_reputation");
		NativeFieldInfoPtr__crestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_crestId");
		NativeFieldInfoPtr__allyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_allyId");
		NativeFieldInfoPtr__allyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_allyName");
		NativeFieldInfoPtr__allyCrestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_allyCrestId");
		NativeFieldInfoPtr__atWar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, "_atWar");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr, 100664522);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14300, XrefRangeEnd = 14305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14305, XrefRangeEnd = 14318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe PledgeShowInfoUpdate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PledgeShowInfoUpdate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PledgeShowInfoUpdate(IntPtr pointer)
		: base(pointer)
	{
	}
}
