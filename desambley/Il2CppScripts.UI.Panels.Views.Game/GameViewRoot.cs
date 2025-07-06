using System;
using System.Runtime.CompilerServices;
using Il2CppGameTypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Panels.Views.Game.Augment;
using Il2CppScripts.UI.Panels.Views.Game.BottomMenu;
using Il2CppScripts.UI.Panels.Views.Game.Chat;
using Il2CppScripts.UI.Panels.Views.Game.CommunityBoard;
using Il2CppScripts.UI.Panels.Views.Game.DeathMenu;
using Il2CppScripts.UI.Panels.Views.Game.Exchange;
using Il2CppScripts.UI.Panels.Views.Game.GloryDisplay;
using Il2CppScripts.UI.Panels.Views.Game.Henna;
using Il2CppScripts.UI.Panels.Views.Game.HeroList;
using Il2CppScripts.UI.Panels.Views.Game.Inventory;
using Il2CppScripts.UI.Panels.Views.Game.ItemEnchant;
using Il2CppScripts.UI.Panels.Views.Game.Macro;
using Il2CppScripts.UI.Panels.Views.Game.MagicEffect;
using Il2CppScripts.UI.Panels.Views.Game.Mail;
using Il2CppScripts.UI.Panels.Views.Game.Multisell;
using Il2CppScripts.UI.Panels.Views.Game.NpcHtmlDialog;
using Il2CppScripts.UI.Panels.Views.Game.OlympSpectate;
using Il2CppScripts.UI.Panels.Views.Game.OlympView;
using Il2CppScripts.UI.Panels.Views.Game.OptionsMenu;
using Il2CppScripts.UI.Panels.Views.Game.PartyMemberList;
using Il2CppScripts.UI.Panels.Views.Game.PawnViewer;
using Il2CppScripts.UI.Panels.Views.Game.PetInterface;
using Il2CppScripts.UI.Panels.Views.Game.PetStatus;
using Il2CppScripts.UI.Panels.Views.Game.PrivateManufacture;
using Il2CppScripts.UI.Panels.Views.Game.PrivateStore;
using Il2CppScripts.UI.Panels.Views.Game.RecipeBook;
using Il2CppScripts.UI.Panels.Views.Game.Shortcuts;
using Il2CppScripts.UI.Panels.Views.Game.ShortcutSettings;
using Il2CppScripts.UI.Panels.Views.Game.SkillEnchant;
using Il2CppScripts.UI.Panels.Views.Game.SystemMenu;
using Il2CppScripts.UI.Panels.Views.Game.TargetStatus;
using Il2CppScripts.UI.Panels.Views.Game.Trading;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.Actions;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.Pledge;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.Quests;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.Skills;
using Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.UserStats;
using Il2CppScripts.UI.Panels.Views.Game.UserStatus;
using Il2CppScripts.UI.Panels.Views.Game.WorldMap;
using Il2CppSystem;
using Il2CppUI.Panels.Views.Game.Deposit;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game;

