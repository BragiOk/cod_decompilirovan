using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Interfaces;
using Il2CppSystem;

namespace Il2CppScripts.Networking;

public static class PacketHelpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameEntity_Public_Static_IGameEntity_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ServerFailReasonToString_Public_Static_String_ServerFailReason_0;

	static PacketHelpers()
	{
		Il2CppClassPointerStore<PacketHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking", "PacketHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_GetGameEntity_Public_Static_IGameEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketHelpers>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_ServerFailReasonToString_Public_Static_String_ServerFailReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketHelpers>.NativeClassPtr, 100664315);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11838, XrefRangeEnd = 11851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IGameEntity GetGameEntity(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameEntity_Public_Static_IGameEntity_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameEntity>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11851, XrefRangeEnd = 11867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ServerFailReasonToString(ServerFailReason serverFailReason)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&serverFailReason);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ServerFailReasonToString_Public_Static_String_ServerFailReason_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public PacketHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
