using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.PlayerGroups;

public class RequestPledgeReorganizeMember : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__memberName;

	private static readonly IntPtr NativeFieldInfoPtr__newPledgeType;

	private static readonly IntPtr NativeFieldInfoPtr__anotherMemberName;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe string _memberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__memberName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__memberName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _newPledgeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newPledgeType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newPledgeType)) = num;
		}
	}

	public unsafe string _anotherMemberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__anotherMemberName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__anotherMemberName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RequestPledgeReorganizeMember()
	{
		Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.PlayerGroups", "RequestPledgeReorganizeMember");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr);
		NativeFieldInfoPtr__memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr, "_memberName");
		NativeFieldInfoPtr__newPledgeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr, "_newPledgeType");
		NativeFieldInfoPtr__anotherMemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr, "_anotherMemberName");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr, 100664956);
	}

	[CallerCount(0)]
	public unsafe RequestPledgeReorganizeMember(string memberName, int newPledgeType, string anotherMemberName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestPledgeReorganizeMember>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &newPledgeType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(anotherMemberName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17341, XrefRangeEnd = 17348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestPledgeReorganizeMember(IntPtr pointer)
		: base(pointer)
	{
	}
}
