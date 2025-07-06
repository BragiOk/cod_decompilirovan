using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.PlayerGroups;

public class RequestChangePartyLeader : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__newLeaderName;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe string _newLeaderName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newLeaderName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newLeaderName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RequestChangePartyLeader()
	{
		Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.PlayerGroups", "RequestChangePartyLeader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr);
		NativeFieldInfoPtr__newLeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr, "_newLeaderName");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr, 100664935);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr, 100664936);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 17179, RefRangeEnd = 17205, XrefRangeStart = 17179, XrefRangeEnd = 17205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestChangePartyLeader(string newLeaderName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestChangePartyLeader>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newLeaderName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17309, XrefRangeEnd = 17313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestChangePartyLeader(IntPtr pointer)
		: base(pointer)
	{
	}
}
