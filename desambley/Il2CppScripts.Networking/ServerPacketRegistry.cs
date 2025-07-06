using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.Networking;

public static class ServerPacketRegistry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterServerPackets_Public_Static_Void_GamePacketHandler_0;

	static ServerPacketRegistry()
	{
		Il2CppClassPointerStore<ServerPacketRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking", "ServerPacketRegistry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerPacketRegistry>.NativeClassPtr);
		NativeMethodInfoPtr_RegisterServerPackets_Public_Static_Void_GamePacketHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerPacketRegistry>.NativeClassPtr, 100664323);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12740, RefRangeEnd = 12741, XrefRangeStart = 11874, XrefRangeEnd = 12740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterServerPackets(this GamePacketHandler p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterServerPackets_Public_Static_Void_GamePacketHandler_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ServerPacketRegistry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
