using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.Components;

public class NoLoadZone : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_PointInsideNoLoadZone_Public_Static_Boolean_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NoLoadZone()
	{
		Il2CppClassPointerStore<NoLoadZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components", "NoLoadZone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoLoadZone>.NativeClassPtr);
		NativeMethodInfoPtr_PointInsideNoLoadZone_Public_Static_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoLoadZone>.NativeClassPtr, 100669845);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoLoadZone>.NativeClassPtr, 100669846);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66533, RefRangeEnd = 66534, XrefRangeStart = 66508, XrefRangeEnd = 66533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PointInsideNoLoadZone(Vector3 point)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointInsideNoLoadZone_Public_Static_Boolean_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoLoadZone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoLoadZone>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NoLoadZone(IntPtr pointer)
		: base(pointer)
	{
	}
}
