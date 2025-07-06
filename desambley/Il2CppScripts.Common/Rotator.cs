using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Common;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Rotator
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Pitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_Yaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_Roll;

	[FieldOffset(0)]
	public float Pitch;

	[FieldOffset(4)]
	public float Yaw;

	[FieldOffset(8)]
	public float Roll;

	static Rotator()
	{
		Il2CppClassPointerStore<Rotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Common", "Rotator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotator>.NativeClassPtr);
		NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotator>.NativeClassPtr, "Pitch");
		NativeFieldInfoPtr_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotator>.NativeClassPtr, "Yaw");
		NativeFieldInfoPtr_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotator>.NativeClassPtr, "Roll");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rotator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
