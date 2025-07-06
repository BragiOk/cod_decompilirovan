using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Skill;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct SkillEnchantReq
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_Count;

	[FieldOffset(0)]
	public int Type;

	[FieldOffset(4)]
	public int Id;

	[FieldOffset(8)]
	public int Count;

	static SkillEnchantReq()
	{
		Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Skill", "SkillEnchantReq");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr, "Id");
		NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr, "Count");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkillEnchantReq>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
