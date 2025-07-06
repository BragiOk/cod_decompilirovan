using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.Persistent;

public class HotkeyProfiles : Il2CppSystem.Object
{
	[System.Serializable]
	public class HotkeyEntry : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_EmptyHotkey;

		private static readonly System.IntPtr NativeFieldInfoPtr_Hotkey;

		private static readonly System.IntPtr NativeFieldInfoPtr_Alternative;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HotkeyEntry_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHotkey_Public_Hotkey_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Hotkey_Hotkey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetHotkey_Public_Void_Hotkey_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_HotkeyEntry_KeyCode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithAlt_Public_Static_HotkeyEntry_KeyCode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WithBothAlt_Public_Static_HotkeyEntry_KeyCode_0;

		public unsafe static HotkeyEntry EmptyHotkey
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EmptyHotkey, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EmptyHotkey, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hotkeyEntry));
			}
		}

		public unsafe Hotkey Hotkey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotkey);
				return *(Hotkey*)num;
			}
			set
			{
				*(Hotkey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotkey)) = hotkey;
			}
		}

		public unsafe Hotkey Alternative
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Alternative);
				return *(Hotkey*)num;
			}
			set
			{
				*(Hotkey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Alternative)) = hotkey;
			}
		}

		static HotkeyEntry()
		{
			Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "HotkeyEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr);
			NativeFieldInfoPtr_EmptyHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, "EmptyHotkey");
			NativeFieldInfoPtr_Hotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, "Hotkey");
			NativeFieldInfoPtr_Alternative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, "Alternative");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665112);
			NativeMethodInfoPtr__ctor_Public_Void_HotkeyEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665113);
			NativeMethodInfoPtr_GetHotkey_Public_Hotkey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665114);
			NativeMethodInfoPtr__ctor_Public_Void_Hotkey_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665115);
			NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665116);
			NativeMethodInfoPtr_SetHotkey_Public_Void_Hotkey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665117);
			NativeMethodInfoPtr_Default_Public_Static_HotkeyEntry_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665118);
			NativeMethodInfoPtr_WithAlt_Public_Static_HotkeyEntry_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665119);
			NativeMethodInfoPtr_WithBothAlt_Public_Static_HotkeyEntry_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr, 100665120);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotkeyEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe HotkeyEntry(HotkeyEntry hotkeyEntry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hotkeyEntry);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HotkeyEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe Hotkey GetHotkey(bool alternative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&alternative);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHotkey_Public_Hotkey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Hotkey*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe HotkeyEntry(Hotkey hotkey, Hotkey alternative)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&hotkey);
			*(Hotkey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Hotkey_Hotkey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe HotkeyEntry(Hotkey hotkey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&hotkey);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void SetHotkey(Hotkey hotkey, bool alternative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&hotkey);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHotkey_Public_Void_Hotkey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17944, XrefRangeEnd = 17947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HotkeyEntry Default(KeyCode keyCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&keyCode);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Default_Public_Static_HotkeyEntry_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyEntry>(intPtr) : null;
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 17950, RefRangeEnd = 17961, XrefRangeStart = 17947, XrefRangeEnd = 17950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HotkeyEntry WithAlt(KeyCode keyCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&keyCode);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithAlt_Public_Static_HotkeyEntry_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyEntry>(intPtr) : null;
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 17964, RefRangeEnd = 17968, XrefRangeStart = 17961, XrefRangeEnd = 17964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HotkeyEntry WithBothAlt(KeyCode keyCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&keyCode);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithBothAlt_Public_Static_HotkeyEntry_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyEntry>(intPtr) : null;
		}

		public HotkeyEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Profile : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_HotkeyEntry_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_HotkeyEntry_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Profile_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopyValues_Public_Void_Profile_Boolean_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0;

		public unsafe Dictionary<string, HotkeyEntry> Entries
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HotkeyEntry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entries)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe HotkeyEntry this[string key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17968, XrefRangeEnd = 17972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_HotkeyEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyEntry>(intPtr) : null;
			}
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 17975, RefRangeEnd = 18002, XrefRangeStart = 17972, XrefRangeEnd = 17975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_String_HotkeyEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static Profile()
		{
			Il2CppClassPointerStore<Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "Profile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profile>.NativeClassPtr);
			NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "Entries");
			NativeMethodInfoPtr_get_Item_Public_get_HotkeyEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665122);
			NativeMethodInfoPtr_set_Item_Public_set_Void_String_HotkeyEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665123);
			NativeMethodInfoPtr__ctor_Public_Void_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665124);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665125);
			NativeMethodInfoPtr_CopyValues_Public_Void_Profile_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665126);
			NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665127);
			NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100665128);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18009, RefRangeEnd = 18012, XrefRangeStart = 18002, XrefRangeEnd = 18009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Profile(Profile profile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Profile>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18018, RefRangeEnd = 18020, XrefRangeStart = 18012, XrefRangeEnd = 18018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Profile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Profile>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 18042, RefRangeEnd = 18046, XrefRangeStart = 18020, XrefRangeEnd = 18042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValues(Profile profile, bool clean = true, bool overwrite = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clean;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyValues_Public_Void_Profile_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 18056, RefRangeEnd = 18072, XrefRangeStart = 18046, XrefRangeEnd = 18056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hotkey GetHotkey(string key, bool alternative = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Hotkey*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18081, RefRangeEnd = 18084, XrefRangeStart = 18072, XrefRangeEnd = 18081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHotkey(string key, Hotkey hotkey, bool alternative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			*(Hotkey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hotkey;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Profile(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxProfiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProfileModified;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultShortcuts;

	private static readonly System.IntPtr NativeFieldInfoPtr__activeProfileIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__profiles;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ProfileModified_Public_add_Void_Action_1_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ProfileModified_Public_rem_Void_Action_1_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Profiles_Public_get_IReadOnlyList_1_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveProfile_Public_get_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveProfileIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultHotkey_Public_Hotkey_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceEmptyHotkeysWithDefaults_Public_Void_Boolean_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHotkeyUsed_Public_Boolean_Hotkey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceProfile_Public_Void_Profile_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectProfile_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProfile_Public_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveProfile_Public_Void_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCurrentProfile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreShortcuts_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearProfiles_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Void_0;

	public unsafe static int MaxProfiles
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxProfiles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxProfiles, (void*)(&num));
		}
	}

	public unsafe Il2CppSystem.Action<Profile> ProfileModified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProfileModified);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Profile>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProfileModified)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Profile _defaultProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Profile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile));
		}
	}

	public unsafe Profile _defaultShortcuts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultShortcuts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Profile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultShortcuts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile));
		}
	}

	public unsafe int _activeProfileIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeProfileIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activeProfileIndex)) = num;
		}
	}

	public unsafe List<Profile> _profiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Profile>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string FileName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18084, XrefRangeEnd = 18086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe IReadOnlyList<Profile> Profiles
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Profiles_Public_get_IReadOnlyList_1_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<Profile>>(intPtr) : null;
		}
	}

	public unsafe Profile ActiveProfile
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 18112, RefRangeEnd = 18144, XrefRangeStart = 18110, XrefRangeEnd = 18112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveProfile_Public_get_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Profile>(intPtr) : null;
		}
	}

	public unsafe int ActiveProfileIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveProfileIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static HotkeyProfiles()
	{
		Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Persistent", "HotkeyProfiles");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr);
		NativeFieldInfoPtr_MaxProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "MaxProfiles");
		NativeFieldInfoPtr_ProfileModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "ProfileModified");
		NativeFieldInfoPtr__defaultProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "_defaultProfile");
		NativeFieldInfoPtr__defaultShortcuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "_defaultShortcuts");
		NativeFieldInfoPtr__activeProfileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "_activeProfileIndex");
		NativeFieldInfoPtr__profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, "_profiles");
		NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_add_ProfileModified_Public_add_Void_Action_1_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_remove_ProfileModified_Public_rem_Void_Action_1_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_get_Profiles_Public_get_IReadOnlyList_1_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_get_ActiveProfile_Public_get_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_get_ActiveProfileIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_GetDefaultHotkey_Public_Hotkey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_ReplaceEmptyHotkeysWithDefaults_Public_Void_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665100);
		NativeMethodInfoPtr_IsHotkeyUsed_Public_Boolean_Hotkey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_ReplaceProfile_Public_Void_Profile_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665102);
		NativeMethodInfoPtr_SelectProfile_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665103);
		NativeMethodInfoPtr_AddProfile_Public_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665104);
		NativeMethodInfoPtr_RemoveProfile_Public_Void_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665105);
		NativeMethodInfoPtr_RemoveCurrentProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665106);
		NativeMethodInfoPtr_RestoreDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665107);
		NativeMethodInfoPtr_RestoreShortcuts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665108);
		NativeMethodInfoPtr_ClearProfiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr_SaveToFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_LoadFromFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr, 100665111);
	}

	[SpecialName]
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 18094, RefRangeEnd = 18098, XrefRangeStart = 18086, XrefRangeEnd = 18094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ProfileModified(Il2CppSystem.Action<Profile> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ProfileModified_Public_add_Void_Action_1_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 18106, RefRangeEnd = 18110, XrefRangeStart = 18098, XrefRangeEnd = 18106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ProfileModified(Il2CppSystem.Action<Profile> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ProfileModified_Public_rem_Void_Action_1_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18437, RefRangeEnd = 18438, XrefRangeStart = 18144, XrefRangeEnd = 18437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HotkeyProfiles()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyProfiles>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18438, XrefRangeEnd = 18441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hotkey GetDefaultHotkey(string key, bool alternative)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultHotkey_Public_Hotkey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Hotkey*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18441, XrefRangeEnd = 18445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hotkey GetHotkey(string key, bool alternative)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHotkey_Public_Hotkey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Hotkey*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18474, RefRangeEnd = 18476, XrefRangeStart = 18445, XrefRangeEnd = 18474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHotkey(string key, Hotkey hotkey, bool alternative)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Hotkey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hotkey;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternative;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHotkey_Public_Void_String_Hotkey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18476, XrefRangeEnd = 18501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplaceEmptyHotkeysWithDefaults(bool alternative, IEnumerable<string> listToReset = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&alternative);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listToReset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceEmptyHotkeysWithDefaults_Public_Void_Boolean_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18514, RefRangeEnd = 18516, XrefRangeStart = 18501, XrefRangeEnd = 18514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHotkeyUsed(Hotkey hotkey, bool alternate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hotkey);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alternate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHotkeyUsed_Public_Boolean_Hotkey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 18520, RefRangeEnd = 18524, XrefRangeStart = 18516, XrefRangeEnd = 18520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplaceProfile(Profile profile, bool clear = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceProfile_Public_Void_Profile_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18526, RefRangeEnd = 18527, XrefRangeStart = 18524, XrefRangeEnd = 18526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectProfile(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectProfile_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18536, RefRangeEnd = 18538, XrefRangeStart = 18527, XrefRangeEnd = 18536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Profile AddProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddProfile_Public_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Profile>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18538, XrefRangeEnd = 18542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveProfile(Profile profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveProfile_Public_Void_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18542, XrefRangeEnd = 18547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCurrentProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCurrentProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18547, XrefRangeEnd = 18549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18549, XrefRangeEnd = 18551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreShortcuts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreShortcuts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18567, RefRangeEnd = 18568, XrefRangeStart = 18551, XrefRangeEnd = 18567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearProfiles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearProfiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 18575, RefRangeEnd = 18580, XrefRangeStart = 18568, XrefRangeEnd = 18575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveToFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18616, RefRangeEnd = 18617, XrefRangeStart = 18580, XrefRangeEnd = 18616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFromFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HotkeyProfiles(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
