using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.Shortcuts;

public class PreventShortcutDeleteOnDropMarker : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PreventShortcutDeleteOnDropMarker()
	{
		Il2CppClassPointerStore<PreventShortcutDeleteOnDropMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.Shortcuts", "PreventShortcutDeleteOnDropMarker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreventShortcutDeleteOnDropMarker>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreventShortcutDeleteOnDropMarker>.NativeClassPtr, 100667198);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PreventShortcutDeleteOnDropMarker()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreventShortcutDeleteOnDropMarker>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PreventShortcutDeleteOnDropMarker(IntPtr pointer)
		: base(pointer)
	{
	}
}
