using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Basics;

public class RequestTargetCanceld : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr_clearTarget;

	private static readonly IntPtr NativeFieldInfoPtr__preventOfflineCall;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0;

	public unsafe bool clearTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTarget)) = flag;
		}
	}

	public unsafe static bool _preventOfflineCall
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__preventOfflineCall, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__preventOfflineCall, (void*)(&flag));
		}
	}

	static RequestTargetCanceld()
	{
		Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Basics", "RequestTargetCanceld");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr);
		NativeFieldInfoPtr_clearTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr, "clearTarget");
		NativeFieldInfoPtr__preventOfflineCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr, "_preventOfflineCall");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr, 100665041);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr, 100665043);
	}

	[CallerCount(0)]
	public unsafe RequestTargetCanceld(bool clearTarget)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestTargetCanceld>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&clearTarget);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17645, XrefRangeEnd = 17648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17648, XrefRangeEnd = 17654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DoOfflineAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestTargetCanceld(IntPtr pointer)
		: base(pointer)
	{
	}
}
