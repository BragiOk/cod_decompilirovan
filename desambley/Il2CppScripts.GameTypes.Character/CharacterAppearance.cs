using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Character;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct CharacterAppearance
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Race;

	private static readonly System.IntPtr NativeFieldInfoPtr_Sex;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_HairStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_HairColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Face;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseClass;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_CharacterAppearance_0;

	[FieldOffset(0)]
	public int Race;

	[FieldOffset(4)]
	public int Sex;

	[FieldOffset(8)]
	public PlayerModel PlayerModel;

	[FieldOffset(12)]
	public int HairStyle;

	[FieldOffset(16)]
	public int HairColor;

	[FieldOffset(20)]
	public int Face;

	[FieldOffset(24)]
	public int BaseClass;

	static CharacterAppearance()
	{
		Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "CharacterAppearance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr);
		NativeFieldInfoPtr_Race = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "Race");
		NativeFieldInfoPtr_Sex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "Sex");
		NativeFieldInfoPtr_PlayerModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "PlayerModel");
		NativeFieldInfoPtr_HairStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "HairStyle");
		NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "HairColor");
		NativeFieldInfoPtr_Face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "Face");
		NativeFieldInfoPtr_BaseClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, "BaseClass");
		NativeMethodInfoPtr_Equals_Public_Boolean_CharacterAppearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, 100668469);
	}

	[CallerCount(0)]
	public unsafe bool Equals(CharacterAppearance other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_CharacterAppearance_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterAppearance>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
