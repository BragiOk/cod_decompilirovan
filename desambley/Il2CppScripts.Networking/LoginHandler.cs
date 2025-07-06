using System;
using System.Runtime.CompilerServices;
using Il2CppBestHTTP.WebSocket;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Lib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Networking;

public class LoginHandler : Il2CppSystem.Object
{
	[OriginalName("Assembly-Scripts.dll", "", "Status")]
	public enum Status
	{
		NotStarted,
		Created,
		Connecting,
		Init,
		GGAuth,
		ServerList,
		ServerSelect,
		Failed,
		LoginOk
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_NetworkCrypt;

	private static readonly System.IntPtr NativeFieldInfoPtr__LoginStatus_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FailReason_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__GameServers_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__host;

	private static readonly System.IntPtr NativeFieldInfoPtr__login;

	private static readonly System.IntPtr NativeFieldInfoPtr__password;

	private static readonly System.IntPtr NativeFieldInfoPtr__playOk1;

	private static readonly System.IntPtr NativeFieldInfoPtr__playOk2;

	private static readonly System.IntPtr NativeFieldInfoPtr__loginOk1;

	private static readonly System.IntPtr NativeFieldInfoPtr__loginOk2;

	private static readonly System.IntPtr NativeFieldInfoPtr__statusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr__sessionId;

	private static readonly System.IntPtr NativeFieldInfoPtr__protocolVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastServer;

	private static readonly System.IntPtr NativeFieldInfoPtr__webSocket;

