using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Movement;
using Il2CppScripts.Services;
using Il2CppServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScripts.GameSystem;

public class ServiceRoot : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__InputManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__KeyboardInput_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__KnownList_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ItemList_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConnectManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CommandManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__WorldStreamer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__UserController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TeleportationController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OfflineManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PointerController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OverheadPanelController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TimeOfDayManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MovementServer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MemoryOptimizer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConfigurationController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MacrosManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OptimizationController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AudioCountLimiter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MusicManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OlympiadManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RadarControlManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ScreenController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RemoteLogService_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MacroCooldownUpdateService_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyboardInput_Public_get_KeyboardInputController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KnownList_Public_get_KnownList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemList_Public_get_ItemEntityList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectManager_Public_get_ConnectManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CommandManager_Public_get_CommandManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldStreamer_Public_get_WorldStreamer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserController_Public_get_UserController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TeleportationController_Public_get_TeleportationController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OfflineManager_Public_get_OfflineManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PointerController_Public_get_PointerController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OverheadPanelController_Public_get_OverheadPanelController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeOfDayManager_Public_get_TimeOfDayManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MovementServer_Public_get_MovementServer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MemoryOptimizer_Public_get_MemoryOptimizer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurationController_Public_get_ConfigurationController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MacrosManager_Public_get_MacrosManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OptimizationController_Public_get_OptimizationController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioCountLimiter_Public_get_AudioCountLimiter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MusicManager_Public_get_MusicManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OlympiadManager_Public_get_OlympiadManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RadarControlManager_Public_get_RadarControlManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScreenController_Public_get_ScreenController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteLogService_Public_get_RemoteLogService_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MacroCooldownUpdateService_Public_get_MacroCooldownUpdateService_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__75_0_Private_Object_FieldInfo_0;

	public unsafe InputManager _InputManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputManager));
		}
	}

	public unsafe KeyboardInputController _KeyboardInput_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KeyboardInput_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyboardInputController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KeyboardInput_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyboardInputController));
		}
	}

	public unsafe KnownList _KnownList_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KnownList_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KnownList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KnownList_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)knownList));
		}
	}

	public unsafe ItemEntityList _ItemList_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemList_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemEntityList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ItemList_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntityList));
		}
	}

	public unsafe ConnectManager _ConnectManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConnectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)connectManager));
		}
	}

	public unsafe CommandManager _CommandManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CommandManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CommandManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandManager));
		}
	}

	public unsafe WorldStreamer _WorldStreamer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WorldStreamer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldStreamer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WorldStreamer_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldStreamer));
		}
	}

	public unsafe UserController _UserController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UserController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UserController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userController));
		}
	}

	public unsafe TeleportationController _TeleportationController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TeleportationController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TeleportationController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TeleportationController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)teleportationController));
		}
	}

	public unsafe OfflineManager _OfflineManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OfflineManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OfflineManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OfflineManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)offlineManager));
		}
	}

	public unsafe PointerController _PointerController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PointerController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointerController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PointerController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerController));
		}
	}

	public unsafe OverheadPanelController _OverheadPanelController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OverheadPanelController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OverheadPanelController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OverheadPanelController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overheadPanelController));
		}
	}

	public unsafe TimeOfDayManager _TimeOfDayManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeOfDayManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeOfDayManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeOfDayManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeOfDayManager));
		}
	}

	public unsafe MovementServer _MovementServer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MovementServer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MovementServer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MovementServer_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)movementServer));
		}
	}

	public unsafe MemoryOptimizer _MemoryOptimizer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MemoryOptimizer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemoryOptimizer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MemoryOptimizer_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)memoryOptimizer));
		}
	}

	public unsafe ConfigurationController _ConfigurationController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConfigurationController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurationController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConfigurationController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configurationController));
		}
	}

	public unsafe MacrosManager _MacrosManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MacrosManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacrosManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MacrosManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosManager));
		}
	}

	public unsafe OptimizationController _OptimizationController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptimizationController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptimizationController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OptimizationController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)optimizationController));
		}
	}

	public unsafe AudioCountLimiter _AudioCountLimiter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AudioCountLimiter_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioCountLimiter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AudioCountLimiter_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioCountLimiter));
		}
	}

	public unsafe MusicManager _MusicManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MusicManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MusicManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MusicManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)musicManager));
		}
	}

	public unsafe OlympiadManager _OlympiadManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OlympiadManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OlympiadManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OlympiadManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)olympiadManager));
		}
	}

	public unsafe RadarControlManager _RadarControlManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RadarControlManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RadarControlManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RadarControlManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radarControlManager));
		}
	}

	public unsafe ScreenController _ScreenController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenController_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenController));
		}
	}

	public unsafe RemoteLogService _RemoteLogService_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RemoteLogService_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RemoteLogService>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RemoteLogService_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remoteLogService));
		}
	}

	public unsafe MacroCooldownUpdateService _MacroCooldownUpdateService_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MacroCooldownUpdateService_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacroCooldownUpdateService>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MacroCooldownUpdateService_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroCooldownUpdateService));
		}
	}

	public unsafe InputManager InputManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 4286, RefRangeEnd = 4287, XrefRangeStart = 4286, XrefRangeEnd = 4287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr) : null;
		}
	}

	public unsafe KeyboardInputController KeyboardInput
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656, RefRangeEnd = 658, XrefRangeStart = 656, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KeyboardInput_Public_get_KeyboardInputController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyboardInputController>(intPtr) : null;
		}
	}

	public unsafe KnownList KnownList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KnownList_Public_get_KnownList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KnownList>(intPtr) : null;
		}
	}

	public unsafe ItemEntityList ItemList
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemList_Public_get_ItemEntityList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemEntityList>(intPtr) : null;
		}
	}

	public unsafe ConnectManager ConnectManager
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConnectManager_Public_get_ConnectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConnectManager>(intPtr) : null;
		}
	}

	public unsafe CommandManager CommandManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11442, RefRangeEnd = 11443, XrefRangeStart = 11442, XrefRangeEnd = 11443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CommandManager_Public_get_CommandManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandManager>(intPtr) : null;
		}
	}

	public unsafe WorldStreamer WorldStreamer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24608, RefRangeEnd = 24609, XrefRangeStart = 24608, XrefRangeEnd = 24609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WorldStreamer_Public_get_WorldStreamer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldStreamer>(intPtr) : null;
		}
	}

	public unsafe UserController UserController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserController_Public_get_UserController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserController>(intPtr) : null;
		}
	}

	public unsafe TeleportationController TeleportationController
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29414, RefRangeEnd = 29415, XrefRangeStart = 29414, XrefRangeEnd = 29415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TeleportationController_Public_get_TeleportationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TeleportationController>(intPtr) : null;
		}
	}

	public unsafe OfflineManager OfflineManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OfflineManager_Public_get_OfflineManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OfflineManager>(intPtr) : null;
		}
	}

	public unsafe PointerController PointerController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PointerController_Public_get_PointerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointerController>(intPtr) : null;
		}
	}

	public unsafe OverheadPanelController OverheadPanelController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OverheadPanelController_Public_get_OverheadPanelController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OverheadPanelController>(intPtr) : null;
		}
	}

	public unsafe TimeOfDayManager TimeOfDayManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeOfDayManager_Public_get_TimeOfDayManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeOfDayManager>(intPtr) : null;
		}
	}

	public unsafe MovementServer MovementServer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MovementServer_Public_get_MovementServer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MovementServer>(intPtr) : null;
		}
	}

	public unsafe MemoryOptimizer MemoryOptimizer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MemoryOptimizer_Public_get_MemoryOptimizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemoryOptimizer>(intPtr) : null;
		}
	}

	public unsafe ConfigurationController ConfigurationController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConfigurationController_Public_get_ConfigurationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigurationController>(intPtr) : null;
		}
	}

	public unsafe MacrosManager MacrosManager
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35447, RefRangeEnd = 35452, XrefRangeStart = 35447, XrefRangeEnd = 35452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MacrosManager_Public_get_MacrosManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacrosManager>(intPtr) : null;
		}
	}

	public unsafe OptimizationController OptimizationController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OptimizationController_Public_get_OptimizationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptimizationController>(intPtr) : null;
		}
	}

	public unsafe AudioCountLimiter AudioCountLimiter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AudioCountLimiter_Public_get_AudioCountLimiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioCountLimiter>(intPtr) : null;
		}
	}

	public unsafe MusicManager MusicManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MusicManager_Public_get_MusicManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MusicManager>(intPtr) : null;
		}
	}

	public unsafe OlympiadManager OlympiadManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OlympiadManager_Public_get_OlympiadManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OlympiadManager>(intPtr) : null;
		}
	}

	public unsafe RadarControlManager RadarControlManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RadarControlManager_Public_get_RadarControlManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RadarControlManager>(intPtr) : null;
		}
	}

	public unsafe ScreenController ScreenController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScreenController_Public_get_ScreenController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenController>(intPtr) : null;
		}
	}

	public unsafe RemoteLogService RemoteLogService
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemoteLogService_Public_get_RemoteLogService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RemoteLogService>(intPtr) : null;
		}
	}

	public unsafe MacroCooldownUpdateService MacroCooldownUpdateService
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MacroCooldownUpdateService_Public_get_MacroCooldownUpdateService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MacroCooldownUpdateService>(intPtr) : null;
		}
	}

	static ServiceRoot()
	{
		Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameSystem", "ServiceRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr);
		NativeFieldInfoPtr__InputManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<InputManager>k__BackingField");
		NativeFieldInfoPtr__KeyboardInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<KeyboardInput>k__BackingField");
		NativeFieldInfoPtr__KnownList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<KnownList>k__BackingField");
		NativeFieldInfoPtr__ItemList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<ItemList>k__BackingField");
		NativeFieldInfoPtr__ConnectManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<ConnectManager>k__BackingField");
		NativeFieldInfoPtr__CommandManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<CommandManager>k__BackingField");
		NativeFieldInfoPtr__WorldStreamer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<WorldStreamer>k__BackingField");
		NativeFieldInfoPtr__UserController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<UserController>k__BackingField");
		NativeFieldInfoPtr__TeleportationController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<TeleportationController>k__BackingField");
		NativeFieldInfoPtr__OfflineManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<OfflineManager>k__BackingField");
		NativeFieldInfoPtr__PointerController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<PointerController>k__BackingField");
		NativeFieldInfoPtr__OverheadPanelController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<OverheadPanelController>k__BackingField");
		NativeFieldInfoPtr__TimeOfDayManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<TimeOfDayManager>k__BackingField");
		NativeFieldInfoPtr__MovementServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<MovementServer>k__BackingField");
		NativeFieldInfoPtr__MemoryOptimizer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<MemoryOptimizer>k__BackingField");
		NativeFieldInfoPtr__ConfigurationController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<ConfigurationController>k__BackingField");
		NativeFieldInfoPtr__MacrosManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<MacrosManager>k__BackingField");
		NativeFieldInfoPtr__OptimizationController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<OptimizationController>k__BackingField");
		NativeFieldInfoPtr__AudioCountLimiter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<AudioCountLimiter>k__BackingField");
		NativeFieldInfoPtr__MusicManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<MusicManager>k__BackingField");
		NativeFieldInfoPtr__OlympiadManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<OlympiadManager>k__BackingField");
		NativeFieldInfoPtr__RadarControlManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<RadarControlManager>k__BackingField");
		NativeFieldInfoPtr__ScreenController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<ScreenController>k__BackingField");
		NativeFieldInfoPtr__RemoteLogService_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<RemoteLogService>k__BackingField");
		NativeFieldInfoPtr__MacroCooldownUpdateService_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, "<MacroCooldownUpdateService>k__BackingField");
		NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668548);
		NativeMethodInfoPtr_get_KeyboardInput_Public_get_KeyboardInputController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668549);
		NativeMethodInfoPtr_get_KnownList_Public_get_KnownList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668550);
		NativeMethodInfoPtr_get_ItemList_Public_get_ItemEntityList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668551);
		NativeMethodInfoPtr_get_ConnectManager_Public_get_ConnectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668552);
		NativeMethodInfoPtr_get_CommandManager_Public_get_CommandManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668553);
		NativeMethodInfoPtr_get_WorldStreamer_Public_get_WorldStreamer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668554);
		NativeMethodInfoPtr_get_UserController_Public_get_UserController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668555);
		NativeMethodInfoPtr_get_TeleportationController_Public_get_TeleportationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668556);
		NativeMethodInfoPtr_get_OfflineManager_Public_get_OfflineManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668557);
		NativeMethodInfoPtr_get_PointerController_Public_get_PointerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668558);
		NativeMethodInfoPtr_get_OverheadPanelController_Public_get_OverheadPanelController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668559);
		NativeMethodInfoPtr_get_TimeOfDayManager_Public_get_TimeOfDayManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668560);
		NativeMethodInfoPtr_get_MovementServer_Public_get_MovementServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668561);
		NativeMethodInfoPtr_get_MemoryOptimizer_Public_get_MemoryOptimizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668562);
		NativeMethodInfoPtr_get_ConfigurationController_Public_get_ConfigurationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668563);
		NativeMethodInfoPtr_get_MacrosManager_Public_get_MacrosManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668564);
		NativeMethodInfoPtr_get_OptimizationController_Public_get_OptimizationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668565);
		NativeMethodInfoPtr_get_AudioCountLimiter_Public_get_AudioCountLimiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668566);
		NativeMethodInfoPtr_get_MusicManager_Public_get_MusicManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668567);
		NativeMethodInfoPtr_get_OlympiadManager_Public_get_OlympiadManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668568);
		NativeMethodInfoPtr_get_RadarControlManager_Public_get_RadarControlManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668569);
		NativeMethodInfoPtr_get_ScreenController_Public_get_ScreenController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668570);
		NativeMethodInfoPtr_get_RemoteLogService_Public_get_RemoteLogService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668571);
		NativeMethodInfoPtr_get_MacroCooldownUpdateService_Public_get_MacroCooldownUpdateService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668572);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668573);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668574);
		NativeMethodInfoPtr__Initialize_b__75_0_Private_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr, 100668575);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51613, RefRangeEnd = 51614, XrefRangeStart = 51591, XrefRangeEnd = 51613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51723, RefRangeEnd = 51724, XrefRangeStart = 51614, XrefRangeEnd = 51723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServiceRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceRoot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51724, XrefRangeEnd = 51725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object _Initialize_b__75_0(FieldInfo field)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__75_0_Private_Object_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public ServiceRoot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
