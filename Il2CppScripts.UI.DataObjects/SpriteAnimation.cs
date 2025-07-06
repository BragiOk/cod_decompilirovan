using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Classes;
using UnityEngine;

namespace Il2CppScripts.UI.DataObjects;

public class SpriteAnimation : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr__animationData;

	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_SpriteAnimationData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SpriteAnimationData _animationData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animationData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteAnimationData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animationData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAnimationData));
		}
	}

	public unsafe SpriteAnimationData Data
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 656, RefRangeEnd = 658, XrefRangeStart = 656, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Data_Public_get_SpriteAnimationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpriteAnimationData>(intPtr) : null;
		}
	}

	static SpriteAnimation()
	{
		Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.DataObjects", "SpriteAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr);
		NativeFieldInfoPtr__animationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr, "_animationData");
		NativeMethodInfoPtr_get_Data_Public_get_SpriteAnimationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr, 100666038);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr, 100666039);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteAnimation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAnimation>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SpriteAnimation(IntPtr pointer)
		: base(pointer)
	{
	}
}
