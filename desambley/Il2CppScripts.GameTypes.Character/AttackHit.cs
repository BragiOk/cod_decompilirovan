using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Character;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AttackHit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TargetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Damage;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	[FieldOffset(0)]
	public int TargetID;

	[FieldOffset(4)]
	public int Damage;

	[FieldOffset(8)]
	public AttackFlags Flags;

	static AttackHit()
	{
		Il2CppClassPointerStore<AttackHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "AttackHit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackHit>.NativeClassPtr);
		NativeFieldInfoPtr_TargetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackHit>.NativeClassPtr, "TargetID");
		NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackHit>.NativeClassPtr, "Damage");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackHit>.NativeClassPtr, "Flags");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttackHit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
