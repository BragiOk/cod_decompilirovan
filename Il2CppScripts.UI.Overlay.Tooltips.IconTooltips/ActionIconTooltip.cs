using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Icons.IconTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Overlay.Tooltips.IconTooltips;

public class ActionIconTooltip : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__actionIcon;

	private static readonly IntPtr NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActionIcon _actionIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActionIcon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionIcon));
		}
	}

	public unsafe virtual float TooltipMargin
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ActionIconTooltip()
	{
		Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.Tooltips.IconTooltips", "ActionIconTooltip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr);
		NativeFieldInfoPtr__actionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr, "_actionIcon");
		NativeMethodInfoPtr_get_TooltipMargin_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr, 100665802);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26112, XrefRangeEnd = 26117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PopulateTooltip(ITooltip tooltip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tooltip);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateTooltip_Public_Virtual_Final_New_Void_ITooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionIconTooltip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionIconTooltip>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActionIconTooltip(IntPtr pointer)
		: base(pointer)
	{
	}
}
