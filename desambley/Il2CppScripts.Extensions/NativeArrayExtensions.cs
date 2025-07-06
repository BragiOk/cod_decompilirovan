using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace Il2CppScripts.Extensions;

public static class NativeArrayExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_DisposeSafe_Public_Static_Void_byref_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DisposeSafe_Public_Static_Void_byref_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeSafe_Public_Static_Void_byref_NativeArray_1_T_0;

	static NativeArrayExtensions()
	{
		Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Extensions", "NativeArrayExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_DisposeSafe_Public_Static_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayExtensions>.NativeClassPtr, 100668713);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52978, XrefRangeEnd = 52980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeSafe<T>(this ref NativeArray<T> nativeArray) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativeArray);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DisposeSafe_Public_Static_Void_byref_NativeArray_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NativeArrayExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
