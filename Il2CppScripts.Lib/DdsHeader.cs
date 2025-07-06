using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public sealed class DdsHeader : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwPitchOrLinearSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwMipMapCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwReserved1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ddspf;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwCaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwCaps2;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwCaps3;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwCaps4;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwReserved2;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_DdsHeader_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsHeader_0;

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

	public unsafe int dwHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwHeight)) = num;
		}
	}

	public unsafe int dwWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwWidth)) = num;
		}
	}

	public unsafe int dwPitchOrLinearSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwPitchOrLinearSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwPitchOrLinearSize)) = num;
		}
	}

	public unsafe int dwDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDepth)) = num;
		}
	}

	public unsafe int dwMipMapCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwMipMapCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwMipMapCount)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> dwReserved1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwReserved1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwReserved1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe DdsPixelFormat ddspf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddspf);
			return new DdsPixelFormat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddspf), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ddsPixelFormat)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DdsPixelFormat>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int dwCaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps)) = num;
		}
	}

	public unsafe int dwCaps2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps2)) = num;
		}
	}

	public unsafe int dwCaps3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps3);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps3)) = num;
		}
	}

	public unsafe int dwCaps4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps4);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwCaps4)) = num;
		}
	}

	public unsafe int dwReserved2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwReserved2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwReserved2)) = num;
		}
	}

	static DdsHeader()
	{
		Il2CppClassPointerStore<DdsHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "DdsHeader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr);
		NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwSize");
		NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwFlags");
		NativeFieldInfoPtr_dwHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwHeight");
		NativeFieldInfoPtr_dwWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwWidth");
		NativeFieldInfoPtr_dwPitchOrLinearSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwPitchOrLinearSize");
		NativeFieldInfoPtr_dwDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwDepth");
		NativeFieldInfoPtr_dwMipMapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwMipMapCount");
		NativeFieldInfoPtr_dwReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwReserved1");
		NativeFieldInfoPtr_ddspf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "ddspf");
		NativeFieldInfoPtr_dwCaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwCaps");
		NativeFieldInfoPtr_dwCaps2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwCaps2");
		NativeFieldInfoPtr_dwCaps3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwCaps3");
		NativeFieldInfoPtr_dwCaps4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwCaps4");
		NativeFieldInfoPtr_dwReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, "dwReserved2");
		NativeMethodInfoPtr_Deserialize_Public_Static_DdsHeader_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, 100665351);
		NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, 100665352);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22008, RefRangeEnd = 22009, XrefRangeStart = 21979, XrefRangeEnd = 22008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DdsHeader Deserialize(BinaryMsgRead reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Static_DdsHeader_BinaryMsgRead_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DdsHeader(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22034, RefRangeEnd = 22036, XrefRangeStart = 22009, XrefRangeEnd = 22034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Serialize(BinaryMsgWrite writer, DdsHeader header)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)header));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsHeader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DdsHeader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DdsHeader()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr))
	{
	}
}
