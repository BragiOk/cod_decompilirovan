using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI;

public class CrestCache : Il2CppSystem.Object
{
	[OriginalName("Assembly-Scripts.dll", "", "CrestType")]
	public enum CrestType
	{
		Pledge,
		Alliance
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Pledge;

	private static readonly System.IntPtr NativeFieldInfoPtr_Alliance;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrestUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr__crestTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr__requestSent;

	private static readonly System.IntPtr NativeFieldInfoPtr__crestType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PledgeCrestSize_Public_Static_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PledgeCrestRealSize_Public_Static_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PledgeCrestByteSize_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllianceCrestSize_Public_Static_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllianceCrestRealSize_Public_Static_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllianceCrestByteSize_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_CrestUpdated_Public_add_Void_Action_2_Int32_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_CrestUpdated_Public_rem_Void_Action_2_Int32_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CrestType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAndPrepareCrestTexture_Public_Static_Il2CppStructArray_1_Byte_String_CrestType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipTextureVertically_Private_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipTextureHorizontally_Private_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCrestTextureRaw_Public_Void_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCrestTexture_Public_Texture2D_Int32_0;

	public unsafe static CrestCache Pledge
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pledge, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CrestCache>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pledge, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)crestCache));
		}
	}

	public unsafe static CrestCache Alliance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Alliance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CrestCache>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Alliance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)crestCache));
		}
	}

	public unsafe Il2CppSystem.Action<int, Texture2D> CrestUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrestUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, Texture2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrestUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Dictionary<int, Texture2D> _crestTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Texture2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<int> _requestSent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__requestSent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__requestSent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe CrestType _crestType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestType);
			return *(CrestType*)num;
		}
		set
		{
			*(CrestType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crestType)) = crestType;
		}
	}

	public unsafe static Vector2Int PledgeCrestSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PledgeCrestSize_Public_Static_get_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static Vector2Int PledgeCrestRealSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PledgeCrestRealSize_Public_Static_get_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static int PledgeCrestByteSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PledgeCrestByteSize_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static Vector2Int AllianceCrestSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllianceCrestSize_Public_Static_get_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static Vector2Int AllianceCrestRealSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllianceCrestRealSize_Public_Static_get_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static int AllianceCrestByteSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllianceCrestByteSize_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static CrestCache()
	{
		Il2CppClassPointerStore<CrestCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI", "CrestCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrestCache>.NativeClassPtr);
		NativeFieldInfoPtr_Pledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "Pledge");
		NativeFieldInfoPtr_Alliance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "Alliance");
		NativeFieldInfoPtr_CrestUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "CrestUpdated");
		NativeFieldInfoPtr__crestTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "_crestTextures");
		NativeFieldInfoPtr__requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "_requestSent");
		NativeFieldInfoPtr__crestType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, "_crestType");
		NativeMethodInfoPtr_get_PledgeCrestSize_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665522);
		NativeMethodInfoPtr_get_PledgeCrestRealSize_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665523);
		NativeMethodInfoPtr_get_PledgeCrestByteSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665524);
		NativeMethodInfoPtr_get_AllianceCrestSize_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665525);
		NativeMethodInfoPtr_get_AllianceCrestRealSize_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665526);
		NativeMethodInfoPtr_get_AllianceCrestByteSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665527);
		NativeMethodInfoPtr_add_CrestUpdated_Public_add_Void_Action_2_Int32_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665528);
		NativeMethodInfoPtr_remove_CrestUpdated_Public_rem_Void_Action_2_Int32_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665529);
		NativeMethodInfoPtr__ctor_Public_Void_CrestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665530);
		NativeMethodInfoPtr_LoadAndPrepareCrestTexture_Public_Static_Il2CppStructArray_1_Byte_String_CrestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665531);
		NativeMethodInfoPtr_FlipTextureVertically_Private_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665532);
		NativeMethodInfoPtr_FlipTextureHorizontally_Private_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665533);
		NativeMethodInfoPtr_SetCrestTextureRaw_Public_Void_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665534);
		NativeMethodInfoPtr_GetCrestTexture_Public_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrestCache>.NativeClassPtr, 100665535);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22935, RefRangeEnd = 22937, XrefRangeStart = 22927, XrefRangeEnd = 22935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_CrestUpdated(Il2CppSystem.Action<int, Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_CrestUpdated_Public_add_Void_Action_2_Int32_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22945, RefRangeEnd = 22947, XrefRangeStart = 22937, XrefRangeEnd = 22945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_CrestUpdated(Il2CppSystem.Action<int, Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_CrestUpdated_Public_rem_Void_Action_2_Int32_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22947, XrefRangeEnd = 22958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrestCache(CrestType crestType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrestCache>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&crestType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CrestType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23054, RefRangeEnd = 23055, XrefRangeStart = 22958, XrefRangeEnd = 23054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> LoadAndPrepareCrestTexture(string path, CrestType crestType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(CrestType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crestType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAndPrepareCrestTexture_Public_Static_Il2CppStructArray_1_Byte_String_CrestType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23063, RefRangeEnd = 23065, XrefRangeStart = 23055, XrefRangeEnd = 23063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipTextureVertically(Texture2D original)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)original);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipTextureVertically_Private_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23065, XrefRangeEnd = 23073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipTextureHorizontally(Texture2D original)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)original);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipTextureHorizontally_Private_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23123, RefRangeEnd = 23125, XrefRangeStart = 23073, XrefRangeEnd = 23123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCrestTextureRaw(int crestId, Il2CppStructArray<byte> rawData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&crestId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCrestTextureRaw_Public_Void_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 23153, RefRangeEnd = 23159, XrefRangeStart = 23125, XrefRangeEnd = 23153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D GetCrestTexture(int crestId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&crestId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCrestTexture_Public_Texture2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	public CrestCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
