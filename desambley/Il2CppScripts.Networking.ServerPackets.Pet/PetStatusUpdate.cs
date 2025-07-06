using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ServerPackets.Pet;

public class PetStatusUpdate : ServerPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__level;

	private static readonly IntPtr NativeFieldInfoPtr__currentHp;

	private static readonly IntPtr NativeFieldInfoPtr__maxHp;

	private static readonly IntPtr NativeFieldInfoPtr__currentMp;

	private static readonly IntPtr NativeFieldInfoPtr__maxMp;

	private static readonly IntPtr NativeFieldInfoPtr__sp;

	private static readonly IntPtr NativeFieldInfoPtr__expPart;

	private static readonly IntPtr NativeFieldInfoPtr__patk;

	private static readonly IntPtr NativeFieldInfoPtr__pdef;

	private static readonly IntPtr NativeFieldInfoPtr__matk;

	private static readonly IntPtr NativeFieldInfoPtr__mdef;

	private static readonly IntPtr NativeFieldInfoPtr__accuracy;

	private static readonly IntPtr NativeFieldInfoPtr__evasion;

	private static readonly IntPtr NativeFieldInfoPtr__critical;

	private static readonly IntPtr NativeFieldInfoPtr__runSped;

	private static readonly IntPtr NativeFieldInfoPtr__patkSpd;

	private static readonly IntPtr NativeFieldInfoPtr__matkSpd;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__level)) = num;
		}
	}

	public unsafe int _currentHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentHp)) = num;
		}
	}

	public unsafe int _maxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxHp)) = num;
		}
	}

	public unsafe int _currentMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentMp)) = num;
		}
	}

	public unsafe int _maxMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxMp)) = num;
		}
	}

	public unsafe int _sp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sp)) = num;
		}
	}

	public unsafe float _expPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__expPart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__expPart)) = num;
		}
	}

	public unsafe int _patk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__patk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__patk)) = num;
		}
	}

	public unsafe int _pdef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pdef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pdef)) = num;
		}
	}

	public unsafe int _matk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matk)) = num;
		}
	}

	public unsafe int _mdef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mdef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mdef)) = num;
		}
	}

	public unsafe int _accuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__accuracy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__accuracy)) = num;
		}
	}

	public unsafe int _evasion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evasion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evasion)) = num;
		}
	}

	public unsafe int _critical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__critical);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__critical)) = num;
		}
	}

	public unsafe int _runSped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runSped);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runSped)) = num;
		}
	}

	public unsafe int _patkSpd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__patkSpd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__patkSpd)) = num;
		}
	}

	public unsafe int _matkSpd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matkSpd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matkSpd)) = num;
		}
	}

	static PetStatusUpdate()
	{
		Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ServerPackets.Pet", "PetStatusUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr);
		NativeFieldInfoPtr__level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_level");
		NativeFieldInfoPtr__currentHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_currentHp");
		NativeFieldInfoPtr__maxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_maxHp");
		NativeFieldInfoPtr__currentMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_currentMp");
		NativeFieldInfoPtr__maxMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_maxMp");
		NativeFieldInfoPtr__sp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_sp");
		NativeFieldInfoPtr__expPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_expPart");
		NativeFieldInfoPtr__patk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_patk");
		NativeFieldInfoPtr__pdef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_pdef");
		NativeFieldInfoPtr__matk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_matk");
		NativeFieldInfoPtr__mdef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_mdef");
		NativeFieldInfoPtr__accuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_accuracy");
		NativeFieldInfoPtr__evasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_evasion");
		NativeFieldInfoPtr__critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_critical");
		NativeFieldInfoPtr__runSped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_runSped");
		NativeFieldInfoPtr__patkSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_patkSpd");
		NativeFieldInfoPtr__matkSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, "_matkSpd");
		NativeMethodInfoPtr_Apply_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_ReadMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr, 100664573);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14680, XrefRangeEnd = 14685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14685, XrefRangeEnd = 14702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe PetStatusUpdate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PetStatusUpdate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PetStatusUpdate(IntPtr pointer)
		: base(pointer)
	{
	}
}
