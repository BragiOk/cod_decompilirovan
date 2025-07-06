using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Paperdoll.Classes;

public class AnimInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GroupType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeFieldInfoPtr_Infos;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_AnimGroup_AnimFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_AnimFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_AnimInfo_AnimType_0;

	public unsafe AnimGroup GroupType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupType);
			return *(AnimGroup*)num;
		}
		set
		{
			*(AnimGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupType)) = animGroup;
		}
	}

	public unsafe AnimFlags Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags);
			return *(AnimFlags*)num;
		}
		set
		{
			*(AnimFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags)) = animFlags;
		}
	}

	public unsafe static AnimInfo Default
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animInfo));
		}
	}

	public unsafe static Il2CppReferenceArray<AnimInfo> Infos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Infos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Infos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static AnimInfo()
	{
		Il2CppClassPointerStore<AnimInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll.Classes", "AnimInfo");
		NativeFieldInfoPtr_GroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, "GroupType");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, "Flags");
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, "Default");
		NativeFieldInfoPtr_Infos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, "Infos");
		NativeMethodInfoPtr__ctor_Private_Void_AnimGroup_AnimFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_HasFlag_Public_Boolean_AnimFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_Get_Public_Static_AnimInfo_AnimType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr, 100664135);
	}

	[CallerCount(0)]
	public unsafe AnimInfo(AnimGroup groupType, AnimFlags flags = (AnimFlags)0)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&groupType);
		*(AnimFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_AnimGroup_AnimFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasFlag(AnimFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlag_Public_Boolean_AnimFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 9597, RefRangeEnd = 9605, XrefRangeStart = 9591, XrefRangeEnd = 9597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimInfo Get(AnimType animType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_AnimInfo_AnimType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimInfo>(intPtr) : null;
	}

	public AnimInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
