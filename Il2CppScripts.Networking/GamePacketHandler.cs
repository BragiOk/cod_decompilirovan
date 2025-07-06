using System;
using System.Runtime.CompilerServices;
using Il2CppBestHTTP.WebSocket;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Networking;

public class GamePacketHandler : Il2CppSystem.Object
{
	[OriginalName("Assembly-Scripts.dll", "", "Status")]
	public enum Status
	{
		NotOpened,
		Opened,
		Closed,
		Error
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ProtocolVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClientPacketSent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ServerPacketReceived;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr__ConnectStatus_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__WebsocketMessage_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OfflineMode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_LogClientPackets;

	private static readonly System.IntPtr NativeFieldInfoPtr_LogServerPackets;

	private static readonly System.IntPtr NativeFieldInfoPtr__WebsocketErrorOnException_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__SelectedGameServer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__webSocket;

	private static readonly System.IntPtr NativeFieldInfoPtr__MaxPacketId;

	private static readonly System.IntPtr NativeFieldInfoPtr__packetHandlers;

	private static readonly System.IntPtr NativeFieldInfoPtr__sendBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_NetworkCrypt;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ClientPacketSent_Public_Static_add_Void_Action_3_ClientPacket_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ClientPacketSent_Public_Static_rem_Void_Action_3_ClientPacket_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ServerPacketReceived_Public_Static_add_Void_Action_4_ServerPacket_Byte_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ServerPacketReceived_Public_Static_rem_Void_Action_4_ServerPacket_Byte_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_StatusChanged_Public_Static_add_Void_Action_2_Status_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_StatusChanged_Public_Static_rem_Void_Action_2_Status_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectStatus_Public_get_Status_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ConnectStatus_Private_set_Void_Status_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WebsocketMessage_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_WebsocketMessage_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OfflineMode_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OfflineMode_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WebsocketErrorOnException_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_WebsocketErrorOnException_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedGameServer_Public_get_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedGameServer_Private_set_Void_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStatus_Private_Void_Status_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendPacket_Public_Void_ClientPacket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPacket_Public_Void_Int32_ServerPacket_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketOpen_Private_Void_WebSocket_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMessage_Private_Void_WebSocket_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketClosed_Private_Void_WebSocket_UInt16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWebsocketError_Private_Void_WebSocket_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectFromServer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectToServer_Public_Void_GameServerInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendClientPacket_Public_Static_Void_ClientPacket_0;

