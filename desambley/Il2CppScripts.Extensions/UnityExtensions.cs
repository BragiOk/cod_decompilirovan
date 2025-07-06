using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Tables;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2CppScripts.Extensions;

public static class UnityExtensions : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("Scripts.Extensions.UnityExtensions+<>c__11`2")]
	public sealed class __c__11<Type, Key> : Il2CppSystem.Object where Type : Component
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__11_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__11_2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortChildren_b__11_1_Internal_Type_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortChildren_b__11_2_Internal_Boolean_Type_0;

		public unsafe static __c__11<Type, Key> __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__11<Type, Key>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__));
			}
		}

		public unsafe static Il2CppSystem.Func<Transform, Type> __9__11_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Transform, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<Type, bool> __9__11_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Type, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c__11()
		{
			Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, "<>c__11`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Key>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, "<>9__11_1");
			NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, "<>9__11_2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, 100668759);
			NativeMethodInfoPtr__SortChildren_b__11_1_Internal_Type_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, 100668760);
			NativeMethodInfoPtr__SortChildren_b__11_2_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr, 100668761);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__11()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__11<Type, Key>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53236, XrefRangeEnd = 53238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type _SortChildren_b__11_1(Transform x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortChildren_b__11_1_Internal_Type_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<Type>(intPtr, false, true);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53238, XrefRangeEnd = 53247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SortChildren_b__11_2(Type x)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref Type reference;
			if (!typeof(Type).IsValueType)
			{
				Type val = x;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref x;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortChildren_b__11_2_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__11(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Scripts.Extensions.UnityExtensions+<>c__DisplayClass0_0`1")]
	public sealed class __c__DisplayClass0_0<T> : Il2CppSystem.Object where T : class
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_includeInactive;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CollectComponents_b__0_Internal_IEnumerable_1_T_GameObject_0;

		public unsafe bool includeInactive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInactive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInactive)) = flag;
			}
		}

		static __c__DisplayClass0_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, "<>c__DisplayClass0_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_includeInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr, "includeInactive");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr, 100668762);
			NativeMethodInfoPtr__CollectComponents_b__0_Internal_IEnumerable_1_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr, 100668763);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass0_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass0_0<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53247, XrefRangeEnd = 53249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> _CollectComponents_b__0(GameObject x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CollectComponents_b__0_Internal_IEnumerable_1_T_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr) : null;
		}

		public __c__DisplayClass0_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Scripts.Extensions.UnityExtensions+<>c__DisplayClass11_0`2")]
	public sealed class __c__DisplayClass11_0<Type, Key> : Il2CppSystem.Object where Type : Component
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_keySelector;

		private static readonly System.IntPtr NativeFieldInfoPtr_reverse;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Int32_Type_Type_PDM_0;

		public unsafe Il2CppSystem.Func<Type, Key> keySelector
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keySelector);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Type, Key>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keySelector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe bool reverse
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse)) = flag;
			}
		}

		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, "<>c__DisplayClass11_0`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Key>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr);
			NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr, "keySelector");
			NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr, "reverse");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr, 100668764);
			NativeMethodInfoPtr_Method_Internal_Int32_Type_Type_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr, 100668765);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass11_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass11_0<Type, Key>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53249, XrefRangeEnd = 53251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Method_Internal_Int32_Type_Type_PDM_0(Type lhs, Type rhs)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			//IL_0094->IL0097: Incompatible stack types: I vs Ref
			//IL_0087->IL0097: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			ref Type reference;
			if (!typeof(Type).IsValueType)
			{
				Type val = lhs;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref lhs;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			ref Type reference2;
			if (!typeof(Type).IsValueType)
			{
				Type val2 = rhs;
				reference2 = ref *(_003F*)((!(val2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val2 is Il2CppObjectBase) ? val2 : null)) : IL2CPP.ManagedStringToIl2Cpp(val2 as string));
			}
			else
			{
				reference2 = ref rhs;
			}
			*(void**)num = Unsafe.AsPointer(ref reference2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Int32_Type_Type_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass11_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CollectComponents_Public_Static_Il2CppArrayBase_1_T_Scene_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CollectComponents_Public_Static_Il2CppArrayBase_1_T_Scene_Boolean_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetInterfaceInParent_Public_Static_Type_MonoBehaviour_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetInterfaceInParent_Public_Static_Type_MonoBehaviour_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_Type_GameObject_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrAddComponent_Public_Static_Type_GameObject_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInParentReliable_Public_Static_Type_MonoBehaviour_Transform_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInParentReliable_Public_Static_Type_MonoBehaviour_Transform_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnableChildComponents_Public_Static_Void_Transform_Boolean_Boolean_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnableChildComponents_Public_Static_Void_Transform_Boolean_Boolean_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SortChildren_Public_Static_Void_Transform_Func_2_Type_Key_Boolean_0<Type, Key>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SortChildren_Public_Static_Void_Transform_Func_2_Type_Key_Boolean_0, Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Key>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectComponents_Public_Static_Il2CppArrayBase_1_T_Scene_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInterfaceInParent_Public_Static_Type_MonoBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Camera_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildren_Public_Static_Il2CppReferenceArray_1_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildrenImmediate_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChildOf_Public_Static_Boolean_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_Type_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInParentReliable_Public_Static_Type_MonoBehaviour_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableChildComponents_Public_Static_Void_Transform_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChildrenTransformChanged_Public_Static_Boolean_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortChildren_Public_Static_Void_Transform_Func_2_Type_Key_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTransform_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEulerY_Public_Static_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransformPath_Public_Static_String_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleActive_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioSource_AudioClip_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_SoundEntry_0;

	static UnityExtensions()
	{
		Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Extensions", "UnityExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_CollectComponents_Public_Static_Il2CppArrayBase_1_T_Scene_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_GetInterfaceInParent_Public_Static_Type_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_GetChildren_Public_Static_Il2CppReferenceArray_1_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668742);
		NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_DestroyChildrenImmediate_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_IsChildOf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_GetOrAddComponent_Public_Static_Type_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668746);
		NativeMethodInfoPtr_GetComponentInParentReliable_Public_Static_Type_MonoBehaviour_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668747);
		NativeMethodInfoPtr_EnableChildComponents_Public_Static_Void_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668748);
		NativeMethodInfoPtr_ChildrenTransformChanged_Public_Static_Boolean_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668749);
		NativeMethodInfoPtr_SortChildren_Public_Static_Void_Transform_Func_2_Type_Key_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668750);
		NativeMethodInfoPtr_ResetTransform_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668751);
		NativeMethodInfoPtr_SetEulerY_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668752);
		NativeMethodInfoPtr_GetTransformPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668753);
		NativeMethodInfoPtr_ToggleActive_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668754);
		NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioSource_AudioClip_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668755);
		NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668756);
		NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_SoundEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityExtensions>.NativeClassPtr, 100668757);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53251, XrefRangeEnd = 53262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> CollectComponents<T>(this Scene scene, bool includeInactive = false) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CollectComponents_Public_Static_Il2CppArrayBase_1_T_Scene_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53262, XrefRangeEnd = 53287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetInterfaceInParent<Type>(this MonoBehaviour monoBehaviour) where Type : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monoBehaviour);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetInterfaceInParent_Public_Static_Type_MonoBehaviour_0<Type>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<Type>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53287, XrefRangeEnd = 53289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisible(this UnityEngine.Camera camera, Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVisible_Public_Static_Boolean_Camera_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53299, RefRangeEnd = 53301, XrefRangeStart = 53289, XrefRangeEnd = 53299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Transform> GetChildren(this Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildren_Public_Static_Il2CppReferenceArray_1_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53328, RefRangeEnd = 53333, XrefRangeStart = 53301, XrefRangeEnd = 53328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildren(this Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53333, XrefRangeEnd = 53360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildrenImmediate(this Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildrenImmediate_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53360, XrefRangeEnd = 53380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsChildOf(this Transform transform, Transform parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChildOf_Public_Static_Boolean_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 53392, RefRangeEnd = 53426, XrefRangeStart = 53380, XrefRangeEnd = 53392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetOrAddComponent<Type>(this GameObject gameObject) where Type : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_Type_GameObject_0<Type>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<Type>(intPtr, false, true);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 53450, RefRangeEnd = 53456, XrefRangeStart = 53426, XrefRangeEnd = 53450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Type GetComponentInParentReliable<Type>(this MonoBehaviour component, Transform root = null) where Type : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInParentReliable_Public_Static_Type_MonoBehaviour_Transform_0<Type>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<Type>(intPtr, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53475, RefRangeEnd = 53476, XrefRangeStart = 53456, XrefRangeEnd = 53475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableChildComponents<Type>(this Transform parent, bool enable, bool ignoreSelf = false) where Type : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSelf;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnableChildComponents_Public_Static_Void_Transform_Boolean_Boolean_0<Type>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53502, RefRangeEnd = 53503, XrefRangeStart = 53476, XrefRangeEnd = 53502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ChildrenTransformChanged(this Transform parent, bool erase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &erase;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChildrenTransformChanged_Public_Static_Boolean_Transform_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53503, XrefRangeEnd = 53557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortChildren<Type, Key>(this Transform transform, Il2CppSystem.Func<Type, Key> keySelector, bool reverse = false) where Type : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keySelector);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &reverse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SortChildren_Public_Static_Void_Transform_Func_2_Type_Key_Boolean_0<Type, Key>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53569, RefRangeEnd = 53572, XrefRangeStart = 53557, XrefRangeEnd = 53569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetTransform(this Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTransform_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53572, XrefRangeEnd = 53576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetEulerY(this Transform transform, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEulerY_Public_Static_Void_Transform_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53576, XrefRangeEnd = 53603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTransformPath(this Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransformPath_Public_Static_String_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53612, RefRangeEnd = 53615, XrefRangeStart = 53603, XrefRangeEnd = 53612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ToggleActive(this GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleActive_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53615, XrefRangeEnd = 53631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PlaySound(this AudioSource audioSource, AudioClip clip, float volume = 1f, float radius = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_Void_AudioSource_AudioClip_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53660, RefRangeEnd = 53661, XrefRangeStart = 53631, XrefRangeEnd = 53660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip PlaySound(this AudioSource audioSource, string name, float volume = 1f, float radius = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_String_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53661, XrefRangeEnd = 53662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip PlaySound(this AudioSource audioSource, SoundEntry soundEntry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundEntry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Static_AudioClip_AudioSource_SoundEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	public UnityExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