public class GameViewRoot : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Chat;

	private static readonly System.IntPtr NativeFieldInfoPtr_BottomMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeathMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_UserInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_UserStatsTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillsTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActionsTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_PledgeTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_QuestsTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_UserStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_TargetStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcHtmlDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_SystemMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutV;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutH;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_MagicEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_Trading;

	private static readonly System.IntPtr NativeFieldInfoPtr_Multisell;

	private static readonly System.IntPtr NativeFieldInfoPtr_Exchange;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrivateStoreSellPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_RecipeBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrivateManufacture;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartyMemberList;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_PetInterface;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemEnchant;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillEnchant;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillAcquire;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClanSkillAcquire;

	private static readonly System.IntPtr NativeFieldInfoPtr_Augment;

	private static readonly System.IntPtr NativeFieldInfoPtr_GloryDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommunityBoard;

	private static readonly System.IntPtr NativeFieldInfoPtr_Henna;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptionsMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_OlympSpectate;

	private static readonly System.IntPtr NativeFieldInfoPtr_OlympView;

	private static readonly System.IntPtr NativeFieldInfoPtr_Warehouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_Macro;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeroList;

	private static readonly System.IntPtr NativeFieldInfoPtr_MailNotification;

	private static readonly System.IntPtr NativeFieldInfoPtr_PawnViewer;

	private static readonly System.IntPtr NativeFieldInfoPtr__interfaceToggleState;

	private static readonly System.IntPtr NativeFieldInfoPtr__overlayToggleState;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveShortcutPanel_Public_ShortcutPanel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleUI_Private_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowOptionsCmd_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleBoard_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleQuests_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleModeratorCmd_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleInterfaceCommand_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleOverlayCommand_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CmdSelectRowPage_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCommand_Private_Void_String_Action_1_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterHotkeyPreset_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterCommand_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterHotkeyPreset_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterShortcutCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterShortcutCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_0_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_1_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_2_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_3_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_4_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_5_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_6_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_7_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_8_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_9_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_10_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCommands_b__62_11_Private_Void_Il2CppStringArray_0;

	public unsafe ChatPanel Chat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Chat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatPanel));
		}
	}

	public unsafe BottomMenuPanel BottomMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BottomMenuPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomMenuPanel));
		}
	}

	public unsafe DeathMenuPanel DeathMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeathMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeathMenuPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeathMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deathMenuPanel));
		}
	}

	public unsafe UserInfoPanel UserInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserInfoPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userInfoPanel));
		}
	}

	public unsafe UserStatsPanel UserStatsTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserStatsTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserStatsPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserStatsTab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userStatsPanel));
		}
	}

	public unsafe SkillListPanel SkillsTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillsTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillListPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillsTab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillListPanel));
		}
	}

	public unsafe ActionsPanel ActionsTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionsTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionsPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionsTab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionsPanel));
		}
	}

	public unsafe PledgePanel PledgeTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PledgePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PledgeTab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pledgePanel));
		}
	}

	public unsafe QuestsPanel QuestsTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestsTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuestsPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QuestsTab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)questsPanel));
		}
	}

	public unsafe InventoryPanel Inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryPanel));
		}
	}

	public unsafe UserStatusPanel UserStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserStats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserStatusPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UserStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userStatusPanel));
		}
	}

	public unsafe TargetStatusPanel TargetStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TargetStatusPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetStatusPanel));
		}
	}

	public unsafe NpcHtmlDialogPanel NpcHtmlDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcHtmlDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcHtmlDialogPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcHtmlDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcHtmlDialogPanel));
		}
	}

	public unsafe SystemMenuPanel SystemMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemMenuPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)systemMenuPanel));
		}
	}

	public unsafe ShortcutPanel ShortcutV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutV);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutPanel));
		}
	}

	public unsafe ShortcutPanel ShortcutH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutH);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutH)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutPanel));
		}
	}

	public unsafe ShortcutSettingsPanel ShortcutSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutSettingsPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutSettingsPanel));
		}
	}

	public unsafe MagicEffectPanel MagicEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicEffect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MagicEffectPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MagicEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)magicEffectPanel));
		}
	}

	public unsafe WorldMapPanel WorldMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldMapPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorldMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldMapPanel));
		}
	}

	public unsafe TradingPanel Trading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trading);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TradingPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trading)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tradingPanel));
		}
	}

	public unsafe MultisellPanel Multisell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multisell);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MultisellPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Multisell)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)multisellPanel));
		}
	}

	public unsafe ExchangePanel Exchange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Exchange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExchangePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Exchange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exchangePanel));
		}
	}

	public unsafe PrivateStorePanel PrivateStoreSellPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreSellPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PrivateStorePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateStoreSellPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)privateStorePanel));
		}
	}

	public unsafe RecipeBookPanel RecipeBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RecipeBook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RecipeBookPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RecipeBook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipeBookPanel));
		}
	}

	public unsafe PrivateManufacturePanel PrivateManufacture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateManufacture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PrivateManufacturePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrivateManufacture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)privateManufacturePanel));
		}
	}

	public unsafe PartyMemberListPanel PartyMemberList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartyMemberList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PartyMemberListPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartyMemberList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)partyMemberListPanel));
		}
	}

	public unsafe PetStatusPanel PetStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PetStatusPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petStatusPanel));
		}
	}

	public unsafe PetInterfacePanel PetInterface
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetInterface);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PetInterfacePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PetInterface)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petInterfacePanel));
		}
	}

	public unsafe ItemEnchantPanel ItemEnchant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemEnchant);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemEnchantPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemEnchant)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEnchantPanel));
		}
	}

	public unsafe SkillEnchantPanel SkillEnchant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillEnchant);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillEnchantPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillEnchant)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillEnchantPanel));
		}
	}

	public unsafe SkillEnchantPanel SkillAcquire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillAcquire);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillEnchantPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillAcquire)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillEnchantPanel));
		}
	}

	public unsafe SkillEnchantPanel ClanSkillAcquire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanSkillAcquire);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillEnchantPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClanSkillAcquire)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillEnchantPanel));
		}
	}

	public unsafe AugmentPanel Augment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Augment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AugmentPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Augment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)augmentPanel));
		}
	}

	public unsafe GloryDisplayPanel GloryDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GloryDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GloryDisplayPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GloryDisplay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gloryDisplayPanel));
		}
	}

	public unsafe CommunityBoardPanel CommunityBoard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommunityBoard);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommunityBoardPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommunityBoard)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)communityBoardPanel));
		}
	}

	public unsafe HennaPanel Henna
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Henna);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HennaPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Henna)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hennaPanel));
		}
	}

	public unsafe OptionsMenuPanel OptionsMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptionsMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptionsMenuPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptionsMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optionsMenuPanel));
		}
	}

	public unsafe OlympSpectatePanel OlympSpectate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OlympSpectate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OlympSpectatePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OlympSpectate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympSpectatePanel));
		}
	}

	public unsafe OlympViewPanel OlympView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OlympView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OlympViewPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OlympView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympViewPanel));
		}
	}

	public unsafe WarehousePanel Warehouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warehouse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WarehousePanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warehouse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)warehousePanel));
		}
	}

	public unsafe MacroPanel Macro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Macro);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacroPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Macro)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroPanel));
		}
	}

	public unsafe HeroListPanel HeroList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeroListPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeroList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)heroListPanel));
		}
	}

	public unsafe MailNotification MailNotification
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MailNotification);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MailNotification>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MailNotification)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mailNotification));
		}
	}

	public unsafe PawnViewerPanel PawnViewer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PawnViewer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PawnViewerPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PawnViewer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pawnViewerPanel));
		}
	}

	public unsafe bool _interfaceToggleState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interfaceToggleState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interfaceToggleState)) = flag;
		}
	}

	public unsafe bool _overlayToggleState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overlayToggleState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__overlayToggleState)) = flag;
		}
	}

	static GameViewRoot()
	{
		Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game", "GameViewRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr);
		NativeFieldInfoPtr_Chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Chat");
		NativeFieldInfoPtr_BottomMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "BottomMenu");
		NativeFieldInfoPtr_DeathMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "DeathMenu");
		NativeFieldInfoPtr_UserInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "UserInfo");
		NativeFieldInfoPtr_UserStatsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "UserStatsTab");
		NativeFieldInfoPtr_SkillsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "SkillsTab");
		NativeFieldInfoPtr_ActionsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ActionsTab");
		NativeFieldInfoPtr_PledgeTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PledgeTab");
		NativeFieldInfoPtr_QuestsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "QuestsTab");
		NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Inventory");
		NativeFieldInfoPtr_UserStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "UserStats");
		NativeFieldInfoPtr_TargetStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "TargetStatus");
		NativeFieldInfoPtr_NpcHtmlDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "NpcHtmlDialog");
		NativeFieldInfoPtr_SystemMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "SystemMenu");
		NativeFieldInfoPtr_ShortcutV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ShortcutV");
		NativeFieldInfoPtr_ShortcutH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ShortcutH");
		NativeFieldInfoPtr_ShortcutSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ShortcutSettings");
		NativeFieldInfoPtr_MagicEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "MagicEffect");
		NativeFieldInfoPtr_WorldMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "WorldMap");
		NativeFieldInfoPtr_Trading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Trading");
		NativeFieldInfoPtr_Multisell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Multisell");
		NativeFieldInfoPtr_Exchange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Exchange");
		NativeFieldInfoPtr_PrivateStoreSellPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PrivateStoreSellPanel");
		NativeFieldInfoPtr_RecipeBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "RecipeBook");
		NativeFieldInfoPtr_PrivateManufacture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PrivateManufacture");
		NativeFieldInfoPtr_PartyMemberList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PartyMemberList");
		NativeFieldInfoPtr_PetStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PetStatus");
		NativeFieldInfoPtr_PetInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PetInterface");
		NativeFieldInfoPtr_ItemEnchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ItemEnchant");
		NativeFieldInfoPtr_SkillEnchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "SkillEnchant");
		NativeFieldInfoPtr_SkillAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "SkillAcquire");
		NativeFieldInfoPtr_ClanSkillAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "ClanSkillAcquire");
		NativeFieldInfoPtr_Augment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Augment");
		NativeFieldInfoPtr_GloryDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "GloryDisplay");
		NativeFieldInfoPtr_CommunityBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "CommunityBoard");
		NativeFieldInfoPtr_Henna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Henna");
		NativeFieldInfoPtr_OptionsMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "OptionsMenu");
		NativeFieldInfoPtr_OlympSpectate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "OlympSpectate");
		NativeFieldInfoPtr_OlympView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "OlympView");
		NativeFieldInfoPtr_Warehouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Warehouse");
		NativeFieldInfoPtr_Macro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "Macro");
		NativeFieldInfoPtr_HeroList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "HeroList");
		NativeFieldInfoPtr_MailNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "MailNotification");
		NativeFieldInfoPtr_PawnViewer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "PawnViewer");
		NativeFieldInfoPtr__interfaceToggleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "_interfaceToggleState");
		NativeFieldInfoPtr__overlayToggleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, "_overlayToggleState");
		NativeMethodInfoPtr_GetActiveShortcutPanel_Public_ShortcutPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667059);
		NativeMethodInfoPtr_ToggleUI_Private_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667060);
		NativeMethodInfoPtr_ShowOptionsCmd_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667061);
		NativeMethodInfoPtr_ToggleBoard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667062);
		NativeMethodInfoPtr_ToggleQuests_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667063);
		NativeMethodInfoPtr_ToggleModeratorCmd_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667064);
		NativeMethodInfoPtr_ToggleInterfaceCommand_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667065);
		NativeMethodInfoPtr_ToggleOverlayCommand_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667066);
		NativeMethodInfoPtr_CmdSelectRowPage_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667067);
		NativeMethodInfoPtr_RegisterCommand_Private_Void_String_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667068);
		NativeMethodInfoPtr_RegisterHotkeyPreset_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667069);
		NativeMethodInfoPtr_UnregisterCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667070);
		NativeMethodInfoPtr_UnregisterHotkeyPreset_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667071);
		NativeMethodInfoPtr_RegisterShortcutCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667072);
		NativeMethodInfoPtr_UnregisterShortcutCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667073);
		NativeMethodInfoPtr_RegisterCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_UnregisterCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr__RegisterCommands_b__62_0_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr__RegisterCommands_b__62_1_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr__RegisterCommands_b__62_2_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr__RegisterCommands_b__62_3_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr__RegisterCommands_b__62_4_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr__RegisterCommands_b__62_5_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr__RegisterCommands_b__62_6_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr__RegisterCommands_b__62_7_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr__RegisterCommands_b__62_8_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667088);
		NativeMethodInfoPtr__RegisterCommands_b__62_9_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667089);
		NativeMethodInfoPtr__RegisterCommands_b__62_10_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667090);
		NativeMethodInfoPtr__RegisterCommands_b__62_11_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr, 100667091);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 36993, RefRangeEnd = 36995, XrefRangeStart = 36991, XrefRangeEnd = 36993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShortcutPanel GetActiveShortcutPanel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveShortcutPanel_Public_ShortcutPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutPanel>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 37046, RefRangeEnd = 37048, XrefRangeStart = 36995, XrefRangeEnd = 37046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOlympiadMode(OlympiadMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOlympiadMode_Public_Void_OlympiadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 37061, RefRangeEnd = 37070, XrefRangeStart = 37048, XrefRangeEnd = 37061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleUI(GameObject gameObject, string sound = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sound);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleUI_Private_Void_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37070, XrefRangeEnd = 37077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowOptionsCmd(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowOptionsCmd_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37101, RefRangeEnd = 37102, XrefRangeStart = 37077, XrefRangeEnd = 37101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleBoard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleBoard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37128, RefRangeEnd = 37129, XrefRangeStart = 37102, XrefRangeEnd = 37128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleQuests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleQuests_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37129, XrefRangeEnd = 37155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleModeratorCmd(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleModeratorCmd_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37155, XrefRangeEnd = 37164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleInterfaceCommand(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleInterfaceCommand_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37164, XrefRangeEnd = 37171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleOverlayCommand(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleOverlayCommand_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37171, XrefRangeEnd = 37186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CmdSelectRowPage(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CmdSelectRowPage_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 37196, RefRangeEnd = 37213, XrefRangeStart = 37186, XrefRangeEnd = 37196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCommand(string command, Il2CppSystem.Action<Il2CppStringArray> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCommand_Private_Void_String_Action_1_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 37221, RefRangeEnd = 37223, XrefRangeStart = 37213, XrefRangeEnd = 37221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterHotkeyPreset(string command, string hotkeyName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hotkeyName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterHotkeyPreset_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 37230, RefRangeEnd = 37246, XrefRangeStart = 37223, XrefRangeEnd = 37230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterCommand(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37246, XrefRangeEnd = 37250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterHotkeyPreset(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterHotkeyPreset_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37282, RefRangeEnd = 37283, XrefRangeStart = 37250, XrefRangeEnd = 37282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterShortcutCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterShortcutCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37302, RefRangeEnd = 37303, XrefRangeStart = 37283, XrefRangeEnd = 37302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterShortcutCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterShortcutCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37445, RefRangeEnd = 37446, XrefRangeStart = 37303, XrefRangeEnd = 37445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37495, RefRangeEnd = 37496, XrefRangeStart = 37446, XrefRangeEnd = 37495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37496, XrefRangeEnd = 37513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37514, XrefRangeEnd = 37515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameViewRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameViewRoot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37515, XrefRangeEnd = 37521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_0(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_0_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37521, XrefRangeEnd = 37522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_1(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_1_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37522, XrefRangeEnd = 37528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_2(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_2_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37528, XrefRangeEnd = 37534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_3(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_3_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37534, XrefRangeEnd = 37540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_4(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_4_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37540, XrefRangeEnd = 37546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_5(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_5_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37546, XrefRangeEnd = 37552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_6(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_6_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37552, XrefRangeEnd = 37553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_7(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_7_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37553, XrefRangeEnd = 37559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_8(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_8_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37559, XrefRangeEnd = 37565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_9(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_9_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37565, XrefRangeEnd = 37571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_10(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_10_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37571, XrefRangeEnd = 37580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterCommands_b__62_11(Il2CppStringArray _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterCommands_b__62_11_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameViewRoot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
