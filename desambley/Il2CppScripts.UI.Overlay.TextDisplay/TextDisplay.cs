using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Overlay.TextDisplay;

public class TextDisplay : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Disable;

	private static readonly IntPtr NativeFieldInfoPtr__textPrefab;

	private static readonly IntPtr NativeFieldInfoPtr__textMap;

	private static readonly IntPtr NativeMethodInfoPtr_ShowText_Public_Void_State_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool Disable
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Disable, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Disable, (void*)(&flag));
		}
	}

	public unsafe TextDisplayText _textPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextDisplayText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textDisplayText));
		}
	}

	public unsafe Dictionary<int, TextDisplayText> _textMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textMap);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TextDisplayText>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static TextDisplay()
	{
		Il2CppClassPointerStore<TextDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Overlay.TextDisplay", "TextDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr);
		NativeFieldInfoPtr_Disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr, "Disable");
		NativeFieldInfoPtr__textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr, "_textPrefab");
		NativeFieldInfoPtr__textMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr, "_textMap");
		NativeMethodInfoPtr_ShowText_Public_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr, 100665832);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26539, RefRangeEnd = 26540, XrefRangeStart = 26513, XrefRangeEnd = 26539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowText(TextDisplayText.State state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowText_Public_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26540, XrefRangeEnd = 26549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextDisplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextDisplay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextDisplay(IntPtr pointer)
		: base(pointer)
	{
	}
}
