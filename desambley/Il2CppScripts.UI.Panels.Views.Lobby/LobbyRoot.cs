using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScripts.UI.Panels.Views.Lobby;

public class LobbyRoot : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_CharacterList;

	private static readonly IntPtr NativeFieldInfoPtr_AppearanceSelector;

	private static readonly IntPtr NativeFieldInfoPtr_CharacterDescription;

	private static readonly IntPtr NativeFieldInfoPtr_ToMainMenuButton;

	private static readonly IntPtr NativeFieldInfoPtr_EnterGameButton;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CharacterListPanel CharacterList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterListPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterListPanel));
		}
	}

	public unsafe CharacterAppearanceSelectorPanel AppearanceSelector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppearanceSelector);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterAppearanceSelectorPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppearanceSelector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterAppearanceSelectorPanel));
		}
	}

	public unsafe CharacterDescriptionPanel CharacterDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterDescription);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterDescriptionPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterDescription)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterDescriptionPanel));
		}
	}

	public unsafe Button ToMainMenuButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToMainMenuButton);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToMainMenuButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
		}
	}

	public unsafe Button EnterGameButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterGameButton);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterGameButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
		}
	}

	static LobbyRoot()
	{
		Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Lobby", "LobbyRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr);
		NativeFieldInfoPtr_CharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, "CharacterList");
		NativeFieldInfoPtr_AppearanceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, "AppearanceSelector");
		NativeFieldInfoPtr_CharacterDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, "CharacterDescription");
		NativeFieldInfoPtr_ToMainMenuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, "ToMainMenuButton");
		NativeFieldInfoPtr_EnterGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, "EnterGameButton");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr, 100667050);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LobbyRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyRoot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LobbyRoot(IntPtr pointer)
		: base(pointer)
	{
	}
}
