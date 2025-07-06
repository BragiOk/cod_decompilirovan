using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AzureSky;

namespace Il2CppScripts.Components;

public class AzureDynamicLightingController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__environmentIntensityBoost;

	private static readonly IntPtr NativeFieldInfoPtr__environmentAmbientColorBoost;

	private static readonly IntPtr NativeFieldInfoPtr__environmentEquatorColorBoost;

	private static readonly IntPtr NativeFieldInfoPtr__environmentGroundColorBoost;

	private static readonly IntPtr NativeFieldInfoPtr__directionalLight;

	private static readonly IntPtr NativeFieldInfoPtr__azureEnvironmentController;

	private static readonly IntPtr NativeFieldInfoPtr__azureWeatherController;

	private static readonly IntPtr NativeFieldInfoPtr__dynamicLightingDisabled;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnableDynamicLightingChanged_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvironmentParameters_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnWeatherProfileEvaluated_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float _environmentIntensityBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentIntensityBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentIntensityBoost)) = num;
		}
	}

	public unsafe Color _environmentAmbientColorBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentAmbientColorBoost);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentAmbientColorBoost)) = color;
		}
	}

	public unsafe Color _environmentEquatorColorBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentEquatorColorBoost);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentEquatorColorBoost)) = color;
		}
	}

	public unsafe Color _environmentGroundColorBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentGroundColorBoost);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__environmentGroundColorBoost)) = color;
		}
	}

	public unsafe Light _directionalLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__directionalLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__directionalLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe AzureEnvironmentController _azureEnvironmentController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__azureEnvironmentController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AzureEnvironmentController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__azureEnvironmentController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)azureEnvironmentController));
		}
	}

	public unsafe AzureWeatherController _azureWeatherController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__azureWeatherController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AzureWeatherController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__azureWeatherController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)azureWeatherController));
		}
	}

	public unsafe bool _dynamicLightingDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dynamicLightingDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dynamicLightingDisabled)) = flag;
		}
	}

	static AzureDynamicLightingController()
	{
		Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components", "AzureDynamicLightingController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr);
		NativeFieldInfoPtr__environmentIntensityBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_environmentIntensityBoost");
		NativeFieldInfoPtr__environmentAmbientColorBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_environmentAmbientColorBoost");
		NativeFieldInfoPtr__environmentEquatorColorBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_environmentEquatorColorBoost");
		NativeFieldInfoPtr__environmentGroundColorBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_environmentGroundColorBoost");
		NativeFieldInfoPtr__directionalLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_directionalLight");
		NativeFieldInfoPtr__azureEnvironmentController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_azureEnvironmentController");
		NativeFieldInfoPtr__azureWeatherController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_azureWeatherController");
		NativeFieldInfoPtr__dynamicLightingDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, "_dynamicLightingDisabled");
		NativeMethodInfoPtr_OnEnableDynamicLightingChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669812);
		NativeMethodInfoPtr_UpdateEnvironmentParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669813);
		NativeMethodInfoPtr_OnWeatherProfileEvaluated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669814);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669815);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669816);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669817);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr, 100669818);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66247, RefRangeEnd = 66248, XrefRangeStart = 66222, XrefRangeEnd = 66247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnableDynamicLightingChanged(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnableDynamicLightingChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 66248, RefRangeEnd = 66250, XrefRangeStart = 66248, XrefRangeEnd = 66248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEnvironmentParameters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEnvironmentParameters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66250, XrefRangeEnd = 66251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWeatherProfileEvaluated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWeatherProfileEvaluated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66251, XrefRangeEnd = 66266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66266, XrefRangeEnd = 66284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66284, XrefRangeEnd = 66306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe AzureDynamicLightingController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AzureDynamicLightingController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AzureDynamicLightingController(IntPtr pointer)
		: base(pointer)
	{
	}
}
