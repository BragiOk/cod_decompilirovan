using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScripts.Extensions.ArrayExtensions;

public static class ArrayExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ForEach_Public_Static_Void_Array_Action_2_Array_Il2CppStructArray_1_Int32_0;

	static ArrayExtensions()
	{
		Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Extensions.ArrayExtensions", "ArrayExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_ForEach_Public_Static_Void_Array_Action_2_Array_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayExtensions>.NativeClassPtr, 100668766);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53668, RefRangeEnd = 53669, XrefRangeStart = 53662, XrefRangeEnd = 53668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForEach(this Il2CppSystem.Array array, Il2CppSystem.Action<Il2CppSystem.Array, Il2CppStructArray<int>> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForEach_Public_Static_Void_Array_Action_2_Array_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ArrayExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
