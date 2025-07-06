using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ShortCut
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillLevel;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ShortCut_0;

	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public ShortCutType Type;

	[FieldOffset(8)]
	public int SkillLevel;

	static ShortCut()
	{
		Il2CppClassPointerStore<ShortCut>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes", "ShortCut");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortCut>.NativeClassPtr);
		NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCut>.NativeClassPtr, "Id");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCut>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_SkillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortCut>.NativeClassPtr, "SkillLevel");
		NativeMethodInfoPtr_Equals_Public_Boolean_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortCut>.NativeClassPtr, 100668466);
	}

	[CallerCount(0)]
	public unsafe bool Equals(ShortCut other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_ShortCut_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortCut>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
