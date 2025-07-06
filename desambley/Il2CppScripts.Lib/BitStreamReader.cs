using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppScripts.Lib;

public class BitStreamReader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bits;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBit_Public_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBits_Public_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

	public unsafe BinaryReader m_Reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryReader));
		}
	}

	public unsafe byte m_Data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data)) = b;
		}
	}

	public unsafe int m_Bits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bits)) = num;
		}
	}

	static BitStreamReader()
	{
		Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Lib", "BitStreamReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr);
		NativeFieldInfoPtr_m_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, "m_Reader");
		NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, "m_Data");
		NativeFieldInfoPtr_m_Bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, "m_Bits");
		NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, 100665331);
		NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, 100665332);
		NativeMethodInfoPtr_ReadBit_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, 100665333);
		NativeMethodInfoPtr_ReadBits_Public_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, 100665334);
		NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr, 100665335);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 21790, RefRangeEnd = 21866, XrefRangeStart = 21790, XrefRangeEnd = 21790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitStreamReader(BinaryReader aReader)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aReader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21866, XrefRangeEnd = 21870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitStreamReader(Stream aStream)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitStreamReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aStream);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe byte ReadBit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBit_Public_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21870, RefRangeEnd = 21871, XrefRangeStart = 21870, XrefRangeEnd = 21870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong ReadBits(int aCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBits_Public_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Flush()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BitStreamReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
