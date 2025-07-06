using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Persistent;

public class PersistentRoot : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Credentials;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutSchema;

	private static readonly System.IntPtr NativeFieldInfoPtr_Hotkeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_Preferences;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllPersistentData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Credentials Credentials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Credentials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Credentials>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Credentials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)credentials));
		}
	}

	public unsafe ShortcutSchema ShortcutSchema
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutSchema);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShortcutSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutSchema)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shortcutSchema));
		}
	}

	public unsafe HotkeyProfiles Hotkeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotkeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HotkeyProfiles>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotkeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hotkeyProfiles));
		}
	}

	public unsafe Preferences Preferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Preferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Preferences>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Preferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preferences));
		}
	}

	static PersistentRoot()
	{
		Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Persistent", "PersistentRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr);
		NativeFieldInfoPtr_Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, "Credentials");
		NativeFieldInfoPtr_ShortcutSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, "ShortcutSchema");
		NativeFieldInfoPtr_Hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, "Hotkeys");
		NativeFieldInfoPtr_Preferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, "Preferences");
		NativeMethodInfoPtr_LoadAllPersistentData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr, 100665130);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18625, RefRangeEnd = 18626, XrefRangeStart = 18617, XrefRangeEnd = 18625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllPersistentData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllPersistentData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18655, RefRangeEnd = 18656, XrefRangeStart = 18626, XrefRangeEnd = 18655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PersistentRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentRoot>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PersistentRoot(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
