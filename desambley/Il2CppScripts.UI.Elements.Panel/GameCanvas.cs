using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Elements.Panel;

public class GameCanvas : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_PreventCloseOnEsc;

	private static readonly IntPtr NativeFieldInfoPtr__focusedPanel;

	private static readonly IntPtr NativeFieldInfoPtr__panels;

	private static readonly IntPtr NativeFieldInfoPtr__panelsZOrder;

	private static readonly IntPtr NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_MoveableWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FocusedPanel_Public_get_MoveableWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterPanel_Public_Void_MoveableWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnregisterPanel_Public_Void_MoveableWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdatePanelZOrder_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetFocusedPanel_Public_Void_MoveableWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckCloseOnEsc_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool PreventCloseOnEsc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreventCloseOnEsc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreventCloseOnEsc)) = flag;
		}
	}

	public unsafe MoveableWindow _focusedPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__focusedPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MoveableWindow>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__focusedPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moveableWindow));
		}
	}

	public unsafe List<MoveableWindow> _panels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panels);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MoveableWindow>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MoveableWindow> _panelsZOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panelsZOrder);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MoveableWindow>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panelsZOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe IReadOnlyList<MoveableWindow> Panels
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11433, RefRangeEnd = 11442, XrefRangeStart = 11433, XrefRangeEnd = 11442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_MoveableWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<MoveableWindow>>(intPtr) : null;
		}
	}

	public unsafe MoveableWindow FocusedPanel
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FocusedPanel_Public_get_MoveableWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MoveableWindow>(intPtr) : null;
		}
	}

	static GameCanvas()
	{
		Il2CppClassPointerStore<GameCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Elements.Panel", "GameCanvas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr);
		NativeFieldInfoPtr_PreventCloseOnEsc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "PreventCloseOnEsc");
		NativeFieldInfoPtr__focusedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "_focusedPanel");
		NativeFieldInfoPtr__panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "_panels");
		NativeFieldInfoPtr__panelsZOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "_panelsZOrder");
		NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_MoveableWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666179);
		NativeMethodInfoPtr_get_FocusedPanel_Public_get_MoveableWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666180);
		NativeMethodInfoPtr_RegisterPanel_Public_Void_MoveableWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666181);
		NativeMethodInfoPtr_UnregisterPanel_Public_Void_MoveableWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666182);
		NativeMethodInfoPtr_UpdatePanelZOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666183);
		NativeMethodInfoPtr_SetFocusedPanel_Public_Void_MoveableWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666184);
		NativeMethodInfoPtr_CheckCloseOnEsc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666185);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666186);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100666187);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29846, XrefRangeEnd = 29852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterPanel(MoveableWindow moveableWindow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moveableWindow);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterPanel_Public_Void_MoveableWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29873, RefRangeEnd = 29874, XrefRangeStart = 29852, XrefRangeEnd = 29873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterPanel(MoveableWindow moveableWindow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moveableWindow);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterPanel_Public_Void_MoveableWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 29890, RefRangeEnd = 29896, XrefRangeStart = 29874, XrefRangeEnd = 29890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePanelZOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePanelZOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29902, RefRangeEnd = 29905, XrefRangeStart = 29896, XrefRangeEnd = 29902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFocusedPanel(MoveableWindow panel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)panel);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFocusedPanel_Public_Void_MoveableWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29905, XrefRangeEnd = 29910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckCloseOnEsc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCloseOnEsc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29910, XrefRangeEnd = 29923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCanvas()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameCanvas(IntPtr pointer)
		: base(pointer)
	{
	}
}
