using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Common;
using UnityEngine;

namespace Il2CppScripts.Components;

public class TimeOfDayActivator : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__timeOfDay;

	private static readonly IntPtr NativeFieldInfoPtr__componentsToActivate;

	private static readonly IntPtr NativeMethodInfoPtr_OnTimeOfDayChanged_Private_Void_TimeOfDay_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TimeOfDay _timeOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timeOfDay);
			return *(TimeOfDay*)num;
		}
		set
		{
			*(TimeOfDay*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timeOfDay)) = timeOfDay;
		}
	}

	public unsafe Il2CppReferenceArray<Component> _componentsToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__componentsToActivate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__componentsToActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static TimeOfDayActivator()
	{
		Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components", "TimeOfDayActivator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr);
		NativeFieldInfoPtr__timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, "_timeOfDay");
		NativeFieldInfoPtr__componentsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, "_componentsToActivate");
		NativeMethodInfoPtr_OnTimeOfDayChanged_Private_Void_TimeOfDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, 100669871);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, 100669872);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, 100669873);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr, 100669874);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66786, RefRangeEnd = 66787, XrefRangeStart = 66778, XrefRangeEnd = 66786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTimeOfDayChanged(TimeOfDay timeOfDay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&timeOfDay);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTimeOfDayChanged_Private_Void_TimeOfDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66787, XrefRangeEnd = 66800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66800, XrefRangeEnd = 66810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66810, XrefRangeEnd = 66813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeOfDayActivator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayActivator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TimeOfDayActivator(IntPtr pointer)
		: base(pointer)
	{
	}
}
