using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Config;
using Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets.Prototypes;

namespace Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets;

public class FpsLimitSliderWidget : AbstractIntSliderOptionWidget
{
	private static readonly IntPtr NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe override ConfigVariable<int> Variable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42399, XrefRangeEnd = 42401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<int>>(intPtr) : null;
		}
	}

	static FpsLimitSliderWidget()
	{
		Il2CppClassPointerStore<FpsLimitSliderWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.OptionsMenu.Widgets", "FpsLimitSliderWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FpsLimitSliderWidget>.NativeClassPtr);
		NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FpsLimitSliderWidget>.NativeClassPtr, 100667479);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FpsLimitSliderWidget>.NativeClassPtr, 100667480);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FpsLimitSliderWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FpsLimitSliderWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FpsLimitSliderWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
