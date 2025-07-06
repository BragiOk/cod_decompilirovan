using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.EditorOnlyUtility;

public class EnsureSceneIsRepaintedFixup : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static EnsureSceneIsRepaintedFixup()
	{
		Il2CppClassPointerStore<EnsureSceneIsRepaintedFixup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.EditorOnlyUtility", "EnsureSceneIsRepaintedFixup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnsureSceneIsRepaintedFixup>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnsureSceneIsRepaintedFixup>.NativeClassPtr, 100668900);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EnsureSceneIsRepaintedFixup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnsureSceneIsRepaintedFixup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EnsureSceneIsRepaintedFixup(IntPtr pointer)
		: base(pointer)
	{
	}
}
