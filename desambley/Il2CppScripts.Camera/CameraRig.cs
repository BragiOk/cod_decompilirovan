using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2CppScripts.Camera;

public class CameraRig : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__thirdPersonCameraRig;

	private static readonly IntPtr NativeFieldInfoPtr__freeCameraRig;

	private static readonly IntPtr NativeFieldInfoPtr__camera;

	private static readonly IntPtr NativeFieldInfoPtr__cameraHandler;

	private static readonly IntPtr NativeFieldInfoPtr__mode;

	private static readonly IntPtr NativeFieldInfoPtr__current;

	private static readonly IntPtr NativeFieldInfoPtr_CameraRigs;

	private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_CameraRig_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_get_Camera_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ThirdPersonCameraRig_Public_get_ThirdPersonCamera_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FreeCameraRig_Public_get_FreeCamera_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCameraMode_Public_Void_CameraRigType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ThirdPersonCamera _thirdPersonCameraRig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thirdPersonCameraRig);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ThirdPersonCamera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thirdPersonCameraRig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thirdPersonCamera));
		}
	}

	public unsafe FreeCamera _freeCameraRig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__freeCameraRig);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FreeCamera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__freeCameraRig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)freeCamera));
		}
	}

	public unsafe UnityEngine.Camera _camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe ICameraHandler _cameraHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraHandler);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICameraHandler>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraHandler));
		}
	}

	public unsafe CameraRigType _mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mode);
			return *(CameraRigType*)num;
		}
		set
		{
			*(CameraRigType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mode)) = cameraRigType;
		}
	}

	public unsafe static CameraRig _current
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__current, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CameraRig>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__current, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraRig));
		}
	}

	public unsafe static List<CameraRig> CameraRigs
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CameraRigs, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<CameraRig>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CameraRigs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static CameraRig Current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65797, XrefRangeEnd = 65801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Static_get_CameraRig_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CameraRig>(intPtr) : null;
		}
	}

	public unsafe UnityEngine.Camera Camera
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr) : null;
		}
	}

	public unsafe ThirdPersonCamera ThirdPersonCameraRig
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ThirdPersonCameraRig_Public_get_ThirdPersonCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ThirdPersonCamera>(intPtr) : null;
		}
	}

	public unsafe FreeCamera FreeCameraRig
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FreeCameraRig_Public_get_FreeCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FreeCamera>(intPtr) : null;
		}
	}

	static CameraRig()
	{
		Il2CppClassPointerStore<CameraRig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Camera", "CameraRig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRig>.NativeClassPtr);
		NativeFieldInfoPtr__thirdPersonCameraRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_thirdPersonCameraRig");
		NativeFieldInfoPtr__freeCameraRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_freeCameraRig");
		NativeFieldInfoPtr__camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_camera");
		NativeFieldInfoPtr__cameraHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_cameraHandler");
		NativeFieldInfoPtr__mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_mode");
		NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "_current");
		NativeFieldInfoPtr_CameraRigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, "CameraRigs");
		NativeMethodInfoPtr_get_Current_Public_Static_get_CameraRig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669767);
		NativeMethodInfoPtr_get_Camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669768);
		NativeMethodInfoPtr_get_ThirdPersonCameraRig_Public_get_ThirdPersonCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669769);
		NativeMethodInfoPtr_get_FreeCameraRig_Public_get_FreeCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669770);
		NativeMethodInfoPtr_SetCameraMode_Public_Void_CameraRigType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669771);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669772);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669773);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669774);
		NativeMethodInfoPtr_OnActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669775);
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669776);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRig>.NativeClassPtr, 100669777);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65803, RefRangeEnd = 65804, XrefRangeStart = 65801, XrefRangeEnd = 65803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraMode(CameraRigType mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraMode_Public_Void_CameraRigType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65804, XrefRangeEnd = 65807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65807, XrefRangeEnd = 65815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65815, XrefRangeEnd = 65824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65851, RefRangeEnd = 65852, XrefRangeStart = 65824, XrefRangeEnd = 65851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnActiveSceneChanged(Scene current, Scene next)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&current);
		*(Scene**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &next;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveSceneChanged_Private_Static_Void_Scene_Scene_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65852, XrefRangeEnd = 65879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraRig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRig>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CameraRig(IntPtr pointer)
		: base(pointer)
	{
	}
}
