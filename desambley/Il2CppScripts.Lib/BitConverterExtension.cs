using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public static class BitConverterExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16Swap_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32Swap_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64Swap_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0;

	static BitConverterExtension()
	{
		Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "BitConverterExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr);
		NativeMethodInfoPtr_ToInt16Swap_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr_ToInt32Swap_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr_ToInt64Swap_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665304);
		NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665305);
		NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterExtension>.NativeClassPtr, 100665306);
	}

	[CallerCount(0)]
	public unsafe static short ToInt16Swap(Il2CppStructArray<byte> bytes, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16Swap_Public_Static_Int16_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int ToInt32Swap(Il2CppStructArray<byte> bytes, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32Swap_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static long ToInt64Swap(Il2CppStructArray<byte> bytes, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64Swap_Public_Static_Int64_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytesSwap(Il2CppStructArray<byte> bytes, int offset, short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytesSwap(Il2CppStructArray<byte> bytes, int offset, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytesSwap(Il2CppStructArray<byte> bytes, int offset, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytesSwap_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytes(Il2CppStructArray<byte> bytes, int offset, short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytes(Il2CppStructArray<byte> bytes, int offset, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void TryWriteBytes(Il2CppStructArray<byte> bytes, int offset, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryWriteBytes_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BitConverterExtension(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
