using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes.Skill;
using Il2CppScripts.Tables;
using Il2CppScripts.UI.Elements.Utility;
using Il2CppScripts.UI.Icons;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScripts.UI.Panels.Views.Game.SkillEnchant;

public class SkillEnchantSkillEntry : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__skillIcon;

	private static readonly IntPtr NativeFieldInfoPtr__descriptionTemplate;

	private static readonly IntPtr NativeFieldInfoPtr__packetType;

	private static readonly IntPtr NativeFieldInfoPtr__skillEnchantDesc;

	private static readonly IntPtr NativeFieldInfoPtr__skillEntry;

	private static readonly IntPtr NativeFieldInfoPtr__mode;

	private static readonly IntPtr NativeMethodInfoPtr_OnSkillListEntryClick_Private_Void_SkillEnchantDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSkill_Public_Void_SkillEnchantDesc_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IconImage _skillIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IconImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iconImage));
		}
	}

	public unsafe TemplateText _descriptionTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__descriptionTemplate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemplateText>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__descriptionTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)templateText));
		}
	}

	public unsafe SkillEnchantPacketType _packetType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__packetType);
			return *(SkillEnchantPacketType*)num;
		}
		set
		{
			*(SkillEnchantPacketType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__packetType)) = skillEnchantPacketType;
		}
	}

	public unsafe SkillEnchantDesc _skillEnchantDesc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEnchantDesc);
			return *(SkillEnchantDesc*)num;
		}
		set
		{
			*(SkillEnchantDesc*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEnchantDesc)) = skillEnchantDesc;
		}
	}

	public unsafe SkillEntry _skillEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEntry);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkillEntry>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillEntry));
		}
	}

	public unsafe int _mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mode)) = num;
		}
	}

	static SkillEnchantSkillEntry()
	{
		Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Game.SkillEnchant", "SkillEnchantSkillEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr);
		NativeFieldInfoPtr__skillIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_skillIcon");
		NativeFieldInfoPtr__descriptionTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_descriptionTemplate");
		NativeFieldInfoPtr__packetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_packetType");
		NativeFieldInfoPtr__skillEnchantDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_skillEnchantDesc");
		NativeFieldInfoPtr__skillEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_skillEntry");
		NativeFieldInfoPtr__mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, "_mode");
		NativeMethodInfoPtr_OnSkillListEntryClick_Private_Void_SkillEnchantDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_SetMode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_SetSkill_Public_Void_SkillEnchantDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr, 100667154);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38346, RefRangeEnd = 38347, XrefRangeStart = 38328, XrefRangeEnd = 38346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSkillListEntryClick(SkillEnchantDesc skillEnchantDesc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&skillEnchantDesc);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSkillListEntryClick_Private_Void_SkillEnchantDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38347, XrefRangeEnd = 38348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetMode(int mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38383, RefRangeEnd = 38384, XrefRangeStart = 38348, XrefRangeEnd = 38383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkill(SkillEnchantDesc skill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&skill);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkill_Public_Void_SkillEnchantDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool HandleIconEvent(IconHandle icon, IconEvent e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		*(IconEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &e;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleIconEvent_Public_Virtual_Final_New_Boolean_IconHandle_IconEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillEnchantSkillEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillEnchantSkillEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillEnchantSkillEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
