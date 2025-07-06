using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.GameTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.Chat;

public class ChatColors : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_ColorAnnouncement;

	private static readonly IntPtr NativeFieldInfoPtr_ColorShout;

	private static readonly IntPtr NativeFieldInfoPtr_ColorTell;

	private static readonly IntPtr NativeFieldInfoPtr_ColorParty;

	private static readonly IntPtr NativeFieldInfoPtr_ColorTrade;

	private static readonly IntPtr NativeFieldInfoPtr_ColorClan;

	private static readonly IntPtr NativeFieldInfoPtr_ColorAlliance;

	private static readonly IntPtr NativeFieldInfoPtr_ColorHero;

	private static readonly IntPtr NativeFieldInfoPtr_ColorSpecialAnnounce;

	private static readonly IntPtr NativeFieldInfoPtr_ColorPartyRoomAll;

	private static readonly IntPtr NativeFieldInfoPtr_SystemMsgColor;

	private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_SayType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Color ColorAnnouncement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorAnnouncement);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorAnnouncement)) = color;
		}
	}

	public unsafe Color ColorShout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorShout);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorShout)) = color;
		}
	}

	public unsafe Color ColorTell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTell);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTell)) = color;
		}
	}

	public unsafe Color ColorParty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorParty);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorParty)) = color;
		}
	}

	public unsafe Color ColorTrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTrade);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTrade)) = color;
		}
	}

	public unsafe Color ColorClan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorClan);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorClan)) = color;
		}
	}

	public unsafe Color ColorAlliance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorAlliance);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorAlliance)) = color;
		}
	}

	public unsafe Color ColorHero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorHero);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorHero)) = color;
		}
	}

	public unsafe Color ColorSpecialAnnounce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorSpecialAnnounce);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorSpecialAnnounce)) = color;
		}
	}

	public unsafe Color ColorPartyRoomAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorPartyRoomAll);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorPartyRoomAll)) = color;
		}
	}

	public unsafe Color SystemMsgColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMsgColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMsgColor)) = color;
		}
	}

	static ChatColors()
	{
		Il2CppClassPointerStore<ChatColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.Chat", "ChatColors");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatColors>.NativeClassPtr);
		NativeFieldInfoPtr_ColorAnnouncement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorAnnouncement");
		NativeFieldInfoPtr_ColorShout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorShout");
		NativeFieldInfoPtr_ColorTell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorTell");
		NativeFieldInfoPtr_ColorParty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorParty");
		NativeFieldInfoPtr_ColorTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorTrade");
		NativeFieldInfoPtr_ColorClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorClan");
		NativeFieldInfoPtr_ColorAlliance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorAlliance");
		NativeFieldInfoPtr_ColorHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorHero");
		NativeFieldInfoPtr_ColorSpecialAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorSpecialAnnounce");
		NativeFieldInfoPtr_ColorPartyRoomAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "ColorPartyRoomAll");
		NativeFieldInfoPtr_SystemMsgColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, "SystemMsgColor");
		NativeMethodInfoPtr_GetColor_Public_Color_SayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, 100667772);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColors>.NativeClassPtr, 100667773);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44817, RefRangeEnd = 44818, XrefRangeStart = 44817, XrefRangeEnd = 44817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(SayType sayType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&sayType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_SayType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44818, XrefRangeEnd = 44819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatColors()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatColors>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChatColors(IntPtr pointer)
		: base(pointer)
	{
	}
}
