using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes.Lobby;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Model;

public class LobbyModel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CharactersChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCharacterCreateResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCharacterDeleteResult;

	private static readonly System.IntPtr NativeFieldInfoPtr__Characters_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CharCreateResult_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CharDeleteResult_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_CharactersChanged_Public_add_Void_Action_1_IEnumerable_1_LobbyCharacter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_CharactersChanged_Public_rem_Void_Action_1_IEnumerable_1_LobbyCharacter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCharacterCreateResult_Public_add_Void_Action_1_CharCreateResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCharacterCreateResult_Public_rem_Void_Action_1_CharCreateResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCharacterDeleteResult_Public_add_Void_Action_1_CharDeleteResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCharacterDeleteResult_Public_rem_Void_Action_1_CharDeleteResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Characters_Public_get_List_1_LobbyCharacter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Characters_Private_set_Void_List_1_LobbyCharacter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharCreateResult_Public_get_CharCreateResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CharCreateResult_Private_set_Void_CharCreateResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharDeleteResult_Public_get_CharDeleteResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CharDeleteResult_Private_set_Void_CharDeleteResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterList_Public_Void_List_1_LobbyCharacter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterCreateResult_Public_Void_CharCreateResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharDeleteResult_Public_Void_CharDeleteResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppSystem.Action<IEnumerable<LobbyCharacter>> CharactersChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharactersChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<IEnumerable<LobbyCharacter>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharactersChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<CharCreateResult> OnCharacterCreateResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCharacterCreateResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CharCreateResult>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCharacterCreateResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<CharDeleteResult> OnCharacterDeleteResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCharacterDeleteResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CharDeleteResult>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCharacterDeleteResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe List<LobbyCharacter> _Characters_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Characters_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LobbyCharacter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Characters_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CharCreateResult _CharCreateResult_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharCreateResult_k__BackingField);
			return *(CharCreateResult*)num;
		}
		set
		{
			*(CharCreateResult*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharCreateResult_k__BackingField)) = charCreateResult;
		}
	}

	public unsafe CharDeleteResult _CharDeleteResult_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharDeleteResult_k__BackingField);
			return *(CharDeleteResult*)num;
		}
		set
		{
			*(CharDeleteResult*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharDeleteResult_k__BackingField)) = charDeleteResult;
		}
	}

	public unsafe List<LobbyCharacter> Characters
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24851, RefRangeEnd = 24857, XrefRangeStart = 24851, XrefRangeEnd = 24857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Characters_Public_get_List_1_LobbyCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LobbyCharacter>>(intPtr) : null;
		}
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 32851, RefRangeEnd = 32890, XrefRangeStart = 32851, XrefRangeEnd = 32890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Characters_Private_set_Void_List_1_LobbyCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CharCreateResult CharCreateResult
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharCreateResult_Public_get_CharCreateResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CharCreateResult*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CharCreateResult_Private_set_Void_CharCreateResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CharDeleteResult CharDeleteResult
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharDeleteResult_Public_get_CharDeleteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CharDeleteResult*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CharDeleteResult_Private_set_Void_CharDeleteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LobbyModel()
	{
		Il2CppClassPointerStore<LobbyModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Model", "LobbyModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr);
		NativeFieldInfoPtr_CharactersChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "CharactersChanged");
		NativeFieldInfoPtr_OnCharacterCreateResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "OnCharacterCreateResult");
		NativeFieldInfoPtr_OnCharacterDeleteResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "OnCharacterDeleteResult");
		NativeFieldInfoPtr__Characters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "<Characters>k__BackingField");
		NativeFieldInfoPtr__CharCreateResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "<CharCreateResult>k__BackingField");
		NativeFieldInfoPtr__CharDeleteResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, "<CharDeleteResult>k__BackingField");
		NativeMethodInfoPtr_add_CharactersChanged_Public_add_Void_Action_1_IEnumerable_1_LobbyCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668202);
		NativeMethodInfoPtr_remove_CharactersChanged_Public_rem_Void_Action_1_IEnumerable_1_LobbyCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668203);
		NativeMethodInfoPtr_add_OnCharacterCreateResult_Public_add_Void_Action_1_CharCreateResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668204);
		NativeMethodInfoPtr_remove_OnCharacterCreateResult_Public_rem_Void_Action_1_CharCreateResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668205);
		NativeMethodInfoPtr_add_OnCharacterDeleteResult_Public_add_Void_Action_1_CharDeleteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668206);
		NativeMethodInfoPtr_remove_OnCharacterDeleteResult_Public_rem_Void_Action_1_CharDeleteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668207);
		NativeMethodInfoPtr_get_Characters_Public_get_List_1_LobbyCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668208);
		NativeMethodInfoPtr_set_Characters_Private_set_Void_List_1_LobbyCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668209);
		NativeMethodInfoPtr_get_CharCreateResult_Public_get_CharCreateResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668210);
		NativeMethodInfoPtr_set_CharCreateResult_Private_set_Void_CharCreateResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668211);
		NativeMethodInfoPtr_get_CharDeleteResult_Public_get_CharDeleteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668212);
		NativeMethodInfoPtr_set_CharDeleteResult_Private_set_Void_CharDeleteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668213);
		NativeMethodInfoPtr_SetCharacterList_Public_Void_List_1_LobbyCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668214);
		NativeMethodInfoPtr_SetCharacterCreateResult_Public_Void_CharCreateResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668215);
		NativeMethodInfoPtr_SetCharDeleteResult_Public_Void_CharDeleteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668216);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr, 100668217);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49283, XrefRangeEnd = 49291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_CharactersChanged(Il2CppSystem.Action<IEnumerable<LobbyCharacter>> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_CharactersChanged_Public_add_Void_Action_1_IEnumerable_1_LobbyCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49291, XrefRangeEnd = 49299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_CharactersChanged(Il2CppSystem.Action<IEnumerable<LobbyCharacter>> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_CharactersChanged_Public_rem_Void_Action_1_IEnumerable_1_LobbyCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49299, XrefRangeEnd = 49307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCharacterCreateResult(Il2CppSystem.Action<CharCreateResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnCharacterCreateResult_Public_add_Void_Action_1_CharCreateResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49307, XrefRangeEnd = 49315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCharacterCreateResult(Il2CppSystem.Action<CharCreateResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnCharacterCreateResult_Public_rem_Void_Action_1_CharCreateResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49315, XrefRangeEnd = 49323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCharacterDeleteResult(Il2CppSystem.Action<CharDeleteResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnCharacterDeleteResult_Public_add_Void_Action_1_CharDeleteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49323, XrefRangeEnd = 49331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCharacterDeleteResult(Il2CppSystem.Action<CharDeleteResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnCharacterDeleteResult_Public_rem_Void_Action_1_CharDeleteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49331, XrefRangeEnd = 49337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCharacterList(List<LobbyCharacter> lobbyCharacters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lobbyCharacters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharacterList_Public_Void_List_1_LobbyCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetCharacterCreateResult(CharCreateResult charCreateResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charCreateResult);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharacterCreateResult_Public_Void_CharCreateResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetCharDeleteResult(CharDeleteResult charDeleteResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charDeleteResult);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharDeleteResult_Public_Void_CharDeleteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LobbyModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyModel>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LobbyModel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
