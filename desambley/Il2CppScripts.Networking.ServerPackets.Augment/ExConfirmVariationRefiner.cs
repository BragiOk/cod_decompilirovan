using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ServerPackets.Augment;

public class ExConfirmVariationRefiner : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__refinerItemObjectId;

	private static readonly IntPtr NativeFieldInfoPtr__lifestoneItemId;

	private static readonly IntPtr NativeFieldInfoPtr__gemstoneItemId;

	private static readonly IntPtr NativeFieldInfoPtr__gemstoneCount;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _refinerItemObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__refinerItemObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__refinerItemObjectId)) = num;
		}
	}

	public unsafe int _lifestoneItemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lifestoneItemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lifestoneItemId)) = num;
		}
	}

	public unsafe int _gemstoneItemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneItemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneItemId)) = num;
		}
	}

	public unsafe int _gemstoneCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneCount)) = num;
		}
	}

	static ExConfirmVariationRefiner()
	{
		Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.Augment", "ExConfirmVariationRefiner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr);
		NativeFieldInfoPtr__refinerItemObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, "_refinerItemObjectId");
		NativeFieldInfoPtr__lifestoneItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, "_lifestoneItemId");
		NativeFieldInfoPtr__gemstoneItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, "_gemstoneItemId");
		NativeFieldInfoPtr__gemstoneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, "_gemstoneCount");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, 100664842);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, 100664843);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr, 100664844);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16965, XrefRangeEnd = 16971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16971, XrefRangeEnd = 16976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExConfirmVariationRefiner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExConfirmVariationRefiner>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ExConfirmVariationRefiner(IntPtr pointer)
		: base(pointer)
	{
	}
}
