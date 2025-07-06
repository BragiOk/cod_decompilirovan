using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.CharacterSystem;
using Il2CppScripts.GameTypes.Character;
using Il2CppScripts.UI.Widgets;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.UserInfo.SubPanels.Stats;

public class CharacterPropertyBarWidget : MonoBehaviour
{
	[OriginalName("Assembly-Scripts.dll", "", "CharacterTarget")]
	public enum CharacterTarget
	{
		User,
		Target
	}

	private static readonly IntPtr NativeFieldInfoPtr__percent;

	private static readonly IntPtr NativeFieldInfoPtr__currentName;

	private static readonly IntPtr NativeFieldInfoPtr__maxName;

	private static readonly IntPtr NativeFieldInfoPtr__percentScale;

	private static readonly IntPtr NativeFieldInfoPtr__targetCharacter;

	private static readonly IntPtr NativeFieldInfoPtr__propertyBar;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateBar_Private_Void_Character_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnCharacterStatsChanged_Private_Void_Character_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _percent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percent)) = flag;
		}
	}

	public unsafe StatusEnum _currentName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentName);
			return *(StatusEnum*)num;
		}
		set
		{
			*(StatusEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentName)) = statusEnum;
		}
	}

	public unsafe StatusEnum _maxName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxName);
			return *(StatusEnum*)num;
		}
		set
		{
			*(StatusEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxName)) = statusEnum;
		}
	}

	public unsafe float _percentScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percentScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percentScale)) = num;
		}
	}

	public unsafe CharacterTarget _targetCharacter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__targetCharacter);
			return *(CharacterTarget*)num;
		}
		set
		{
			*(CharacterTarget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__targetCharacter)) = characterTarget;
		}
	}

	public unsafe PropertyBar _propertyBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propertyBar);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PropertyBar>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propertyBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBar));
		}
	}

	static CharacterPropertyBarWidget()
	{
		Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.UserInfo.SubPanels.Stats", "CharacterPropertyBarWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr);
		NativeFieldInfoPtr__percent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_percent");
		NativeFieldInfoPtr__currentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_currentName");
		NativeFieldInfoPtr__maxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_maxName");
		NativeFieldInfoPtr__percentScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_percentScale");
		NativeFieldInfoPtr__targetCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_targetCharacter");
		NativeFieldInfoPtr__propertyBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, "_propertyBar");
		NativeMethodInfoPtr_UpdateBar_Private_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_OnCharacterStatsChanged_Private_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, 100667855);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr, 100667857);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45798, XrefRangeEnd = 45802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBar(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBar_Private_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45802, XrefRangeEnd = 45803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCharacterStatsChanged(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCharacterStatsChanged_Private_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45803, XrefRangeEnd = 45816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45816, XrefRangeEnd = 45826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45826, XrefRangeEnd = 45829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterPropertyBarWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPropertyBarWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CharacterPropertyBarWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
