using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes;

[System.Serializable]
public sealed class PetProperties : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level;

	private static readonly System.IntPtr NativeFieldInfoPtr_SummonType;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_SP;

	private static readonly System.IntPtr NativeFieldInfoPtr_Exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_PAtk;

	private static readonly System.IntPtr NativeFieldInfoPtr_PDef;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAtk;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDef;

	private static readonly System.IntPtr NativeFieldInfoPtr_Accuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Evasion;

	private static readonly System.IntPtr NativeFieldInfoPtr_Critical;

	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_AtkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_CastSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_CritMultiply;

	private static readonly System.IntPtr NativeFieldInfoPtr_MagicCritChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_FoodMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_FoodRemain;

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

	public unsafe int Level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level)) = num;
		}
	}

	public unsafe int SummonType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SummonType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SummonType)) = num;
		}
	}

	public unsafe int CurrentHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentHP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentHP)) = num;
		}
	}

	public unsafe int MaxHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxHP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxHP)) = num;
		}
	}

	public unsafe int CurrentMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMP)) = num;
		}
	}

	public unsafe int MaxMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxMP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxMP)) = num;
		}
	}

	public unsafe int SP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SP)) = num;
		}
	}

	public unsafe float Exp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Exp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Exp)) = num;
		}
	}

	public unsafe int PAtk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PAtk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PAtk)) = num;
		}
	}

	public unsafe int PDef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PDef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PDef)) = num;
		}
	}

	public unsafe int MAtk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAtk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAtk)) = num;
		}
	}

	public unsafe int MDef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDef)) = num;
		}
	}

	public unsafe int Accuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accuracy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accuracy)) = num;
		}
	}

	public unsafe int Evasion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Evasion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Evasion)) = num;
		}
	}

	public unsafe int Critical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Critical);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Critical)) = num;
		}
	}

	public unsafe int Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed)) = num;
		}
	}

	public unsafe int AtkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtkSpeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtkSpeed)) = num;
		}
	}

	public unsafe int CastSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastSpeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CastSpeed)) = num;
		}
	}

	public unsafe int CritMultiply
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CritMultiply);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CritMultiply)) = num;
		}
	}

	public unsafe int MagicCritChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicCritChance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicCritChance)) = num;
		}
	}

	public unsafe int FoodMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoodMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoodMax)) = num;
		}
	}

	public unsafe int FoodRemain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoodRemain);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoodRemain)) = num;
		}
	}

	static PetProperties()
	{
		Il2CppClassPointerStore<PetProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes", "PetProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PetProperties>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "ObjectId");
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_SummonType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "SummonType");
		NativeFieldInfoPtr_CurrentHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "CurrentHP");
		NativeFieldInfoPtr_MaxHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "MaxHP");
		NativeFieldInfoPtr_CurrentMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "CurrentMP");
		NativeFieldInfoPtr_MaxMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "MaxMP");
		NativeFieldInfoPtr_SP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "SP");
		NativeFieldInfoPtr_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Exp");
		NativeFieldInfoPtr_PAtk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "PAtk");
		NativeFieldInfoPtr_PDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "PDef");
		NativeFieldInfoPtr_MAtk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "MAtk");
		NativeFieldInfoPtr_MDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "MDef");
		NativeFieldInfoPtr_Accuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Accuracy");
		NativeFieldInfoPtr_Evasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Evasion");
		NativeFieldInfoPtr_Critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Critical");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_AtkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "AtkSpeed");
		NativeFieldInfoPtr_CastSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "CastSpeed");
		NativeFieldInfoPtr_CritMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "CritMultiply");
		NativeFieldInfoPtr_MagicCritChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "MagicCritChance");
		NativeFieldInfoPtr_FoodMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "FoodMax");
		NativeFieldInfoPtr_FoodRemain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetProperties>.NativeClassPtr, "FoodRemain");
	}

	public PetProperties(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PetProperties()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PetProperties>.NativeClassPtr))
	{
	}
}
