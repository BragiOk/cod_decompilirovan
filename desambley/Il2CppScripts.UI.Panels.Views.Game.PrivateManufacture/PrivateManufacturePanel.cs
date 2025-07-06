using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes;
using Il2CppScripts.UI.Elements.ScrollList;
using Il2CppScripts.UI.Widgets;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Game.PrivateManufacture;

public class PrivateManufacturePanel : MonoBehaviour
{
	public sealed class State : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Adena;

		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMp;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxMp;

		private static readonly System.IntPtr NativeFieldInfoPtr_CraftsmanId;

		private static readonly System.IntPtr NativeFieldInfoPtr_Recipes;

		public unsafe int Adena
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Adena);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Adena)) = num;
			}
		}

		public unsafe int CurrentMp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMp);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMp)) = num;
			}
		}

		public unsafe int MaxMp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxMp);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxMp)) = num;
			}
		}

		public unsafe int CraftsmanId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CraftsmanId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CraftsmanId)) = num;
			}
		}

		public unsafe List<ItemState> Recipes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Recipes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemState>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Recipes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			NativeFieldInfoPtr_Adena = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "Adena");
			NativeFieldInfoPtr_CurrentMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "CurrentMp");
			NativeFieldInfoPtr_MaxMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "MaxMp");
			NativeFieldInfoPtr_CraftsmanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "CraftsmanId");
			NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "Recipes");
		}

		public State(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public State()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<State>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("Scripts.UI.Panels.Views.Game.PrivateManufacture.PrivateManufacturePanel+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_state;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetState_b__0_Internal_Void_Int32_ManufactureRecipeEntry_0;

		public unsafe State state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
				return new State(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<State>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "state");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100667317);
			NativeMethodInfoPtr__SetState_b__0_Internal_Void_Int32_ManufactureRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100667318);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40455, XrefRangeEnd = 40457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetState_b__0(int i, ManufactureRecipeEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetState_b__0_Internal_Void_Int32_ManufactureRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass5_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__recipeContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr__manaBar;

	private static readonly System.IntPtr NativeFieldInfoPtr__recipeScrollList;

	private static readonly System.IntPtr NativeFieldInfoPtr__manufactureRecipeEntryTemplate;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RectTransform _recipeContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe PropertyBar _manaBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__manaBar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyBar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__manaBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyBar));
		}
	}

	public unsafe SnapScrollList _recipeScrollList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeScrollList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SnapScrollList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__recipeScrollList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snapScrollList));
		}
	}

	public unsafe ManufactureRecipeEntry _manufactureRecipeEntryTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__manufactureRecipeEntryTemplate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManufactureRecipeEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__manufactureRecipeEntryTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manufactureRecipeEntry));
		}
	}

	static PrivateManufacturePanel()
	{
		Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.PrivateManufacture", "PrivateManufacturePanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr);
		NativeFieldInfoPtr__recipeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "_recipeContainer");
		NativeFieldInfoPtr__manaBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "_manaBar");
		NativeFieldInfoPtr__recipeScrollList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "_recipeScrollList");
		NativeFieldInfoPtr__manufactureRecipeEntryTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, "_manufactureRecipeEntryTemplate");
		NativeMethodInfoPtr_SetState_Public_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr, 100667316);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40476, RefRangeEnd = 40477, XrefRangeStart = 40457, XrefRangeEnd = 40476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetState(State state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetState_Public_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrivateManufacturePanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrivateManufacturePanel>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PrivateManufacturePanel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
