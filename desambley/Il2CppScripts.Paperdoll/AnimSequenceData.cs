using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Paperdoll.Classes;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Paperdoll;

public class AnimSequenceData : ScriptableObject
{
	[System.Serializable]
	public class Sequence : Il2CppSystem.Object
	{
		[OriginalName("Assembly-Scripts.dll", "", "Type")]
		public enum Type
		{
			Shot,
			Sequential
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_AniChar;

		private static readonly System.IntPtr NativeFieldInfoPtr_SeqType;

		private static readonly System.IntPtr NativeFieldInfoPtr_SplitLimit;

		private static readonly System.IntPtr NativeFieldInfoPtr_Start;

		private static readonly System.IntPtr NativeFieldInfoPtr_Middle;

		private static readonly System.IntPtr NativeFieldInfoPtr_Shot;

		private static readonly System.IntPtr NativeFieldInfoPtr_Sequenced;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string AniChar
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AniChar);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AniChar)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Type SeqType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeqType);
				return *(Type*)num;
			}
			set
			{
				*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeqType)) = type;
			}
		}

		public unsafe float SplitLimit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SplitLimit);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SplitLimit)) = num;
			}
		}

		public unsafe AnimName Start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Start);
				return *(AnimName*)num;
			}
			set
			{
				*(AnimName*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Start)) = animName;
			}
		}

		public unsafe AnimName Middle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Middle);
				return *(AnimName*)num;
			}
			set
			{
				*(AnimName*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Middle)) = animName;
			}
		}

		public unsafe AnimName Shot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shot);
				return *(AnimName*)num;
			}
			set
			{
				*(AnimName*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shot)) = animName;
			}
		}

		public unsafe Il2CppStructArray<AnimName> Sequenced
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sequenced);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimName>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sequenced)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static Sequence()
		{
			Il2CppClassPointerStore<Sequence>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr, "Sequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence>.NativeClassPtr);
			NativeFieldInfoPtr_AniChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "AniChar");
			NativeFieldInfoPtr_SeqType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "SeqType");
			NativeFieldInfoPtr_SplitLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "SplitLimit");
			NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "Start");
			NativeFieldInfoPtr_Middle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "Middle");
			NativeFieldInfoPtr_Shot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "Shot");
			NativeFieldInfoPtr_Sequenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "Sequenced");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663812);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequence>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Sequence(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Sequences;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<Sequence> Sequences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sequences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sequence>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sequences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static AnimSequenceData()
	{
		Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Paperdoll", "AnimSequenceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr);
		NativeFieldInfoPtr_Sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr, "Sequences");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr, 100663811);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5896, XrefRangeEnd = 5897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimSequenceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimSequenceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AnimSequenceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
