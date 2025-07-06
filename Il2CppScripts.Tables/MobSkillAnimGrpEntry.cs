using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class MobSkillAnimGrpEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_npc_id;

	private static readonly IntPtr NativeFieldInfoPtr_skill_id;

	private static readonly IntPtr NativeFieldInfoPtr_seq_name;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int npc_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npc_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npc_id)) = num;
		}
	}

	public unsafe int skill_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skill_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skill_id)) = num;
		}
	}

	public unsafe string seq_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seq_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seq_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static MobSkillAnimGrpEntry()
	{
		Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "MobSkillAnimGrpEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr);
		NativeFieldInfoPtr_npc_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr, "npc_id");
		NativeFieldInfoPtr_skill_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr, "skill_id");
		NativeFieldInfoPtr_seq_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr, "seq_name");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr, 100663712);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobSkillAnimGrpEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobSkillAnimGrpEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MobSkillAnimGrpEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
