using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Lib;

public static class GeoUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_OverlapPointCapsule_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCapsuleColliderOverlapsPoint_Public_Static_Boolean_CapsuleCollider_Single_Vector3_0;

	static GeoUtility()
	{
		Il2CppClassPointerStore<GeoUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "GeoUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeoUtility>.NativeClassPtr);
		NativeMethodInfoPtr_OverlapPointCapsule_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeoUtility>.NativeClassPtr, 100665426);
		NativeMethodInfoPtr_CheckCapsuleColliderOverlapsPoint_Public_Static_Boolean_CapsuleCollider_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeoUtility>.NativeClassPtr, 100665427);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22246, RefRangeEnd = 22247, XrefRangeStart = 22218, XrefRangeEnd = 22246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OverlapPointCapsule(Vector3 point1, Vector3 point2, float radius, Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&point1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverlapPointCapsule_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22247, XrefRangeEnd = 22264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckCapsuleColliderOverlapsPoint(CapsuleCollider capsule, float pawnRadius, Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capsule);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pawnRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCapsuleColliderOverlapsPoint_Public_Static_Boolean_CapsuleCollider_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GeoUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
