using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.AssetSystem;

public static class AssetPaths : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_BundleRoot_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TerrainScenesPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TerrainSceneNameAtIndex_Public_Static_String_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TerrainScenePathAtIndex_Public_Static_String_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UIScenePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyScenePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RootScenePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldInstanceScenePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MainMenuScenePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OfflineObjectsScenePath_Public_Static_get_String_0;

	public unsafe static string BundleRoot
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70556, XrefRangeEnd = 70558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BundleRoot_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string TerrainScenesPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70558, XrefRangeEnd = 70560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TerrainScenesPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string UIScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70598, XrefRangeEnd = 70600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UIScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string LobbyScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70600, XrefRangeEnd = 70602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LobbyScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string RootScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70602, XrefRangeEnd = 70604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RootScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string WorldInstanceScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70604, XrefRangeEnd = 70606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WorldInstanceScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string MainMenuScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70606, XrefRangeEnd = 70608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MainMenuScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string OfflineObjectsScenePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70608, XrefRangeEnd = 70610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OfflineObjectsScenePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static AssetPaths()
	{
		Il2CppClassPointerStore<AssetPaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.AssetSystem", "AssetPaths");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr);
		NativeMethodInfoPtr_get_BundleRoot_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670177);
		NativeMethodInfoPtr_get_TerrainScenesPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670178);
		NativeMethodInfoPtr_TerrainSceneNameAtIndex_Public_Static_String_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670179);
		NativeMethodInfoPtr_TerrainScenePathAtIndex_Public_Static_String_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670180);
		NativeMethodInfoPtr_get_UIScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670181);
		NativeMethodInfoPtr_get_LobbyScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670182);
		NativeMethodInfoPtr_get_RootScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670183);
		NativeMethodInfoPtr_get_WorldInstanceScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670184);
		NativeMethodInfoPtr_get_MainMenuScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670185);
		NativeMethodInfoPtr_get_OfflineObjectsScenePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPaths>.NativeClassPtr, 100670186);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70560, XrefRangeEnd = 70569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TerrainSceneNameAtIndex(Vector2Int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TerrainSceneNameAtIndex_Public_Static_String_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70597, RefRangeEnd = 70598, XrefRangeStart = 70569, XrefRangeEnd = 70597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TerrainScenePathAtIndex(Vector2Int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TerrainScenePathAtIndex_Public_Static_String_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public AssetPaths(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
