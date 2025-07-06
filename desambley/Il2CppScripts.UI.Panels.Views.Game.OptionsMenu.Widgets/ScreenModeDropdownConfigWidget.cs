using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Config;
using Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets.Prototypes;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.OptionsMenu.Widgets;

public class ScreenModeDropdownConfigWidget : AbstractDropdownOptionWidget<FullScreenMode>
{
	private static readonly IntPtr NativeFieldInfoPtr__fullScreenMode;

	private static readonly IntPtr NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_FullScreenMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_Virtual_get_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_IndexToValue_Protected_Virtual_FullScreenMode_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValueToIndex_Protected_Virtual_Int32_FullScreenMode_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<FullScreenMode> _fullScreenMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullScreenMode);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<FullScreenMode>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullScreenMode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe override ConfigVariable<FullScreenMode> Variable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42403, XrefRangeEnd = 42405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_FullScreenMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ConfigVariable<FullScreenMode>>(intPtr) : null;
		}
	}

	public unsafe override Il2CppStringArray Options
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42405, XrefRangeEnd = 42417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Options_Protected_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
	}

	static ScreenModeDropdownConfigWidget()
	{
		Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.OptionsMenu.Widgets", "ScreenModeDropdownConfigWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr);
		NativeFieldInfoPtr__fullScreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, "_fullScreenMode");
		NativeMethodInfoPtr_get_Variable_Protected_Virtual_get_ConfigVariable_1_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_get_Options_Protected_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr_IndexToValue_Protected_Virtual_FullScreenMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, 100667485);
		NativeMethodInfoPtr_ValueToIndex_Protected_Virtual_Int32_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, 100667486);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr, 100667487);
	}

	[CallerCount(0)]
	public unsafe override FullScreenMode IndexToValue(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IndexToValue_Protected_Virtual_FullScreenMode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FullScreenMode*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42417, XrefRangeEnd = 42421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int ValueToIndex(FullScreenMode value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ValueToIndex_Protected_Virtual_Int32_FullScreenMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42421, XrefRangeEnd = 42428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenModeDropdownConfigWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenModeDropdownConfigWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ScreenModeDropdownConfigWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
