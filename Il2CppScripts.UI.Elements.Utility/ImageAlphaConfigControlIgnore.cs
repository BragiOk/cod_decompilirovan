using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Elements.Utility;

public class ImageAlphaConfigControlIgnore : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__ignoreChildren;

	private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreChildren_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _ignoreChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreChildren);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreChildren)) = flag;
		}
	}

	public unsafe bool IgnoreChildren
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IgnoreChildren_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ImageAlphaConfigControlIgnore()
	{
		Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.Utility", "ImageAlphaConfigControlIgnore");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr);
		NativeFieldInfoPtr__ignoreChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr, "_ignoreChildren");
		NativeMethodInfoPtr_get_IgnoreChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr, 100666446);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr, 100666447);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImageAlphaConfigControlIgnore()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageAlphaConfigControlIgnore>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImageAlphaConfigControlIgnore(IntPtr pointer)
		: base(pointer)
	{
	}
}
