using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Networking;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScripts.UI.Panels.Views.Login.ServerList;

public class ServerRow : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Server_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__highlight;

	private static readonly IntPtr NativeFieldInfoPtr__serverId;

	private static readonly IntPtr NativeFieldInfoPtr__serverName;

	private static readonly IntPtr NativeFieldInfoPtr__serverState;

	private static readonly IntPtr NativeFieldInfoPtr__serverPing;

	private static readonly IntPtr NativeFieldInfoPtr__templateText;

	private static readonly IntPtr NativeMethodInfoPtr_get_Server_Public_get_GameServerInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Server_Private_set_Void_GameServerInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetServerInfo_Public_Void_GameServerInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameServerInfo _Server_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Server_k__BackingField);
			return new GameServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Server_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameServerInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Image _highlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__highlight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__highlight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI _serverId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverId);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _serverName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _serverState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverState);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _serverPing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverPing);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverPing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TemplateText _templateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemplateText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templateText));
		}
	}

	public unsafe GameServerInfo Server
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Server_Public_get_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GameServerInfo(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Server_Private_set_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ServerRow()
	{
		Il2CppClassPointerStore<ServerRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Login.ServerList", "ServerRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRow>.NativeClassPtr);
		NativeFieldInfoPtr__Server_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "<Server>k__BackingField");
		NativeFieldInfoPtr__highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_highlight");
		NativeFieldInfoPtr__serverId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_serverId");
		NativeFieldInfoPtr__serverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_serverName");
		NativeFieldInfoPtr__serverState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_serverState");
		NativeFieldInfoPtr__serverPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_serverPing");
		NativeFieldInfoPtr__templateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, "_templateText");
		NativeMethodInfoPtr_get_Server_Public_get_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, 100666938);
		NativeMethodInfoPtr_set_Server_Private_set_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, 100666939);
		NativeMethodInfoPtr_SetServerInfo_Public_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, 100666940);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRow>.NativeClassPtr, 100666941);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35990, RefRangeEnd = 35991, XrefRangeStart = 35949, XrefRangeEnd = 35990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetServerInfo(GameServerInfo server)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)server));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetServerInfo_Public_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServerRow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerRow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ServerRow(IntPtr pointer)
		: base(pointer)
	{
	}
}
