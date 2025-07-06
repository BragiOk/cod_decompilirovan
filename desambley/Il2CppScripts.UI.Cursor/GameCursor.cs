using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.UI.Cursor;

public class GameCursor : MonoBehaviour
{
	[OriginalName("Assembly-Scripts.dll", "", "CursorType")]
	public enum CursorType
	{
		Default,
		Attack,
		Speak,
		Hand,
		ResizeV,
		ResizeH,
		ResizeHV1,
		ResizeHV2
	}

	[System.Serializable]
	public sealed class CursorDef : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Texture;

		private static readonly System.IntPtr NativeFieldInfoPtr_Hotspot;

		public unsafe Texture2D Texture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Texture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Texture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Vector2 Hotspot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotspot);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hotspot)) = vector;
			}
		}

		static CursorDef()
		{
			Il2CppClassPointerStore<CursorDef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "CursorDef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorDef>.NativeClassPtr);
			NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, "Texture");
			NativeFieldInfoPtr_Hotspot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, "Hotspot");
		}

		public CursorDef(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CursorDef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorDef>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__useSoftwareCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__speakCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__attackCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__resizeHCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__resizeVCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__resizeHV1Cursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__resizeHV2Cursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__handCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastCursorType;

	private static readonly System.IntPtr NativeFieldInfoPtr__cursorPrio;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorInternal_Private_Void_CursorType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCursor_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideCursor_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetType_Public_Static_Void_CursorType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCursor_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _useSoftwareCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useSoftwareCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useSoftwareCursor)) = flag;
		}
	}

	public unsafe CursorDef _defaultCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _speakCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__speakCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__speakCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _attackCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attackCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__attackCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _resizeHCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _resizeVCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeVCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeVCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _resizeHV1Cursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHV1Cursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHV1Cursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _resizeHV2Cursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHV2Cursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resizeHV2Cursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorDef _handCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handCursor);
			return new CursorDef(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cursorDef)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CursorDef>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CursorType _lastCursorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastCursorType);
			return *(CursorType*)num;
		}
		set
		{
			*(CursorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastCursorType)) = cursorType;
		}
	}

	public unsafe int _cursorPrio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursorPrio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursorPrio)) = num;
		}
	}

	public unsafe static GameCursor _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCursor>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCursor));
		}
	}

	static GameCursor()
	{
		Il2CppClassPointerStore<GameCursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Cursor", "GameCursor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCursor>.NativeClassPtr);
		NativeFieldInfoPtr__useSoftwareCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_useSoftwareCursor");
		NativeFieldInfoPtr__defaultCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_defaultCursor");
		NativeFieldInfoPtr__speakCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_speakCursor");
		NativeFieldInfoPtr__attackCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_attackCursor");
		NativeFieldInfoPtr__resizeHCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_resizeHCursor");
		NativeFieldInfoPtr__resizeVCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_resizeVCursor");
		NativeFieldInfoPtr__resizeHV1Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_resizeHV1Cursor");
		NativeFieldInfoPtr__resizeHV2Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_resizeHV2Cursor");
		NativeFieldInfoPtr__handCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_handCursor");
		NativeFieldInfoPtr__lastCursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_lastCursorType");
		NativeFieldInfoPtr__cursorPrio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_cursorPrio");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_SetCursorInternal_Private_Void_CursorType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_ShowCursor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_HideCursor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_SetType_Public_Static_Void_CursorType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_ResetCursor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCursor>.NativeClassPtr, 100666622);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32977, XrefRangeEnd = 32980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32980, XrefRangeEnd = 32981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32981, XrefRangeEnd = 32983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 32992, RefRangeEnd = 33000, XrefRangeStart = 32983, XrefRangeEnd = 32992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorInternal(CursorType cursorType, int prio = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cursorType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prio;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorInternal_Private_Void_CursorType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33000, XrefRangeEnd = 33004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowCursor()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCursor_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33004, XrefRangeEnd = 33008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideCursor()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideCursor_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33008, XrefRangeEnd = 33012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetType(CursorType cursorType, int prio = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cursorType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prio;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetType_Public_Static_Void_CursorType_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33012, XrefRangeEnd = 33016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetCursor()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCursor_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCursor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCursor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameCursor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
