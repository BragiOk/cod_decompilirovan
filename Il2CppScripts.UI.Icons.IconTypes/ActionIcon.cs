using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.Tables;

namespace Il2CppScripts.UI.Icons.IconTypes;

public class ActionIcon : IconHandle
{
	private static readonly IntPtr NativeFieldInfoPtr__actionEntry;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_ActionEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DisplayDesc_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAction_Public_Void_ActionEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAction_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActionEntry _actionEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionEntry);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionEntry));
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

	public unsafe ActionEntry Action
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35447, RefRangeEnd = 35452, XrefRangeStart = 35447, XrefRangeEnd = 35447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Action_Public_get_ActionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
		}
	}

	public unsafe string DisplayName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string DisplayDesc
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisplayDesc_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static ActionIcon()
	{
		Il2CppClassPointerStore<ActionIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Icons.IconTypes", "ActionIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr);
		NativeFieldInfoPtr__actionEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, "_actionEntry");
		NativeMethodInfoPtr_get_ShortCut_Public_Virtual_get_ShortCut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666844);
		NativeMethodInfoPtr_get_Action_Public_get_ActionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666845);
		NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666846);
		NativeMethodInfoPtr_get_DisplayDesc_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666847);
		NativeMethodInfoPtr_SetAction_Public_Void_ActionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666848);
		NativeMethodInfoPtr_SetAction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666849);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr, 100666850);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 35456, RefRangeEnd = 35460, XrefRangeStart = 35452, XrefRangeEnd = 35456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAction(ActionEntry actionEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionEntry);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAction_Public_Void_ActionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35460, XrefRangeEnd = 35463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAction(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionIcon>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActionIcon(IntPtr pointer)
		: base(pointer)
	{
	}
}
