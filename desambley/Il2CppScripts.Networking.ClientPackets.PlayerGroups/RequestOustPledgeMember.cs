using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.PlayerGroups;

public class RequestOustPledgeMember : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__target;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe string _target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__target);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__target)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RequestOustPledgeMember()
	{
		Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.PlayerGroups", "RequestOustPledgeMember");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr);
		NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr, "_target");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr, 100664943);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr, 100664944);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 17179, RefRangeEnd = 17205, XrefRangeStart = 17179, XrefRangeEnd = 17205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestOustPledgeMember(string target)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestOustPledgeMember>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17324, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestOustPledgeMember(IntPtr pointer)
		: base(pointer)
	{
	}
}
