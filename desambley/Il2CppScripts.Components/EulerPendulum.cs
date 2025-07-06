using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.Components;

public class EulerPendulum : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_FrequencyX;

	private static readonly IntPtr NativeFieldInfoPtr_AmplitudeX;

	private static readonly IntPtr NativeFieldInfoPtr_FrequencyZ;

	private static readonly IntPtr NativeFieldInfoPtr_AmplitudeZ;

	private static readonly IntPtr NativeFieldInfoPtr_RandomizeStartingAngle;

	private static readonly IntPtr NativeFieldInfoPtr__previousRotation;

	private static readonly IntPtr NativeFieldInfoPtr__phaseXRandom;

	private static readonly IntPtr NativeFieldInfoPtr__phaseZRandom;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float FrequencyX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrequencyX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrequencyX)) = num;
		}
	}

	public unsafe float AmplitudeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmplitudeX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmplitudeX)) = num;
		}
	}

	public unsafe float FrequencyZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrequencyZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrequencyZ)) = num;
		}
	}

	public unsafe float AmplitudeZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmplitudeZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmplitudeZ)) = num;
		}
	}

	public unsafe bool RandomizeStartingAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomizeStartingAngle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomizeStartingAngle)) = flag;
		}
	}

	public unsafe Quaternion _previousRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousRotation)) = quaternion;
		}
	}

	public unsafe float _phaseXRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__phaseXRandom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__phaseXRandom)) = num;
		}
	}

	public unsafe float _phaseZRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__phaseZRandom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__phaseZRandom)) = num;
		}
	}

	static EulerPendulum()
	{
		Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components", "EulerPendulum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr);
		NativeFieldInfoPtr_FrequencyX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "FrequencyX");
		NativeFieldInfoPtr_AmplitudeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "AmplitudeX");
		NativeFieldInfoPtr_FrequencyZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "FrequencyZ");
		NativeFieldInfoPtr_AmplitudeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "AmplitudeZ");
		NativeFieldInfoPtr_RandomizeStartingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "RandomizeStartingAngle");
		NativeFieldInfoPtr__previousRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "_previousRotation");
		NativeFieldInfoPtr__phaseXRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "_phaseXRandom");
		NativeFieldInfoPtr__phaseZRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, "_phaseZRandom");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, 100669888);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, 100669889);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr, 100669890);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66977, XrefRangeEnd = 66980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66980, XrefRangeEnd = 66996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66996, XrefRangeEnd = 67001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EulerPendulum()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EulerPendulum>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EulerPendulum(IntPtr pointer)
		: base(pointer)
	{
	}
}
