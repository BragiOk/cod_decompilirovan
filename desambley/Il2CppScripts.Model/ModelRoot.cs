using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Model;

public class ModelRoot : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LobbyModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_MagicEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortCuts;

	private static readonly System.IntPtr NativeFieldInfoPtr_Chat;

	private static readonly System.IntPtr NativeFieldInfoPtr_Skills;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartyModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_PledgeModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_MacroModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_HennaModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillCooldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemCooldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_MacroCooldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinimapModel;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe LobbyModel LobbyModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LobbyModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lobbyModel));
		}
	}

	public unsafe Inventory Inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory));
		}
	}

	public unsafe MagicEffects MagicEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MagicEffects>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)magicEffects));
		}
	}

	public unsafe ShortCuts ShortCuts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortCuts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortCuts>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortCuts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortCuts));
		}
	}

	public unsafe ChatModel Chat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatModel));
		}
	}

	public unsafe SkillModel Skills
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Skills);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Skills)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillModel));
		}
	}

	public unsafe PartyModel PartyModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartyModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PartyModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartyModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)partyModel));
		}
	}

	public unsafe PetModel PetModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PetModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petModel));
		}
	}

	public unsafe PledgeModel PledgeModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PledgeModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pledgeModel));
		}
	}

	public unsafe MacroModel MacroModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacroModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroModel));
		}
	}

	public unsafe HennaModel HennaModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HennaModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HennaModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HennaModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hennaModel));
		}
	}

	public unsafe CooldownModel SkillCooldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillCooldown);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CooldownModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillCooldown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cooldownModel));
		}
	}

	public unsafe CooldownModel ItemCooldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemCooldown);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CooldownModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemCooldown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cooldownModel));
		}
	}

	public unsafe CooldownModel MacroCooldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroCooldown);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CooldownModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MacroCooldown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cooldownModel));
		}
	}

	public unsafe ToggleModel SkillToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillToggle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ToggleModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillToggle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggleModel));
		}
	}

	public unsafe MinimapModel MinimapModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimapModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MinimapModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimapModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)minimapModel));
		}
	}

	static ModelRoot()
	{
		Il2CppClassPointerStore<ModelRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Model", "ModelRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr);
		NativeFieldInfoPtr_LobbyModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "LobbyModel");
		NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "Inventory");
		NativeFieldInfoPtr_MagicEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "MagicEffects");
		NativeFieldInfoPtr_ShortCuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "ShortCuts");
		NativeFieldInfoPtr_Chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "Chat");
		NativeFieldInfoPtr_Skills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "Skills");
		NativeFieldInfoPtr_PartyModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "PartyModel");
		NativeFieldInfoPtr_PetModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "PetModel");
		NativeFieldInfoPtr_PledgeModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "PledgeModel");
		NativeFieldInfoPtr_MacroModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "MacroModel");
		NativeFieldInfoPtr_HennaModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "HennaModel");
		NativeFieldInfoPtr_SkillCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "SkillCooldown");
		NativeFieldInfoPtr_ItemCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "ItemCooldown");
		NativeFieldInfoPtr_MacroCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "MacroCooldown");
		NativeFieldInfoPtr_SkillToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "SkillToggle");
		NativeFieldInfoPtr_MinimapModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, "MinimapModel");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, 100668279);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr, 100668280);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49680, RefRangeEnd = 49681, XrefRangeStart = 49642, XrefRangeEnd = 49680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49790, RefRangeEnd = 49791, XrefRangeStart = 49681, XrefRangeEnd = 49790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelRoot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModelRoot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
