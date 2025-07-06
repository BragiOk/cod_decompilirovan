using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.Camera;

public class ICameraHandler : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_HandleCamera_Public_Abstract_Virtual_New_Void_Camera_0;

	static ICameraHandler()
	{
		Il2CppClassPointerStore<ICameraHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Camera", "ICameraHandler");
		NativeMethodInfoPtr_HandleCamera_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraHandler>.NativeClassPtr, 100669784);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleCamera(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleCamera_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ICameraHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}
