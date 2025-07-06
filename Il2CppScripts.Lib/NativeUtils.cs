using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public static class NativeUtils : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct POINT
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		[FieldOffset(0)]
		public int x;

		[FieldOffset(4)]
		public int y;

		static POINT()
		{
			Il2CppClassPointerStore<POINT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr, "POINT");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POINT>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POINT>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POINT>.NativeClassPtr, "y");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POINT>.NativeClassPtr, 100665456);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 17684, RefRangeEnd = 17693, XrefRangeStart = 17684, XrefRangeEnd = 17693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POINT(int x, int y)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<POINT>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorPos_Public_Static_Int64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorPos_Private_Static_Void_POINT_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPosition_Public_Static_Void_byref_Int32_byref_Int32_0;

	static NativeUtils()
	{
		Il2CppClassPointerStore<NativeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "NativeUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr);
		NativeMethodInfoPtr_SetCursorPos_Public_Static_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr, 100665452);
		NativeMethodInfoPtr_SetCursorPos_Private_Static_Void_POINT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr, 100665453);
		NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr, 100665454);
		NativeMethodInfoPtr_GetCursorPosition_Public_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUtils>.NativeClassPtr, 100665455);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22496, RefRangeEnd = 22498, XrefRangeStart = 22494, XrefRangeEnd = 22496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long SetCursorPos(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorPos_Public_Static_Int64_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCursorPos(POINT pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorPos_Private_Static_Void_POINT_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22499, XrefRangeEnd = 22501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetCursorPos(out POINT lpPoint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref lpPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22501, XrefRangeEnd = 22503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCursorPosition(out int x, out int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref x);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPosition_Public_Static_Void_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NativeUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
