using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.UI.Elements.State;
using Il2CppScripts.UI.Widgets;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.PetInterface;

public class PetInterfacePanel : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__primaryPetStats;

	private static readonly IntPtr NativeFieldInfoPtr__primarySummonStats;

	private static readonly IntPtr NativeFieldInfoPtr__secondaryStats;

	private static readonly IntPtr NativeFieldInfoPtr__inventory;

	private static readonly IntPtr NativeFieldInfoPtr__stateChanger;

	private static readonly IntPtr NativeMethodInfoPtr_OnPetPropertiesUpdated_Private_Void_PetProperties_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnItemsUpdated_Private_Void_IReadOnlyList_1_ItemState_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PetPrimaryStatsWidget _primaryPetStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryPetStats);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PetPrimaryStatsWidget>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryPetStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petPrimaryStatsWidget));
		}
	}

	public unsafe PetPrimaryStatsWidget _primarySummonStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primarySummonStats);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PetPrimaryStatsWidget>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primarySummonStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petPrimaryStatsWidget));
		}
	}

	public unsafe PetSecondaryStatsWidget _secondaryStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryStats);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PetSecondaryStatsWidget>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__secondaryStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petSecondaryStatsWidget));
		}
	}

	public unsafe ItemIconList _inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventory);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ItemIconList>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIconList));
		}
	}

	public unsafe UIStateChanger _stateChanger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateChanger);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIStateChanger>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stateChanger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIStateChanger));
		}
	}

	static PetInterfacePanel()
	{
		Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.PetInterface", "PetInterfacePanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr);
		NativeFieldInfoPtr__primaryPetStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, "_primaryPetStats");
		NativeFieldInfoPtr__primarySummonStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, "_primarySummonStats");
		NativeFieldInfoPtr__secondaryStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, "_secondaryStats");
		NativeFieldInfoPtr__inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, "_inventory");
		NativeFieldInfoPtr__stateChanger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, "_stateChanger");
		NativeMethodInfoPtr_OnPetPropertiesUpdated_Private_Void_PetProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, 100667331);
		NativeMethodInfoPtr_OnItemsUpdated_Private_Void_IReadOnlyList_1_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, 100667332);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, 100667333);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr, 100667335);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40667, XrefRangeEnd = 40671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPetPropertiesUpdated(PetProperties petProperties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)petProperties));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPetPropertiesUpdated_Private_Void_PetProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40671, XrefRangeEnd = 40674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemsUpdated(IReadOnlyList<ItemState> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemsUpdated_Private_Void_IReadOnlyList_1_ItemState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40674, XrefRangeEnd = 40695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40695, XrefRangeEnd = 40714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PetInterfacePanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PetInterfacePanel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PetInterfacePanel(IntPtr pointer)
		: base(pointer)
	{
	}
}
