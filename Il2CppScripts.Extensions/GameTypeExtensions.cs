using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.GameTypes.Skill;
using Il2CppScripts.Tables;
using Il2CppSystem;

namespace Il2CppScripts.Extensions;

public static class GameTypeExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemEntry_Public_Static_ItemEntry_ItemState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_MagicEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_SkillInstance_0;

	static GameTypeExtensions()
	{
		Il2CppClassPointerStore<GameTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Extensions", "GameTypeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTypeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetItemEntry_Public_Static_ItemEntry_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTypeExtensions>.NativeClassPtr, 100668626);
		NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_MagicEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTypeExtensions>.NativeClassPtr, 100668627);
		NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_SkillInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameTypeExtensions>.NativeClassPtr, 100668628);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 52616, RefRangeEnd = 52621, XrefRangeStart = 52611, XrefRangeEnd = 52616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ItemEntry GetItemEntry(this ItemState itemState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemEntry_Public_Static_ItemEntry_ItemState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemEntry>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52621, XrefRangeEnd = 52623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkillEntry GetSkillEntry(this MagicEffect magicEffect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&magicEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_MagicEffect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillEntry>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52623, XrefRangeEnd = 52625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SkillEntry GetSkillEntry(this SkillInstance skillInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillEntry_Public_Static_SkillEntry_SkillInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillEntry>(intPtr) : null;
	}

	public GameTypeExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
