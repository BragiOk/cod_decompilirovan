using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes.Character;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct PaperdollSlot
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Enchant;

	private static readonly System.IntPtr NativeFieldInfoPtr_Augment;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0;

	[FieldOffset(0)]
	public int ObjectID;

	[FieldOffset(4)]
	public int ItemID;

	[FieldOffset(8)]
	public int Enchant;

	[FieldOffset(12)]
	public int Augment;

	static PaperdollSlot()
	{
		Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "PaperdollSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr);
		NativeFieldInfoPtr_ObjectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, "ObjectID");
		NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, "ItemID");
		NativeFieldInfoPtr_Enchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, "Enchant");
		NativeFieldInfoPtr_Augment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, "Augment");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, 100668479);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, 100668480);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, 100668481);
	}

	[CallerCount(0)]
	public unsafe PaperdollSlot(int itemId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(PaperdollSlot a, PaperdollSlot b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(PaperdollSlot**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(PaperdollSlot a, PaperdollSlot b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(PaperdollSlot**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaperdollSlot_PaperdollSlot_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaperdollSlot>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
