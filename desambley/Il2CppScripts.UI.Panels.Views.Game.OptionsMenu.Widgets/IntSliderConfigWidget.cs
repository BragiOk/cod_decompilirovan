using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Config;
using Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets.Prototypes;

namespace Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets;

public class IntSliderConfigWidget : AbstractIntSliderOptionWidget
{
	private static readonly IntPtr NativeFieldInfoPtr__configVariableName;

	private static readonly IntPtr NativeFieldInfoPtr__useCustomMaxValue;

	private static readonly IntPtr NativeFieldInfoPtr__customMaxValue;

	private static readonly IntPtr NativeFieldInfoPtr__useCustomMinValue;

	private static readonly IntPtr NativeFieldInfoPtr__customMinValue;

	private static readonly IntPtr NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CustomMaxValue_Protected_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CustomMinValue_Protected_Virtual_get_Int32_0;

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

	public unsafe bool _useCustomMaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useCustomMaxValue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useCustomMaxValue)) = flag;
		}
	}

	public unsafe int _customMaxValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customMaxValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customMaxValue)) = num;
		}
	}

	public unsafe bool _useCustomMinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useCustomMinValue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useCustomMinValue)) = flag;
		}
	}

	public unsafe int _customMinValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customMinValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customMinValue)) = num;
		}
	}

	public unsafe override ConfigVariable<int> Variable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42491, XrefRangeEnd = 42497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe override int CustomMaxValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CustomMaxValue_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override int CustomMinValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CustomMinValue_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static IntSliderConfigWidget()
	{
		Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.OptionsMenu.Widgets", "IntSliderConfigWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr);
		NativeFieldInfoPtr__configVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, "_configVariableName");
		NativeFieldInfoPtr__useCustomMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, "_useCustomMaxValue");
		NativeFieldInfoPtr__customMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, "_customMaxValue");
		NativeFieldInfoPtr__useCustomMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, "_useCustomMinValue");
		NativeFieldInfoPtr__customMinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, "_customMinValue");
		NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, 100667503);
		NativeMethodInfoPtr_get_CustomMaxValue_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, 100667504);
		NativeMethodInfoPtr_get_CustomMinValue_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, 100667505);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr, 100667506);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IntSliderConfigWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSliderConfigWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IntSliderConfigWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
