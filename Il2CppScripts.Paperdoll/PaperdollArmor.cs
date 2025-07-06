using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.AssetSystem;
using Il2CppScripts.GameTypes.Character;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Paperdoll;

public class PaperdollArmor : ScriptableObject
{
	[OriginalName("Assembly-Scripts.dll", "", "BodyPartType")]
	public enum BodyPartType
	{
		None,
		Chest,
		Legs,
		Boots,
		Gloves,
		FullArmor,
		Accessory,
		WeddingDress
	}

	[System.Serializable]
	public class Model : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Meshes;

		private static readonly System.IntPtr NativeFieldInfoPtr_Materials;

		private static readonly System.IntPtr NativeFieldInfoPtr_Accessory;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppReferenceArray<MeshRef> Meshes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Meshes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRef>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Meshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppReferenceArray<MaterialRef> Materials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialRef>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe PaperdollAccessoryRef Accessory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accessory);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PaperdollAccessoryRef>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Accessory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paperdollAccessoryRef));
			}
		}

		static Model()
		{
			Il2CppClassPointerStore<Model>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "Model");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Model>.NativeClassPtr);
			NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Model>.NativeClassPtr, "Meshes");
			NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Model>.NativeClassPtr, "Materials");
			NativeFieldInfoPtr_Accessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Model>.NativeClassPtr, "Accessory");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Model>.NativeClassPtr, 100664084);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Model()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Model>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Model(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyPart;

	private static readonly System.IntPtr NativeFieldInfoPtr_MFighter;

	private static readonly System.IntPtr NativeFieldInfoPtr_FFighter;

	private static readonly System.IntPtr NativeFieldInfoPtr_MMagic;

	private static readonly System.IntPtr NativeFieldInfoPtr_FMagic;

	private static readonly System.IntPtr NativeFieldInfoPtr_MElf;

	private static readonly System.IntPtr NativeFieldInfoPtr_FElf;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDarkElf;

	private static readonly System.IntPtr NativeFieldInfoPtr_FDarkElf;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOrc;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOrc;

	private static readonly System.IntPtr NativeFieldInfoPtr_MShaman;

	private static readonly System.IntPtr NativeFieldInfoPtr_FShaman;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDwarf;

	private static readonly System.IntPtr NativeFieldInfoPtr_FDwarf;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetModel_Public_Model_PlayerModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BodyPartType BodyPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPart);
			return *(BodyPartType*)num;
		}
		set
		{
			*(BodyPartType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPart)) = bodyPartType;
		}
	}

	public unsafe Model MFighter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MFighter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MFighter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FFighter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FFighter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FFighter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MMagic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MMagic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MMagic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FMagic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FMagic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FMagic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MElf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MElf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MElf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FElf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FElf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FElf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MDarkElf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDarkElf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDarkElf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FDarkElf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FDarkElf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FDarkElf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MOrc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOrc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOrc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FOrc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOrc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOrc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MShaman
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MShaman);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MShaman)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FShaman
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FShaman);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FShaman)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model MDwarf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDwarf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDwarf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	public unsafe Model FDwarf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FDwarf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FDwarf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model));
		}
	}

	static PaperdollArmor()
	{
		Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll", "PaperdollArmor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr);
		NativeFieldInfoPtr_BodyPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "BodyPart");
		NativeFieldInfoPtr_MFighter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MFighter");
		NativeFieldInfoPtr_FFighter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FFighter");
		NativeFieldInfoPtr_MMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MMagic");
		NativeFieldInfoPtr_FMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FMagic");
		NativeFieldInfoPtr_MElf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MElf");
		NativeFieldInfoPtr_FElf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FElf");
		NativeFieldInfoPtr_MDarkElf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MDarkElf");
		NativeFieldInfoPtr_FDarkElf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FDarkElf");
		NativeFieldInfoPtr_MOrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MOrc");
		NativeFieldInfoPtr_FOrc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FOrc");
		NativeFieldInfoPtr_MShaman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MShaman");
		NativeFieldInfoPtr_FShaman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FShaman");
		NativeFieldInfoPtr_MDwarf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "MDwarf");
		NativeFieldInfoPtr_FDwarf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, "FDwarf");
		NativeMethodInfoPtr_GetModel_Public_Model_PlayerModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr, 100664083);
	}

	[CallerCount(0)]
	public unsafe Model GetModel(PlayerModel playerModel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerModel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModel_Public_Model_PlayerModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Model>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PaperdollArmor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaperdollArmor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PaperdollArmor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
