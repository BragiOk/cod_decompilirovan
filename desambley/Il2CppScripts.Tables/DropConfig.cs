using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Tables;

[System.Serializable]
public class DropConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DropType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropAnimType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropSound;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int DropType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropType)) = num;
		}
	}

	public unsafe int DropAnimType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropAnimType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropAnimType)) = num;
		}
	}

	public unsafe int DropRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropRadius);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropRadius)) = num;
		}
	}

	public unsafe int DropHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropHeight)) = num;
		}
	}

	public unsafe Il2CppStringArray DropMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStringArray DropTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string DropSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropSound);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropSound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static DropConfig()
	{
		Il2CppClassPointerStore<DropConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "DropConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropConfig>.NativeClassPtr);
		NativeFieldInfoPtr_DropType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropType");
		NativeFieldInfoPtr_DropAnimType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropAnimType");
		NativeFieldInfoPtr_DropRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropRadius");
		NativeFieldInfoPtr_DropHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropHeight");
		NativeFieldInfoPtr_DropMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropMesh");
		NativeFieldInfoPtr_DropTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropTex");
		NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, "DropSound");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropConfig>.NativeClassPtr, 100663702);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DropConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
