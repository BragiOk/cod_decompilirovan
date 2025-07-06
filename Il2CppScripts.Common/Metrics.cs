using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Common;

public static class Metrics : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ConvSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldSizeX;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldSizeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldOriginX;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldOriginY;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorldOriginOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldPosToSectorIndex_Public_Static_Vector2Int_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToLocalPosition_Public_Static_Vector2_Vector3_Vector2_0;

	public unsafe static float ConvSize
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConvSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConvSize, (void*)(&num));
		}
	}

	public unsafe static float ChunkSize
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChunkSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChunkSize, (void*)(&num));
		}
	}

	public unsafe static int WorldSizeX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldSizeX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldSizeX, (void*)(&num));
		}
	}

	public unsafe static int WorldSizeY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldSizeY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldSizeY, (void*)(&num));
		}
	}

	public unsafe static Vector2 WorldSize
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldSize, (void*)(&vector));
		}
	}

	public unsafe static int WorldOriginX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldOriginX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldOriginX, (void*)(&num));
		}
	}

	public unsafe static int WorldOriginY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldOriginY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldOriginY, (void*)(&num));
		}
	}

	public unsafe static int WorldOffsetX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldOffsetX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldOffsetX, (void*)(&num));
		}
	}

	public unsafe static int WorldOffsetY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldOffsetY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldOffsetY, (void*)(&num));
		}
	}

	public unsafe static Vector2 WorldOriginOffset
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorldOriginOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorldOriginOffset, (void*)(&vector));
		}
	}

	static Metrics()
	{
		Il2CppClassPointerStore<Metrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Common", "Metrics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics>.NativeClassPtr);
		NativeFieldInfoPtr_ConvSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "ConvSize");
		NativeFieldInfoPtr_ChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "ChunkSize");
		NativeFieldInfoPtr_WorldSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldSizeX");
		NativeFieldInfoPtr_WorldSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldSizeY");
		NativeFieldInfoPtr_WorldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldSize");
		NativeFieldInfoPtr_WorldOriginX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldOriginX");
		NativeFieldInfoPtr_WorldOriginY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldOriginY");
		NativeFieldInfoPtr_WorldOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldOffsetX");
		NativeFieldInfoPtr_WorldOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldOffsetY");
		NativeFieldInfoPtr_WorldOriginOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics>.NativeClassPtr, "WorldOriginOffset");
		NativeMethodInfoPtr_WorldPosToSectorIndex_Public_Static_Vector2Int_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics>.NativeClassPtr, 100669343);
		NativeMethodInfoPtr_ConvertToLocalPosition_Public_Static_Vector2_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics>.NativeClassPtr, 100669344);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60805, XrefRangeEnd = 60807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2Int WorldPosToSectorIndex(Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldPosToSectorIndex_Public_Static_Vector2Int_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60807, XrefRangeEnd = 60811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ConvertToLocalPosition(Vector3 position, Vector2 size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToLocalPosition_Public_Static_Vector2_Vector3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Metrics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
