using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

[StructLayout(LayoutKind.Explicit)]
public struct BitmapInfoHeader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_nColorPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_nBitsPerPixel;

	private static readonly System.IntPtr NativeFieldInfoPtr_compressionMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr_rawImageSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_xPPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_nPaletteColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_nImportantColors;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_absWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_absHeight_Public_get_Int32_0;

	[FieldOffset(0)]
	public uint size;

	[FieldOffset(4)]
	public int width;

	[FieldOffset(8)]
	public int height;

	[FieldOffset(12)]
	public ushort nColorPlanes;

	[FieldOffset(14)]
	public ushort nBitsPerPixel;

	[FieldOffset(16)]
	public BMPComressionMode compressionMethod;

	[FieldOffset(20)]
	public uint rawImageSize;

	[FieldOffset(24)]
	public int xPPM;

	[FieldOffset(28)]
	public int yPPM;

	[FieldOffset(32)]
	public uint nPaletteColors;

	[FieldOffset(36)]
	public uint nImportantColors;

	public unsafe int absWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21589, XrefRangeEnd = 21592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_absWidth_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int absHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21592, XrefRangeEnd = 21595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_absHeight_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BitmapInfoHeader()
	{
		Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "BitmapInfoHeader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr);
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "size");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "height");
		NativeFieldInfoPtr_nColorPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "nColorPlanes");
		NativeFieldInfoPtr_nBitsPerPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "nBitsPerPixel");
		NativeFieldInfoPtr_compressionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "compressionMethod");
		NativeFieldInfoPtr_rawImageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "rawImageSize");
		NativeFieldInfoPtr_xPPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "xPPM");
		NativeFieldInfoPtr_yPPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "yPPM");
		NativeFieldInfoPtr_nPaletteColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "nPaletteColors");
		NativeFieldInfoPtr_nImportantColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, "nImportantColors");
		NativeMethodInfoPtr_get_absWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr_get_absHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, 100665308);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitmapInfoHeader>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
