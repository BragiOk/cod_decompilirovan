using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Icons;

public class IIconController : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_HandleIconEvent_Public_Abstract_Virtual_New_Boolean_IconHandle_IconEvent_0;

	static IIconController()
	{
		Il2CppClassPointerStore<IIconController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons", "IIconController");
		NativeMethodInfoPtr_HandleIconEvent_Public_Abstract_Virtual_New_Boolean_IconHandle_IconEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIconController>.NativeClassPtr, 100666751);
	}

	[CallerCount(0)]
	public unsafe virtual bool HandleIconEvent(IconHandle icon, IconEvent e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		*(IconEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &e;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleIconEvent_Public_Abstract_Virtual_New_Boolean_IconHandle_IconEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IIconController(IntPtr pointer)
		: base(pointer)
	{
	}
}
