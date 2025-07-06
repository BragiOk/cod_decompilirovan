using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScripts.Components.Entity;

public class ItemBody : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_DropType;

	private static readonly IntPtr NativeFieldInfoPtr_DropAnimType;

	private static readonly IntPtr NativeFieldInfoPtr_DropRadius;

	private static readonly IntPtr NativeFieldInfoPtr_DropHeight;

	private static readonly IntPtr NativeFieldInfoPtr_DropSound;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe float DropRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropRadius)) = num;
		}
	}

	public unsafe float DropHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropHeight)) = num;
		}
	}

	public unsafe AudioClip DropSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropSound);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioClip));
		}
	}

	static ItemBody()
	{
		Il2CppClassPointerStore<ItemBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components.Entity", "ItemBody");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemBody>.NativeClassPtr);
		NativeFieldInfoPtr_DropType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, "DropType");
		NativeFieldInfoPtr_DropAnimType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, "DropAnimType");
		NativeFieldInfoPtr_DropRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, "DropRadius");
		NativeFieldInfoPtr_DropHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, "DropHeight");
		NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, "DropSound");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemBody>.NativeClassPtr, 100669984);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemBody()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemBody>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemBody(IntPtr pointer)
		: base(pointer)
	{
	}
}
