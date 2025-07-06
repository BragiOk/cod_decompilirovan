using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Elements.State;

public class UIStateChangedBase : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_NotifyStateChanged_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static UIStateChangedBase()
	{
		Il2CppClassPointerStore<UIStateChangedBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.State", "UIStateChangedBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIStateChangedBase>.NativeClassPtr);
		NativeMethodInfoPtr_NotifyStateChanged_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStateChangedBase>.NativeClassPtr, 100666079);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStateChangedBase>.NativeClassPtr, 100666080);
	}

	[CallerCount(0)]
	public unsafe virtual void NotifyStateChanged(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotifyStateChanged_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIStateChangedBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIStateChangedBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UIStateChangedBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
