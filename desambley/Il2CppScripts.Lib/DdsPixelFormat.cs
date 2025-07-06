using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public sealed class DdsPixelFormat : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFourCC;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwRGBBitCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwRBitMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwGBitMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwBBitMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwABitMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_DdsPixelFormat_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsPixelFormat_0;

	public unsafe int dwSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize)) = num;
		}
	}

	public unsafe int dwFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags)) = num;
		}
	}

	public unsafe string dwFourCC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFourCC);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFourCC)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int dwRGBBitCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwRGBBitCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwRGBBitCount)) = num;
		}
	}

	public unsafe int dwRBitMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwRBitMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwRBitMask)) = num;
		}
	}

	public unsafe int dwGBitMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwGBitMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwGBitMask)) = num;
		}
	}

	public unsafe int dwBBitMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwBBitMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwBBitMask)) = num;
		}
	}

	public unsafe int dwABitMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwABitMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwABitMask)) = num;
		}
	}

	static DdsPixelFormat()
	{
		Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "DdsPixelFormat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr);
		NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwSize");
		NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwFlags");
		NativeFieldInfoPtr_dwFourCC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwFourCC");
		NativeFieldInfoPtr_dwRGBBitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwRGBBitCount");
		NativeFieldInfoPtr_dwRBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwRBitMask");
		NativeFieldInfoPtr_dwGBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwGBitMask");
		NativeFieldInfoPtr_dwBBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwBBitMask");
		NativeFieldInfoPtr_dwABitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, "dwABitMask");
		NativeMethodInfoPtr_Deserialize_Public_Static_DdsPixelFormat_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsPixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, 100665350);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21959, XrefRangeEnd = 21968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DdsPixelFormat Deserialize(BinaryMsgRead reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Static_DdsPixelFormat_BinaryMsgRead_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DdsPixelFormat(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21968, XrefRangeEnd = 21979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Serialize(BinaryMsgWrite writer, DdsPixelFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsPixelFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DdsPixelFormat(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DdsPixelFormat()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr))
	{
	}
}
