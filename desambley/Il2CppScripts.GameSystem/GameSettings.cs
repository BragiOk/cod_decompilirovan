using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.CharacterSystem;
using Il2CppScripts.Components.Entity;
using Il2CppScripts.Paperdoll.Abnormals;
using Il2CppScripts.Paperdoll.Classes;
using Il2CppScripts.Paperdoll.Enchant;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Audio;

namespace Il2CppScripts.GameSystem;

public class GameSettings : ScriptableObject
{
	[System.Serializable]
	public class SettingsData : Il2CppSystem.Object
	{
		[System.Serializable]
		public class StaticActivationData : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			private static readonly System.IntPtr NativeFieldInfoPtr_TerrainScenesStreamInDistance;

			private static readonly System.IntPtr NativeFieldInfoPtr_DistanceMin;

			private static readonly System.IntPtr NativeFieldInfoPtr_Bias;

			private static readonly System.IntPtr NativeFieldInfoPtr_ShadowBias;

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

			public unsafe float TerrainScenesStreamInDistance
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TerrainScenesStreamInDistance);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TerrainScenesStreamInDistance)) = num;
				}
			}

			public unsafe float DistanceMin
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DistanceMin);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DistanceMin)) = num;
				}
			}

			public unsafe float Bias
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bias);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bias)) = num;
				}
			}

			public unsafe float ShadowBias
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowBias);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowBias)) = num;
				}
			}

			static StaticActivationData()
			{
				Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "StaticActivationData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr);
				NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, "Name");
				NativeFieldInfoPtr_TerrainScenesStreamInDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, "TerrainScenesStreamInDistance");
				NativeFieldInfoPtr_DistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, "DistanceMin");
				NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, "Bias");
				NativeFieldInfoPtr_ShadowBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, "ShadowBias");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr, 100668516);
			}

			[CallerCount(0)]
			public unsafe StaticActivationData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticActivationData>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public StaticActivationData(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_OfflineMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_AutoConnect;

		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultServerID;

		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCharacterIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_LoginServerAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_StaticsActivationMargin;

		private static readonly System.IntPtr NativeFieldInfoPtr_StaticActivation;

		private static readonly System.IntPtr NativeFieldInfoPtr_DisableStaticOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_DisableDynamicOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_DisableEffectCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_MainMenuScene;

		private static readonly System.IntPtr NativeFieldInfoPtr_DebugLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnableLogger;

		private static readonly System.IntPtr NativeFieldInfoPtr_StepSoundVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_SoulshotHitVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_CriticalHitVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxCommonSounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxStepSounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxAnimSounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxSkillLongSounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxReceiveHitSounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_SplitDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxSoundsCalcTimeMs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool OfflineMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OfflineMode);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OfflineMode)) = flag;
			}
		}

		public unsafe bool AutoConnect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoConnect);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoConnect)) = flag;
			}
		}

		public unsafe int DefaultServerID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultServerID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultServerID)) = num;
			}
		}

		public unsafe int DefaultCharacterIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultCharacterIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultCharacterIndex)) = num;
			}
		}

		public unsafe string LoginServerAddress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginServerAddress);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginServerAddress)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float StaticsActivationMargin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticsActivationMargin);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticsActivationMargin)) = num;
			}
		}

		public unsafe Il2CppReferenceArray<StaticActivationData> StaticActivation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticActivation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticActivationData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticActivation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe bool DisableStaticOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableStaticOcclusion);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableStaticOcclusion)) = flag;
			}
		}

		public unsafe bool DisableDynamicOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableDynamicOcclusion);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableDynamicOcclusion)) = flag;
			}
		}

		public unsafe bool DisableEffectCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableEffectCache);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableEffectCache)) = flag;
			}
		}

		public unsafe string MainMenuScene
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainMenuScene);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainMenuScene)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int DebugLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DebugLevel)) = num;
			}
		}

		public unsafe bool EnableLogger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableLogger);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableLogger)) = flag;
			}
		}

		public unsafe float StepSoundVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StepSoundVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StepSoundVolume)) = num;
			}
		}

		public unsafe float SoulshotHitVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoulshotHitVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoulshotHitVolume)) = num;
			}
		}

		public unsafe float CriticalHitVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CriticalHitVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CriticalHitVolume)) = num;
			}
		}

		public unsafe int MaxCommonSounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCommonSounds);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCommonSounds)) = num;
			}
		}

		public unsafe int MaxStepSounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxStepSounds);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxStepSounds)) = num;
			}
		}

		public unsafe int MaxAnimSounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAnimSounds);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAnimSounds)) = num;
			}
		}

		public unsafe int MaxSkillLongSounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxSkillLongSounds);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxSkillLongSounds)) = num;
			}
		}

		public unsafe int MaxReceiveHitSounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxReceiveHitSounds);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxReceiveHitSounds)) = num;
			}
		}

		public unsafe float SplitDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SplitDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SplitDistance)) = num;
			}
		}

		public unsafe int MaxSoundsCalcTimeMs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxSoundsCalcTimeMs);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxSoundsCalcTimeMs)) = num;
			}
		}

		static SettingsData()
		{
			Il2CppClassPointerStore<SettingsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "SettingsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsData>.NativeClassPtr);
			NativeFieldInfoPtr_OfflineMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "OfflineMode");
			NativeFieldInfoPtr_AutoConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "AutoConnect");
			NativeFieldInfoPtr_DefaultServerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DefaultServerID");
			NativeFieldInfoPtr_DefaultCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DefaultCharacterIndex");
			NativeFieldInfoPtr_LoginServerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "LoginServerAddress");
			NativeFieldInfoPtr_StaticsActivationMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "StaticsActivationMargin");
			NativeFieldInfoPtr_StaticActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "StaticActivation");
			NativeFieldInfoPtr_DisableStaticOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DisableStaticOcclusion");
			NativeFieldInfoPtr_DisableDynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DisableDynamicOcclusion");
			NativeFieldInfoPtr_DisableEffectCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DisableEffectCache");
			NativeFieldInfoPtr_MainMenuScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MainMenuScene");
			NativeFieldInfoPtr_DebugLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DebugLevel");
			NativeFieldInfoPtr_EnableLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "EnableLogger");
			NativeFieldInfoPtr_StepSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "StepSoundVolume");
			NativeFieldInfoPtr_SoulshotHitVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "SoulshotHitVolume");
			NativeFieldInfoPtr_CriticalHitVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "CriticalHitVolume");
			NativeFieldInfoPtr_MaxCommonSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxCommonSounds");
			NativeFieldInfoPtr_MaxStepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxStepSounds");
			NativeFieldInfoPtr_MaxAnimSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxAnimSounds");
			NativeFieldInfoPtr_MaxSkillLongSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxSkillLongSounds");
			NativeFieldInfoPtr_MaxReceiveHitSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxReceiveHitSounds");
			NativeFieldInfoPtr_SplitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "SplitDistance");
			NativeFieldInfoPtr_MaxSoundsCalcTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "MaxSoundsCalcTimeMs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, 100668515);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51282, XrefRangeEnd = 51286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SettingsData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InternalData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntityPrefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_CharacterPrefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_MovementPointerPrefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_AudioMixer;

		private static readonly System.IntPtr NativeFieldInfoPtr_AbnormalEffectData;

		private static readonly System.IntPtr NativeFieldInfoPtr_CharacterConfiguration;

		private static readonly System.IntPtr NativeFieldInfoPtr_CubicsData;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnchantData;

		private static readonly System.IntPtr NativeFieldInfoPtr_FootstepSoundData;

		private static readonly System.IntPtr NativeFieldInfoPtr_ItemDropData;

		private static readonly System.IntPtr NativeFieldInfoPtr_Capsule;

		private static readonly System.IntPtr NativeFieldInfoPtr_PaperdollCapsuleEditVisibilityMaterial;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ItemEntity ItemEntityPrefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemEntityPrefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemEntity>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemEntityPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemEntity));
			}
		}

		public unsafe Character CharacterPrefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterPrefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character));
			}
		}

		public unsafe GameObject MovementPointerPrefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MovementPointerPrefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MovementPointerPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe AudioMixer AudioMixer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioMixer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioMixer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AudioMixer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioMixer));
			}
		}

		public unsafe AbnormalEffectData AbnormalEffectData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbnormalEffectData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AbnormalEffectData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbnormalEffectData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)abnormalEffectData));
			}
		}

		public unsafe CharacterConfiguration CharacterConfiguration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterConfiguration);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterConfiguration>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterConfiguration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterConfiguration));
			}
		}

		public unsafe CubicsData CubicsData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicsData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CubicsData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CubicsData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cubicsData));
			}
		}

		public unsafe EnchantData EnchantData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnchantData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnchantData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnchantData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enchantData));
			}
		}

		public unsafe FootstepSoundData FootstepSoundData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootstepSoundData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FootstepSoundData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootstepSoundData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)footstepSoundData));
			}
		}

		public unsafe ItemDropData ItemDropData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemDropData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemDropData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemDropData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemDropData));
			}
		}

		public unsafe Mesh Capsule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capsule);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Capsule)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Material PaperdollCapsuleEditVisibilityMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaperdollCapsuleEditVisibilityMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaperdollCapsuleEditVisibilityMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		static InternalData()
		{
			Il2CppClassPointerStore<InternalData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "InternalData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalData>.NativeClassPtr);
			NativeFieldInfoPtr_ItemEntityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "ItemEntityPrefab");
			NativeFieldInfoPtr_CharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "CharacterPrefab");
			NativeFieldInfoPtr_MovementPointerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "MovementPointerPrefab");
			NativeFieldInfoPtr_AudioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "AudioMixer");
			NativeFieldInfoPtr_AbnormalEffectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "AbnormalEffectData");
			NativeFieldInfoPtr_CharacterConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "CharacterConfiguration");
			NativeFieldInfoPtr_CubicsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "CubicsData");
			NativeFieldInfoPtr_EnchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "EnchantData");
			NativeFieldInfoPtr_FootstepSoundData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "FootstepSoundData");
			NativeFieldInfoPtr_ItemDropData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "ItemDropData");
			NativeFieldInfoPtr_Capsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "Capsule");
			NativeFieldInfoPtr_PaperdollCapsuleEditVisibilityMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalData>.NativeClassPtr, "PaperdollCapsuleEditVisibilityMaterial");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalData>.NativeClassPtr, 100668517);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InternalData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowJsonConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceAssetBundles;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoNotLoadWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_Main;

	private static readonly System.IntPtr NativeFieldInfoPtr_Internal;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteJsonConfig_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJsonConfig_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool AllowJsonConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowJsonConfig);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowJsonConfig)) = flag;
		}
	}

	public unsafe bool ForceAssetBundles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceAssetBundles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceAssetBundles)) = flag;
		}
	}

	public unsafe bool DoNotLoadWorld
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoNotLoadWorld);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoNotLoadWorld)) = flag;
		}
	}

	public unsafe SettingsData Main
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Main);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SettingsData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Main)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsData));
		}
	}

	public unsafe InternalData Internal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Internal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Internal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalData));
		}
	}

	public unsafe string ConfigName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51286, XrefRangeEnd = 51288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConfigName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static GameSettings()
	{
		Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameSystem", "GameSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
		NativeFieldInfoPtr_AllowJsonConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AllowJsonConfig");
		NativeFieldInfoPtr_ForceAssetBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ForceAssetBundles");
		NativeFieldInfoPtr_DoNotLoadWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DoNotLoadWorld");
		NativeFieldInfoPtr_Main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "Main");
		NativeFieldInfoPtr_Internal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "Internal");
		NativeMethodInfoPtr_get_ConfigName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100668511);
		NativeMethodInfoPtr_WriteJsonConfig_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100668512);
		NativeMethodInfoPtr_LoadJsonConfig_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100668513);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100668514);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51298, RefRangeEnd = 51300, XrefRangeStart = 51288, XrefRangeEnd = 51298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteJsonConfig(bool overwrite = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&overwrite);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteJsonConfig_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51315, RefRangeEnd = 51316, XrefRangeStart = 51300, XrefRangeEnd = 51315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadJsonConfig()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJsonConfig_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
