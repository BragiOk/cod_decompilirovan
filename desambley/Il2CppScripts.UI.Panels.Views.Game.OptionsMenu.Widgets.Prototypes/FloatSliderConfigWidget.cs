using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Config;

namespace Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets.Prototypes;

public class FloatSliderConfigWidget : AbstractSliderOptionWidget
{
	private static readonly IntPtr NativeFieldInfoPtr__configVariableName;

	private static readonly IntPtr NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string _configVariableName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__configVariableName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__configVariableName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe override ConfigVariable<float> Variable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42516, XrefRangeEnd = 42522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<float>>(intPtr) : null;
		}
	}

	static FloatSliderConfigWidget()
	{
		Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.OptionsMenu.Widgets.Prototypes", "FloatSliderConfigWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr);
		NativeFieldInfoPtr__configVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr, "_configVariableName");
		NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr, 100667524);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr, 100667525);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FloatSliderConfigWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSliderConfigWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FloatSliderConfigWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
