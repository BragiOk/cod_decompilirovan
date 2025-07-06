using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.UI.Overlay.Tooltips;

public class ITooltipSource : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_PopulateTooltip_Public_Abstract_Virtual_New_Void_ITooltip_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TooltipMargin_Public_Abstract_Virtual_New_get_Single_0;

	public unsafe virtual float TooltipMargin
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_TooltipMargin_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ITooltipSource()
	{
		Il2CppClassPointerStore<ITooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.Tooltips", "ITooltipSource");
		NativeMethodInfoPtr_PopulateTooltip_Public_Abstract_Virtual_New_Void_ITooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITooltipSource>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_get_TooltipMargin_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITooltipSource>.NativeClassPtr, 100665772);
	}

	[CallerCount(0)]
	public unsafe virtual void PopulateTooltip(ITooltip tooltip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tooltip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PopulateTooltip_Public_Abstract_Virtual_New_Void_ITooltip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ITooltipSource(IntPtr pointer)
		: base(pointer)
	{
	}
}
