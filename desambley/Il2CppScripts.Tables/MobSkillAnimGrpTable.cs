using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Tables;

public class MobSkillAnimGrpTable : DataTable<MobSkillAnimGrpEntry>
{
	private static readonly System.IntPtr NativeFieldInfoPtr__dictionary;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataEntry_Public_MobSkillAnimGrpEntry_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateDictionary_Protected_Virtual_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<Il2CppSystem.ValueTuple<int, int>, MobSkillAnimGrpEntry> _dictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.ValueTuple<int, int>, MobSkillAnimGrpEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static MobSkillAnimGrpTable()
	{
		Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "MobSkillAnimGrpTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr);
		NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr, "_dictionary");
		NativeMethodInfoPtr_GetDataEntry_Public_MobSkillAnimGrpEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_PopulateDictionary_Protected_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr, 100663715);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4879, XrefRangeEnd = 4886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobSkillAnimGrpEntry GetDataEntry(int npcId, int skillId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&npcId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skillId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataEntry_Public_MobSkillAnimGrpEntry_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobSkillAnimGrpEntry>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4886, XrefRangeEnd = 4898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PopulateDictionary(string key, bool multimap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multimap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PopulateDictionary_Protected_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4898, XrefRangeEnd = 4907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobSkillAnimGrpTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobSkillAnimGrpTable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MobSkillAnimGrpTable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
