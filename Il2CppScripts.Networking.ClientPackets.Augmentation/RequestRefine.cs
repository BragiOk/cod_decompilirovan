using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.Augmentation;

public class RequestRefine : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__targetItemObjectId;

	private static readonly IntPtr NativeFieldInfoPtr__refinerItemObjectId;

	private static readonly IntPtr NativeFieldInfoPtr__gemstoneItemObjectId;

	private static readonly IntPtr NativeFieldInfoPtr__gemstoneCount;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe int _targetItemObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__targetItemObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__targetItemObjectId)) = num;
		}
	}

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

	public unsafe int _gemstoneItemObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneItemObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gemstoneItemObjectId)) = num;
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

	static RequestRefine()
	{
		Il2CppClassPointerStore<RequestRefine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.Augmentation", "RequestRefine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr);
		NativeFieldInfoPtr__targetItemObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, "_targetItemObjectId");
		NativeFieldInfoPtr__refinerItemObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, "_refinerItemObjectId");
		NativeFieldInfoPtr__gemstoneItemObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, "_gemstoneItemObjectId");
		NativeFieldInfoPtr__gemstoneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, "_gemstoneCount");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr, 100665056);
	}

	[CallerCount(0)]
	public unsafe RequestRefine(int targetItemObjectId, int refinerItemObjectId, int gemstoneItemObjectId, int gemstoneCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestRefine>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&targetItemObjectId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &refinerItemObjectId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &gemstoneItemObjectId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &gemstoneCount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17677, XrefRangeEnd = 17684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RequestRefine(IntPtr pointer)
		: base(pointer)
	{
	}
}
