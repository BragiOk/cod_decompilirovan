using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Tables;

[StructLayout(LayoutKind.Explicit)]
public struct AccessoryData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_X;

	private static readonly System.IntPtr NativeFieldInfoPtr_Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z;

	private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_Yaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_Roll;

	[FieldOffset(0)]
	public float X;

	[FieldOffset(4)]
	public float Y;

	[FieldOffset(8)]
	public float Z;

	[FieldOffset(12)]
	public float Pitch;

	[FieldOffset(16)]
	public float Yaw;

	[FieldOffset(20)]
	public float Roll;

	static AccessoryData()
	{
		Il2CppClassPointerStore<AccessoryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "AccessoryData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr);
		NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "X");
		NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "Y");
		NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "Z");
		NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "Pitch");
		NativeFieldInfoPtr_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "Yaw");
		NativeFieldInfoPtr_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, "Roll");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccessoryData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
