using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Model;
using Il2CppTMPro;

namespace Il2CppScripts.UI.Icons.IconTypes;

public class MacroIcon : IconHandle
{
	private static readonly IntPtr NativeFieldInfoPtr_MaxAcronymLength;

	private static readonly IntPtr NativeFieldInfoPtr__label;

	private static readonly IntPtr NativeFieldInfoPtr__iconCooldown;

	private static readonly IntPtr NativeFieldInfoPtr__macrosEntry;

	private static readonly IntPtr NativeFieldInfoPtr__macroModel;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Macros_Public_get_MacrosEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnMacroUpdated_Private_Void_MacrosEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_MacroModel_0;

	private static readonly IntPtr NativeMethodInfoPtr_DetachFromModel_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMacro_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MaxAcronymLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAcronymLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAcronymLength, (void*)(&num));
		}
	}

	public unsafe TextMeshProUGUI _label
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__label);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__label)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe IconCooldown _iconCooldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__iconCooldown);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IconCooldown>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__iconCooldown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconCooldown));
		}
	}

	public unsafe MacrosEntry _macrosEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__macrosEntry);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MacrosEntry>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__macrosEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosEntry));
		}
	}

	public unsafe MacroModel _macroModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__macroModel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MacroModel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__macroModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroModel));
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

	public unsafe MacrosEntry Macros
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Macros_Public_get_MacrosEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MacrosEntry>(intPtr) : null;
		}
	}

	static MacroIcon()
	{
		Il2CppClassPointerStore<MacroIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons.IconTypes", "MacroIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr);
		NativeFieldInfoPtr_MaxAcronymLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, "MaxAcronymLength");
		NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, "_label");
		NativeFieldInfoPtr__iconCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, "_iconCooldown");
		NativeFieldInfoPtr__macrosEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, "_macrosEntry");
		NativeFieldInfoPtr__macroModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, "_macroModel");
		NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666885);
		NativeMethodInfoPtr_get_Macros_Public_get_MacrosEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666886);
		NativeMethodInfoPtr_OnMacroUpdated_Private_Void_MacrosEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666887);
		NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_MacroModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666888);
		NativeMethodInfoPtr_DetachFromModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666889);
		NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666890);
		NativeMethodInfoPtr_SetMacro_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666891);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666892);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr, 100666893);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35628, XrefRangeEnd = 35629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMacroUpdated(MacrosEntry macrosEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMacroUpdated_Private_Void_MacrosEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35648, RefRangeEnd = 35649, XrefRangeStart = 35629, XrefRangeEnd = 35648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMacro(MacrosEntry macrosEntry, MacroModel macroModel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosEntry);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macroModel);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_MacroModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35656, RefRangeEnd = 35658, XrefRangeStart = 35649, XrefRangeEnd = 35656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetachFromModel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetachFromModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 35662, RefRangeEnd = 35670, XrefRangeStart = 35658, XrefRangeEnd = 35662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMacro(MacrosEntry macrosEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)macrosEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMacro_Public_Void_MacrosEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35670, XrefRangeEnd = 35681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMacro(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMacro_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35681, XrefRangeEnd = 35682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MacroIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MacroIcon>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MacroIcon(IntPtr pointer)
		: base(pointer)
	{
	}
}
