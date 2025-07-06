using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Common;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Range
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Min;

	private static readonly System.IntPtr NativeFieldInfoPtr_Max;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Range_Range_Single_0;

	[FieldOffset(0)]
	public float Min;

	[FieldOffset(4)]
	public float Max;

	static Range()
	{
		Il2CppClassPointerStore<Range>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Common", "Range");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Range>.NativeClassPtr);
		NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Range>.NativeClassPtr, "Min");
		NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Range>.NativeClassPtr, "Max");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100669346);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Range_Range_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Range>.NativeClassPtr, 100669347);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 18656, RefRangeEnd = 18662, XrefRangeStart = 18656, XrefRangeEnd = 18662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Range(float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Range operator *(Range range, float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&range);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Range_Range_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Range*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Range>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
