using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MagicEffect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SkillId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level;

	private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

	[FieldOffset(0)]
	public int SkillId;

	[FieldOffset(4)]
	public int Level;

	[FieldOffset(8)]
	public float Duration;

	[FieldOffset(12)]
	public float EndTime;

	static MagicEffect()
	{
		Il2CppClassPointerStore<MagicEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes", "MagicEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr);
		NativeFieldInfoPtr_SkillId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr, "SkillId");
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr, "Duration");
		NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr, "EndTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MagicEffect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
