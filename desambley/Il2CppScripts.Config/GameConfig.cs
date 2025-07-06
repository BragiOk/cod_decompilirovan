using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScripts.Config;

public class GameConfig : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetConfigVariableByName_Public_ConfigVariable_1_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetConfigVariableByName_Public_ConfigVariable_1_T_String_0, Il2CppClassPointerStore<GameConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_OnConfigApply;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnConfigReset;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigName;

	private static readonly System.IntPtr NativeFieldInfoPtr__allVariables;

	private static readonly System.IntPtr NativeFieldInfoPtr_Language;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScreenResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_FullscreenMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_MuteSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_AudioVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_EffectAudioVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIAudioVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_AmbientAudioVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_MusicAudioVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharactersDisplayDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameChatAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameInterfaceAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameInterfaceScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasdMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnterToChat;

	private static readonly System.IntPtr NativeFieldInfoPtr_TeleportFadeScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConservePerformance;

	private static readonly System.IntPtr NativeFieldInfoPtr_CapsuleRadiusScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_CapsuleHeightScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZoomSpeedScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_TurnSpeedScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighQualitySkinning;

	private static readonly System.IntPtr NativeFieldInfoPtr_VSync;

	private static readonly System.IntPtr NativeFieldInfoPtr_FpsLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundLoadPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableHBAO;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableDynamicOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_HideOfflineTraders;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableDynamicLighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisplayBrightness;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseSimplifiedAlphaCutout;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadowQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_GrassRenderingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationBudgetLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationFrameRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptimizeSkeleton;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseLOD1;

	private static readonly System.IntPtr NativeFieldInfoPtr_TitleDisplayDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_EffectTimeBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChatSayTypesAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChatSayTypesTrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChatSayTypesParty;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChatSayTypesClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChatSayTypesAlliance;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnConfigApply_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnConfigApply_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnConfigReset_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnConfigReset_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefaultResolution_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigVariableByName_Public_ConfigVariable_1_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasModifiedValues_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDefault_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyChanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetChanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__8_0_Private_Object_FieldInfo_0;

	public unsafe Il2CppSystem.Action OnConfigApply
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnConfigApply);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnConfigApply)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action OnConfigReset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnConfigReset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnConfigReset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static string ConfigName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConfigName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConfigName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppReferenceArray<IConfigVariable> _allVariables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allVariables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IConfigVariable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allVariables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe ConfigVariable<string> Language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ScreenResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScreenResolution);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScreenResolution)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<FullScreenMode> FullscreenMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FullscreenMode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<FullScreenMode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FullscreenMode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> MuteSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MuteSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MuteSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> AudioVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> EffectAudioVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectAudioVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectAudioVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> UIAudioVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIAudioVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIAudioVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> AmbientAudioVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmbientAudioVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmbientAudioVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> MusicAudioVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusicAudioVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MusicAudioVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> RenderingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderingDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderingDistance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> CharactersDisplayDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharactersDisplayDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharactersDisplayDistance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> GameChatAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameChatAlpha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameChatAlpha)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> GameInterfaceAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameInterfaceAlpha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameInterfaceAlpha)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> GameInterfaceScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameInterfaceScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameInterfaceScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> WasdMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasdMovement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasdMovement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> EnterToChat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterToChat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterToChat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> TeleportFadeScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TeleportFadeScreen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TeleportFadeScreen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> ConservePerformance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConservePerformance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConservePerformance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> CapsuleRadiusScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleRadiusScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleRadiusScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> CapsuleHeightScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleHeightScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapsuleHeightScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> ZoomSpeedScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZoomSpeedScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZoomSpeedScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> TurnSpeedScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeedScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnSpeedScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> HighQualitySkinning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighQualitySkinning);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighQualitySkinning)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> VSync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VSync);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VSync)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> FpsLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FpsLimit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FpsLimit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> BackgroundLoadPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackgroundLoadPriority);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackgroundLoadPriority)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> EnableShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableShadows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableShadows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> EnableHBAO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableHBAO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableHBAO)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> EnableDynamicOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDynamicOcclusion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDynamicOcclusion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> HideOfflineTraders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOfflineTraders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HideOfflineTraders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> DisableDynamicLighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableDynamicLighting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableDynamicLighting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> DisplayBrightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayBrightness);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisplayBrightness)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> UseSimplifiedAlphaCutout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSimplifiedAlphaCutout);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSimplifiedAlphaCutout)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ShadowQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowQuality);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowQuality)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> TextureQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureQuality);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureQuality)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> GrassRenderingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrassRenderingDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GrassRenderingDistance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> AnimationBudgetLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationBudgetLimit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationBudgetLimit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> AnimationFrameRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationFrameRate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationFrameRate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> OptimizeSkeleton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptimizeSkeleton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptimizeSkeleton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<bool> UseLOD1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseLOD1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseLOD1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<float> TitleDisplayDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleDisplayDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TitleDisplayDistance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> EffectTimeBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectTimeBudget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectTimeBudget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ChatSayTypesAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesAll);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesAll)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ChatSayTypesTrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesTrade);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesTrade)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ChatSayTypesParty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesParty);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesParty)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ChatSayTypesClan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesClan);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesClan)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	public unsafe ConfigVariable<int> ChatSayTypesAlliance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesAlliance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChatSayTypesAlliance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configVariable));
		}
	}

	static GameConfig()
	{
		Il2CppClassPointerStore<GameConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Config", "GameConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConfig>.NativeClassPtr);
		NativeFieldInfoPtr_OnConfigApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "OnConfigApply");
		NativeFieldInfoPtr_OnConfigReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "OnConfigReset");
		NativeFieldInfoPtr_ConfigName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ConfigName");
		NativeFieldInfoPtr__allVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "_allVariables");
		NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "Language");
		NativeFieldInfoPtr_ScreenResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ScreenResolution");
		NativeFieldInfoPtr_FullscreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "FullscreenMode");
		NativeFieldInfoPtr_MuteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "MuteSound");
		NativeFieldInfoPtr_AudioVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "AudioVolume");
		NativeFieldInfoPtr_EffectAudioVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EffectAudioVolume");
		NativeFieldInfoPtr_UIAudioVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "UIAudioVolume");
		NativeFieldInfoPtr_AmbientAudioVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "AmbientAudioVolume");
		NativeFieldInfoPtr_MusicAudioVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "MusicAudioVolume");
		NativeFieldInfoPtr_RenderingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "RenderingDistance");
		NativeFieldInfoPtr_CharactersDisplayDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "CharactersDisplayDistance");
		NativeFieldInfoPtr_GameChatAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "GameChatAlpha");
		NativeFieldInfoPtr_GameInterfaceAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "GameInterfaceAlpha");
		NativeFieldInfoPtr_GameInterfaceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "GameInterfaceScale");
		NativeFieldInfoPtr_WasdMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "WasdMovement");
		NativeFieldInfoPtr_EnterToChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EnterToChat");
		NativeFieldInfoPtr_TeleportFadeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "TeleportFadeScreen");
		NativeFieldInfoPtr_ConservePerformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ConservePerformance");
		NativeFieldInfoPtr_CapsuleRadiusScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "CapsuleRadiusScale");
		NativeFieldInfoPtr_CapsuleHeightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "CapsuleHeightScale");
		NativeFieldInfoPtr_ZoomSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ZoomSpeedScale");
		NativeFieldInfoPtr_TurnSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "TurnSpeedScale");
		NativeFieldInfoPtr_HighQualitySkinning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "HighQualitySkinning");
		NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "VSync");
		NativeFieldInfoPtr_FpsLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "FpsLimit");
		NativeFieldInfoPtr_BackgroundLoadPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "BackgroundLoadPriority");
		NativeFieldInfoPtr_EnableShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EnableShadows");
		NativeFieldInfoPtr_EnableHBAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EnableHBAO");
		NativeFieldInfoPtr_EnableDynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EnableDynamicOcclusion");
		NativeFieldInfoPtr_HideOfflineTraders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "HideOfflineTraders");
		NativeFieldInfoPtr_DisableDynamicLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "DisableDynamicLighting");
		NativeFieldInfoPtr_DisplayBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "DisplayBrightness");
		NativeFieldInfoPtr_UseSimplifiedAlphaCutout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "UseSimplifiedAlphaCutout");
		NativeFieldInfoPtr_ShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ShadowQuality");
		NativeFieldInfoPtr_TextureQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "TextureQuality");
		NativeFieldInfoPtr_GrassRenderingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "GrassRenderingDistance");
		NativeFieldInfoPtr_AnimationBudgetLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "AnimationBudgetLimit");
		NativeFieldInfoPtr_AnimationFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "AnimationFrameRate");
		NativeFieldInfoPtr_OptimizeSkeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "OptimizeSkeleton");
		NativeFieldInfoPtr_UseLOD1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "UseLOD1");
		NativeFieldInfoPtr_TitleDisplayDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "TitleDisplayDistance");
		NativeFieldInfoPtr_EffectTimeBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "EffectTimeBudget");
		NativeFieldInfoPtr_ChatSayTypesAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ChatSayTypesAll");
		NativeFieldInfoPtr_ChatSayTypesTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ChatSayTypesTrade");
		NativeFieldInfoPtr_ChatSayTypesParty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ChatSayTypesParty");
		NativeFieldInfoPtr_ChatSayTypesClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ChatSayTypesClan");
		NativeFieldInfoPtr_ChatSayTypesAlliance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, "ChatSayTypesAlliance");
		NativeMethodInfoPtr_add_OnConfigApply_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668927);
		NativeMethodInfoPtr_remove_OnConfigApply_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668928);
		NativeMethodInfoPtr_add_OnConfigReset_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668929);
		NativeMethodInfoPtr_remove_OnConfigReset_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668930);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668931);
		NativeMethodInfoPtr_DefaultResolution_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668932);
		NativeMethodInfoPtr_GetConfigVariableByName_Public_ConfigVariable_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668933);
		NativeMethodInfoPtr_HasModifiedValues_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668934);
		NativeMethodInfoPtr_LoadFromFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668935);
		NativeMethodInfoPtr_SaveToFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668936);
		NativeMethodInfoPtr_InitDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668937);
		NativeMethodInfoPtr_ApplyChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668938);
		NativeMethodInfoPtr_ResetChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668939);
		NativeMethodInfoPtr___ctor_b__8_0_Private_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConfig>.NativeClassPtr, 100668940);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55327, XrefRangeEnd = 55330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnConfigApply(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnConfigApply_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55330, XrefRangeEnd = 55333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnConfigApply(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnConfigApply_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55333, XrefRangeEnd = 55336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnConfigReset(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnConfigReset_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55336, XrefRangeEnd = 55339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnConfigReset(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnConfigReset_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55524, RefRangeEnd = 55525, XrefRangeStart = 55339, XrefRangeEnd = 55524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55525, XrefRangeEnd = 55534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DefaultResolution()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefaultResolution_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 55555, RefRangeEnd = 55560, XrefRangeStart = 55534, XrefRangeEnd = 55555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfigVariable<T> GetConfigVariableByName<T>(string proprtyName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(proprtyName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetConfigVariableByName_Public_ConfigVariable_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55560, XrefRangeEnd = 55564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasModifiedValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasModifiedValues_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55590, RefRangeEnd = 55591, XrefRangeStart = 55564, XrefRangeEnd = 55590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFromFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55598, RefRangeEnd = 55600, XrefRangeStart = 55591, XrefRangeEnd = 55598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveToFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55615, RefRangeEnd = 55616, XrefRangeStart = 55600, XrefRangeEnd = 55615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitDefault()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55630, RefRangeEnd = 55633, XrefRangeStart = 55616, XrefRangeEnd = 55630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55633, XrefRangeEnd = 55638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object __ctor_b__8_0(FieldInfo field)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__8_0_Private_Object_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public GameConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
