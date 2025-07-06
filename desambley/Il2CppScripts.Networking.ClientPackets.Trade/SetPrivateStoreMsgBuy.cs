using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Trade;

public class SetPrivateStoreMsgBuy : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__message;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe string _message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__message);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__message)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SetPrivateStoreMsgBuy()
	{
		Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Trade", "SetPrivateStoreMsgBuy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr);
		NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr, "_message");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr, 100664887);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr, 100664888);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 17179, RefRangeEnd = 17205, XrefRangeStart = 17179, XrefRangeEnd = 17179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetPrivateStoreMsgBuy(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPrivateStoreMsgBuy>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17205, XrefRangeEnd = 17208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SetPrivateStoreMsgBuy(IntPtr pointer)
		: base(pointer)
	{
	}
}
