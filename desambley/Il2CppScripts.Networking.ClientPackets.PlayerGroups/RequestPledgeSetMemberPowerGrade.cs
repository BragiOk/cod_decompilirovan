using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.PlayerGroups;

public class RequestPledgeSetMemberPowerGrade : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__member;

	private static readonly IntPtr NativeFieldInfoPtr__powerGrade;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe string _member
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__member);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__member)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int _powerGrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__powerGrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__powerGrade)) = num;
		}
	}

	static RequestPledgeSetMemberPowerGrade()
	{
		Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.PlayerGroups", "RequestPledgeSetMemberPowerGrade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr);
		NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr, "_member");
		NativeFieldInfoPtr__powerGrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr, "_powerGrade");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr, 100664957);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr, 100664958);
	}

	[CallerCount(0)]
	public unsafe RequestPledgeSetMemberPowerGrade(string member, int powerGrade)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestPledgeSetMemberPowerGrade>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(member);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &powerGrade;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17348, XrefRangeEnd = 17353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestPledgeSetMemberPowerGrade(IntPtr pointer)
		: base(pointer)
	{
	}
}
