using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Managers;
using Il2CppScripts.UI.Overlay;
using Il2CppScripts.UI.Panels.Views.Game;
using Il2CppScripts.UI.Panels.Views.Lobby;
using Il2CppScripts.UI.Panels.Views.Login;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.UI;

public class UIRoot : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LoginViewPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_LobbyViewPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameViewPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverlayPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoginRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_LobbyRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameView;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverlayView;

	private static readonly System.IntPtr NativeFieldInfoPtr_VisibilityManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyViews_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGameStatusChanged_Private_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HtmlDumpCommand_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe LoginViewRoot LoginViewPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginViewPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoginViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginViewPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loginViewRoot));
		}
	}

	public unsafe LobbyRoot LobbyViewPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyViewPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LobbyRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyViewPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lobbyRoot));
		}
	}

	public unsafe GameViewRoot GameViewPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameViewPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameViewPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameViewRoot));
		}
	}

	public unsafe OverlayViewRoot OverlayPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverlayPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OverlayViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverlayPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overlayViewRoot));
		}
	}

	public unsafe LoginViewRoot LoginRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoginViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoginRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loginViewRoot));
		}
	}

	public unsafe LobbyRoot LobbyRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LobbyRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LobbyRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lobbyRoot));
		}
	}

	public unsafe GameViewRoot GameView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameViewRoot));
		}
	}

	public unsafe OverlayViewRoot OverlayView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverlayView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OverlayViewRoot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverlayView)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overlayViewRoot));
		}
	}

	public unsafe UIVisibilityManager VisibilityManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VisibilityManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIVisibilityManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VisibilityManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIVisibilityManager));
		}
	}

	static UIRoot()
	{
		Il2CppClassPointerStore<UIRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI", "UIRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRoot>.NativeClassPtr);
		NativeFieldInfoPtr_LoginViewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "LoginViewPrefab");
		NativeFieldInfoPtr_LobbyViewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "LobbyViewPrefab");
		NativeFieldInfoPtr_GameViewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "GameViewPrefab");
		NativeFieldInfoPtr_OverlayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "OverlayPrefab");
		NativeFieldInfoPtr_LoginRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "LoginRoot");
		NativeFieldInfoPtr_LobbyRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "LobbyRoot");
		NativeFieldInfoPtr_GameView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "GameView");
		NativeFieldInfoPtr_OverlayView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "OverlayView");
		NativeFieldInfoPtr_VisibilityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, "VisibilityManager");
		NativeMethodInfoPtr_DestroyViews_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100665587);
		NativeMethodInfoPtr_OnGameStatusChanged_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100665588);
		NativeMethodInfoPtr_HtmlDumpCommand_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100665589);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100665590);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRoot>.NativeClassPtr, 100665591);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23836, RefRangeEnd = 23837, XrefRangeStart = 23796, XrefRangeEnd = 23836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyViews()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyViews_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23929, RefRangeEnd = 23930, XrefRangeStart = 23837, XrefRangeEnd = 23929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameStatusChanged(Il2CppSystem.Type state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGameStatusChanged_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23930, XrefRangeEnd = 23935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HtmlDumpCommand(Il2CppStringArray argv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)argv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HtmlDumpCommand_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23935, XrefRangeEnd = 23968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRoot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIRoot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
