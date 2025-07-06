using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI;

public static class SpriteCache : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Sprites;

	private static readonly System.IntPtr NativeMethodInfoPtr_DomainCleanup_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_String_0;

	public unsafe static Dictionary<string, Sprite> Sprites
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Sprites, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Sprite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Sprites, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static SpriteCache()
	{
		Il2CppClassPointerStore<SpriteCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI", "SpriteCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteCache>.NativeClassPtr);
		NativeFieldInfoPtr_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteCache>.NativeClassPtr, "Sprites");
		NativeMethodInfoPtr_DomainCleanup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteCache>.NativeClassPtr, 100665539);
		NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteCache>.NativeClassPtr, 100665540);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23175, XrefRangeEnd = 23183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DomainCleanup()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DomainCleanup_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 23219, RefRangeEnd = 23228, XrefRangeStart = 23183, XrefRangeEnd = 23219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetSprite(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
	}

	public SpriteCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
