using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public class AudioCounter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__name;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxSounds;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxSoundsFar;

	private static readonly System.IntPtr NativeFieldInfoPtr__splitDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr__downfall;

	private static readonly System.IntPtr NativeFieldInfoPtr__allSoundCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__farSoundsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedFar;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_tick;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowPlay_Public_Boolean_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedTick_Public_Void_0;

	public unsafe string _name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _maxSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSounds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSounds)) = num;
		}
	}

	public unsafe int _maxSoundsFar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSoundsFar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSoundsFar)) = num;
		}
	}

	public unsafe float _splitDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__splitDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__splitDistance)) = num;
		}
	}

	public unsafe float _downfall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__downfall);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__downfall)) = num;
		}
	}

	public unsafe float _allSoundCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allSoundCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allSoundCount)) = num;
		}
	}

	public unsafe float _farSoundsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__farSoundsCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__farSoundsCount)) = num;
		}
	}

	public unsafe int blockedFar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedFar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedFar)) = num;
		}
	}

	public unsafe int blockedAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAll);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAll)) = num;
		}
	}

	public unsafe int tick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick)) = num;
		}
	}

	static AudioCounter()
	{
		Il2CppClassPointerStore<AudioCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "AudioCounter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr);
		NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_name");
		NativeFieldInfoPtr__maxSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_maxSounds");
		NativeFieldInfoPtr__maxSoundsFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_maxSoundsFar");
		NativeFieldInfoPtr__splitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_splitDistance");
		NativeFieldInfoPtr__downfall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_downfall");
		NativeFieldInfoPtr__allSoundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_allSoundCount");
		NativeFieldInfoPtr__farSoundsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "_farSoundsCount");
		NativeFieldInfoPtr_blockedFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "blockedFar");
		NativeFieldInfoPtr_blockedAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "blockedAll");
		NativeFieldInfoPtr_tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, "tick");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, 100665259);
		NativeMethodInfoPtr_AllowPlay_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, 100665260);
		NativeMethodInfoPtr_FixedTick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr, 100665261);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 20389, RefRangeEnd = 20394, XrefRangeStart = 20389, XrefRangeEnd = 20389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioCounter(string name, int loopsLimit, int maxSoundsNear, float splitDistance)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioCounter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopsLimit;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSoundsNear;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &splitDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool AllowPlay(double distanceToUser)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&distanceToUser);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowPlay_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void FixedTick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedTick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioCounter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
