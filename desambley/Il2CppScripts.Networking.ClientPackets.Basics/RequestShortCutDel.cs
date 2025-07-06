using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Basics;

public class RequestShortCutDel : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__slot;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe int _slot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slot);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__slot)) = num;
		}
	}

	static RequestShortCutDel()
	{
		Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Basics", "RequestShortCutDel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr);
		NativeFieldInfoPtr__slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr, "_slot");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr, 100665036);
	}

	[CallerCount(0)]
	public unsafe RequestShortCutDel(int slot)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestShortCutDel>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17636, XrefRangeEnd = 17639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestShortCutDel(IntPtr pointer)
		: base(pointer)
	{
	}
}
