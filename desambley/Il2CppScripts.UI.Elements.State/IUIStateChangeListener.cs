using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Elements.State;

public class IUIStateChangeListener : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_NotifyStateChanged_Public_Abstract_Virtual_New_Void_Int32_0;

	static IUIStateChangeListener()
	{
		Il2CppClassPointerStore<IUIStateChangeListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.State", "IUIStateChangeListener");
		NativeMethodInfoPtr_NotifyStateChanged_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIStateChangeListener>.NativeClassPtr, 100666075);
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

	public IUIStateChangeListener(IntPtr pointer)
		: base(pointer)
	{
	}
}
