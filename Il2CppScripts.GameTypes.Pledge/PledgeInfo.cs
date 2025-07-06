using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Pledge;

[System.Serializable]
public sealed class PledgeInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ClanId;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrestId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Leader;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsClanLeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_UserName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CastleId;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Reputation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanRanking;

	public unsafe int ClanId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanId)) = num;
		}
	}

	public unsafe int CrestId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrestId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrestId)) = num;
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string Leader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Leader);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Leader)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool IsClanLeader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsClanLeader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsClanLeader)) = flag;
		}
	}

	public unsafe string UserName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int CastleId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastleId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastleId)) = num;
		}
	}

	public unsafe int ClanLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanLevel)) = num;
		}
	}

	public unsafe int Reputation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reputation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reputation)) = num;
		}
	}

	public unsafe int ClanRanking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanRanking);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanRanking)) = num;
		}
	}

	static PledgeInfo()
	{
		Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Pledge", "PledgeInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr);
		NativeFieldInfoPtr_ClanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "ClanId");
		NativeFieldInfoPtr_CrestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "CrestId");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "Leader");
		NativeFieldInfoPtr_IsClanLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "IsClanLeader");
		NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "UserName");
		NativeFieldInfoPtr_CastleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "CastleId");
		NativeFieldInfoPtr_ClanLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "ClanLevel");
		NativeFieldInfoPtr_Reputation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "Reputation");
		NativeFieldInfoPtr_ClanRanking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr, "ClanRanking");
	}

	public PledgeInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PledgeInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PledgeInfo>.NativeClassPtr))
	{
	}
}
