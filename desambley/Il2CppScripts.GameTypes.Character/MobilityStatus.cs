using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Character;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MobilityStatus
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_WalkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsRunning;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSitting;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsInCombat;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAlikeDead;

	[FieldOffset(0)]
	public int RunSpeed;

	[FieldOffset(4)]
	public int WalkSpeed;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsRunning;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsSitting;

	[FieldOffset(10)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsInCombat;

	[FieldOffset(11)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsAlikeDead;

	static MobilityStatus()
	{
		Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "MobilityStatus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr);
		NativeFieldInfoPtr_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "RunSpeed");
		NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "WalkSpeed");
		NativeFieldInfoPtr_IsRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "IsRunning");
		NativeFieldInfoPtr_IsSitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "IsSitting");
		NativeFieldInfoPtr_IsInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "IsInCombat");
		NativeFieldInfoPtr_IsAlikeDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, "IsAlikeDead");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MobilityStatus>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