	public unsafe static int ProtocolVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProtocolVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProtocolVersion, (void*)(&num));
		}
	}

	public unsafe static Il2CppSystem.Action<ClientPacket, byte, int> ClientPacketSent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClientPacketSent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ClientPacket, byte, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClientPacketSent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static Il2CppSystem.Action<ServerPacket, byte, short, int> ServerPacketReceived
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ServerPacketReceived, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ServerPacket, byte, short, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ServerPacketReceived, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static Il2CppSystem.Action<Status, string> StatusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StatusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Status, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StatusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Status _ConnectStatus_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectStatus_k__BackingField);
			return *(Status*)num;
		}
		set
		{
			*(Status*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ConnectStatus_k__BackingField)) = status;
		}
	}

	public unsafe string _WebsocketMessage_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WebsocketMessage_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WebsocketMessage_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool _OfflineMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OfflineMode_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OfflineMode_k__BackingField)) = flag;
		}
	}

	public unsafe bool LogClientPackets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogClientPackets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogClientPackets)) = flag;
		}
	}

	public unsafe bool LogServerPackets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogServerPackets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LogServerPackets)) = flag;
		}
	}

	public unsafe bool _WebsocketErrorOnException_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WebsocketErrorOnException_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WebsocketErrorOnException_k__BackingField)) = flag;
		}
	}

	public unsafe GameServerInfo _SelectedGameServer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedGameServer_k__BackingField);
			return new GameServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedGameServer_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameServerInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe static int _MaxPacketId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MaxPacketId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MaxPacketId, (void*)(&num));
		}
	}

	public unsafe Il2CppReferenceArray<ServerPacket> _packetHandlers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__packetHandlers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServerPacket>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__packetHandlers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> _sendBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sendBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static GamePacketHandler _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GamePacketHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gamePacketHandler));
		}
	}

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

	public unsafe Status ConnectStatus
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10812, RefRangeEnd = 10818, XrefRangeStart = 10812, XrefRangeEnd = 10812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConnectStatus_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ConnectStatus_Private_set_Void_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string WebsocketMessage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656, RefRangeEnd = 658, XrefRangeStart = 656, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WebsocketMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 10818, RefRangeEnd = 10896, XrefRangeStart = 10818, XrefRangeEnd = 10818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_WebsocketMessage_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool OfflineMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OfflineMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OfflineMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool WebsocketErrorOnException
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WebsocketErrorOnException_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_WebsocketErrorOnException_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GameServerInfo SelectedGameServer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelectedGameServer_Public_get_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GameServerInfo(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelectedGameServer_Private_set_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GamePacketHandler()
	{
		Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking", "GamePacketHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr);
		NativeFieldInfoPtr_ProtocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "ProtocolVersion");
		NativeFieldInfoPtr_ClientPacketSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "ClientPacketSent");
		NativeFieldInfoPtr_ServerPacketReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "ServerPacketReceived");
		NativeFieldInfoPtr_StatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "StatusChanged");
		NativeFieldInfoPtr__ConnectStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "<ConnectStatus>k__BackingField");
		NativeFieldInfoPtr__WebsocketMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "<WebsocketMessage>k__BackingField");
		NativeFieldInfoPtr__OfflineMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "<OfflineMode>k__BackingField");
		NativeFieldInfoPtr_LogClientPackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "LogClientPackets");
		NativeFieldInfoPtr_LogServerPackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "LogServerPackets");
		NativeFieldInfoPtr__WebsocketErrorOnException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "<WebsocketErrorOnException>k__BackingField");
		NativeFieldInfoPtr__SelectedGameServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "<SelectedGameServer>k__BackingField");
		NativeFieldInfoPtr__webSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "_webSocket");
		NativeFieldInfoPtr__MaxPacketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "_MaxPacketId");
		NativeFieldInfoPtr__packetHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "_packetHandlers");
		NativeFieldInfoPtr__sendBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "_sendBuffer");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_NetworkCrypt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, "NetworkCrypt");
		NativeMethodInfoPtr_add_ClientPacketSent_Public_Static_add_Void_Action_3_ClientPacket_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_remove_ClientPacketSent_Public_Static_rem_Void_Action_3_ClientPacket_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_add_ServerPacketReceived_Public_Static_add_Void_Action_4_ServerPacket_Byte_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_remove_ServerPacketReceived_Public_Static_rem_Void_Action_4_ServerPacket_Byte_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_add_StatusChanged_Public_Static_add_Void_Action_2_Status_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_remove_StatusChanged_Public_Static_rem_Void_Action_2_Status_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_get_ConnectStatus_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_set_ConnectStatus_Private_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_get_WebsocketMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_set_WebsocketMessage_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_get_OfflineMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_set_OfflineMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_get_WebsocketErrorOnException_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr_set_WebsocketErrorOnException_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_get_SelectedGameServer_Public_get_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_set_SelectedGameServer_Private_set_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_SetStatus_Private_Void_Status_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_SendPacket_Public_Void_ClientPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_RegisterPacket_Public_Void_Int32_ServerPacket_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_OnWebsocketOpen_Private_Void_WebSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_OnBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_OnMessage_Private_Void_WebSocket_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_OnWebsocketClosed_Private_Void_WebSocket_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_OnWebsocketError_Private_Void_WebSocket_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_DisconnectFromServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_ConnectToServer_Public_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_SendClientPacket_Public_Static_Void_ClientPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr, 100664269);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10718, XrefRangeEnd = 10733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ClientPacketSent(Il2CppSystem.Action<ClientPacket, byte, int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ClientPacketSent_Public_Static_add_Void_Action_3_ClientPacket_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10733, XrefRangeEnd = 10748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ClientPacketSent(Il2CppSystem.Action<ClientPacket, byte, int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ClientPacketSent_Public_Static_rem_Void_Action_3_ClientPacket_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10748, XrefRangeEnd = 10763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ServerPacketReceived(Il2CppSystem.Action<ServerPacket, byte, short, int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ServerPacketReceived_Public_Static_add_Void_Action_4_ServerPacket_Byte_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10763, XrefRangeEnd = 10778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ServerPacketReceived(Il2CppSystem.Action<ServerPacket, byte, short, int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ServerPacketReceived_Public_Static_rem_Void_Action_4_ServerPacket_Byte_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 10793, RefRangeEnd = 10795, XrefRangeStart = 10778, XrefRangeEnd = 10793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_StatusChanged(Il2CppSystem.Action<Status, string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_StatusChanged_Public_Static_add_Void_Action_2_Status_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 10810, RefRangeEnd = 10812, XrefRangeStart = 10795, XrefRangeEnd = 10810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_StatusChanged(Il2CppSystem.Action<Status, string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_StatusChanged_Public_Static_rem_Void_Action_2_Status_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 10900, RefRangeEnd = 10905, XrefRangeStart = 10896, XrefRangeEnd = 10900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStatus(Status status, string message = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&status);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStatus_Private_Void_Status_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10920, RefRangeEnd = 10921, XrefRangeStart = 10905, XrefRangeEnd = 10920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamePacketHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamePacketHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 10941, RefRangeEnd = 10947, XrefRangeStart = 10921, XrefRangeEnd = 10941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendPacket(ClientPacket packet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)packet);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendPacket_Public_Void_ClientPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(142)]
	[CachedScanResults(RefRangeStart = 10951, RefRangeEnd = 11093, XrefRangeStart = 10947, XrefRangeEnd = 10951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterPacket(int opcode, ServerPacket packet, bool print = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&opcode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)packet);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &print;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterPacket_Public_Void_Int32_ServerPacket_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11093, XrefRangeEnd = 11103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11103, XrefRangeEnd = 11159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBinaryMessage(WebSocket webSocket, Il2CppStructArray<byte> message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBinaryMessage_Private_Void_WebSocket_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMessage(WebSocket webSocket, string mesage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)webSocket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mesage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMessage_Private_Void_WebSocket_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11159, XrefRangeEnd = 11167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11167, XrefRangeEnd = 11168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11229, RefRangeEnd = 11231, XrefRangeStart = 11168, XrefRangeEnd = 11229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisconnectFromServer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisconnectFromServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11231, XrefRangeEnd = 11284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectToServer(GameServerInfo serverInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serverInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectToServer_Public_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(122)]
	[CachedScanResults(RefRangeStart = 11289, RefRangeEnd = 11411, XrefRangeStart = 11284, XrefRangeEnd = 11289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendClientPacket(ClientPacket packet)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)packet);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendClientPacket_Public_Static_Void_ClientPacket_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GamePacketHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
