using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScripts.Common;

namespace Il2CppScripts.Interfaces;

public class ISelectionNotify : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SelectionStateChanged_Public_Abstract_Virtual_New_Void_SelectState_0;

	static ISelectionNotify()
	{
		Il2CppClassPointerStore<ISelectionNotify>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Interfaces", "ISelectionNotify");
		NativeMethodInfoPtr_SelectionStateChanged_Public_Abstract_Virtual_New_Void_SelectState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionNotify>.NativeClassPtr, 100665506);
	}

	[CallerCount(0)]
	public unsafe virtual void SelectionStateChanged(SelectState selectionState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&selectionState);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SelectionStateChanged_Public_Abstract_Virtual_New_Void_SelectState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISelectionNotify(IntPtr pointer)
		: base(pointer)
	{
	}
}
