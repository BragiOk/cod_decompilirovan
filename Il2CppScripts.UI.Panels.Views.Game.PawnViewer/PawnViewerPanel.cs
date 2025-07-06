using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Panels.Views.Game.PawnViewer.SubPanels;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.PawnViewer;

public class PawnViewerPanel : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__modelViewerPanel;

	private static readonly IntPtr NativeFieldInfoPtr__paperdollViewerPanel;

	private static readonly IntPtr NativeFieldInfoPtr__pawnViewerOptionsPanel;

	private static readonly IntPtr NativeMethodInfoPtr_get_ModelViewer_Public_get_ModelViewerPanel_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PaperdollViewer_Public_get_PaperdollViewerPanel_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ModelViewerPanel _modelViewerPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modelViewerPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ModelViewerPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modelViewerPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modelViewerPanel));
		}
	}

	public unsafe PaperdollViewerPanel _paperdollViewerPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paperdollViewerPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PaperdollViewerPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paperdollViewerPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paperdollViewerPanel));
		}
	}

	public unsafe PawnViewerOptionsPanel _pawnViewerOptionsPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pawnViewerOptionsPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PawnViewerOptionsPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pawnViewerOptionsPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pawnViewerOptionsPanel));
		}
	}

	public unsafe ModelViewerPanel ModelViewer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ModelViewer_Public_get_ModelViewerPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ModelViewerPanel>(intPtr) : null;
		}
	}

	public unsafe PaperdollViewerPanel PaperdollViewer
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PaperdollViewer_Public_get_PaperdollViewerPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PaperdollViewerPanel>(intPtr) : null;
		}
	}

	static PawnViewerPanel()
	{
		Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.PawnViewer", "PawnViewerPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr);
		NativeFieldInfoPtr__modelViewerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, "_modelViewerPanel");
		NativeFieldInfoPtr__paperdollViewerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, "_paperdollViewerPanel");
		NativeFieldInfoPtr__pawnViewerOptionsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, "_pawnViewerOptionsPanel");
		NativeMethodInfoPtr_get_ModelViewer_Public_get_ModelViewerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, 100667353);
		NativeMethodInfoPtr_get_PaperdollViewer_Public_get_PaperdollViewerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, 100667354);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr, 100667355);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PawnViewerPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnViewerPanel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PawnViewerPanel(IntPtr pointer)
		: base(pointer)
	{
	}
}
