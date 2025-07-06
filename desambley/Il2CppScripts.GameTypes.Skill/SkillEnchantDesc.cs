using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Skill;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct SkillEnchantDesc
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SkillId;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Sp;

	private static readonly System.IntPtr NativeFieldInfoPtr_Exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_Chance;

	[FieldOffset(0)]
	public int SkillId;

	[FieldOffset(4)]
	public int NextLevel;

	[FieldOffset(8)]
	public int Sp;

	[FieldOffset(12)]
	public int Exp;

	[FieldOffset(16)]
	public int Chance;

	static SkillEnchantDesc()
	{
		Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Skill", "SkillEnchantDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr);
		NativeFieldInfoPtr_SkillId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, "SkillId");
		NativeFieldInfoPtr_NextLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, "NextLevel");
		NativeFieldInfoPtr_Sp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, "Sp");
		NativeFieldInfoPtr_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, "Exp");
		NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, "Chance");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkillEnchantDesc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
