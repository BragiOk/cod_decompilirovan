using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Elements.Tween;

public class IUITweenValue : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Public_Abstract_Virtual_New_Void_Single_0;

	static IUITweenValue()
	{
		Il2CppClassPointerStore<IUITweenValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.Tween", "IUITweenValue");
		NativeMethodInfoPtr_Interpolate_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUITweenValue>.NativeClassPtr, 100666047);
	}

	[CallerCount(0)]
	public unsafe virtual void Interpolate(float f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Interpolate_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IUITweenValue(IntPtr pointer)
		: base(pointer)
	{
	}
}
