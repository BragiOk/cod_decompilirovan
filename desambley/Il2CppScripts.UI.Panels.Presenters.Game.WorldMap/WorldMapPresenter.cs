using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Panels.Views.Game.WorldMap;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Presenters.Game.WorldMap;

public class WorldMapPresenter : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__worldMapPanel;

	private static readonly IntPtr NativeFieldInfoPtr__wasFocused;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe WorldMapPanel _worldMapPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldMapPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<WorldMapPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldMapPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldMapPanel));
		}
	}

	public unsafe bool _wasFocused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasFocused);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasFocused)) = flag;
		}
	}

	static WorldMapPresenter()
	{
		Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Presenters.Game.WorldMap", "WorldMapPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr);
		NativeFieldInfoPtr__worldMapPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr, "_worldMapPanel");
		NativeFieldInfoPtr__wasFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr, "_wasFocused");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr, 100666915);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldMapPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldMapPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldMapPresenter(IntPtr pointer)
		: base(pointer)
	{
	}
}
