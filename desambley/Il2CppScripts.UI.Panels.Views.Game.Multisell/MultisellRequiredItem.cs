using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppScripts.UI.Icons;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.Multisell;

public class MultisellRequiredItem : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__itemIconImage;

	private static readonly IntPtr NativeFieldInfoPtr__templateText;

	private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_ItemState_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IconImage _itemIconImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemIconImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IconImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemIconImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconImage));
		}
	}

	public unsafe TemplateText _templateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemplateText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__templateText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templateText));
		}
	}

	static MultisellRequiredItem()
	{
		Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.Multisell", "MultisellRequiredItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr);
		NativeFieldInfoPtr__itemIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr, "_itemIconImage");
		NativeFieldInfoPtr__templateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr, "_templateText");
		NativeMethodInfoPtr_SetItem_Public_Void_ItemState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr, 100667610);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr, 100667611);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43221, RefRangeEnd = 43222, XrefRangeStart = 43170, XrefRangeEnd = 43221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetItem(ItemState itemState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemState);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetItem_Public_Void_ItemState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultisellRequiredItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultisellRequiredItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultisellRequiredItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
