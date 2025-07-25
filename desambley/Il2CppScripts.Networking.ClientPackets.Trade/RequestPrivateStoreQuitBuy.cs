using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Trade;

public class RequestPrivateStoreQuitBuy : ClientPacket
{
	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RequestPrivateStoreQuitBuy()
	{
		Il2CppClassPointerStore<RequestPrivateStoreQuitBuy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Trade", "RequestPrivateStoreQuitBuy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPrivateStoreQuitBuy>.NativeClassPtr);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPrivateStoreQuitBuy>.NativeClassPtr, 100664877);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPrivateStoreQuitBuy>.NativeClassPtr, 100664878);
	}

	[CallerCount(0)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestPrivateStoreQuitBuy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestPrivateStoreQuitBuy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestPrivateStoreQuitBuy(IntPtr pointer)
		: base(pointer)
	{
	}
}
