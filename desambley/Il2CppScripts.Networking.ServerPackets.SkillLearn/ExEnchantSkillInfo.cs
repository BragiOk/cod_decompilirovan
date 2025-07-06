using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.GameTypes.Skill;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScripts.Networking.ServerPackets.SkillLearn;

public class ExEnchantSkillInfo : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__skillEnchantDesc;

	private static readonly IntPtr NativeFieldInfoPtr__skillReqs;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe List<SkillEnchantReq> _skillReqs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillReqs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SkillEnchantReq>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillReqs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ExEnchantSkillInfo()
	{
		Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.SkillLearn", "ExEnchantSkillInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr);
		NativeFieldInfoPtr__skillEnchantDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr, "_skillEnchantDesc");
		NativeFieldInfoPtr__skillReqs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr, "_skillReqs");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr, 100664414);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13621, XrefRangeEnd = 13640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13640, XrefRangeEnd = 13655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13655, XrefRangeEnd = 13661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExEnchantSkillInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExEnchantSkillInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExEnchantSkillInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
