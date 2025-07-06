using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

public class DdsFile : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_magicNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwMagic;

	private static readonly System.IntPtr NativeFieldInfoPtr_header;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_DdsFile_BinaryMsgRead_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsFile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string magicNumber
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_magicNumber, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_magicNumber, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string dwMagic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwMagic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwMagic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe DdsHeader header
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_header);
			return new DdsHeader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_header), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ddsHeader)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DdsHeader>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<byte> data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static DdsFile()
	{
		Il2CppClassPointerStore<DdsFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "DdsFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DdsFile>.NativeClassPtr);
		NativeFieldInfoPtr_magicNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, "magicNumber");
		NativeFieldInfoPtr_dwMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, "dwMagic");
		NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, "header");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, "data");
		NativeMethodInfoPtr_Deserialize_Public_Static_DdsFile_BinaryMsgRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, 100665353);
		NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, 100665354);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DdsFile>.NativeClassPtr, 100665355);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22044, RefRangeEnd = 22045, XrefRangeStart = 22036, XrefRangeEnd = 22044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DdsFile Deserialize(BinaryMsgRead reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Static_DdsFile_BinaryMsgRead_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DdsFile>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22045, XrefRangeEnd = 22051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Serialize(BinaryMsgWrite writer, DdsFile file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)file);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Static_Void_BinaryMsgWrite_DdsFile_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DdsFile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DdsFile>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DdsFile(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
