using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Elements.Interfaces;

public class IElementActivator : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0;

	static IElementActivator()
	{
		Il2CppClassPointerStore<IElementActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.Interfaces", "IElementActivator");
		NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IElementActivator>.NativeClassPtr, 100666613);
	}

	[CallerCount(0)]
	public unsafe virtual void SetActive(bool flag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IElementActivator(IntPtr pointer)
		: base(pointer)
	{
	}
}
