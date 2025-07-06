using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppLibUnity;

public static class BuiltinResources : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Capsule_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Capsule_Public_Static_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Capsule_Private_Static_set_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	public unsafe static Mesh _Capsule_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Capsule_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Capsule_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe static Mesh Capsule
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3941, XrefRangeEnd = 3943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Capsule_Public_Static_get_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3943, XrefRangeEnd = 3946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Capsule_Private_Static_set_Void_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static BuiltinResources()
	{
		Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "LibUnity", "BuiltinResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr);
		NativeFieldInfoPtr__Capsule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr, "<Capsule>k__BackingField");
		NativeMethodInfoPtr_get_Capsule_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_set_Capsule_Private_Static_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinResources>.NativeClassPtr, 100663632);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3946, XrefRangeEnd = 3954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuiltinResources(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
