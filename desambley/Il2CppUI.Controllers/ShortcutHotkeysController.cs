using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Persistent;
using Il2CppScripts.UI.Panels.Views.Game.Shortcuts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppUI.Controllers;

public class ShortcutHotkeysController : MonoBehaviour
{
	public class HotkeyData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__shortcutPanel;

		private static readonly System.IntPtr NativeFieldInfoPtr__row;

		private static readonly System.IntPtr NativeFieldInfoPtr__slot;

		private static readonly System.IntPtr NativeFieldInfoPtr__hotkey;

		private static readonly System.IntPtr NativeFieldInfoPtr__lastRepeatTime;

		private static readonly System.IntPtr NativeFieldInfoPtr__repeatDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr__keyIsPressed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShortcutPanel_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyAllowed_Private_Boolean_Hotkey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckForRepeatedKey_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckForHotkeyPress_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Void_0;

		public unsafe ShortcutPanel _shortcutPanel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcutPanel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutPanel>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcutPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutPanel));
			}
		}

		public unsafe int _row
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__row);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__row)) = num;
			}
		}

		public unsafe int _slot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slot);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slot)) = num;
			}
		}

		public unsafe Hotkey _hotkey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hotkey);
				return *(Hotkey*)num;
			}
			set
			{
				*(Hotkey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hotkey)) = hotkey;
			}
		}

		public unsafe float _lastRepeatTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRepeatTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRepeatTime)) = num;
			}
		}

		public unsafe float _repeatDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__repeatDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__repeatDelay)) = num;
			}
		}

		public unsafe bool _keyIsPressed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyIsPressed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyIsPressed)) = flag;
			}
		}

		static HotkeyData()
		{
			Il2CppClassPointerStore<HotkeyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "HotkeyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr);
			NativeFieldInfoPtr__shortcutPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_shortcutPanel");
			NativeFieldInfoPtr__row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_row");
			NativeFieldInfoPtr__slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_slot");
			NativeFieldInfoPtr__hotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_hotkey");
			NativeFieldInfoPtr__lastRepeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_lastRepeatTime");
			NativeFieldInfoPtr__repeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_repeatDelay");
			NativeFieldInfoPtr__keyIsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, "_keyIsPressed");
			NativeMethodInfoPtr__ctor_Public_Void_ShortcutPanel_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663488);
			NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663489);
			NativeMethodInfoPtr_IsKeyAllowed_Private_Boolean_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663490);
			NativeMethodInfoPtr_CheckForRepeatedKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663491);
			NativeMethodInfoPtr_CheckForHotkeyPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663492);
			NativeMethodInfoPtr_Process_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr, 100663493);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1896, RefRangeEnd = 1897, XrefRangeStart = 1882, XrefRangeEnd = 1896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotkeyData(ShortcutPanel panel, int row, int slot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotkeyData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)panel);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShortcutPanel_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1905, RefRangeEnd = 1909, XrefRangeStart = 1897, XrefRangeEnd = 1905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1909, XrefRangeEnd = 1919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeyAllowed(Hotkey hotKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&hotKey);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyAllowed_Private_Boolean_Hotkey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1919, XrefRangeEnd = 1927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForRepeatedKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForRepeatedKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1956, RefRangeEnd = 1958, XrefRangeStart = 1927, XrefRangeEnd = 1956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForHotkeyPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForHotkeyPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1958, XrefRangeEnd = 1967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HotkeyData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SuppressHotkeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotInitialPressDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotRepeatPressDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr__shortcutPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr__hotkeys;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshHotkeys_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHotkeysChanged_Private_Void_Profile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool SuppressHotkeys
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuppressHotkeys, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuppressHotkeys, (void*)(&flag));
		}
	}

	public unsafe static int SlotInitialPressDelay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotInitialPressDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotInitialPressDelay, (void*)(&num));
		}
	}

	public unsafe static int SlotRepeatPressDelay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotRepeatPressDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotRepeatPressDelay, (void*)(&num));
		}
	}

	public unsafe ShortcutPanel _shortcutPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcutPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutPanel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shortcutPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutPanel));
		}
	}

	public unsafe List<HotkeyData> _hotkeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hotkeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HotkeyData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hotkeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ShortcutHotkeysController()
	{
		Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "UI.Controllers", "ShortcutHotkeysController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr);
		NativeFieldInfoPtr_SuppressHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "SuppressHotkeys");
		NativeFieldInfoPtr_SlotInitialPressDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "SlotInitialPressDelay");
		NativeFieldInfoPtr_SlotRepeatPressDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "SlotRepeatPressDelay");
		NativeFieldInfoPtr__shortcutPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "_shortcutPanel");
		NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, "_hotkeys");
		NativeMethodInfoPtr_RefreshHotkeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_OnHotkeysChanged_Private_Void_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr, 100663487);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1978, RefRangeEnd = 1980, XrefRangeStart = 1967, XrefRangeEnd = 1978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHotkeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHotkeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1980, XrefRangeEnd = 1981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHotkeysChanged(HotkeyProfiles.Profile profile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)profile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHotkeysChanged_Private_Void_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1981, XrefRangeEnd = 2000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2000, XrefRangeEnd = 2013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2013, XrefRangeEnd = 2023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2023, XrefRangeEnd = 2032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShortcutHotkeysController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortcutHotkeysController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShortcutHotkeysController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
