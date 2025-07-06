using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class __JobReflectionRegistrationOutput__1636958993 : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

	static __JobReflectionRegistrationOutput__1636958993()
	{
		Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1636958993>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "", "__JobReflectionRegistrationOutput__1636958993");
		NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1636958993>.NativeClassPtr, 100670209);
		NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1636958993>.NativeClassPtr, 100670210);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70754, RefRangeEnd = 70755, XrefRangeStart = 70658, XrefRangeEnd = 70754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateJobReflectionData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70755, XrefRangeEnd = 70760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EarlyInit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public __JobReflectionRegistrationOutput__1636958993(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
