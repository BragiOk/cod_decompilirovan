using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScripts.UI.Icons;

public class IconSelectGroup : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__SelectedIcon_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_SelectedIcon_Public_get_IconHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SelectedIcon_Private_set_Void_IconHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_NotifySelected_Public_Void_IconHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_NotifyDeselected_Public_Void_IconHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IconHandle _SelectedIcon_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedIcon_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IconHandle>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelectedIcon_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconHandle));
		}
	}

	public unsafe IconHandle SelectedIcon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelectedIcon_Public_get_IconHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IconHandle>(intPtr) : null;
		}
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 69, RefRangeEnd = 119, XrefRangeStart = 69, XrefRangeEnd = 119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelectedIcon_Private_set_Void_IconHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static IconSelectGroup()
	{
		Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons", "IconSelectGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr);
		NativeFieldInfoPtr__SelectedIcon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, "<SelectedIcon>k__BackingField");
		NativeMethodInfoPtr_get_SelectedIcon_Public_get_IconHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, 100666746);
		NativeMethodInfoPtr_set_SelectedIcon_Private_set_Void_IconHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, 100666747);
		NativeMethodInfoPtr_NotifySelected_Public_Void_IconHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, 100666748);
		NativeMethodInfoPtr_NotifyDeselected_Public_Void_IconHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, 100666749);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr, 100666750);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34738, XrefRangeEnd = 34748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifySelected(IconHandle icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifySelected_Public_Void_IconHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34748, XrefRangeEnd = 34761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyDeselected(IconHandle icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyDeselected_Public_Void_IconHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IconSelectGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconSelectGroup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IconSelectGroup(IntPtr pointer)
		: base(pointer)
	{
	}
}
