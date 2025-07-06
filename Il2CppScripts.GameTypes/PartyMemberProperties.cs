using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes;

[System.Serializable]
public class PartyMemberProperties : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClassId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int CurrentCP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCP)) = num;
		}
	}

	public unsafe int MaxCP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCP)) = num;
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

	static PartyMemberProperties()
	{
		Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes", "PartyMemberProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "ObjectId");
		NativeFieldInfoPtr_CurrentCP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "CurrentCP");
		NativeFieldInfoPtr_MaxCP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "MaxCP");
		NativeFieldInfoPtr_CurrentHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "CurrentHP");
		NativeFieldInfoPtr_MaxHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "MaxHP");
		NativeFieldInfoPtr_CurrentMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "CurrentMP");
		NativeFieldInfoPtr_MaxMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "MaxMP");
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_ClassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, "ClassId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr, 100668465);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartyMemberProperties()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyMemberProperties>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PartyMemberProperties(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
