using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Tables;

namespace Il2CppScripts.UI.Icons.IconTypes;

public class HennaIcon : IconHandle
{
	private static readonly IntPtr NativeFieldInfoPtr__ShortCut_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__hennaEntry;

	private static readonly IntPtr NativeMethodInfoPtr_get_HennaEntry_Public_get_HennaEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetupIcon_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShortCut _ShortCut_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShortCut_k__BackingField);
			return *(ShortCut*)num;
		}
		set
		{
			*(ShortCut*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShortCut_k__BackingField)) = shortCut;
		}
	}

	public unsafe HennaEntry _hennaEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hennaEntry);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HennaEntry>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hennaEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hennaEntry));
		}
	}

	public unsafe HennaEntry HennaEntry
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HennaEntry_Public_get_HennaEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HennaEntry>(intPtr) : null;
		}
	}

	public unsafe override ShortCut ShortCut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ShortCut*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static HennaIcon()
	{
		Il2CppClassPointerStore<HennaIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons.IconTypes", "HennaIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr);
		NativeFieldInfoPtr__ShortCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, "<ShortCut>k__BackingField");
		NativeFieldInfoPtr__hennaEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, "_hennaEntry");
		NativeMethodInfoPtr_get_HennaEntry_Public_get_HennaEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, 100666859);
		NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, 100666860);
		NativeMethodInfoPtr_SetupIcon_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, 100666861);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr, 100666862);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35512, RefRangeEnd = 35514, XrefRangeStart = 35509, XrefRangeEnd = 35512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupIcon(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupIcon_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HennaIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HennaIcon>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HennaIcon(IntPtr pointer)
		: base(pointer)
	{
	}
}
