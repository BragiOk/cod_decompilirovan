using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Pledge;

[System.Serializable]
public sealed class PledgeMemberInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_PledgeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClassId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Online;

	private static readonly System.IntPtr NativeFieldInfoPtr_PowerGrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_RankPrivs;

	private static readonly System.IntPtr NativeFieldInfoPtr_Yellow;

	public unsafe string PlayerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int ObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjectId)) = num;
		}
	}

	public unsafe int PlayerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLevel)) = num;
		}
	}

	public unsafe int PledgeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeType)) = num;
		}
	}

	public unsafe string ClanName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int ClassId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClassId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClassId)) = num;
		}
	}

	public unsafe bool Online
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Online);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Online)) = flag;
		}
	}

	public unsafe int PowerGrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PowerGrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PowerGrade)) = num;
		}
	}

	public unsafe int RankPrivs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankPrivs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankPrivs)) = num;
		}
	}

	public unsafe bool Yellow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Yellow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Yellow)) = flag;
		}
	}

	static PledgeMemberInfo()
	{
		Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Pledge", "PledgeMemberInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "PlayerName");
		NativeFieldInfoPtr_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "ObjectId");
		NativeFieldInfoPtr_PlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "PlayerLevel");
		NativeFieldInfoPtr_PledgeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "PledgeType");
		NativeFieldInfoPtr_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "ClanName");
		NativeFieldInfoPtr_ClassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "ClassId");
		NativeFieldInfoPtr_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "Online");
		NativeFieldInfoPtr_PowerGrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "PowerGrade");
		NativeFieldInfoPtr_RankPrivs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "RankPrivs");
		NativeFieldInfoPtr_Yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr, "Yellow");
	}

	public PledgeMemberInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PledgeMemberInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PledgeMemberInfo>.NativeClassPtr))
	{
	}
}
