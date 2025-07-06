using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Paperdoll.Classes;

public static class BoneNames : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerNeckBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLeftHandBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRightHandBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLeftWeaponBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRightWeaponBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLeftShieldBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRightShieldBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerHeadBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcNeckBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcLeftHandBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcRightHandBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcBowBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcSwordBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcShieldBonePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerBonesToExpose;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcBonesToExpose;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Origin_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Head_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftHandBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightHandBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerWeaponLBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerWeaponRBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerShieldLBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerShieldRBoneName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcBowBone_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcSwordBone_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcShieldBone_Public_Static_get_String_0;

	public unsafe static string PlayerNeckBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerNeckBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerNeckBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerLeftHandBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerLeftHandBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerLeftHandBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerRightHandBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerRightHandBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerRightHandBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerLeftWeaponBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerLeftWeaponBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerLeftWeaponBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerRightWeaponBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerRightWeaponBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerRightWeaponBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerLeftShieldBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerLeftShieldBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerLeftShieldBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerRightShieldBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerRightShieldBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerRightShieldBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PlayerHeadBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerHeadBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerHeadBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcNeckBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcNeckBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcNeckBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcLeftHandBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcLeftHandBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcLeftHandBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcRightHandBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcRightHandBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcRightHandBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcBowBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcBowBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcBowBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcSwordBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcSwordBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcSwordBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NpcShieldBonePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcShieldBonePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcShieldBonePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray PlayerBonesToExpose
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerBonesToExpose, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerBonesToExpose, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray NpcBonesToExpose
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcBonesToExpose, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcBonesToExpose, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string Origin
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9688, XrefRangeEnd = 9690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Origin_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string Head
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9690, XrefRangeEnd = 9692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Head_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string LeftHandBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9692, XrefRangeEnd = 9694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeftHandBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string RightHandBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9694, XrefRangeEnd = 9696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightHandBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string PlayerWeaponLBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9696, XrefRangeEnd = 9698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerWeaponLBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string PlayerWeaponRBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9698, XrefRangeEnd = 9700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerWeaponRBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string PlayerShieldLBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9700, XrefRangeEnd = 9702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerShieldLBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string PlayerShieldRBoneName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9702, XrefRangeEnd = 9704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerShieldRBoneName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string NpcBowBone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9704, XrefRangeEnd = 9706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcBowBone_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string NpcSwordBone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9706, XrefRangeEnd = 9708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcSwordBone_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe static string NpcShieldBone
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9708, XrefRangeEnd = 9710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcShieldBone_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static BoneNames()
	{
		Il2CppClassPointerStore<BoneNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll.Classes", "BoneNames");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneNames>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerNeckBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerNeckBonePath");
		NativeFieldInfoPtr_PlayerLeftHandBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerLeftHandBonePath");
		NativeFieldInfoPtr_PlayerRightHandBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerRightHandBonePath");
		NativeFieldInfoPtr_PlayerLeftWeaponBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerLeftWeaponBonePath");
		NativeFieldInfoPtr_PlayerRightWeaponBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerRightWeaponBonePath");
		NativeFieldInfoPtr_PlayerLeftShieldBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerLeftShieldBonePath");
		NativeFieldInfoPtr_PlayerRightShieldBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerRightShieldBonePath");
		NativeFieldInfoPtr_PlayerHeadBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerHeadBonePath");
		NativeFieldInfoPtr_NpcNeckBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcNeckBonePath");
		NativeFieldInfoPtr_NpcLeftHandBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcLeftHandBonePath");
		NativeFieldInfoPtr_NpcRightHandBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcRightHandBonePath");
		NativeFieldInfoPtr_NpcBowBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcBowBonePath");
		NativeFieldInfoPtr_NpcSwordBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcSwordBonePath");
		NativeFieldInfoPtr_NpcShieldBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcShieldBonePath");
		NativeFieldInfoPtr_PlayerBonesToExpose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "PlayerBonesToExpose");
		NativeFieldInfoPtr_NpcBonesToExpose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, "NpcBonesToExpose");
		NativeMethodInfoPtr_get_Origin_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_get_Head_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_get_LeftHandBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_get_RightHandBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_get_PlayerWeaponLBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_get_PlayerWeaponRBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_get_PlayerShieldLBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_get_PlayerShieldRBoneName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_get_NpcBowBone_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_get_NpcSwordBone_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_get_NpcShieldBone_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneNames>.NativeClassPtr, 100664156);
	}

	public BoneNames(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
