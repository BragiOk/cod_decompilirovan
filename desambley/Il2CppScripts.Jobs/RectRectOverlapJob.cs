using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace Il2CppScripts.Jobs;

public sealed class RectRectOverlapJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Min;

	private static readonly System.IntPtr NativeFieldInfoPtr_Max;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mins;

	private static readonly System.IntPtr NativeFieldInfoPtr_Maxs;

	private static readonly System.IntPtr NativeFieldInfoPtr_Overlap;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe float2 Min
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min);
			return *(float2*)num;
		}
		set
		{
			*(float2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Min)) = @float;
		}
	}

	public unsafe float2 Max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max);
			return *(float2*)num;
		}
		set
		{
			*(float2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Max)) = @float;
		}
	}

	public unsafe NativeArray<float2> Mins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mins);
			return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float2> Maxs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Maxs);
			return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Maxs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<bool> Overlap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overlap);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Overlap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static RectRectOverlapJob()
	{
		Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Jobs", "RectRectOverlapJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr);
		NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, "Min");
		NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, "Max");
		NativeFieldInfoPtr_Mins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, "Mins");
		NativeFieldInfoPtr_Maxs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, "Maxs");
		NativeFieldInfoPtr_Overlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, "Overlap");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr, 100665474);
	}

	[CallerCount(0)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RectRectOverlapJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RectRectOverlapJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectRectOverlapJob>.NativeClassPtr))
	{
	}
}
