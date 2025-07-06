using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.EditorOnlyUtility;

public class ForcedBreakpointOnKey : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__keyCode;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe KeyCode _keyCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyCode);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyCode)) = keyCode;
		}
	}

	static ForcedBreakpointOnKey()
	{
		Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.EditorOnlyUtility", "ForcedBreakpointOnKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr);
		NativeFieldInfoPtr__keyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr, "_keyCode");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr, 100668901);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr, 100668902);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55180, XrefRangeEnd = 55183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForcedBreakpointOnKey()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForcedBreakpointOnKey>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ForcedBreakpointOnKey(IntPtr pointer)
		: base(pointer)
	{
	}
}
