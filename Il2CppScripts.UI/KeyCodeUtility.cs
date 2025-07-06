using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Services;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.UI;

public static class KeyCodeUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_KeyCodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_FunctionalKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlphaKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeypadKeys;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceKeysWithKeyMods_Public_Static_Void_byref_Il2CppStructArray_1_KeyCode_byref_KeyMods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstPressedKey_Public_Static_KeyCode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyKeyDown_Public_Static_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPressedKeys_Public_Static_Il2CppStructArray_1_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumKeysPressed_Public_Static_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeysPressed_Public_Static_Boolean_Il2CppStructArray_1_KeyCode_KeyMods_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeyHeld_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeyPressed_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeyMods_Public_Static_Boolean_KeyMods_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyMods_Public_Static_KeyMods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_KeyMods_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyPrintable_Public_Static_Boolean_KeyCode_0;

	public unsafe static Il2CppStructArray<KeyCode> KeyCodes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyCodes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyCodes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<KeyCode> FunctionalKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FunctionalKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FunctionalKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<KeyCode> AlphaKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AlphaKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AlphaKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<KeyCode> KeypadKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeypadKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeypadKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static KeyCodeUtility()
	{
		Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI", "KeyCodeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr);
		NativeFieldInfoPtr_KeyCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, "KeyCodes");
		NativeFieldInfoPtr_FunctionalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, "FunctionalKeys");
		NativeFieldInfoPtr_AlphaKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, "AlphaKeys");
		NativeFieldInfoPtr_KeypadKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, "KeypadKeys");
		NativeMethodInfoPtr_ReplaceKeysWithKeyMods_Public_Static_Void_byref_Il2CppStructArray_1_KeyCode_byref_KeyMods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665508);
		NativeMethodInfoPtr_GetFirstPressedKey_Public_Static_KeyCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665509);
		NativeMethodInfoPtr_IsAnyKeyDown_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665510);
		NativeMethodInfoPtr_GetAllPressedKeys_Public_Static_Il2CppStructArray_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665511);
		NativeMethodInfoPtr_GetNumKeysPressed_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665512);
		NativeMethodInfoPtr_CheckKeysPressed_Public_Static_Boolean_Il2CppStructArray_1_KeyCode_KeyMods_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665513);
		NativeMethodInfoPtr_CheckKeyHeld_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665514);
		NativeMethodInfoPtr_CheckKeyPressed_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr_CheckKeyMods_Public_Static_Boolean_KeyMods_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_GetKeyMods_Public_Static_KeyMods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_KeyMods_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665518);
		NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665519);
		NativeMethodInfoPtr_IsKeyPrintable_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyCodeUtility>.NativeClassPtr, 100665520);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22554, XrefRangeEnd = 22591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceKeysWithKeyMods(ref Il2CppStructArray<KeyCode> keys, ref KeyMods mods)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mods);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceKeysWithKeyMods_Public_Static_Void_byref_Il2CppStructArray_1_KeyCode_byref_KeyMods_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		keys = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<KeyCode>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22598, RefRangeEnd = 22601, XrefRangeStart = 22591, XrefRangeEnd = 22598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyCode GetFirstPressedKey(bool includeKeyMods = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeKeyMods);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstPressedKey_Public_Static_KeyCode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(KeyCode*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22601, XrefRangeEnd = 22605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAnyKeyDown(bool includeKeyMods = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeKeyMods);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyKeyDown_Public_Static_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22605, XrefRangeEnd = 22632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<KeyCode> GetAllPressedKeys()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPressedKeys_Public_Static_Il2CppStructArray_1_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 22638, RefRangeEnd = 22642, XrefRangeStart = 22632, XrefRangeEnd = 22638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumKeysPressed(bool includeKeyMods = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&includeKeyMods);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumKeysPressed_Public_Static_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22642, XrefRangeEnd = 22660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckKeysPressed(Il2CppStructArray<KeyCode> keys, KeyMods keyMods = KeyMods.None, bool allowOtherKeys = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(KeyMods**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyMods;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeys;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKeysPressed_Public_Static_Boolean_Il2CppStructArray_1_KeyCode_KeyMods_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22660, XrefRangeEnd = 22670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckKeyHeld(KeyCode keyCode, KeyMods keyMods = KeyMods.None, bool allowOtherKeys = false, bool allowOtherKeymods = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&keyCode);
		*(KeyMods**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyMods;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeys;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeymods;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKeyHeld_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22670, XrefRangeEnd = 22680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckKeyPressed(KeyCode keyCode, KeyMods keyMods = KeyMods.None, bool allowOtherKeys = false, bool allowOtherKeymods = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&keyCode);
		*(KeyMods**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyMods;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeys;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeymods;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKeyPressed_Public_Static_Boolean_KeyCode_KeyMods_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 22695, RefRangeEnd = 22709, XrefRangeStart = 22680, XrefRangeEnd = 22695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckKeyMods(KeyMods keyMods, bool exclusive = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&keyMods);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exclusive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKeyMods_Public_Static_Boolean_KeyMods_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22723, RefRangeEnd = 22726, XrefRangeStart = 22709, XrefRangeEnd = 22723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static KeyMods GetKeyMods()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyMods_Public_Static_KeyMods_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(KeyMods*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22753, RefRangeEnd = 22756, XrefRangeStart = 22726, XrefRangeEnd = 22753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string KeyToCaption(KeyCode keyCode, KeyMods keyMods, bool keyModsVerbose = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&keyCode);
		*(KeyMods**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyMods;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyModsVerbose;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_KeyMods_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22921, RefRangeEnd = 22923, XrefRangeStart = 22756, XrefRangeEnd = 22921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string KeyToCaption(KeyCode key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyToCaption_Public_Static_String_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 22923, RefRangeEnd = 22927, XrefRangeStart = 22923, XrefRangeEnd = 22923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsKeyPrintable(KeyCode keyCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyPrintable_Public_Static_Boolean_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public KeyCodeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
