using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Icons;
using UnityEngine;

namespace Il2CppScripts.UI.Controllers;

public class ItemUseController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__allowLeftClick;

	private static readonly IntPtr NativeFieldInfoPtr__allowRightClick;

	private static readonly IntPtr NativeFieldInfoPtr__allowDoubleClick;

	private static readonly IntPtr NativeFieldInfoPtr_Delayer;

	private static readonly IntPtr NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _allowLeftClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowLeftClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowLeftClick)) = flag;
		}
	}

	public unsafe bool _allowRightClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowRightClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowRightClick)) = flag;
		}
	}

	public unsafe bool _allowDoubleClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowDoubleClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowDoubleClick)) = flag;
		}
	}

	public unsafe static IconUseDelayer Delayer
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Delayer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IconUseDelayer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Delayer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconUseDelayer));
		}
	}

	static ItemUseController()
	{
		Il2CppClassPointerStore<ItemUseController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Controllers", "ItemUseController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr);
		NativeFieldInfoPtr__allowLeftClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, "_allowLeftClick");
		NativeFieldInfoPtr__allowRightClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, "_allowRightClick");
		NativeFieldInfoPtr__allowDoubleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, "_allowDoubleClick");
		NativeFieldInfoPtr_Delayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, "Delayer");
		NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, 100666717);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr, 100666718);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34560, XrefRangeEnd = 34563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool HandleIconEvent(IconHandle icon, IconEvent e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		*(IconEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &e;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34563, XrefRangeEnd = 34566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemUseController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUseController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemUseController(IntPtr pointer)
		: base(pointer)
	{
	}
}
