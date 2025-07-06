using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScripts.Services;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Persistent;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Hotkey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Empty;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyMods;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyMods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hotkey_Hotkey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hotkey_Hotkey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPressed_Public_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHeld_Public_Boolean_Boolean_Boolean_0;

	[FieldOffset(0)]
	public KeyCode KeyCode;

	[FieldOffset(4)]
	public KeyMods KeyMods;

	public unsafe static Hotkey Empty
	{
		get
		{
			Unsafe.SkipInit(out Hotkey result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Empty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Empty, (void*)(&hotkey));
		}
	}

	static Hotkey()
	{
		Il2CppClassPointerStore<Hotkey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Persistent", "Hotkey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hotkey>.NativeClassPtr);
		NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, "Empty");
		NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, "KeyCode");
		NativeFieldInfoPtr_KeyMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, "KeyMods");
		NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyMods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665057);
		NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665058);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hotkey_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hotkey_Hotkey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr_IsPressed_Public_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_IsHeld_Public_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, 100665062);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 17684, RefRangeEnd = 17693, XrefRangeStart = 17684, XrefRangeEnd = 17684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hotkey(KeyCode keyCode, KeyMods keyMods = KeyMods.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&keyCode);
		*(KeyMods**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keyMods;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyMods_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Hotkey(Hotkey hotkey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hotkey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Hotkey_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(Hotkey a, Hotkey b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Hotkey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hotkey_Hotkey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(Hotkey a, Hotkey b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Hotkey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hotkey_Hotkey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17706, RefRangeEnd = 17707, XrefRangeStart = 17693, XrefRangeEnd = 17706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPressed(bool allowOtherKeys = false, bool allowOtherKeyMods = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&allowOtherKeys);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeyMods;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPressed_Public_Boolean_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 17720, RefRangeEnd = 17731, XrefRangeStart = 17707, XrefRangeEnd = 17720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHeld(bool allowOtherKeys = false, bool allowOtherKeyMods = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&allowOtherKeys);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOtherKeyMods;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHeld_Public_Boolean_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hotkey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
