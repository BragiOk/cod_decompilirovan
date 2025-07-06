using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Basics;

public class RequestMagicSkillUse : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__skillId;

	private static readonly IntPtr NativeFieldInfoPtr__ctrl;

	private static readonly IntPtr NativeFieldInfoPtr__shift;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0;

	public unsafe int _skillId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skillId)) = num;
		}
	}

	public unsafe bool _ctrl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ctrl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ctrl)) = flag;
		}
	}

	public unsafe bool _shift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shift);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shift)) = flag;
		}
	}

	static RequestMagicSkillUse()
	{
		Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Basics", "RequestMagicSkillUse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr);
		NativeFieldInfoPtr__skillId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, "_skillId");
		NativeFieldInfoPtr__ctrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, "_ctrl");
		NativeFieldInfoPtr__shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, "_shift");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr, 100665030);
	}

	[CallerCount(0)]
	public unsafe RequestMagicSkillUse(int skillId, bool ctrl = false, bool shift = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestMagicSkillUse>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&skillId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &ctrl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &shift;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17625, XrefRangeEnd = 17627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17627, XrefRangeEnd = 17631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DoOfflineAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoOfflineAction_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestMagicSkillUse(IntPtr pointer)
		: base(pointer)
	{
	}
}
