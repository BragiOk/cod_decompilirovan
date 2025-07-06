using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.CharacterSystem;
using Il2CppScripts.Common;
using Il2CppScripts.GameTypes.Character;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Networking.ServerPackets.Basics;

public class _CharacterPacketBase : ServerPacket
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAppearance_Protected_CharacterAppearance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMobilityStatus_Protected_MobilityStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadNameTitle_Protected_ValueTuple_2_ColorText_ColorText_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPaperdoll_Protected_Paperdoll_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateCharacter_Protected_Character_Int32_Boolean_Int32_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static _CharacterPacketBase()
	{
		Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.Basics", "_CharacterPacketBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr);
		NativeMethodInfoPtr_ReadAppearance_Protected_CharacterAppearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664830);
		NativeMethodInfoPtr_ReadMobilityStatus_Protected_MobilityStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664831);
		NativeMethodInfoPtr_ReadNameTitle_Protected_ValueTuple_2_ColorText_ColorText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664832);
		NativeMethodInfoPtr_ReadPaperdoll_Protected_Paperdoll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664833);
		NativeMethodInfoPtr_GetOrCreateCharacter_Protected_Character_Int32_Boolean_Int32_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664834);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr, 100664835);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16903, XrefRangeEnd = 16909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterAppearance ReadAppearance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAppearance_Protected_CharacterAppearance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CharacterAppearance*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16912, RefRangeEnd = 16915, XrefRangeStart = 16909, XrefRangeEnd = 16912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobilityStatus ReadMobilityStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMobilityStatus_Protected_MobilityStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(MobilityStatus*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16920, RefRangeEnd = 16923, XrefRangeStart = 16915, XrefRangeEnd = 16920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<ColorText, ColorText> ReadNameTitle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadNameTitle_Protected_ValueTuple_2_ColorText_ColorText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<ColorText, ColorText>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16931, RefRangeEnd = 16933, XrefRangeStart = 16923, XrefRangeEnd = 16931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppScripts.GameTypes.Character.Paperdoll ReadPaperdoll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPaperdoll_Protected_Paperdoll_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScripts.GameTypes.Character.Paperdoll>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16933, XrefRangeEnd = 16948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Character GetOrCreateCharacter(int id, bool isPlayer, int modelId, Vector3 location, float rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlayer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &modelId;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateCharacter_Protected_Character_Int32_Boolean_Int32_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe _CharacterPacketBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_CharacterPacketBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public _CharacterPacketBase(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
