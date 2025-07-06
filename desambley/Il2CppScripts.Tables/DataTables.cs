using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Tables;

public class DataTables : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ActionTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_SystemMsgTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacterTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemSetTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_HennaTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanSubunitTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanPrivilegeTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_AugmentationTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameclassTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimSequenceTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_AccessoryTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_MacroIconTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_MobSkillAnimGrpTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_MusicTable;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DataTables_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTables_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActionTable ActionTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionTable));
		}
	}

	public unsafe SkillTable SkillTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillTable));
		}
	}

	public unsafe SystemMsgTable SystemMsgTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMsgTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemMsgTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMsgTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemMsgTable));
		}
	}

	public unsafe PlayerCharacterTable PlayerCharacterTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCharacterTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCharacterTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCharacterTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerCharacterTable));
		}
	}

	public unsafe NpcTable NpcTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcTable));
		}
	}

	public unsafe ItemSetTable ItemSetTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemSetTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemSetTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemSetTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemSetTable));
		}
	}

	public unsafe HennaTable HennaTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HennaTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HennaTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HennaTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hennaTable));
		}
	}

	public unsafe ClanSubunitTable ClanSubunitTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanSubunitTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClanSubunitTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanSubunitTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clanSubunitTable));
		}
	}

	public unsafe ClanPrivilegeTable ClanPrivilegeTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanPrivilegeTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClanPrivilegeTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanPrivilegeTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clanPrivilegeTable));
		}
	}

	public unsafe AugmentationTable AugmentationTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AugmentationTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AugmentationTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AugmentationTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)augmentationTable));
		}
	}

	public unsafe GameclassTable GameclassTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameclassTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameclassTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameclassTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameclassTable));
		}
	}

	public unsafe AnimSequenceTable AnimSequenceTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimSequenceTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimSequenceTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimSequenceTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animSequenceTable));
		}
	}

	public unsafe AccessoryTable AccessoryTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AccessoryTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessoryTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AccessoryTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accessoryTable));
		}
	}

	public unsafe ItemTable ItemTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemTable));
		}
	}

	public unsafe MacroIconTable MacroIconTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroIconTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacroIconTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroIconTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroIconTable));
		}
	}

	public unsafe MobSkillAnimGrpTable MobSkillAnimGrpTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MobSkillAnimGrpTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobSkillAnimGrpTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MobSkillAnimGrpTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mobSkillAnimGrpTable));
		}
	}

	public unsafe MusicTable MusicTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusicTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MusicTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusicTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)musicTable));
		}
	}

	public unsafe static DataTables _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataTables>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataTables));
		}
	}

	public unsafe static DataTables Instance
	{
		[CallerCount(129)]
		[CachedScanResults(RefRangeStart = 4503, RefRangeEnd = 4632, XrefRangeStart = 4494, XrefRangeEnd = 4503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DataTables_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataTables>(intPtr) : null;
		}
	}

	static DataTables()
	{
		Il2CppClassPointerStore<DataTables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "DataTables");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTables>.NativeClassPtr);
		NativeFieldInfoPtr_ActionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "ActionTable");
		NativeFieldInfoPtr_SkillTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "SkillTable");
		NativeFieldInfoPtr_SystemMsgTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "SystemMsgTable");
		NativeFieldInfoPtr_PlayerCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "PlayerCharacterTable");
		NativeFieldInfoPtr_NpcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "NpcTable");
		NativeFieldInfoPtr_ItemSetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "ItemSetTable");
		NativeFieldInfoPtr_HennaTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "HennaTable");
		NativeFieldInfoPtr_ClanSubunitTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "ClanSubunitTable");
		NativeFieldInfoPtr_ClanPrivilegeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "ClanPrivilegeTable");
		NativeFieldInfoPtr_AugmentationTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "AugmentationTable");
		NativeFieldInfoPtr_GameclassTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "GameclassTable");
		NativeFieldInfoPtr_AnimSequenceTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "AnimSequenceTable");
		NativeFieldInfoPtr_AccessoryTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "AccessoryTable");
		NativeFieldInfoPtr_ItemTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "ItemTable");
		NativeFieldInfoPtr_MacroIconTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "MacroIconTable");
		NativeFieldInfoPtr_MobSkillAnimGrpTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "MobSkillAnimGrpTable");
		NativeFieldInfoPtr_MusicTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "MusicTable");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTables>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DataTables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTables>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_LoadTables_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTables>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTables>.NativeClassPtr, 100663694);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4732, RefRangeEnd = 4734, XrefRangeStart = 4632, XrefRangeEnd = 4732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadTables(string langCode = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(langCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTables_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4842, RefRangeEnd = 4843, XrefRangeStart = 4734, XrefRangeEnd = 4842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataTables()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTables>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DataTables(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
