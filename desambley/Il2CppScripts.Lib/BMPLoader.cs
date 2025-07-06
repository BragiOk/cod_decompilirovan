using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnityEngine;

namespace Il2CppScripts.Lib;

public class BMPLoader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAGIC;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReadPaletteAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceAlphaReadWhenPossible;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBMP_Public_BMPImage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadBMP_Public_BMPImage_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read32BitImage_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read24BitImage_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read16BitImage_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadIndexedImage_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadIndexedImageRLE4_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadIndexedImageRLE8_Private_Static_Void_BinaryReader_BMPImage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShiftCount_Private_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMask_Private_Static_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFileHeader_Private_Static_Boolean_BinaryReader_byref_BMPFileHeader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInfoHeader_Private_Static_Boolean_BinaryReader_byref_BitmapInfoHeader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPalette_Public_Static_List_1_Color32_BinaryReader_BMPImage_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ushort MAGIC
	{
		get
		{
			Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAGIC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAGIC, (void*)(&num));
		}
	}

	public unsafe bool ReadPaletteAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadPaletteAlpha);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReadPaletteAlpha)) = flag;
		}
	}

	public unsafe bool ForceAlphaReadWhenPossible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceAlphaReadWhenPossible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceAlphaReadWhenPossible)) = flag;
		}
	}

	static BMPLoader()
	{
		Il2CppClassPointerStore<BMPLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "BMPLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr);
		NativeFieldInfoPtr_MAGIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, "MAGIC");
		NativeFieldInfoPtr_ReadPaletteAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, "ReadPaletteAlpha");
		NativeFieldInfoPtr_ForceAlphaReadWhenPossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, "ForceAlphaReadWhenPossible");
		NativeMethodInfoPtr_LoadBMP_Public_BMPImage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665315);
		NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665316);
		NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665317);
		NativeMethodInfoPtr_LoadBMP_Public_BMPImage_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665318);
		NativeMethodInfoPtr_Read32BitImage_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665319);
		NativeMethodInfoPtr_Read24BitImage_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr_Read16BitImage_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665321);
		NativeMethodInfoPtr_ReadIndexedImage_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr_ReadIndexedImageRLE4_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr_ReadIndexedImageRLE8_Private_Static_Void_BinaryReader_BMPImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665324);
		NativeMethodInfoPtr_GetShiftCount_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665325);
		NativeMethodInfoPtr_GetMask_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr_ReadFileHeader_Private_Static_Boolean_BinaryReader_byref_BMPFileHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665327);
		NativeMethodInfoPtr_ReadInfoHeader_Private_Static_Boolean_BinaryReader_byref_BitmapInfoHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665328);
		NativeMethodInfoPtr_ReadPalette_Public_Static_List_1_Color32_BinaryReader_BMPImage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665329);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr, 100665330);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21619, XrefRangeEnd = 21627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMPImage LoadBMP(string aFileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(aFileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBMP_Public_BMPImage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BMPImage>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21638, RefRangeEnd = 21639, XrefRangeStart = 21627, XrefRangeEnd = 21638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMPImage LoadBMP(Il2CppStructArray<byte> aData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BMPImage>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21650, RefRangeEnd = 21652, XrefRangeStart = 21639, XrefRangeEnd = 21650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMPImage LoadBMP(Stream aData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBMP_Public_BMPImage_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BMPImage>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21670, RefRangeEnd = 21671, XrefRangeStart = 21652, XrefRangeEnd = 21670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMPImage LoadBMP(BinaryReader aReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadBMP_Public_BMPImage_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BMPImage>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21671, XrefRangeEnd = 21688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Read32BitImage(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read32BitImage_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21688, XrefRangeEnd = 21703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Read24BitImage(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read24BitImage_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21703, XrefRangeEnd = 21718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Read16BitImage(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read16BitImage_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21718, XrefRangeEnd = 21745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadIndexedImage(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadIndexedImage_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21745, XrefRangeEnd = 21765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadIndexedImageRLE4(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadIndexedImageRLE4_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21765, XrefRangeEnd = 21781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadIndexedImageRLE8(BinaryReader aReader, BMPImage bmp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadIndexedImageRLE8_Private_Static_Void_BinaryReader_BMPImage_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetShiftCount(uint mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShiftCount_Private_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static uint GetMask(int bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMask_Private_Static_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool ReadFileHeader(BinaryReader aReader, ref BMPFileHeader aFileHeader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aFileHeader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFileHeader_Private_Static_Boolean_BinaryReader_byref_BMPFileHeader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21781, RefRangeEnd = 21782, XrefRangeStart = 21781, XrefRangeEnd = 21781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadInfoHeader(BinaryReader aReader, ref BitmapInfoHeader aHeader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aHeader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadInfoHeader_Private_Static_Boolean_BinaryReader_byref_BitmapInfoHeader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21782, XrefRangeEnd = 21790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Color32> ReadPalette(BinaryReader aReader, BMPImage aBmp, bool aReadAlpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aBmp);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &aReadAlpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPalette_Public_Static_List_1_Color32_BinaryReader_BMPImage_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BMPLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BMPLoader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BMPLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
