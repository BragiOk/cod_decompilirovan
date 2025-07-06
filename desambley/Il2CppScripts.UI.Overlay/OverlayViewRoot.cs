using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Overlay.ContextMenu;
using Il2CppScripts.UI.Overlay.Curtain;
using Il2CppScripts.UI.Overlay.DragIcon;
using Il2CppScripts.UI.Overlay.Prompt;
using Il2CppScripts.UI.Overlay.TextDisplay;
using Il2CppScripts.UI.Overlay.Tooltips;
using UnityEngine;

namespace Il2CppScripts.UI.Overlay;

public class OverlayViewRoot : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_DragIcon;

	private static readonly IntPtr NativeFieldInfoPtr_Prompt;

	private static readonly IntPtr NativeFieldInfoPtr_Tooltip;

	private static readonly IntPtr NativeFieldInfoPtr_TextOverlay;

	private static readonly IntPtr NativeFieldInfoPtr_ContextMenu;

	private static readonly IntPtr NativeFieldInfoPtr_Curtain;

	private static readonly IntPtr NativeFieldInfoPtr_Curtain2;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppScripts.UI.Overlay.DragIcon.DragIcon DragIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScripts.UI.Overlay.DragIcon.DragIcon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dragIcon));
		}
	}

	public unsafe PromptPanel Prompt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prompt);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PromptPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prompt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)promptPanel));
		}
	}

	public unsafe TooltipPanel Tooltip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tooltip);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TooltipPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tooltip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tooltipPanel));
		}
	}

	public unsafe Il2CppScripts.UI.Overlay.TextDisplay.TextDisplay TextOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextOverlay);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScripts.UI.Overlay.TextDisplay.TextDisplay>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textDisplay));
		}
	}

	public unsafe ContextMenuPanel ContextMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContextMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ContextMenuPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContextMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextMenuPanel));
		}
	}

	public unsafe Il2CppScripts.UI.Overlay.Curtain.Curtain Curtain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Curtain);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScripts.UI.Overlay.Curtain.Curtain>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Curtain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curtain));
		}
	}

	public unsafe Il2CppScripts.UI.Overlay.Curtain.Curtain Curtain2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Curtain2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppScripts.UI.Overlay.Curtain.Curtain>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Curtain2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curtain));
		}
	}

	static OverlayViewRoot()
	{
		Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay", "OverlayViewRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr);
		NativeFieldInfoPtr_DragIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "DragIcon");
		NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "Prompt");
		NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "Tooltip");
		NativeFieldInfoPtr_TextOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "TextOverlay");
		NativeFieldInfoPtr_ContextMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "ContextMenu");
		NativeFieldInfoPtr_Curtain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "Curtain");
		NativeFieldInfoPtr_Curtain2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, "Curtain2");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr, 100665768);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25596, XrefRangeEnd = 25645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OverlayViewRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayViewRoot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OverlayViewRoot(IntPtr pointer)
		: base(pointer)
	{
	}
}
