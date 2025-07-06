using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.Common;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Paperdoll.Classes;

public class FootstepSoundLibrary : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainFootstepType_Private_Static_FootstepType_Terrain_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColliderFootstepType_Public_Static_FootstepType_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static FootstepSoundLibrary()
	{
		Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll.Classes", "FootstepSoundLibrary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr);
		NativeMethodInfoPtr_GetTerrainFootstepType_Private_Static_FootstepType_Terrain_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_GetColliderFootstepType_Public_Static_FootstepType_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr, 100664171);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9805, RefRangeEnd = 9806, XrefRangeStart = 9751, XrefRangeEnd = 9805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FootstepType GetTerrainFootstepType(Terrain terrain, RaycastHit hit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		*(RaycastHit**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainFootstepType_Private_Static_FootstepType_Terrain_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FootstepType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9857, RefRangeEnd = 9858, XrefRangeStart = 9806, XrefRangeEnd = 9857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FootstepType GetColliderFootstepType(RaycastHit hit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColliderFootstepType_Public_Static_FootstepType_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FootstepType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FootstepSoundLibrary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSoundLibrary>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FootstepSoundLibrary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
