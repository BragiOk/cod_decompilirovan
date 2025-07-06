using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.LibUnity;

public class GlobalSound : MonoBehaviour
{
	[OriginalName("Assembly-Scripts.dll", "", "Channel")]
	public enum Channel
	{
		Default,
		Chat,
		UI,
		Music
	}

	private static readonly IntPtr NativeFieldInfoPtr__PrintLog_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeFieldInfoPtr__disabledForFrame;

	private static readonly IntPtr NativeFieldInfoPtr_Volume;

	private static readonly IntPtr NativeFieldInfoPtr_Suppress;

	private static readonly IntPtr NativeFieldInfoPtr__playedThisFrame;

	private static readonly IntPtr NativeFieldInfoPtr__lastPlayedFrame;

	private static readonly IntPtr NativeFieldInfoPtr__audioSource;

	private static readonly IntPtr NativeMethodInfoPtr_set_DisableForOneFrame_Public_Static_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PrintLog_Public_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_PrintLog_Public_Static_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Private_Static_get_GlobalSound_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_Channel_AudioClip_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SuppressChannel_Public_Static_Void_Channel_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_AudioClip_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetChannelVolume_Public_Static_Void_Channel_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool _PrintLog_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__PrintLog_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__PrintLog_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static GlobalSound _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<GlobalSound>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)globalSound));
		}
	}

	public unsafe static int _disabledForFrame
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__disabledForFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__disabledForFrame, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<float> Volume
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Volume, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Volume, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<bool> Suppress
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Suppress, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Suppress, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe HashSet<AudioClip> _playedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playedThisFrame);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<AudioClip>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playedThisFrame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe int _lastPlayedFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPlayedFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPlayedFrame)) = num;
		}
	}

	public unsafe AudioSource _audioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__audioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__audioSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static bool DisableForOneFrame
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20045, XrefRangeEnd = 20052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableForOneFrame_Public_Static_set_Void_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool PrintLog
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20052, XrefRangeEnd = 20056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PrintLog_Public_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20056, XrefRangeEnd = 20060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PrintLog_Public_Static_set_Void_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static GlobalSound Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20096, XrefRangeStart = 20060, XrefRangeEnd = 20094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Private_Static_get_GlobalSound_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GlobalSound>(intPtr) : null;
		}
	}

	static GlobalSound()
	{
		Il2CppClassPointerStore<GlobalSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.LibUnity", "GlobalSound");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr);
		NativeFieldInfoPtr__PrintLog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "<PrintLog>k__BackingField");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr__disabledForFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "_disabledForFrame");
		NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "Volume");
		NativeFieldInfoPtr_Suppress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "Suppress");
		NativeFieldInfoPtr__playedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "_playedThisFrame");
		NativeFieldInfoPtr__lastPlayedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "_lastPlayedFrame");
		NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, "_audioSource");
		NativeMethodInfoPtr_set_DisableForOneFrame_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665235);
		NativeMethodInfoPtr_get_PrintLog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665236);
		NativeMethodInfoPtr_set_PrintLog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665237);
		NativeMethodInfoPtr_get_Instance_Private_Static_get_GlobalSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665238);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665239);
		NativeMethodInfoPtr_Play_Private_Void_Channel_AudioClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665240);
		NativeMethodInfoPtr_SuppressChannel_Public_Static_Void_Channel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665241);
		NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665242);
		NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665243);
		NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665244);
		NativeMethodInfoPtr_SetChannelVolume_Public_Static_Void_Channel_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665245);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr, 100665246);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20096, XrefRangeEnd = 20101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20170, RefRangeEnd = 20172, XrefRangeStart = 20101, XrefRangeEnd = 20170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(Channel channel, AudioClip clip, bool looped = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&channel);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &looped;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Private_Void_Channel_AudioClip_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20172, XrefRangeEnd = 20176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SuppressChannel(Channel channel, bool suppress)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&channel);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &suppress;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SuppressChannel_Public_Static_Void_Channel_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20176, XrefRangeEnd = 20181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlaySound(AudioClip clip)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioClip_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 20186, RefRangeEnd = 20213, XrefRangeStart = 20181, XrefRangeEnd = 20186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlaySound(Channel channel, AudioClip clip)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&channel);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_AudioClip_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20213, XrefRangeEnd = 20223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlaySound(Channel channel, string sound)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&channel);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sound);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_Void_Channel_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20227, RefRangeEnd = 20229, XrefRangeStart = 20223, XrefRangeEnd = 20227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetChannelVolume(Channel channel, float volume)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&channel);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChannelVolume_Public_Static_Void_Channel_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20229, XrefRangeEnd = 20238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalSound()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalSound>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GlobalSound(IntPtr pointer)
		: base(pointer)
	{
	}
}
