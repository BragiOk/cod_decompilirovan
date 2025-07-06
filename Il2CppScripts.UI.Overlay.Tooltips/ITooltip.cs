using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Overlay.Tooltips;

public class ITooltip : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Abstract_Virtual_New_Void_TooltipField_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetFields_Public_Abstract_Virtual_New_Void_0;

	static ITooltip()
	{
		Il2CppClassPointerStore<ITooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.Tooltips", "ITooltip");
		NativeMethodInfoPtr_SetText_Public_Abstract_Virtual_New_Void_TooltipField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITooltip>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_ResetFields_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITooltip>.NativeClassPtr, 100665770);
	}

	[CallerCount(0)]
	public unsafe virtual void SetText(TooltipField field, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&field);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetText_Public_Abstract_Virtual_New_Void_TooltipField_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ResetFields()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResetFields_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ITooltip(IntPtr pointer)
		: base(pointer)
	{
	}
}
