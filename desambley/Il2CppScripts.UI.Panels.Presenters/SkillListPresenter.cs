using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes.Skill;
using Il2CppScripts.UI.Icons.IconTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Presenters;

public class SkillListPresenter : MonoBehaviour
{
	[OriginalName("Assembly-Scripts.dll", "", "SkillGroupFlags")]
	public enum SkillGroupFlags
	{
		Attacking = 1,
		Enhancing = 2,
		Debuffs = 4,
		Other = 8,
		Passive = 0x10
	}

	private static readonly IntPtr NativeFieldInfoPtr__skillGroup;

	private static readonly IntPtr NativeFieldInfoPtr__allowDrag;

	private static readonly IntPtr NativeFieldInfoPtr__skillIconPrefab;

	private static readonly IntPtr NativeMethodInfoPtr_OnSkillListChanged_Private_Void_IReadOnlyCollection_1_SkillInstance_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnSkillListChanged_b__4_0_Private_Void_SkillIcon_SkillInstance_0;

	public unsafe SkillGroupFlags _skillGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillGroup);
			return *(SkillGroupFlags*)num;
		}
		set
		{
			*(SkillGroupFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillGroup)) = skillGroupFlags;
		}
	}

	public unsafe bool _allowDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowDrag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowDrag)) = flag;
		}
	}

	public unsafe SkillIcon _skillIconPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillIconPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillIcon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillIconPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillIcon));
		}
	}

	static SkillListPresenter()
	{
		Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Presenters", "SkillListPresenter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr);
		NativeFieldInfoPtr__skillGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, "_skillGroup");
		NativeFieldInfoPtr__allowDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, "_allowDrag");
		NativeFieldInfoPtr__skillIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, "_skillIconPrefab");
		NativeMethodInfoPtr_OnSkillListChanged_Private_Void_IReadOnlyCollection_1_SkillInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666909);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666910);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666911);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666912);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666913);
		NativeMethodInfoPtr__OnSkillListChanged_b__4_0_Private_Void_SkillIcon_SkillInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr, 100666914);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35753, RefRangeEnd = 35754, XrefRangeStart = 35711, XrefRangeEnd = 35753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSkillListChanged(IReadOnlyCollection<SkillInstance> skills)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skills);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSkillListChanged_Private_Void_IReadOnlyCollection_1_SkillInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35754, XrefRangeEnd = 35758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35758, XrefRangeEnd = 35768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35768, XrefRangeEnd = 35778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35778, XrefRangeEnd = 35781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillListPresenter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillListPresenter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35781, XrefRangeEnd = 35782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnSkillListChanged_b__4_0(SkillIcon icon, SkillInstance instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnSkillListChanged_b__4_0_Private_Void_SkillIcon_SkillInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillListPresenter(IntPtr pointer)
		: base(pointer)
	{
	}
}
