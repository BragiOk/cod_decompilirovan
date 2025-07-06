using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Lib;

[StructLayout(LayoutKind.Explicit)]
public struct BMPFileHeader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_magic;

	private static readonly System.IntPtr NativeFieldInfoPtr_filesize;

	private static readonly System.IntPtr NativeFieldInfoPtr_reserved;

	private static readonly System.IntPtr NativeFieldInfoPtr_offset;

	[FieldOffset(0)]
	public ushort magic;

	[FieldOffset(4)]
	public uint filesize;

	[FieldOffset(8)]
	public uint reserved;

	[FieldOffset(12)]
	public uint offset;

	static BMPFileHeader()
	{
		Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "BMPFileHeader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr);
		NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr, "magic");
		NativeFieldInfoPtr_filesize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr, "filesize");
		NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr, "reserved");
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr, "offset");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BMPFileHeader>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
