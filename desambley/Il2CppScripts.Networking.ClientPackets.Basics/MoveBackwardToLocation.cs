using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.Networking.ClientPackets.Basics;

public class MoveBackwardToLocation : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr_location;

	private static readonly IntPtr NativeFieldInfoPtr_byCursor;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0;

	public unsafe Vector3 location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = vector;
		}
	}

	public unsafe bool byCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_byCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_byCursor)) = flag;
		}
	}

	static MoveBackwardToLocation()
	{
		Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Basics", "MoveBackwardToLocation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr);
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr, "location");
		NativeFieldInfoPtr_byCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr, "byCursor");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr, 100665023);
	}

	[CallerCount(0)]
	public unsafe MoveBackwardToLocation(Vector3 location, bool byCursor)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveBackwardToLocation>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&location);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &byCursor;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17603, XrefRangeEnd = 17606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17606, XrefRangeEnd = 17620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DoOfflineAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MoveBackwardToLocation(IntPtr pointer)
		: base(pointer)
	{
	}
}