	private static readonly System.IntPtr NativeFieldInfoPtr__sendMsg;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoginStatus_Public_get_Status_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LoginStatus_Private_set_Void_Status_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Login_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastServer_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerOk1_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerOk2_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoginOk1_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoginOk2_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FailReason_Public_get_ServerFailReason_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FailReason_Private_set_Void_ServerFailReason_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GameServers_Public_get_List_1_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_GameServers_Private_set_Void_List_1_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStatus_Private_Void_Status_ServerFailReason_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleInitPacket_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleGGAuth_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleLoginFail_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleLoginOK_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleServerListRetrieved_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleGameServerSelect_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandlePlayFail_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__HandleUnknownPacket_Private_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleAuthPacket_Private_Void_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendPacket_Private_Void_BinaryMsgWrite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketMessage_Private_Void_WebSocket_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebscoketBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketOpen_Private_Void_WebSocket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketClosed_Private_Void_WebSocket_UInt16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketError_Private_Void_WebSocket_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestAuth_Public_Void_String_String_String_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseConnection_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestEnterGameServer_Public_Void_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NerworkCrypt NetworkCrypt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NetworkCrypt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NerworkCrypt>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NetworkCrypt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nerworkCrypt));
		}
	}

	public unsafe Status _LoginStatus_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LoginStatus_k__BackingField);
			return *(Status*)num;
		}
		set
		{
			*(Status*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LoginStatus_k__BackingField)) = status;
		}
	}

	public unsafe ServerFailReason _FailReason_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FailReason_k__BackingField);
			return *(ServerFailReason*)num;
		}
		set
		{
			*(ServerFailReason*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FailReason_k__BackingField)) = serverFailReason;
		}
	}

	public unsafe List<GameServerInfo> _GameServers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameServers_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameServerInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameServers_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string _host
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__host);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__host)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _login
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__login);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__login)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _password
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__password);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__password)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _playOk1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playOk1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playOk1)) = num;
		}
	}

	public unsafe int _playOk2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playOk2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playOk2)) = num;
		}
	}

	public unsafe int _loginOk1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loginOk1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loginOk1)) = num;
		}
	}

	public unsafe int _loginOk2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loginOk2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loginOk2)) = num;
		}
	}

	public unsafe Il2CppSystem.Action _statusChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__statusChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__statusChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe int _sessionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sessionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sessionId)) = num;
		}
	}

	public unsafe int _protocolVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__protocolVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__protocolVersion)) = num;
		}
	}

	public unsafe int _lastServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastServer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastServer)) = num;
		}
	}

	public unsafe WebSocket _webSocket
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__webSocket);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WebSocket>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__webSocket)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket));
		}
	}

	public unsafe BinaryMsgWrite _sendMsg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendMsg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryMsgWrite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendMsg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryMsgWrite));
		}
	}

	public unsafe Status LoginStatus
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoginStatus_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Status*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LoginStatus_Private_set_Void_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string Login
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Login_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string Password
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11442, RefRangeEnd = 11443, XrefRangeStart = 11442, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe int LastServer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastServer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int PlayerOk1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerOk1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int PlayerOk2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerOk2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int LoginOk1
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 11443, RefRangeEnd = 11446, XrefRangeStart = 11443, XrefRangeEnd = 11443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoginOk1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int LoginOk2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoginOk2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe ServerFailReason FailReason
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FailReason_Public_get_ServerFailReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ServerFailReason*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FailReason_Private_set_Void_ServerFailReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<GameServerInfo> GameServers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameServers_Public_get_List_1_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameServerInfo>>(intPtr) : null;
		}
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 69, RefRangeEnd = 119, XrefRangeStart = 69, XrefRangeEnd = 119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GameServers_Private_set_Void_List_1_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LoginHandler()
	{
		Il2CppClassPointerStore<LoginHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking", "LoginHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr);
		NativeFieldInfoPtr_NetworkCrypt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "NetworkCrypt");
		NativeFieldInfoPtr__LoginStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "<LoginStatus>k__BackingField");
		NativeFieldInfoPtr__FailReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "<FailReason>k__BackingField");
		NativeFieldInfoPtr__GameServers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "<GameServers>k__BackingField");
		NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_host");
		NativeFieldInfoPtr__login = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_login");
		NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_password");
		NativeFieldInfoPtr__playOk1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_playOk1");
		NativeFieldInfoPtr__playOk2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_playOk2");
		NativeFieldInfoPtr__loginOk1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_loginOk1");
		NativeFieldInfoPtr__loginOk2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_loginOk2");
		NativeFieldInfoPtr__statusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_statusChanged");
		NativeFieldInfoPtr__sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_sessionId");
		NativeFieldInfoPtr__protocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_protocolVersion");
		NativeFieldInfoPtr__lastServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_lastServer");
		NativeFieldInfoPtr__webSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_webSocket");
		NativeFieldInfoPtr__sendMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, "_sendMsg");
		NativeMethodInfoPtr_get_LoginStatus_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_set_LoginStatus_Private_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_get_Login_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_get_LastServer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_get_PlayerOk1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_get_PlayerOk2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_get_LoginOk1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_get_LoginOk2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_get_FailReason_Public_get_ServerFailReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_set_FailReason_Private_set_Void_ServerFailReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_get_GameServers_Public_get_List_1_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_set_GameServers_Private_set_Void_List_1_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_SetStatus_Private_Void_Status_ServerFailReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr__HandleInitPacket_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr__HandleGGAuth_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr__HandleLoginFail_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr__HandleLoginOK_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr__HandleServerListRetrieved_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr__HandleGameServerSelect_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr__HandlePlayFail_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr__HandleUnknownPacket_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_HandleAuthPacket_Private_Void_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_SendPacket_Private_Void_BinaryMsgWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_OnWebsocketMessage_Private_Void_WebSocket_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_OnWebscoketBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_OnWebsocketOpen_Private_Void_WebSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_OnWebsocketClosed_Private_Void_WebSocket_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_OnWebsocketError_Private_Void_WebSocket_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_RequestAuth_Public_Void_String_String_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_CloseConnection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_RequestEnterGameServer_Public_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr, 100664304);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 11450, RefRangeEnd = 11472, XrefRangeStart = 11446, XrefRangeEnd = 11450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStatus(Status status, ServerFailReason failReason = ServerFailReason.NONE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&status);
		*(ServerFailReason**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &failReason;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStatus_Private_Void_Status_ServerFailReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11496, RefRangeEnd = 11497, XrefRangeStart = 11472, XrefRangeEnd = 11496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleInitPacket(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleInitPacket_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11497, XrefRangeEnd = 11511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleGGAuth(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleGGAuth_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11511, XrefRangeEnd = 11514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleLoginFail(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleLoginFail_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11514, XrefRangeEnd = 11532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleLoginOK(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleLoginOK_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11609, RefRangeEnd = 11610, XrefRangeStart = 11532, XrefRangeEnd = 11609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleServerListRetrieved(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleServerListRetrieved_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11610, XrefRangeEnd = 11626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleGameServerSelect(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleGameServerSelect_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11626, XrefRangeEnd = 11629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandlePlayFail(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandlePlayFail_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11629, XrefRangeEnd = 11641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleUnknownPacket(byte header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&header);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleUnknownPacket_Private_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11729, RefRangeEnd = 11730, XrefRangeStart = 11641, XrefRangeEnd = 11729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleAuthPacket(BinaryMsgRead msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleAuthPacket_Private_Void_BinaryMsgRead_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 11731, RefRangeEnd = 11736, XrefRangeStart = 11730, XrefRangeEnd = 11731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendPacket(BinaryMsgWrite msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPacket_Private_Void_BinaryMsgWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWebsocketMessage(WebSocket webSocket, string mesage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mesage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWebsocketMessage_Private_Void_WebSocket_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11736, XrefRangeEnd = 11742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWebscoketBinaryMessage(WebSocket webSocket, Il2CppStructArray<byte> message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWebscoketBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11742, XrefRangeEnd = 11743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWebsocketOpen(WebSocket webSocket)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWebsocketOpen_Private_Void_WebSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11743, XrefRangeEnd = 11744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWebsocketClosed(WebSocket webSocket, ushort code, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWebsocketClosed_Private_Void_WebSocket_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11744, XrefRangeEnd = 11745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWebsocketError(WebSocket ws, string error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(error);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWebsocketError_Private_Void_WebSocket_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11799, RefRangeEnd = 11800, XrefRangeStart = 11745, XrefRangeEnd = 11799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestAuth(string host, string login, string password, Il2CppSystem.Action statusChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(login);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestAuth_Public_Void_String_String_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11801, RefRangeEnd = 11804, XrefRangeStart = 11800, XrefRangeEnd = 11801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseConnection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseConnection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11804, XrefRangeEnd = 11809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestEnterGameServer(GameServerInfo gameServerInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gameServerInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestEnterGameServer_Public_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoginHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LoginHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
