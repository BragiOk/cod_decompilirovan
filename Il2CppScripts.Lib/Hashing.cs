using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public static class Hashing : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash_Public_Static_Int32_Il2CppStructArray_1_Byte_Nullable_1_Int32_0;

	static Hashing()
	{
		Il2CppClassPointerStore<Hashing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "Hashing");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashing>.NativeClassPtr);
		NativeMethodInfoPtr_ComputeHash_Public_Static_Int32_Il2CppStructArray_1_Byte_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashing>.NativeClassPtr, 100665428);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22270, RefRangeEnd = 22272, XrefRangeStart = 22264, XrefRangeEnd = 22270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ComputeHash(Il2CppStructArray<byte> data, Il2CppSystem.Nullable<int> max = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)max));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHash_Public_Static_Int32_Il2CppStructArray_1_Byte_Nullable_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Hashing(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
