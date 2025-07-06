using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScripts.Camera;

public class ThirdPersonCamera : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__ZoomSpeedScale_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TurnSpeedScale_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DisableSmoothing_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__pivot;

	private static readonly IntPtr NativeFieldInfoPtr__verticalOffset;

	private static readonly IntPtr NativeFieldInfoPtr__turnSpeedX;

	private static readonly IntPtr NativeFieldInfoPtr__turnSpeedY;

	private static readonly IntPtr NativeFieldInfoPtr__zoomSpeed;

	private static readonly IntPtr NativeFieldInfoPtr__minDistance;

	private static readonly IntPtr NativeFieldInfoPtr__maxDistance;

	private static readonly IntPtr NativeFieldInfoPtr__enableSmoothing;

	private static readonly IntPtr NativeFieldInfoPtr__smoothTimeV;

	private static readonly IntPtr NativeFieldInfoPtr__smoothSpeedV;

	private static readonly IntPtr NativeFieldInfoPtr__smoothMinV;

	private static readonly IntPtr NativeFieldInfoPtr__distance;

	private static readonly IntPtr NativeFieldInfoPtr__preventClipping;

	private static readonly IntPtr NativeFieldInfoPtr__clipMargin;

	private static readonly IntPtr NativeFieldInfoPtr__clipIgnoreLayers;

	private static readonly IntPtr NativeFieldInfoPtr__attackAngle;

	private static readonly IntPtr NativeFieldInfoPtr__rotation;

	private static readonly IntPtr NativeFieldInfoPtr__hideCursorWhenRotating;

	private static readonly IntPtr NativeFieldInfoPtr__mouseAxisX;

	private static readonly IntPtr NativeFieldInfoPtr__mouseAxisY;

	private static readonly IntPtr NativeFieldInfoPtr__fixedTimeDelta;

	private static readonly IntPtr NativeFieldInfoPtr__startedRotating;

	private static readonly IntPtr NativeFieldInfoPtr__cursorSavedPos;

	private static readonly IntPtr NativeFieldInfoPtr__nextUpdate;

	private static readonly IntPtr NativeFieldInfoPtr__zoomDeltaAccumulated;

	private static readonly IntPtr NativeFieldInfoPtr__mouseDeltaAccumulated;

	private static readonly IntPtr NativeFieldInfoPtr__realPivot;

	private static readonly IntPtr NativeFieldInfoPtr__smoothVelocityV;

	private static readonly IntPtr NativeFieldInfoPtr__camera;

	private static readonly IntPtr NativeMethodInfoPtr_get_ZoomSpeedScale_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ZoomSpeedScale_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TurnSpeedScale_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_TurnSpeedScale_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DisableSmoothing_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DisableSmoothing_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Pivot_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Pivot_Public_set_Void_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_VerticalOffset_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_VerticalOffset_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CameraHalfExtents_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get__layerMask_Private_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get__cameraHalfExtends_Private_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__HandleRotationAndZoom_Private_Void_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleRotationAndZoom_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SyncPivot_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleCamera_Public_Virtual_Final_New_Void_Camera_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float _ZoomSpeedScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ZoomSpeedScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ZoomSpeedScale_k__BackingField)) = num;
		}
	}

	public unsafe float _TurnSpeedScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TurnSpeedScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TurnSpeedScale_k__BackingField)) = num;
		}
	}

	public unsafe bool _DisableSmoothing_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisableSmoothing_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisableSmoothing_k__BackingField)) = flag;
		}
	}

	public unsafe Transform _pivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pivot);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pivot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe float _verticalOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verticalOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verticalOffset)) = num;
		}
	}

	public unsafe float _turnSpeedX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__turnSpeedX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__turnSpeedX)) = num;
		}
	}

	public unsafe float _turnSpeedY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__turnSpeedY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__turnSpeedY)) = num;
		}
	}

	public unsafe float _zoomSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zoomSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zoomSpeed)) = num;
		}
	}

	public unsafe float _minDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minDistance)) = num;
		}
	}

	public unsafe float _maxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxDistance)) = num;
		}
	}

	public unsafe bool _enableSmoothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableSmoothing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableSmoothing)) = flag;
		}
	}

	public unsafe float _smoothTimeV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothTimeV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothTimeV)) = num;
		}
	}

	public unsafe float _smoothSpeedV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothSpeedV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothSpeedV)) = num;
		}
	}

	public unsafe float _smoothMinV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothMinV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothMinV)) = num;
		}
	}

	public unsafe float _distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distance)) = num;
		}
	}

	public unsafe bool _preventClipping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preventClipping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preventClipping)) = flag;
		}
	}

	public unsafe float _clipMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipMargin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipMargin)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> _clipIgnoreLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipIgnoreLayers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipIgnoreLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float _attackAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attackAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attackAngle)) = num;
		}
	}

	public unsafe float _rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotation)) = num;
		}
	}

	public unsafe bool _hideCursorWhenRotating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideCursorWhenRotating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideCursorWhenRotating)) = flag;
		}
	}

	public unsafe string _mouseAxisX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAxisX);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAxisX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseAxisY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAxisY);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAxisY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float _fixedTimeDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fixedTimeDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fixedTimeDelta)) = num;
		}
	}

	public unsafe bool _startedRotating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startedRotating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startedRotating)) = flag;
		}
	}

	public unsafe Vector2Int _cursorSavedPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursorSavedPos);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursorSavedPos)) = vector2Int;
		}
	}

	public unsafe float _nextUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextUpdate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextUpdate)) = num;
		}
	}

	public unsafe float _zoomDeltaAccumulated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zoomDeltaAccumulated);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zoomDeltaAccumulated)) = num;
		}
	}

	public unsafe Vector2 _mouseDeltaAccumulated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseDeltaAccumulated);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseDeltaAccumulated)) = vector;
		}
	}

	public unsafe Vector3 _realPivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__realPivot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__realPivot)) = vector;
		}
	}

	public unsafe float _smoothVelocityV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothVelocityV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smoothVelocityV)) = num;
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

	public unsafe float ZoomSpeedScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ZoomSpeedScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ZoomSpeedScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float TurnSpeedScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TurnSpeedScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TurnSpeedScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool DisableSmoothing
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44851, RefRangeEnd = 44852, XrefRangeStart = 44851, XrefRangeEnd = 44852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisableSmoothing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableSmoothing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Transform Pivot
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Pivot_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65924, XrefRangeEnd = 65926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Pivot_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float VerticalOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VerticalOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_VerticalOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector3 CameraHalfExtents
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65926, XrefRangeEnd = 65927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CameraHalfExtents_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int _layerMask
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65927, XrefRangeEnd = 65928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__layerMask_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector3 _cameraHalfExtends
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65935, RefRangeEnd = 65937, XrefRangeStart = 65928, XrefRangeEnd = 65935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__cameraHalfExtends_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ThirdPersonCamera()
	{
		Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Camera", "ThirdPersonCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr);
		NativeFieldInfoPtr__ZoomSpeedScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "<ZoomSpeedScale>k__BackingField");
		NativeFieldInfoPtr__TurnSpeedScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "<TurnSpeedScale>k__BackingField");
		NativeFieldInfoPtr__DisableSmoothing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "<DisableSmoothing>k__BackingField");
		NativeFieldInfoPtr__pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_pivot");
		NativeFieldInfoPtr__verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_verticalOffset");
		NativeFieldInfoPtr__turnSpeedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_turnSpeedX");
		NativeFieldInfoPtr__turnSpeedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_turnSpeedY");
		NativeFieldInfoPtr__zoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_zoomSpeed");
		NativeFieldInfoPtr__minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_minDistance");
		NativeFieldInfoPtr__maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_maxDistance");
		NativeFieldInfoPtr__enableSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_enableSmoothing");
		NativeFieldInfoPtr__smoothTimeV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_smoothTimeV");
		NativeFieldInfoPtr__smoothSpeedV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_smoothSpeedV");
		NativeFieldInfoPtr__smoothMinV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_smoothMinV");
		NativeFieldInfoPtr__distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_distance");
		NativeFieldInfoPtr__preventClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_preventClipping");
		NativeFieldInfoPtr__clipMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_clipMargin");
		NativeFieldInfoPtr__clipIgnoreLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_clipIgnoreLayers");
		NativeFieldInfoPtr__attackAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_attackAngle");
		NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_rotation");
		NativeFieldInfoPtr__hideCursorWhenRotating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_hideCursorWhenRotating");
		NativeFieldInfoPtr__mouseAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_mouseAxisX");
		NativeFieldInfoPtr__mouseAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_mouseAxisY");
		NativeFieldInfoPtr__fixedTimeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_fixedTimeDelta");
		NativeFieldInfoPtr__startedRotating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_startedRotating");
		NativeFieldInfoPtr__cursorSavedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_cursorSavedPos");
		NativeFieldInfoPtr__nextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_nextUpdate");
		NativeFieldInfoPtr__zoomDeltaAccumulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_zoomDeltaAccumulated");
		NativeFieldInfoPtr__mouseDeltaAccumulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_mouseDeltaAccumulated");
		NativeFieldInfoPtr__realPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_realPivot");
		NativeFieldInfoPtr__smoothVelocityV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_smoothVelocityV");
		NativeFieldInfoPtr__camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, "_camera");
		NativeMethodInfoPtr_get_ZoomSpeedScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669785);
		NativeMethodInfoPtr_set_ZoomSpeedScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669786);
		NativeMethodInfoPtr_get_TurnSpeedScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669787);
		NativeMethodInfoPtr_set_TurnSpeedScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669788);
		NativeMethodInfoPtr_get_DisableSmoothing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669789);
		NativeMethodInfoPtr_set_DisableSmoothing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669790);
		NativeMethodInfoPtr_get_Pivot_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669791);
		NativeMethodInfoPtr_set_Pivot_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669792);
		NativeMethodInfoPtr_get_VerticalOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669793);
		NativeMethodInfoPtr_set_VerticalOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669794);
		NativeMethodInfoPtr_get_CameraHalfExtents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669795);
		NativeMethodInfoPtr_get__layerMask_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669796);
		NativeMethodInfoPtr_get__cameraHalfExtends_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669797);
		NativeMethodInfoPtr__HandleRotationAndZoom_Private_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669798);
		NativeMethodInfoPtr_HandleRotationAndZoom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669799);
		NativeMethodInfoPtr_SyncPivot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669800);
		NativeMethodInfoPtr_HandleCamera_Public_Virtual_Final_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669801);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr, 100669802);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65998, RefRangeEnd = 65999, XrefRangeStart = 65937, XrefRangeEnd = 65998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _HandleRotationAndZoom(float x, float y, float zoomDelta, float timeDelta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &zoomDelta;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &timeDelta;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HandleRotationAndZoom_Private_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66031, RefRangeEnd = 66032, XrefRangeStart = 65999, XrefRangeEnd = 66031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleRotationAndZoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleRotationAndZoom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66032, XrefRangeEnd = 66034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncPivot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncPivot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66034, XrefRangeEnd = 66044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleCamera(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleCamera_Public_Virtual_Final_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66044, XrefRangeEnd = 66054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThirdPersonCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThirdPersonCamera>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ThirdPersonCamera(IntPtr pointer)
		: base(pointer)
	{
	}
}
