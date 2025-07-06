using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.Common;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScripts.Emitters;

public class UnrealEmitter : MonoBehaviour
{
	public sealed class NativeRelativeColor : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("Scripts.Emitters.UnrealEmitter+NativeRelativeColor+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_float4_RelativeColor_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeColor_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeColor, float4> __9__2_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeColor, float4>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeColor, float> __9__2_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeColor, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_0");
				NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_1");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668860);
				NativeMethodInfoPtr___ctor_b__2_0_Internal_float4_RelativeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668861);
				NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668862);
			}

			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe float4 __ctor_b__2_0(RelativeColor x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_0_Internal_float4_RelativeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe float __ctor_b__2_1(RelativeColor x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeColor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		public unsafe NativeArray<float> Time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4> Value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
				return new NativeArray<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static NativeRelativeColor()
		{
			Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "NativeRelativeColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr);
			NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, "Time");
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, "Value");
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, 100668857);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, 100668858);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53854, RefRangeEnd = 53855, XrefRangeStart = 53799, XrefRangeEnd = 53854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeRelativeColor(Il2CppStructArray<RelativeColor> colors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeColor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53863, RefRangeEnd = 53865, XrefRangeStart = 53855, XrefRangeEnd = 53863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NativeRelativeColor(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NativeRelativeColor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr))
		{
		}
	}

	public sealed class NativeRelativeVector3 : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("Scripts.Emitters.UnrealEmitter+NativeRelativeVector3+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_float3_RelativeVector3_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeVector3_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeVector3, float3> __9__2_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeVector3, float3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeVector3, float> __9__2_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeVector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_0");
				NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_1");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668866);
				NativeMethodInfoPtr___ctor_b__2_0_Internal_float3_RelativeVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668867);
				NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668868);
			}

			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe float3 __ctor_b__2_0(RelativeVector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_0_Internal_float3_RelativeVector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe float __ctor_b__2_1(RelativeVector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeVector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeVector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		public unsafe NativeArray<float> Time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float3> Value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static NativeRelativeVector3()
		{
			Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "NativeRelativeVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr);
			NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, "Time");
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, "Value");
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, 100668863);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, 100668864);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53920, RefRangeEnd = 53922, XrefRangeStart = 53865, XrefRangeEnd = 53920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeRelativeVector3(Il2CppStructArray<RelativeVector3> values)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeVector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 53930, RefRangeEnd = 53934, XrefRangeStart = 53922, XrefRangeEnd = 53930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NativeRelativeVector3(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NativeRelativeVector3()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr))
		{
		}
	}

	public sealed class NativeRelativeFloat : Il2CppSystem.ValueType
	{
		[System.Serializable]
		[ObfuscatedName("Scripts.Emitters.UnrealEmitter+NativeRelativeFloat+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_Single_RelativeFloat_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeFloat_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeFloat, float> __9__2_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeFloat, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			public unsafe static Il2CppSystem.Func<RelativeFloat, float> __9__2_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RelativeFloat, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_0");
				NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_1");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668872);
				NativeMethodInfoPtr___ctor_b__2_0_Internal_Single_RelativeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668873);
				NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668874);
			}

			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe float __ctor_b__2_0(RelativeFloat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_0_Internal_Single_RelativeFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe float __ctor_b__2_1(RelativeFloat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&x);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_1_Internal_Single_RelativeFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeFloat_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		public unsafe NativeArray<float> Time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float> Value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static NativeRelativeFloat()
		{
			Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "NativeRelativeFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr);
			NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, "Time");
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, "Value");
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, 100668869);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, 100668870);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53984, RefRangeEnd = 53985, XrefRangeStart = 53934, XrefRangeEnd = 53984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeRelativeFloat(Il2CppStructArray<RelativeFloat> values)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RelativeFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53991, RefRangeEnd = 53993, XrefRangeStart = 53985, XrefRangeEnd = 53991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NativeRelativeFloat(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NativeRelativeFloat()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Particle
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Spawned;

		private static readonly System.IntPtr NativeFieldInfoPtr_Color;

		private static readonly System.IntPtr NativeFieldInfoPtr_Location;

		private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_OldLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_Size;

		private static readonly System.IntPtr NativeFieldInfoPtr_Spin;

		private static readonly System.IntPtr NativeFieldInfoPtr_Subdivision;

		private static readonly System.IntPtr NativeFieldInfoPtr_NextSubdivision;

		private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionBlend;

		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_Lifetime;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColorMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_Origin;

		private static readonly System.IntPtr NativeFieldInfoPtr_OriginRot;

		private static readonly System.IntPtr NativeFieldInfoPtr_OriginScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_SpinsPerSecond;

		private static readonly System.IntPtr NativeFieldInfoPtr_Spin3D;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionsPerSecond;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionCenterOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityLoss;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Alive_Public_get_Boolean_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool Spawned;

		[FieldOffset(4)]
		public float4 Color;

		[FieldOffset(20)]
		public float3 Location;

		[FieldOffset(32)]
		public float3 Velocity;

		[FieldOffset(44)]
		public float3 OldLocation;

		[FieldOffset(56)]
		public quaternion Rotation;

		[FieldOffset(72)]
		public float3 Size;

		[FieldOffset(84)]
		public float3 Spin;

		[FieldOffset(96)]
		public int Subdivision;

		[FieldOffset(100)]
		public int NextSubdivision;

		[FieldOffset(104)]
		public float SubdivisionBlend;

		[FieldOffset(108)]
		public float Time;

		[FieldOffset(112)]
		public float Lifetime;

		[FieldOffset(116)]
		public float4 StartColor;

		[FieldOffset(132)]
		public float3 ColorMultiplier;

		[FieldOffset(144)]
		public float3 StartLocation;

		[FieldOffset(156)]
		public float3 Origin;

		[FieldOffset(168)]
		public quaternion OriginRot;

		[FieldOffset(184)]
		public float3 OriginScale;

		[FieldOffset(196)]
		public float3 StartSize;

		[FieldOffset(208)]
		public float3 SpinsPerSecond;

		[FieldOffset(220)]
		[MarshalAs(UnmanagedType.U1)]
		public bool Spin3D;

		[FieldOffset(224)]
		public float3 RevolutionsPerSecond;

		[FieldOffset(236)]
		public float3 RevolutionCenterOffset;

		[FieldOffset(248)]
		public float3 VelocityLoss;

		public unsafe bool Alive
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Alive_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static Particle()
		{
			Il2CppClassPointerStore<Particle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Particle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Particle>.NativeClassPtr);
			NativeFieldInfoPtr_Spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Spawned");
			NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Color");
			NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Location");
			NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Velocity");
			NativeFieldInfoPtr_OldLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "OldLocation");
			NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Rotation");
			NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Size");
			NativeFieldInfoPtr_Spin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Spin");
			NativeFieldInfoPtr_Subdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Subdivision");
			NativeFieldInfoPtr_NextSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "NextSubdivision");
			NativeFieldInfoPtr_SubdivisionBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "SubdivisionBlend");
			NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Time");
			NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Lifetime");
			NativeFieldInfoPtr_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "StartColor");
			NativeFieldInfoPtr_ColorMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "ColorMultiplier");
			NativeFieldInfoPtr_StartLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "StartLocation");
			NativeFieldInfoPtr_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Origin");
			NativeFieldInfoPtr_OriginRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "OriginRot");
			NativeFieldInfoPtr_OriginScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "OriginScale");
			NativeFieldInfoPtr_StartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "StartSize");
			NativeFieldInfoPtr_SpinsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "SpinsPerSecond");
			NativeFieldInfoPtr_Spin3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "Spin3D");
			NativeFieldInfoPtr_RevolutionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "RevolutionsPerSecond");
			NativeFieldInfoPtr_RevolutionCenterOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "RevolutionCenterOffset");
			NativeFieldInfoPtr_VelocityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "VelocityLoss");
			NativeMethodInfoPtr_get_Alive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particle>.NativeClassPtr, 100668875);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Particle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ParticleVertex
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		private static readonly System.IntPtr NativeFieldInfoPtr_Normal;

		private static readonly System.IntPtr NativeFieldInfoPtr_Color;

		private static readonly System.IntPtr NativeFieldInfoPtr_UV;

		[FieldOffset(0)]
		public float3 Position;

		[FieldOffset(12)]
		public float3 Normal;

		[FieldOffset(24)]
		public float4 Color;

		[FieldOffset(40)]
		public float2 UV;

		static ParticleVertex()
		{
			Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ParticleVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr);
			NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr, "Position");
			NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr, "Normal");
			NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr, "Color");
			NativeFieldInfoPtr_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr, "UV");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleVertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MeshInstanceData
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Color;

		[FieldOffset(0)]
		public float4 Color;

		static MeshInstanceData()
		{
			Il2CppClassPointerStore<MeshInstanceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MeshInstanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshInstanceData>.NativeClassPtr);
			NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInstanceData>.NativeClassPtr, "Color");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshInstanceData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class ProcessParticlesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Particles;

		private static readonly System.IntPtr NativeFieldInfoPtr_ComputeBounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_ParticleRadius;

		private static readonly System.IntPtr NativeFieldInfoPtr_ParticleRadiusOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_EmitterType;

		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_NumToSpawn;

		private static readonly System.IntPtr NativeFieldInfoPtr_Counters;

		private static readonly System.IntPtr NativeFieldInfoPtr_BaseSeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForcedLifetimeSet;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForcedLifetimeEndTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_EmitterPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_EmitterRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_EmitterScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;

		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateSystem;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForcedLifeTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForcedMaxParticles;

		private static readonly System.IntPtr NativeFieldInfoPtr_ForcedFade;

		private static readonly System.IntPtr NativeFieldInfoPtr_RespawnDeadParticles;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationShape;

		private static readonly System.IntPtr NativeFieldInfoPtr_SphereRadiusRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationPolarRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_Opacity;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColorScaleRepeats;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseColorScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColorMultiplierRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_ColorScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseParticleColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseRevolution;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseRevolutionScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionCenterOffsetRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionsPerSecondRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionScaleRepeats;

		private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_SpinParticles;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseRotationFrom;

		private static readonly System.IntPtr NativeFieldInfoPtr_SpinCCWorCW;

		private static readonly System.IntPtr NativeFieldInfoPtr_SpinsPerSecondRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartSpinRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartSizeRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_UniformSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_SizeScaleRepeats;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseRegularSizeScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseSizeScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_SizeScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseDirectionAs;

		private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionNormal;

		private static readonly System.IntPtr NativeFieldInfoPtr_BlendBetweenSubdivisions;

		private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomSubdivision;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseSubdivisionScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_FadeIn;

		private static readonly System.IntPtr NativeFieldInfoPtr_FadeInEndTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_FadeOut;

		private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutStartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartVelocityRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_StartVelocityRadialRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityLossRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_AddVelocityFromOtherEmitter;

		private static readonly System.IntPtr NativeFieldInfoPtr_GetVelocityDirectionFrom;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseVelocityScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityScaleRepeats;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxAbsVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_InitialTimeRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_InitialDelayRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_LifetimeRange;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCounters_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AdvanceTime_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SpawnParticle_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessParticle_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBounds_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		public unsafe NativeArray<Particle> Particles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles);
				return new NativeArray<Particle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool ComputeBounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ComputeBounds);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ComputeBounds)) = flag;
			}
		}

		public unsafe NativeArray<float3> Bounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bounds);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe float ParticleRadius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleRadius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleRadius)) = num;
			}
		}

		public unsafe float3 ParticleRadiusOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleRadiusOffset);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleRadiusOffset)) = @float;
			}
		}

		public unsafe Type EmitterType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterType);
				return *(Type*)num;
			}
			set
			{
				*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterType)) = type;
			}
		}

		public unsafe float Time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time)) = num;
			}
		}

		public unsafe int NumToSpawn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumToSpawn);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NumToSpawn)) = num;
			}
		}

		public unsafe NativeArray<int> Counters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Counters);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Counters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe uint BaseSeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseSeed);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseSeed)) = num;
			}
		}

		public unsafe float DeltaTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeltaTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeltaTime)) = num;
			}
		}

		public unsafe bool ForcedLifetimeSet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifetimeSet);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifetimeSet)) = flag;
			}
		}

		public unsafe float ForcedLifetimeEndTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifetimeEndTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifetimeEndTime)) = num;
			}
		}

		public unsafe float3 EmitterPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterPosition);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterPosition)) = @float;
			}
		}

		public unsafe quaternion EmitterRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterRotation);
				return *(quaternion*)num;
			}
			set
			{
				*(quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterRotation)) = quaternion;
			}
		}

		public unsafe float3 EmitterScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterScale);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterScale)) = @float;
			}
		}

		public unsafe float3 Acceleration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Acceleration);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Acceleration)) = @float;
			}
		}

		public unsafe EParticleCoordinateSystem CoordinateSystem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem);
				return *(EParticleCoordinateSystem*)num;
			}
			set
			{
				*(EParticleCoordinateSystem*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem)) = eParticleCoordinateSystem;
			}
		}

		public unsafe bool ForcedLifeTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifeTime);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifeTime)) = flag;
			}
		}

		public unsafe bool ForcedMaxParticles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedMaxParticles);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedMaxParticles)) = flag;
			}
		}

		public unsafe bool ForcedFade
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedFade);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedFade)) = flag;
			}
		}

		public unsafe bool RespawnDeadParticles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RespawnDeadParticles);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RespawnDeadParticles)) = flag;
			}
		}

		public unsafe EParticleStartLocationShape StartLocationShape
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationShape);
				return *(EParticleStartLocationShape*)num;
			}
			set
			{
				*(EParticleStartLocationShape*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationShape)) = eParticleStartLocationShape;
			}
		}

		public unsafe Il2CppScripts.Common.Range SphereRadiusRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SphereRadiusRange);
				return *(Il2CppScripts.Common.Range*)num;
			}
			set
			{
				*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SphereRadiusRange)) = range;
			}
		}

		public unsafe Vector3 StartLocationOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationOffset)) = vector;
			}
		}

		public unsafe Range3 StartLocationPolarRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationPolarRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationPolarRange)) = range;
			}
		}

		public unsafe Range3 StartLocationRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationRange)) = range;
			}
		}

		public unsafe float Opacity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opacity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opacity)) = num;
			}
		}

		public unsafe float ColorScaleRepeats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScaleRepeats);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScaleRepeats)) = num;
			}
		}

		public unsafe bool UseColorScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseColorScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseColorScale)) = flag;
			}
		}

		public unsafe Range3 ColorMultiplierRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorMultiplierRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorMultiplierRange)) = range;
			}
		}

		public unsafe NativeRelativeColor ColorScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScale);
				return new NativeRelativeColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeColor)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool UseParticleColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseParticleColor);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseParticleColor)) = flag;
			}
		}

		public unsafe bool UseRevolution
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolution);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolution)) = flag;
			}
		}

		public unsafe bool UseRevolutionScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolutionScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolutionScale)) = flag;
			}
		}

		public unsafe Range3 RevolutionCenterOffsetRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionCenterOffsetRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionCenterOffsetRange)) = range;
			}
		}

		public unsafe Range3 RevolutionsPerSecondRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionsPerSecondRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionsPerSecondRange)) = range;
			}
		}

		public unsafe float RevolutionScaleRepeats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScaleRepeats);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScaleRepeats)) = num;
			}
		}

		public unsafe NativeRelativeVector3 RevolutionScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScale);
				return new NativeRelativeVector3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeVector)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool SpinParticles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinParticles);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinParticles)) = flag;
			}
		}

		public unsafe int UseRotationFrom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRotationFrom);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRotationFrom)) = num;
			}
		}

		public unsafe float3 SpinCCWorCW
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinCCWorCW);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinCCWorCW)) = @float;
			}
		}

		public unsafe Range3 SpinsPerSecondRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinsPerSecondRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinsPerSecondRange)) = range;
			}
		}

		public unsafe Range3 StartSpinRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSpinRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSpinRange)) = range;
			}
		}

		public unsafe Range3 StartSizeRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSizeRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSizeRange)) = range;
			}
		}

		public unsafe bool UniformSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize)) = flag;
			}
		}

		public unsafe float SizeScaleRepeats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScaleRepeats);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScaleRepeats)) = num;
			}
		}

		public unsafe bool UseRegularSizeScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRegularSizeScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRegularSizeScale)) = flag;
			}
		}

		public unsafe bool UseSizeScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSizeScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSizeScale)) = flag;
			}
		}

		public unsafe NativeRelativeFloat SizeScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale);
				return new NativeRelativeFloat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeFloat)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe EParticleDirectionUsage UseDirectionAs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs);
				return *(EParticleDirectionUsage*)num;
			}
			set
			{
				*(EParticleDirectionUsage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs)) = eParticleDirectionUsage;
			}
		}

		public unsafe Vector3 ProjectionNormal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal)) = vector;
			}
		}

		public unsafe bool BlendBetweenSubdivisions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions)) = flag;
			}
		}

		public unsafe int SubdivisionEnd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionEnd);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionEnd)) = num;
			}
		}

		public unsafe int SubdivisionStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionStart);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionStart)) = num;
			}
		}

		public unsafe bool UseRandomSubdivision
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRandomSubdivision);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRandomSubdivision)) = flag;
			}
		}

		public unsafe bool UseSubdivisionScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSubdivisionScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSubdivisionScale)) = flag;
			}
		}

		public unsafe NativeArray<float> SubdivisionScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionScale);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool FadeIn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeIn);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeIn)) = flag;
			}
		}

		public unsafe float FadeInEndTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeInEndTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeInEndTime)) = num;
			}
		}

		public unsafe bool FadeOut
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut)) = flag;
			}
		}

		public unsafe float FadeOutStartTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutStartTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutStartTime)) = num;
			}
		}

		public unsafe Range3 StartVelocityRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRange)) = range;
			}
		}

		public unsafe Il2CppScripts.Common.Range StartVelocityRadialRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRadialRange);
				return *(Il2CppScripts.Common.Range*)num;
			}
			set
			{
				*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRadialRange)) = range;
			}
		}

		public unsafe Range3 VelocityLossRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityLossRange);
				return *(Range3*)num;
			}
			set
			{
				*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityLossRange)) = range;
			}
		}

		public unsafe int AddVelocityFromOtherEmitter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddVelocityFromOtherEmitter);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddVelocityFromOtherEmitter)) = num;
			}
		}

		public unsafe EParticleVelocityDirection GetVelocityDirectionFrom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetVelocityDirectionFrom);
				return *(EParticleVelocityDirection*)num;
			}
			set
			{
				*(EParticleVelocityDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetVelocityDirectionFrom)) = eParticleVelocityDirection;
			}
		}

		public unsafe bool UseVelocityScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseVelocityScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseVelocityScale)) = flag;
			}
		}

		public unsafe float VelocityScaleRepeats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScaleRepeats);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScaleRepeats)) = num;
			}
		}

		public unsafe float3 MaxAbsVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAbsVelocity);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAbsVelocity)) = @float;
			}
		}

		public unsafe NativeRelativeVector3 VelocityScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScale);
				return new NativeRelativeVector3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeVector)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppScripts.Common.Range InitialTimeRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialTimeRange);
				return *(Il2CppScripts.Common.Range*)num;
			}
			set
			{
				*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialTimeRange)) = range;
			}
		}

		public unsafe Il2CppScripts.Common.Range InitialDelayRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialDelayRange);
				return *(Il2CppScripts.Common.Range*)num;
			}
			set
			{
				*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialDelayRange)) = range;
			}
		}

		public unsafe Il2CppScripts.Common.Range LifetimeRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifetimeRange);
				return *(Il2CppScripts.Common.Range*)num;
			}
			set
			{
				*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifetimeRange)) = range;
			}
		}

		static ProcessParticlesJob()
		{
			Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ProcessParticlesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr);
			NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Particles");
			NativeFieldInfoPtr_ComputeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ComputeBounds");
			NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Bounds");
			NativeFieldInfoPtr_ParticleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ParticleRadius");
			NativeFieldInfoPtr_ParticleRadiusOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ParticleRadiusOffset");
			NativeFieldInfoPtr_EmitterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "EmitterType");
			NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Time");
			NativeFieldInfoPtr_NumToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "NumToSpawn");
			NativeFieldInfoPtr_Counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Counters");
			NativeFieldInfoPtr_BaseSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "BaseSeed");
			NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "DeltaTime");
			NativeFieldInfoPtr_ForcedLifetimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ForcedLifetimeSet");
			NativeFieldInfoPtr_ForcedLifetimeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ForcedLifetimeEndTime");
			NativeFieldInfoPtr_EmitterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "EmitterPosition");
			NativeFieldInfoPtr_EmitterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "EmitterRotation");
			NativeFieldInfoPtr_EmitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "EmitterScale");
			NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Acceleration");
			NativeFieldInfoPtr_CoordinateSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "CoordinateSystem");
			NativeFieldInfoPtr_ForcedLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ForcedLifeTime");
			NativeFieldInfoPtr_ForcedMaxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ForcedMaxParticles");
			NativeFieldInfoPtr_ForcedFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ForcedFade");
			NativeFieldInfoPtr_RespawnDeadParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "RespawnDeadParticles");
			NativeFieldInfoPtr_StartLocationShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartLocationShape");
			NativeFieldInfoPtr_SphereRadiusRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SphereRadiusRange");
			NativeFieldInfoPtr_StartLocationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartLocationOffset");
			NativeFieldInfoPtr_StartLocationPolarRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartLocationPolarRange");
			NativeFieldInfoPtr_StartLocationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartLocationRange");
			NativeFieldInfoPtr_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "Opacity");
			NativeFieldInfoPtr_ColorScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ColorScaleRepeats");
			NativeFieldInfoPtr_UseColorScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseColorScale");
			NativeFieldInfoPtr_ColorMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ColorMultiplierRange");
			NativeFieldInfoPtr_ColorScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ColorScale");
			NativeFieldInfoPtr_UseParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseParticleColor");
			NativeFieldInfoPtr_UseRevolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseRevolution");
			NativeFieldInfoPtr_UseRevolutionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseRevolutionScale");
			NativeFieldInfoPtr_RevolutionCenterOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "RevolutionCenterOffsetRange");
			NativeFieldInfoPtr_RevolutionsPerSecondRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "RevolutionsPerSecondRange");
			NativeFieldInfoPtr_RevolutionScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "RevolutionScaleRepeats");
			NativeFieldInfoPtr_RevolutionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "RevolutionScale");
			NativeFieldInfoPtr_SpinParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SpinParticles");
			NativeFieldInfoPtr_UseRotationFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseRotationFrom");
			NativeFieldInfoPtr_SpinCCWorCW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SpinCCWorCW");
			NativeFieldInfoPtr_SpinsPerSecondRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SpinsPerSecondRange");
			NativeFieldInfoPtr_StartSpinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartSpinRange");
			NativeFieldInfoPtr_StartSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartSizeRange");
			NativeFieldInfoPtr_UniformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UniformSize");
			NativeFieldInfoPtr_SizeScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SizeScaleRepeats");
			NativeFieldInfoPtr_UseRegularSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseRegularSizeScale");
			NativeFieldInfoPtr_UseSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseSizeScale");
			NativeFieldInfoPtr_SizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SizeScale");
			NativeFieldInfoPtr_UseDirectionAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseDirectionAs");
			NativeFieldInfoPtr_ProjectionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "ProjectionNormal");
			NativeFieldInfoPtr_BlendBetweenSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "BlendBetweenSubdivisions");
			NativeFieldInfoPtr_SubdivisionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SubdivisionEnd");
			NativeFieldInfoPtr_SubdivisionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SubdivisionStart");
			NativeFieldInfoPtr_UseRandomSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseRandomSubdivision");
			NativeFieldInfoPtr_UseSubdivisionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseSubdivisionScale");
			NativeFieldInfoPtr_SubdivisionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "SubdivisionScale");
			NativeFieldInfoPtr_FadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "FadeIn");
			NativeFieldInfoPtr_FadeInEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "FadeInEndTime");
			NativeFieldInfoPtr_FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "FadeOut");
			NativeFieldInfoPtr_FadeOutStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "FadeOutStartTime");
			NativeFieldInfoPtr_StartVelocityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartVelocityRange");
			NativeFieldInfoPtr_StartVelocityRadialRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "StartVelocityRadialRange");
			NativeFieldInfoPtr_VelocityLossRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "VelocityLossRange");
			NativeFieldInfoPtr_AddVelocityFromOtherEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "AddVelocityFromOtherEmitter");
			NativeFieldInfoPtr_GetVelocityDirectionFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "GetVelocityDirectionFrom");
			NativeFieldInfoPtr_UseVelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "UseVelocityScale");
			NativeFieldInfoPtr_VelocityScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "VelocityScaleRepeats");
			NativeFieldInfoPtr_MaxAbsVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "MaxAbsVelocity");
			NativeFieldInfoPtr_VelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "VelocityScale");
			NativeFieldInfoPtr_InitialTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "InitialTimeRange");
			NativeFieldInfoPtr_InitialDelayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "InitialDelayRange");
			NativeFieldInfoPtr_LifetimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, "LifetimeRange");
			NativeMethodInfoPtr_UpdateCounters_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668876);
			NativeMethodInfoPtr_AdvanceTime_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668877);
			NativeMethodInfoPtr_SpawnParticle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668878);
			NativeMethodInfoPtr_ProcessParticle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668879);
			NativeMethodInfoPtr_UpdateBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668880);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr, 100668881);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53993, RefRangeEnd = 53994, XrefRangeStart = 53993, XrefRangeEnd = 53993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCounters(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCounters_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53994, RefRangeEnd = 53995, XrefRangeStart = 53994, XrefRangeEnd = 53994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceTime(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvanceTime_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54022, RefRangeEnd = 54023, XrefRangeStart = 53995, XrefRangeEnd = 54022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnParticle(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnParticle_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54060, RefRangeEnd = 54061, XrefRangeStart = 54023, XrefRangeEnd = 54060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessParticle(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessParticle_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54077, RefRangeEnd = 54078, XrefRangeStart = 54061, XrefRangeEnd = 54077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBounds_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54078, XrefRangeEnd = 54083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ProcessParticlesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ProcessParticlesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessParticlesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class UpdateViewDependentParticleDataJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Particles;

		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateSystem;

		private static readonly System.IntPtr NativeFieldInfoPtr_Origin;

		private static readonly System.IntPtr NativeFieldInfoPtr_OriginScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_OriginRot;

		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_CameraNormal;

		private static readonly System.IntPtr NativeFieldInfoPtr_CameraUp;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseDirectionAs;

		private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionNormal;

		private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSpriteRotation_Private_quaternion_Particle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe NativeArray<Particle> Particles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles);
				return new NativeArray<Particle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe EParticleCoordinateSystem CoordinateSystem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem);
				return *(EParticleCoordinateSystem*)num;
			}
			set
			{
				*(EParticleCoordinateSystem*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem)) = eParticleCoordinateSystem;
			}
		}

		public unsafe float3 Origin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Origin);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Origin)) = @float;
			}
		}

		public unsafe float3 OriginScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginScale);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginScale)) = @float;
			}
		}

		public unsafe quaternion OriginRot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginRot);
				return *(quaternion*)num;
			}
			set
			{
				*(quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginRot)) = quaternion;
			}
		}

		public unsafe float3 CameraPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraPosition);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraPosition)) = @float;
			}
		}

		public unsafe float3 CameraNormal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraNormal);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraNormal)) = @float;
			}
		}

		public unsafe float3 CameraUp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraUp);
				return *(float3*)num;
			}
			set
			{
				*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraUp)) = @float;
			}
		}

		public unsafe EParticleDirectionUsage UseDirectionAs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs);
				return *(EParticleDirectionUsage*)num;
			}
			set
			{
				*(EParticleDirectionUsage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs)) = eParticleDirectionUsage;
			}
		}

		public unsafe Vector3 ProjectionNormal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal)) = vector;
			}
		}

		static UpdateViewDependentParticleDataJob()
		{
			Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UpdateViewDependentParticleDataJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr);
			NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "Particles");
			NativeFieldInfoPtr_CoordinateSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "CoordinateSystem");
			NativeFieldInfoPtr_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "Origin");
			NativeFieldInfoPtr_OriginScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "OriginScale");
			NativeFieldInfoPtr_OriginRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "OriginRot");
			NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "CameraPosition");
			NativeFieldInfoPtr_CameraNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "CameraNormal");
			NativeFieldInfoPtr_CameraUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "CameraUp");
			NativeFieldInfoPtr_UseDirectionAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "UseDirectionAs");
			NativeFieldInfoPtr_ProjectionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, "ProjectionNormal");
			NativeMethodInfoPtr_ComputeSpriteRotation_Private_quaternion_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, 100668882);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr, 100668883);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54113, RefRangeEnd = 54114, XrefRangeStart = 54083, XrefRangeEnd = 54113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe quaternion ComputeSpriteRotation(Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&particle);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSpriteRotation_Private_quaternion_Particle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54114, XrefRangeEnd = 54117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public UpdateViewDependentParticleDataJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public UpdateViewDependentParticleDataJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateViewDependentParticleDataJob>.NativeClassPtr))
		{
		}
	}

	public sealed class BuildParticleVertexBuffersJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Particles;

		private static readonly System.IntPtr NativeFieldInfoPtr_Vertices;

		private static readonly System.IntPtr NativeFieldInfoPtr_Indexes;

		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_UniformSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_UseDirectionAs;

		private static readonly System.IntPtr NativeFieldInfoPtr_TextureUSubdivisions;

		private static readonly System.IntPtr NativeFieldInfoPtr_TextureVSubdivisions;

		private static readonly System.IntPtr NativeFieldInfoPtr_BlendBetweenSubdivisions;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddQuad_Private_Void_Particle_Single_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		public unsafe NativeArray<Particle> Particles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles);
				return new NativeArray<Particle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<ParticleVertex> Vertices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vertices);
				return new NativeArray<ParticleVertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ParticleVertex>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ParticleVertex>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<ushort> Indexes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Indexes);
				return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Indexes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int CurrentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentIndex)) = num;
			}
		}

		public unsafe bool UniformSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize)) = flag;
			}
		}

		public unsafe EParticleDirectionUsage UseDirectionAs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs);
				return *(EParticleDirectionUsage*)num;
			}
			set
			{
				*(EParticleDirectionUsage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs)) = eParticleDirectionUsage;
			}
		}

		public unsafe int TextureUSubdivisions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureUSubdivisions);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureUSubdivisions)) = num;
			}
		}

		public unsafe int TextureVSubdivisions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureVSubdivisions);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureVSubdivisions)) = num;
			}
		}

		public unsafe bool BlendBetweenSubdivisions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions)) = flag;
			}
		}

		static BuildParticleVertexBuffersJob()
		{
			Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BuildParticleVertexBuffersJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr);
			NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "Particles");
			NativeFieldInfoPtr_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "Vertices");
			NativeFieldInfoPtr_Indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "Indexes");
			NativeFieldInfoPtr_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "CurrentIndex");
			NativeFieldInfoPtr_UniformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "UniformSize");
			NativeFieldInfoPtr_UseDirectionAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "UseDirectionAs");
			NativeFieldInfoPtr_TextureUSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "TextureUSubdivisions");
			NativeFieldInfoPtr_TextureVSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "TextureVSubdivisions");
			NativeFieldInfoPtr_BlendBetweenSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, "BlendBetweenSubdivisions");
			NativeMethodInfoPtr_AddQuad_Private_Void_Particle_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, 100668884);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr, 100668885);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54129, RefRangeEnd = 54131, XrefRangeStart = 54117, XrefRangeEnd = 54129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQuad(Particle particle, float blend, int subdivision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&particle);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blend;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &subdivision;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddQuad_Private_Void_Particle_Single_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54131, XrefRangeEnd = 54134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuildParticleVertexBuffersJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BuildParticleVertexBuffersJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildParticleVertexBuffersJob>.NativeClassPtr))
		{
		}
	}

	public sealed class GenerateRenderMatricesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Particles;

		private static readonly System.IntPtr NativeFieldInfoPtr_Matrices;

		private static readonly System.IntPtr NativeFieldInfoPtr_MeshInstanceData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		public unsafe NativeArray<Particle> Particles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles);
				return new NativeArray<Particle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Particles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Matrix4x4> Matrices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Matrices);
				return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Matrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<MeshInstanceData> MeshInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshInstanceData);
				return new NativeArray<MeshInstanceData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<UnrealEmitter.MeshInstanceData>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<UnrealEmitter.MeshInstanceData>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static GenerateRenderMatricesJob()
		{
			Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "GenerateRenderMatricesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr);
			NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr, "Particles");
			NativeFieldInfoPtr_Matrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr, "Matrices");
			NativeFieldInfoPtr_MeshInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr, "MeshInstanceData");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr, 100668886);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54134, XrefRangeEnd = 54137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GenerateRenderMatricesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GenerateRenderMatricesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateRenderMatricesJob>.NativeClassPtr))
		{
		}
	}

	public class EmitterLoop : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FirstCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_LastRenderedTick;

		private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;

		private static readonly System.IntPtr NativeFieldInfoPtr_FrustumFarCorners;

		private static readonly System.IntPtr NativeFieldInfoPtr_FrustumNearCorners;

		private static readonly System.IntPtr NativeFieldInfoPtr_FrustumAllCorners;

		private static readonly System.IntPtr NativeFieldInfoPtr_PrevTime;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalTime_Private_Static_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFrustumVolumes_Private_Static_Void_Camera_byref_Bounds_byref_Il2CppStructArray_1_Plane_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetOutOfFrustumState_Private_Static_Void_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PrepareParticleFrameData_Private_Static_Void_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RenderParticles_Private_Static_Void_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RenderCamera_Private_Static_Void_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginCameraRenderingSRP_Private_Static_Void_ScriptableRenderContext_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Private_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeAssemblyReload_Private_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InjectParticlesTickSubsystem_Private_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static UnityEngine.Camera FirstCamera
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FirstCamera, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FirstCamera, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
			}
		}

		public unsafe static int LastRenderedTick
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LastRenderedTick, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LastRenderedTick, (void*)(&num));
			}
		}

		public unsafe static bool Initialized
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Initialized, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Initialized, (void*)(&flag));
			}
		}

		public unsafe static Il2CppStructArray<Vector3> FrustumFarCorners
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FrustumFarCorners, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FrustumFarCorners, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe static Il2CppStructArray<Vector3> FrustumNearCorners
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FrustumNearCorners, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FrustumNearCorners, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe static Il2CppStructArray<Vector3> FrustumAllCorners
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FrustumAllCorners, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FrustumAllCorners, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe static float PrevTime
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevTime, (void*)(&num));
			}
		}

		public unsafe static float LocalTime
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 54141, RefRangeEnd = 54159, XrefRangeStart = 54137, XrefRangeEnd = 54141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalTime_Private_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static EmitterLoop()
		{
			Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "EmitterLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr);
			NativeFieldInfoPtr_FirstCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "FirstCamera");
			NativeFieldInfoPtr_LastRenderedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "LastRenderedTick");
			NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "Initialized");
			NativeFieldInfoPtr_FrustumFarCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "FrustumFarCorners");
			NativeFieldInfoPtr_FrustumNearCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "FrustumNearCorners");
			NativeFieldInfoPtr_FrustumAllCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "FrustumAllCorners");
			NativeFieldInfoPtr_PrevTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, "PrevTime");
			NativeMethodInfoPtr_get_LocalTime_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668887);
			NativeMethodInfoPtr_ComputeFrustumVolumes_Private_Static_Void_Camera_byref_Bounds_byref_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668888);
			NativeMethodInfoPtr_SetOutOfFrustumState_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668889);
			NativeMethodInfoPtr_PrepareParticleFrameData_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668890);
			NativeMethodInfoPtr_RenderParticles_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668891);
			NativeMethodInfoPtr_RenderCamera_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668892);
			NativeMethodInfoPtr_BeginCameraRenderingSRP_Private_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668893);
			NativeMethodInfoPtr_Tick_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668894);
			NativeMethodInfoPtr_OnBeforeAssemblyReload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668895);
			NativeMethodInfoPtr_InjectParticlesTickSubsystem_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668896);
			NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668897);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr, 100668898);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54189, RefRangeEnd = 54190, XrefRangeStart = 54159, XrefRangeEnd = 54189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeFrustumVolumes(UnityEngine.Camera camera, out Bounds frustumBounds, out Il2CppStructArray<Plane> frustumPlanes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref frustumBounds);
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFrustumVolumes_Private_Static_Void_Camera_byref_Bounds_byref_Il2CppStructArray_1_Plane_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			nint num3 = num2;
			frustumPlanes = ((num3 == 0) ? null : new Il2CppStructArray<Plane>((System.IntPtr)num3));
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54211, RefRangeEnd = 54212, XrefRangeStart = 54190, XrefRangeEnd = 54211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOutOfFrustumState(UnityEngine.Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOutOfFrustumState_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54212, XrefRangeEnd = 54229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareParticleFrameData(UnityEngine.Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareParticleFrameData_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54229, XrefRangeEnd = 54239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderParticles(UnityEngine.Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderParticles_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54300, RefRangeEnd = 54301, XrefRangeStart = 54239, XrefRangeEnd = 54300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderCamera(UnityEngine.Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderCamera_Private_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54301, XrefRangeEnd = 54305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCameraRenderingSRP(ScriptableRenderContext scriptableRenderContext, UnityEngine.Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&scriptableRenderContext);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginCameraRenderingSRP_Private_Static_Void_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54305, XrefRangeEnd = 54348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Tick()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tick_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54348, XrefRangeEnd = 54366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnBeforeAssemblyReload()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeAssemblyReload_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54391, RefRangeEnd = 54392, XrefRangeStart = 54366, XrefRangeEnd = 54391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InjectParticlesTickSubsystem()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InjectParticlesTickSubsystem_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54392, XrefRangeEnd = 54457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitterLoop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitterLoop>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EmitterLoop(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Assembly-Scripts.dll", "", "Type")]
	public enum Type
	{
		SpriteEmitter,
		MeshEmitter,
		BeamEmitter,
		VertMeshEmitter
	}

	[OriginalName("Assembly-Scripts.dll", "", "EParticleDirectionUsage")]
	public enum EParticleDirectionUsage
	{
		None,
		Up,
		Right,
		Forward,
		Normal,
		UpAndNormal,
		RightAndNormal
	}

	[OriginalName("Assembly-Scripts.dll", "", "EParticleStartLocationShape")]
	public enum EParticleStartLocationShape
	{
		Box,
		Sphere,
		Polar
	}

	[OriginalName("Assembly-Scripts.dll", "", "EBeamEndPointType")]
	public enum EBeamEndPointType
	{
		Velocity,
		Distance,
		Offset,
		Actor,
		TraceOffset
	}

	[OriginalName("Assembly-Scripts.dll", "", "EParticleCoordinateSystem")]
	public enum EParticleCoordinateSystem
	{
		Independent,
		Relative,
		Absolute,
		Spray
	}

	[OriginalName("Assembly-Scripts.dll", "", "EParticleDrawStyle")]
	public enum EParticleDrawStyle
	{
		Regular = 0,
		AlphaBlend = 1,
		Translucent = 3,
		Darken = 5,
		Brighten = 6
	}

	[OriginalName("Assembly-Scripts.dll", "", "EParticleVelocityDirection")]
	public enum EParticleVelocityDirection
	{
		None,
		AddRadial,
		StartPositionAndOwner,
		OwnerAndStartPosition
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct RelativeColor
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_Color;

		[FieldOffset(0)]
		public float RelativeTime;

		[FieldOffset(4)]
		public Color Color;

		static RelativeColor()
		{
			Il2CppClassPointerStore<RelativeColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RelativeColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelativeColor>.NativeClassPtr);
			NativeFieldInfoPtr_RelativeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeColor>.NativeClassPtr, "RelativeTime");
			NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeColor>.NativeClassPtr, "Color");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelativeColor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct RelativeVector3
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_Vector3;

		[FieldOffset(0)]
		public float RelativeTime;

		[FieldOffset(4)]
		public Vector3 Vector3;

		static RelativeVector3()
		{
			Il2CppClassPointerStore<RelativeVector3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RelativeVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelativeVector3>.NativeClassPtr);
			NativeFieldInfoPtr_RelativeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeVector3>.NativeClassPtr, "RelativeTime");
			NativeFieldInfoPtr_Vector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeVector3>.NativeClassPtr, "Vector3");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelativeVector3>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct RelativeFloat
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_Float;

		[FieldOffset(0)]
		public float RelativeTime;

		[FieldOffset(4)]
		public float Float;

		static RelativeFloat()
		{
			Il2CppClassPointerStore<RelativeFloat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RelativeFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelativeFloat>.NativeClassPtr);
			NativeFieldInfoPtr_RelativeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeFloat>.NativeClassPtr, "RelativeTime");
			NativeFieldInfoPtr_Float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativeFloat>.NativeClassPtr, "Float");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelativeFloat>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_MeshScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxSkipDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_TooFarDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_TicksBeforeInactive;

	private static readonly System.IntPtr NativeFieldInfoPtr__AllowInitialize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnDeath;

	private static readonly System.IntPtr NativeFieldInfoPtr__DisableRendering_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__particles;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastScheduledFrameJobHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr__colorScaleNative;

	private static readonly System.IntPtr NativeFieldInfoPtr__revolutionScaleNative;

	private static readonly System.IntPtr NativeFieldInfoPtr__sizeScaleNative;

	private static readonly System.IntPtr NativeFieldInfoPtr__velocityScaleNative;

	private static readonly System.IntPtr NativeFieldInfoPtr__subdivisionScale;

	private static readonly System.IntPtr NativeFieldInfoPtr__boundsArray;

	private static readonly System.IntPtr NativeFieldInfoPtr__particleCounterArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_CounterSpawned;

	private static readonly System.IntPtr NativeFieldInfoPtr_CounterAlive;

	private static readonly System.IntPtr NativeFieldInfoPtr_CounterNumToSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr__initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr__numToSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr__numAliveParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr__numSpawnedParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentTick;

	private static readonly System.IntPtr NativeFieldInfoPtr__paused;

	private static readonly System.IntPtr NativeFieldInfoPtr__particleDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr__warmedUp;

	private static readonly System.IntPtr NativeFieldInfoPtr__delay;

	private static readonly System.IntPtr NativeFieldInfoPtr__time;

	private static readonly System.IntPtr NativeFieldInfoPtr__startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__particlesPerFrameAccum;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastRenderedTick;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastViewUpdatedTick;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastSpriteMeshUpdatedTick;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastSynced;

	private static readonly System.IntPtr NativeFieldInfoPtr__outOfFrustum;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentThrottleFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr__onDeathEventCalled;

	private static readonly System.IntPtr NativeFieldInfoPtr__forcedLifetimeEndTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__forcedLifetimeSet;

	private static readonly System.IntPtr NativeFieldInfoPtr__bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr__particleBoundingRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr__particleRadiusOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr__sourceMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr__materialPropertyBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__materials;

	private static readonly System.IntPtr NativeFieldInfoPtr_Emitters;

	private static readonly System.IntPtr NativeFieldInfoPtr__errorMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_CullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_ParticleTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr__matrices;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshInstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr__matricesCopy;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomTicksPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxThrottleFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxUpdateDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxRenderingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_EmitterType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IndependentSprayAccel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeamTextureUScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeamTextureVScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_DetermineEndPointBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeamEndPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_BranchEmitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_BranchHFPointsRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_BranchProbability;

	private static readonly System.IntPtr NativeFieldInfoPtr_BranchSpawnAmountRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_HFScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighFrequencyPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_LFScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_LowFrequencyPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoiseDeterminesEndPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseLowFrequencyScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighFrequencyNoiseRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_LFScaleFactors;

	private static readonly System.IntPtr NativeFieldInfoPtr_LowFrequencyNoiseRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_HFScaleFactors;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseColorScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_Opacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorMultiplierRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeInEndTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForcedLifeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForcedMaxParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForcedFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_RespawnDeadParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddLocationFromOtherEmitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationShape;

	private static readonly System.IntPtr NativeFieldInfoPtr_SphereRadiusRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationPolarRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartLocationRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderTwoSided;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaticMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseMeshBlendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseParticleColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_Materials;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseOriginalMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unlit;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZWrite;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brightness;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseRevolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseRevolutionScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionCenterOffsetRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionsPerSecondRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_RevolutionScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpinParticles;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseRotationFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpinCCWorCW;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpinsPerSecondRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartSpinRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_SizeScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_UniformSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseRegularSizeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseSizeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_SizeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartSizeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutomaticInitialSpawning;

	private static readonly System.IntPtr NativeFieldInfoPtr_InitialParticlesPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_ParticlesPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_RefrUScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_RefrVScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Refraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseDirectionAs;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlendBetweenSubdivisions;

	private static readonly System.IntPtr NativeFieldInfoPtr_DrawStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_Texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureUSubdivisions;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureVSubdivisions;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseSubdivisionScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubdivisionScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_InitialDelayRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_InitialTimeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_LifetimeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddVelocityFromOtherEmitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetVelocityDirectionFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseVelocityScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_VelocityScaleRepeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAbsVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartVelocityRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartVelocityRadialRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_VelocityLossRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_VelocityScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_RelativeWarmupTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_WarmupTicksPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr__spriteMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr__vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr__indexes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowInitialize_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowInitialize_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInactive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumSpawnedParticles_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumAliveParticles_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableRendering_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableRendering_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Paused_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Particles_Public_get_IEnumerable_1_Particle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParticle_Public_Particle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParticle_Public_Void_Int32_Particle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForcedLifetime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CanThrottle_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ErrorMaterial_Private_Static_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowTick_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTooFarUpdate_Private_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTooFarRender_Private_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOutOfFrustumState_Private_Void_Bounds_Il2CppStructArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessParticlesSchedule_Private_Void_Single_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleFrameJobs_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteFrameJobs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateViewDependedParticleDataSchedule_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareParticleFrameData_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderParticles_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickParticlesCore_Private_Void_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WarmupParticles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallDeathEventIfNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickParticles_Private_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TickSingle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIdentity_Private_Static_Boolean_quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNanOrInfinite_Private_Static_Boolean_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointWorldPosition_Private_Static_Void_byref_float3_float3_quaternion_float3_quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateTime_Private_Static_Void_Single_NativeArray_1_Single_Single_byref_Int32_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeValue_Private_Static_float3_Single_NativeArray_1_float3_NativeArray_1_Single_Single_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeValue_Private_Static_float4_Single_NativeArray_1_float4_NativeArray_1_Single_Single_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeValue_Private_Static_Single_Single_NativeArray_1_Single_NativeArray_1_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandBounds_Private_Static_Void_NativeArray_1_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromToRotation_Private_Static_quaternion_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeVariables_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateParameterBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeParameterBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SoftRestart_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBlendMode_Private_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterials_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRenderMatricesSchedule_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMeshes_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMeshEmitterData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeMeshEmitterData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildParticleVertexBuffersSchedule_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpriteMesh_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSprites_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpriteEmitterData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeSpriteEmitterData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float DefaultScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultScale, (void*)(&num));
		}
	}

	public unsafe static float MeshScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MeshScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MeshScale, (void*)(&num));
		}
	}

	public unsafe static float MaxDelta
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxDelta, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxDelta, (void*)(&num));
		}
	}

	public unsafe static float MaxSkipDelta
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSkipDelta, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSkipDelta, (void*)(&num));
		}
	}

	public unsafe static float TooFarDistance
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TooFarDistance, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TooFarDistance, (void*)(&num));
		}
	}

	public unsafe static int TicksBeforeInactive
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksBeforeInactive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksBeforeInactive, (void*)(&num));
		}
	}

	public unsafe static bool _AllowInitialize_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AllowInitialize_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AllowInitialize_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe Il2CppSystem.Action OnDeath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeath);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeath)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe bool _DisableRendering_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisableRendering_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisableRendering_k__BackingField)) = flag;
		}
	}

	public unsafe NativeArray<Particle> _particles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particles);
			return new NativeArray<Particle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Particle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe JobHandle _lastScheduledFrameJobHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastScheduledFrameJobHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastScheduledFrameJobHandle)) = jobHandle;
		}
	}

	public unsafe NativeRelativeColor _colorScaleNative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colorScaleNative);
			return new NativeRelativeColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colorScaleNative), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeColor)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeColor>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeRelativeVector3 _revolutionScaleNative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__revolutionScaleNative);
			return new NativeRelativeVector3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__revolutionScaleNative), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeVector)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeRelativeFloat _sizeScaleNative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeScaleNative);
			return new NativeRelativeFloat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeScaleNative), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeFloat)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeFloat>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeRelativeVector3 _velocityScaleNative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__velocityScaleNative);
			return new NativeRelativeVector3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__velocityScaleNative), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeRelativeVector)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeRelativeVector3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> _subdivisionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subdivisionScale);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subdivisionScale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float3> _boundsArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__boundsArray);
			return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__boundsArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> _particleCounterArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleCounterArray);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleCounterArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static int CounterSpawned
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CounterSpawned, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CounterSpawned, (void*)(&num));
		}
	}

	public unsafe static int CounterAlive
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CounterAlive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CounterAlive, (void*)(&num));
		}
	}

	public unsafe static int CounterNumToSpawn
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CounterNumToSpawn, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CounterNumToSpawn, (void*)(&num));
		}
	}

	public unsafe bool _initialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized)) = flag;
		}
	}

	public unsafe int _numToSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numToSpawn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numToSpawn)) = num;
		}
	}

	public unsafe int _numAliveParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numAliveParticles);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numAliveParticles)) = num;
		}
	}

	public unsafe int _numSpawnedParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numSpawnedParticles);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numSpawnedParticles)) = num;
		}
	}

	public unsafe int _currentTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentTick)) = num;
		}
	}

	public unsafe bool _paused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paused);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__paused)) = flag;
		}
	}

	public unsafe float _particleDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleDelta)) = num;
		}
	}

	public unsafe bool _warmedUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__warmedUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__warmedUp)) = flag;
		}
	}

	public unsafe float _delay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__delay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__delay)) = num;
		}
	}

	public unsafe float _time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time)) = num;
		}
	}

	public unsafe float _startTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startTime)) = num;
		}
	}

	public unsafe float _particlesPerFrameAccum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particlesPerFrameAccum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particlesPerFrameAccum)) = num;
		}
	}

	public unsafe int _lastRenderedTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRenderedTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRenderedTick)) = num;
		}
	}

	public unsafe int _lastViewUpdatedTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastViewUpdatedTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastViewUpdatedTick)) = num;
		}
	}

	public unsafe int _lastSpriteMeshUpdatedTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSpriteMeshUpdatedTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSpriteMeshUpdatedTick)) = num;
		}
	}

	public unsafe int _lastSynced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSynced);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastSynced)) = num;
		}
	}

	public unsafe bool _outOfFrustum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outOfFrustum);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outOfFrustum)) = flag;
		}
	}

	public unsafe int _currentThrottleFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentThrottleFrames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentThrottleFrames)) = num;
		}
	}

	public unsafe bool _onDeathEventCalled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onDeathEventCalled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onDeathEventCalled)) = flag;
		}
	}

	public unsafe float _forcedLifetimeEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forcedLifetimeEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forcedLifetimeEndTime)) = num;
		}
	}

	public unsafe bool _forcedLifetimeSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forcedLifetimeSet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forcedLifetimeSet)) = flag;
		}
	}

	public unsafe Bounds _bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bounds)) = bounds;
		}
	}

	public unsafe float _particleBoundingRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleBoundingRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleBoundingRadius)) = num;
		}
	}

	public unsafe Vector3 _particleRadiusOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleRadiusOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__particleRadiusOffset)) = vector;
		}
	}

	public unsafe Mesh _sourceMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe MaterialPropertyBlock _materialPropertyBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materialPropertyBlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materialPropertyBlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertyBlock));
		}
	}

	public unsafe Vector3 _lastPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastPosition)) = vector;
		}
	}

	public unsafe List<Material> _materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<UnrealEmitter> Emitters
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Emitters, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UnrealEmitter>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Emitters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Material _errorMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__errorMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__errorMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe static int CullingMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CullingMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CullingMask, (void*)(&num));
		}
	}

	public unsafe static Stopwatch ParticleTimer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ParticleTimer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ParticleTimer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopwatch));
		}
	}

	public unsafe NativeArray<Matrix4x4> _matrices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matrices);
			return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<MeshInstanceData> _meshInstanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshInstanceData);
			return new NativeArray<MeshInstanceData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<MeshInstanceData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MeshInstanceData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> _matricesCopy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matricesCopy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__matricesCopy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<Vector4> _meshColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshColors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int CustomTicksPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomTicksPerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomTicksPerSecond)) = num;
		}
	}

	public unsafe int MaxThrottleFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxThrottleFrames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxThrottleFrames)) = num;
		}
	}

	public unsafe float MaxUpdateDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxUpdateDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxUpdateDistance)) = num;
		}
	}

	public unsafe float MaxRenderingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxRenderingDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxRenderingDistance)) = num;
		}
	}

	public unsafe bool AlwaysUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlwaysUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlwaysUpdate)) = flag;
		}
	}

	public unsafe float TimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeScale)) = num;
		}
	}

	public unsafe Type EmitterType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterType);
			return *(Type*)num;
		}
		set
		{
			*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EmitterType)) = type;
		}
	}

	public unsafe bool IndependentSprayAccel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IndependentSprayAccel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IndependentSprayAccel)) = flag;
		}
	}

	public unsafe Vector3 Acceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Acceleration);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Acceleration)) = vector;
		}
	}

	public unsafe float BeamTextureUScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamTextureUScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamTextureUScale)) = num;
		}
	}

	public unsafe float BeamTextureVScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamTextureVScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamTextureVScale)) = num;
		}
	}

	public unsafe EBeamEndPointType DetermineEndPointBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetermineEndPointBy);
			return *(EBeamEndPointType*)num;
		}
		set
		{
			*(EBeamEndPointType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DetermineEndPointBy)) = eBeamEndPointType;
		}
	}

	public unsafe Il2CppStructArray<Range3> BeamEndPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamEndPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Range3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeamEndPoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int BranchEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchEmitter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchEmitter)) = num;
		}
	}

	public unsafe Il2CppScripts.Common.Range BranchHFPointsRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchHFPointsRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchHFPointsRange)) = range;
		}
	}

	public unsafe Il2CppScripts.Common.Range BranchProbability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchProbability);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchProbability)) = range;
		}
	}

	public unsafe Il2CppScripts.Common.Range BranchSpawnAmountRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchSpawnAmountRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchSpawnAmountRange)) = range;
		}
	}

	public unsafe float HFScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HFScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HFScaleRepeats)) = num;
		}
	}

	public unsafe int HighFrequencyPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighFrequencyPoints);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighFrequencyPoints)) = num;
		}
	}

	public unsafe float LFScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LFScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LFScaleRepeats)) = num;
		}
	}

	public unsafe float LowFrequencyPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LowFrequencyPoints);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LowFrequencyPoints)) = num;
		}
	}

	public unsafe bool NoiseDeterminesEndPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoiseDeterminesEndPoint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoiseDeterminesEndPoint)) = flag;
		}
	}

	public unsafe bool UseLowFrequencyScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseLowFrequencyScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseLowFrequencyScale)) = flag;
		}
	}

	public unsafe Range3 HighFrequencyNoiseRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighFrequencyNoiseRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighFrequencyNoiseRange)) = range;
		}
	}

	public unsafe RelativeVector3 LFScaleFactors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LFScaleFactors);
			return *(RelativeVector3*)num;
		}
		set
		{
			*(RelativeVector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LFScaleFactors)) = relativeVector;
		}
	}

	public unsafe Range3 LowFrequencyNoiseRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LowFrequencyNoiseRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LowFrequencyNoiseRange)) = range;
		}
	}

	public unsafe RelativeVector3 HFScaleFactors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HFScaleFactors);
			return *(RelativeVector3*)num;
		}
		set
		{
			*(RelativeVector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HFScaleFactors)) = relativeVector;
		}
	}

	public unsafe bool UseColorScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseColorScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseColorScale)) = flag;
		}
	}

	public unsafe float ColorScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScaleRepeats)) = num;
		}
	}

	public unsafe float Opacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opacity)) = num;
		}
	}

	public unsafe Range3 ColorMultiplierRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorMultiplierRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorMultiplierRange)) = range;
		}
	}

	public unsafe Il2CppStructArray<RelativeColor> ColorScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RelativeColor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool FadeIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeIn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeIn)) = flag;
		}
	}

	public unsafe float FadeInEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeInEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeInEndTime)) = num;
		}
	}

	public unsafe bool FadeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOut)) = flag;
		}
	}

	public unsafe float FadeOutStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeOutStartTime)) = num;
		}
	}

	public unsafe EParticleCoordinateSystem CoordinateSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem);
			return *(EParticleCoordinateSystem*)num;
		}
		set
		{
			*(EParticleCoordinateSystem*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CoordinateSystem)) = eParticleCoordinateSystem;
		}
	}

	public unsafe int MaxParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxParticles);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxParticles)) = num;
		}
	}

	public unsafe bool ForcedLifeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifeTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedLifeTime)) = flag;
		}
	}

	public unsafe bool ForcedMaxParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedMaxParticles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedMaxParticles)) = flag;
		}
	}

	public unsafe bool ForcedFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForcedFade)) = flag;
		}
	}

	public unsafe bool AutoDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoDestroy)) = flag;
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool RespawnDeadParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RespawnDeadParticles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RespawnDeadParticles)) = flag;
		}
	}

	public unsafe int AddLocationFromOtherEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddLocationFromOtherEmitter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddLocationFromOtherEmitter)) = num;
		}
	}

	public unsafe EParticleStartLocationShape StartLocationShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationShape);
			return *(EParticleStartLocationShape*)num;
		}
		set
		{
			*(EParticleStartLocationShape*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationShape)) = eParticleStartLocationShape;
		}
	}

	public unsafe Il2CppScripts.Common.Range SphereRadiusRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SphereRadiusRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SphereRadiusRange)) = range;
		}
	}

	public unsafe Vector3 StartLocationOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationOffset)) = vector;
		}
	}

	public unsafe Range3 StartLocationPolarRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationPolarRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationPolarRange)) = range;
		}
	}

	public unsafe Range3 StartLocationRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartLocationRange)) = range;
		}
	}

	public unsafe bool RenderTwoSided
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderTwoSided);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderTwoSided)) = flag;
		}
	}

	public unsafe MeshRenderer StaticMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaticMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe bool UseMeshBlendMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMeshBlendMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseMeshBlendMode)) = flag;
		}
	}

	public unsafe bool UseParticleColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseParticleColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseParticleColor)) = flag;
		}
	}

	public unsafe Mesh Mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Il2CppReferenceArray<Material> Materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool UseOriginalMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOriginalMaterial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseOriginalMaterial)) = flag;
		}
	}

	public unsafe bool Unlit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unlit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unlit)) = flag;
		}
	}

	public unsafe bool ZTest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZTest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZTest)) = flag;
		}
	}

	public unsafe bool ZWrite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZWrite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ZWrite)) = flag;
		}
	}

	public unsafe float Brightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brightness)) = num;
		}
	}

	public unsafe bool UseRevolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolution);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolution)) = flag;
		}
	}

	public unsafe bool UseRevolutionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolutionScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRevolutionScale)) = flag;
		}
	}

	public unsafe float RevolutionScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScaleRepeats)) = num;
		}
	}

	public unsafe Range3 RevolutionCenterOffsetRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionCenterOffsetRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionCenterOffsetRange)) = range;
		}
	}

	public unsafe Range3 RevolutionsPerSecondRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionsPerSecondRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionsPerSecondRange)) = range;
		}
	}

	public unsafe Il2CppStructArray<RelativeVector3> RevolutionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RelativeVector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RevolutionScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool SpinParticles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinParticles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinParticles)) = flag;
		}
	}

	public unsafe int UseRotationFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRotationFrom);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRotationFrom)) = num;
		}
	}

	public unsafe Vector3 SpinCCWorCW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinCCWorCW);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinCCWorCW)) = vector;
		}
	}

	public unsafe Range3 SpinsPerSecondRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinsPerSecondRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpinsPerSecondRange)) = range;
		}
	}

	public unsafe Range3 StartSpinRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSpinRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSpinRange)) = range;
		}
	}

	public unsafe float SizeScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScaleRepeats)) = num;
		}
	}

	public unsafe bool UniformSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniformSize)) = flag;
		}
	}

	public unsafe bool UseRegularSizeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRegularSizeScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRegularSizeScale)) = flag;
		}
	}

	public unsafe bool UseSizeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSizeScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSizeScale)) = flag;
		}
	}

	public unsafe Il2CppStructArray<RelativeFloat> SizeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RelativeFloat>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Range3 StartSizeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSizeRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSizeRange)) = range;
		}
	}

	public unsafe bool AutomaticInitialSpawning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutomaticInitialSpawning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutomaticInitialSpawning)) = flag;
		}
	}

	public unsafe float InitialParticlesPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialParticlesPerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialParticlesPerSecond)) = num;
		}
	}

	public unsafe int ParticlesPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticlesPerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticlesPerSecond)) = num;
		}
	}

	public unsafe float RefrUScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefrUScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefrUScale)) = num;
		}
	}

	public unsafe float RefrVScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefrVScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RefrVScale)) = num;
		}
	}

	public unsafe bool Refraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refraction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refraction)) = flag;
		}
	}

	public unsafe EParticleDirectionUsage UseDirectionAs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs);
			return *(EParticleDirectionUsage*)num;
		}
		set
		{
			*(EParticleDirectionUsage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseDirectionAs)) = eParticleDirectionUsage;
		}
	}

	public unsafe Vector3 ProjectionNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectionNormal)) = vector;
		}
	}

	public unsafe bool BlendBetweenSubdivisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlendBetweenSubdivisions)) = flag;
		}
	}

	public unsafe EParticleDrawStyle DrawStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawStyle);
			return *(EParticleDrawStyle*)num;
		}
		set
		{
			*(EParticleDrawStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawStyle)) = eParticleDrawStyle;
		}
	}

	public unsafe int SubdivisionEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionEnd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionEnd)) = num;
		}
	}

	public unsafe int SubdivisionStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionStart)) = num;
		}
	}

	public unsafe Material Texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Texture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe int TextureUSubdivisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureUSubdivisions);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureUSubdivisions)) = num;
		}
	}

	public unsafe int TextureVSubdivisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureVSubdivisions);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureVSubdivisions)) = num;
		}
	}

	public unsafe bool UseRandomSubdivision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRandomSubdivision);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseRandomSubdivision)) = flag;
		}
	}

	public unsafe bool UseSubdivisionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSubdivisionScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseSubdivisionScale)) = flag;
		}
	}

	public unsafe Il2CppStructArray<float> SubdivisionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubdivisionScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppScripts.Common.Range InitialDelayRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialDelayRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialDelayRange)) = range;
		}
	}

	public unsafe Il2CppScripts.Common.Range InitialTimeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialTimeRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitialTimeRange)) = range;
		}
	}

	public unsafe Il2CppScripts.Common.Range LifetimeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifetimeRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifetimeRange)) = range;
		}
	}

	public unsafe int AddVelocityFromOtherEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddVelocityFromOtherEmitter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddVelocityFromOtherEmitter)) = num;
		}
	}

	public unsafe EParticleVelocityDirection GetVelocityDirectionFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetVelocityDirectionFrom);
			return *(EParticleVelocityDirection*)num;
		}
		set
		{
			*(EParticleVelocityDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GetVelocityDirectionFrom)) = eParticleVelocityDirection;
		}
	}

	public unsafe bool UseVelocityScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseVelocityScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseVelocityScale)) = flag;
		}
	}

	public unsafe float VelocityScaleRepeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScaleRepeats);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScaleRepeats)) = num;
		}
	}

	public unsafe Vector3 MaxAbsVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAbsVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAbsVelocity)) = vector;
		}
	}

	public unsafe Range3 StartVelocityRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRange)) = range;
		}
	}

	public unsafe Il2CppScripts.Common.Range StartVelocityRadialRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRadialRange);
			return *(Il2CppScripts.Common.Range*)num;
		}
		set
		{
			*(Il2CppScripts.Common.Range*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartVelocityRadialRange)) = range;
		}
	}

	public unsafe Range3 VelocityLossRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityLossRange);
			return *(Range3*)num;
		}
		set
		{
			*(Range3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityLossRange)) = range;
		}
	}

	public unsafe Il2CppStructArray<RelativeVector3> VelocityScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RelativeVector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityScale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float RelativeWarmupTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeWarmupTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeWarmupTime)) = num;
		}
	}

	public unsafe int WarmupTicksPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WarmupTicksPerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WarmupTicksPerSecond)) = num;
		}
	}

	public unsafe Mesh _spriteMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spriteMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spriteMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe NativeArray<ParticleVertex> _vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vertices);
			return new NativeArray<ParticleVertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ParticleVertex>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ParticleVertex>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<ushort> _indexes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__indexes);
			return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__indexes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static bool AllowInitialize
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54457, XrefRangeEnd = 54461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllowInitialize_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54461, XrefRangeEnd = 54465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AllowInitialize_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsAlive
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 54472, RefRangeEnd = 54475, XrefRangeStart = 54471, XrefRangeEnd = 54472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Initialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsReady
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 54480, RefRangeEnd = 54483, XrefRangeStart = 54475, XrefRangeEnd = 54480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsInactive
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 54485, RefRangeEnd = 54487, XrefRangeStart = 54483, XrefRangeEnd = 54485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInactive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int NumSpawnedParticles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumSpawnedParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int NumAliveParticles
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumAliveParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool DisableRendering
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44851, RefRangeEnd = 44852, XrefRangeStart = 44851, XrefRangeEnd = 44852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisableRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool Paused
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Paused_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IEnumerable<Particle> Particles
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54487, XrefRangeEnd = 54490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Particles_Public_get_IEnumerable_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Particle>>(intPtr) : null;
		}
	}

	public unsafe Bounds Bounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool CanThrottle
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 54490, RefRangeEnd = 54495, XrefRangeStart = 54490, XrefRangeEnd = 54490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanThrottle_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static Material ErrorMaterial
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54495, XrefRangeEnd = 54523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ErrorMaterial_Private_Static_get_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
	}

	public unsafe bool AllowTick
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllowTick_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static UnrealEmitter()
	{
		Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Emitters", "UnrealEmitter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr);
		NativeFieldInfoPtr_DefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "DefaultScale");
		NativeFieldInfoPtr_MeshScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MeshScale");
		NativeFieldInfoPtr_MaxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxDelta");
		NativeFieldInfoPtr_MaxSkipDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxSkipDelta");
		NativeFieldInfoPtr_TooFarDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "TooFarDistance");
		NativeFieldInfoPtr_TicksBeforeInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "TicksBeforeInactive");
		NativeFieldInfoPtr__AllowInitialize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "<AllowInitialize>k__BackingField");
		NativeFieldInfoPtr_OnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "OnDeath");
		NativeFieldInfoPtr__DisableRendering_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "<DisableRendering>k__BackingField");
		NativeFieldInfoPtr__particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particles");
		NativeFieldInfoPtr__lastScheduledFrameJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastScheduledFrameJobHandle");
		NativeFieldInfoPtr__colorScaleNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_colorScaleNative");
		NativeFieldInfoPtr__revolutionScaleNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_revolutionScaleNative");
		NativeFieldInfoPtr__sizeScaleNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_sizeScaleNative");
		NativeFieldInfoPtr__velocityScaleNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_velocityScaleNative");
		NativeFieldInfoPtr__subdivisionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_subdivisionScale");
		NativeFieldInfoPtr__boundsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_boundsArray");
		NativeFieldInfoPtr__particleCounterArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particleCounterArray");
		NativeFieldInfoPtr_CounterSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CounterSpawned");
		NativeFieldInfoPtr_CounterAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CounterAlive");
		NativeFieldInfoPtr_CounterNumToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CounterNumToSpawn");
		NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_initialized");
		NativeFieldInfoPtr__numToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_numToSpawn");
		NativeFieldInfoPtr__numAliveParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_numAliveParticles");
		NativeFieldInfoPtr__numSpawnedParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_numSpawnedParticles");
		NativeFieldInfoPtr__currentTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_currentTick");
		NativeFieldInfoPtr__paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_paused");
		NativeFieldInfoPtr__particleDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particleDelta");
		NativeFieldInfoPtr__warmedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_warmedUp");
		NativeFieldInfoPtr__delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_delay");
		NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_time");
		NativeFieldInfoPtr__startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_startTime");
		NativeFieldInfoPtr__particlesPerFrameAccum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particlesPerFrameAccum");
		NativeFieldInfoPtr__lastRenderedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastRenderedTick");
		NativeFieldInfoPtr__lastViewUpdatedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastViewUpdatedTick");
		NativeFieldInfoPtr__lastSpriteMeshUpdatedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastSpriteMeshUpdatedTick");
		NativeFieldInfoPtr__lastSynced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastSynced");
		NativeFieldInfoPtr__outOfFrustum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_outOfFrustum");
		NativeFieldInfoPtr__currentThrottleFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_currentThrottleFrames");
		NativeFieldInfoPtr__onDeathEventCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_onDeathEventCalled");
		NativeFieldInfoPtr__forcedLifetimeEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_forcedLifetimeEndTime");
		NativeFieldInfoPtr__forcedLifetimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_forcedLifetimeSet");
		NativeFieldInfoPtr__bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_bounds");
		NativeFieldInfoPtr__particleBoundingRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particleBoundingRadius");
		NativeFieldInfoPtr__particleRadiusOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_particleRadiusOffset");
		NativeFieldInfoPtr__sourceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_sourceMesh");
		NativeFieldInfoPtr__materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_materialPropertyBlock");
		NativeFieldInfoPtr__lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_lastPosition");
		NativeFieldInfoPtr__materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_materials");
		NativeFieldInfoPtr_Emitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Emitters");
		NativeFieldInfoPtr__errorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_errorMaterial");
		NativeFieldInfoPtr_CullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CullingMask");
		NativeFieldInfoPtr_ParticleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ParticleTimer");
		NativeFieldInfoPtr__matrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_matrices");
		NativeFieldInfoPtr__meshInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_meshInstanceData");
		NativeFieldInfoPtr__matricesCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_matricesCopy");
		NativeFieldInfoPtr__meshColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_meshColors");
		NativeFieldInfoPtr_CustomTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CustomTicksPerSecond");
		NativeFieldInfoPtr_MaxThrottleFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxThrottleFrames");
		NativeFieldInfoPtr_MaxUpdateDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxUpdateDistance");
		NativeFieldInfoPtr_MaxRenderingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxRenderingDistance");
		NativeFieldInfoPtr_AlwaysUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "AlwaysUpdate");
		NativeFieldInfoPtr_TimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "TimeScale");
		NativeFieldInfoPtr_EmitterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "EmitterType");
		NativeFieldInfoPtr_IndependentSprayAccel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "IndependentSprayAccel");
		NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Acceleration");
		NativeFieldInfoPtr_BeamTextureUScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BeamTextureUScale");
		NativeFieldInfoPtr_BeamTextureVScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BeamTextureVScale");
		NativeFieldInfoPtr_DetermineEndPointBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "DetermineEndPointBy");
		NativeFieldInfoPtr_BeamEndPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BeamEndPoints");
		NativeFieldInfoPtr_BranchEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BranchEmitter");
		NativeFieldInfoPtr_BranchHFPointsRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BranchHFPointsRange");
		NativeFieldInfoPtr_BranchProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BranchProbability");
		NativeFieldInfoPtr_BranchSpawnAmountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BranchSpawnAmountRange");
		NativeFieldInfoPtr_HFScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "HFScaleRepeats");
		NativeFieldInfoPtr_HighFrequencyPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "HighFrequencyPoints");
		NativeFieldInfoPtr_LFScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "LFScaleRepeats");
		NativeFieldInfoPtr_LowFrequencyPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "LowFrequencyPoints");
		NativeFieldInfoPtr_NoiseDeterminesEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "NoiseDeterminesEndPoint");
		NativeFieldInfoPtr_UseLowFrequencyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseLowFrequencyScale");
		NativeFieldInfoPtr_HighFrequencyNoiseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "HighFrequencyNoiseRange");
		NativeFieldInfoPtr_LFScaleFactors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "LFScaleFactors");
		NativeFieldInfoPtr_LowFrequencyNoiseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "LowFrequencyNoiseRange");
		NativeFieldInfoPtr_HFScaleFactors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "HFScaleFactors");
		NativeFieldInfoPtr_UseColorScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseColorScale");
		NativeFieldInfoPtr_ColorScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ColorScaleRepeats");
		NativeFieldInfoPtr_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Opacity");
		NativeFieldInfoPtr_ColorMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ColorMultiplierRange");
		NativeFieldInfoPtr_ColorScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ColorScale");
		NativeFieldInfoPtr_FadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "FadeIn");
		NativeFieldInfoPtr_FadeInEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "FadeInEndTime");
		NativeFieldInfoPtr_FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "FadeOut");
		NativeFieldInfoPtr_FadeOutStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "FadeOutStartTime");
		NativeFieldInfoPtr_CoordinateSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "CoordinateSystem");
		NativeFieldInfoPtr_MaxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxParticles");
		NativeFieldInfoPtr_ForcedLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ForcedLifeTime");
		NativeFieldInfoPtr_ForcedMaxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ForcedMaxParticles");
		NativeFieldInfoPtr_ForcedFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ForcedFade");
		NativeFieldInfoPtr_AutoDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "AutoDestroy");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_RespawnDeadParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RespawnDeadParticles");
		NativeFieldInfoPtr_AddLocationFromOtherEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "AddLocationFromOtherEmitter");
		NativeFieldInfoPtr_StartLocationShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartLocationShape");
		NativeFieldInfoPtr_SphereRadiusRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SphereRadiusRange");
		NativeFieldInfoPtr_StartLocationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartLocationOffset");
		NativeFieldInfoPtr_StartLocationPolarRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartLocationPolarRange");
		NativeFieldInfoPtr_StartLocationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartLocationRange");
		NativeFieldInfoPtr_RenderTwoSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RenderTwoSided");
		NativeFieldInfoPtr_StaticMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StaticMesh");
		NativeFieldInfoPtr_UseMeshBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseMeshBlendMode");
		NativeFieldInfoPtr_UseParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseParticleColor");
		NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Mesh");
		NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Materials");
		NativeFieldInfoPtr_UseOriginalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseOriginalMaterial");
		NativeFieldInfoPtr_Unlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Unlit");
		NativeFieldInfoPtr_ZTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ZTest");
		NativeFieldInfoPtr_ZWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ZWrite");
		NativeFieldInfoPtr_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Brightness");
		NativeFieldInfoPtr_UseRevolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseRevolution");
		NativeFieldInfoPtr_UseRevolutionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseRevolutionScale");
		NativeFieldInfoPtr_RevolutionScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RevolutionScaleRepeats");
		NativeFieldInfoPtr_RevolutionCenterOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RevolutionCenterOffsetRange");
		NativeFieldInfoPtr_RevolutionsPerSecondRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RevolutionsPerSecondRange");
		NativeFieldInfoPtr_RevolutionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RevolutionScale");
		NativeFieldInfoPtr_SpinParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SpinParticles");
		NativeFieldInfoPtr_UseRotationFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseRotationFrom");
		NativeFieldInfoPtr_SpinCCWorCW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SpinCCWorCW");
		NativeFieldInfoPtr_SpinsPerSecondRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SpinsPerSecondRange");
		NativeFieldInfoPtr_StartSpinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartSpinRange");
		NativeFieldInfoPtr_SizeScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SizeScaleRepeats");
		NativeFieldInfoPtr_UniformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UniformSize");
		NativeFieldInfoPtr_UseRegularSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseRegularSizeScale");
		NativeFieldInfoPtr_UseSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseSizeScale");
		NativeFieldInfoPtr_SizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SizeScale");
		NativeFieldInfoPtr_StartSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartSizeRange");
		NativeFieldInfoPtr_AutomaticInitialSpawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "AutomaticInitialSpawning");
		NativeFieldInfoPtr_InitialParticlesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "InitialParticlesPerSecond");
		NativeFieldInfoPtr_ParticlesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ParticlesPerSecond");
		NativeFieldInfoPtr_RefrUScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RefrUScale");
		NativeFieldInfoPtr_RefrVScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RefrVScale");
		NativeFieldInfoPtr_Refraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Refraction");
		NativeFieldInfoPtr_UseDirectionAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseDirectionAs");
		NativeFieldInfoPtr_ProjectionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "ProjectionNormal");
		NativeFieldInfoPtr_BlendBetweenSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "BlendBetweenSubdivisions");
		NativeFieldInfoPtr_DrawStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "DrawStyle");
		NativeFieldInfoPtr_SubdivisionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SubdivisionEnd");
		NativeFieldInfoPtr_SubdivisionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SubdivisionStart");
		NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "Texture");
		NativeFieldInfoPtr_TextureUSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "TextureUSubdivisions");
		NativeFieldInfoPtr_TextureVSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "TextureVSubdivisions");
		NativeFieldInfoPtr_UseRandomSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseRandomSubdivision");
		NativeFieldInfoPtr_UseSubdivisionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseSubdivisionScale");
		NativeFieldInfoPtr_SubdivisionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "SubdivisionScale");
		NativeFieldInfoPtr_InitialDelayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "InitialDelayRange");
		NativeFieldInfoPtr_InitialTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "InitialTimeRange");
		NativeFieldInfoPtr_LifetimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "LifetimeRange");
		NativeFieldInfoPtr_AddVelocityFromOtherEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "AddVelocityFromOtherEmitter");
		NativeFieldInfoPtr_GetVelocityDirectionFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "GetVelocityDirectionFrom");
		NativeFieldInfoPtr_UseVelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "UseVelocityScale");
		NativeFieldInfoPtr_VelocityScaleRepeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "VelocityScaleRepeats");
		NativeFieldInfoPtr_MaxAbsVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "MaxAbsVelocity");
		NativeFieldInfoPtr_StartVelocityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartVelocityRange");
		NativeFieldInfoPtr_StartVelocityRadialRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "StartVelocityRadialRange");
		NativeFieldInfoPtr_VelocityLossRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "VelocityLossRange");
		NativeFieldInfoPtr_VelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "VelocityScale");
		NativeFieldInfoPtr_RelativeWarmupTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "RelativeWarmupTime");
		NativeFieldInfoPtr_WarmupTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "WarmupTicksPerSecond");
		NativeFieldInfoPtr__spriteMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_spriteMesh");
		NativeFieldInfoPtr__vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_vertices");
		NativeFieldInfoPtr__indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, "_indexes");
		NativeMethodInfoPtr_get_AllowInitialize_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668788);
		NativeMethodInfoPtr_set_AllowInitialize_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668789);
		NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668790);
		NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668791);
		NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668792);
		NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668793);
		NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668794);
		NativeMethodInfoPtr_get_IsInactive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668795);
		NativeMethodInfoPtr_get_NumSpawnedParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668796);
		NativeMethodInfoPtr_get_NumAliveParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668797);
		NativeMethodInfoPtr_get_DisableRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668798);
		NativeMethodInfoPtr_set_DisableRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_get_Paused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_set_Paused_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_get_Particles_Public_get_IEnumerable_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_GetParticle_Public_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_SetParticle_Public_Void_Int32_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668805);
		NativeMethodInfoPtr_SetForcedLifetime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668806);
		NativeMethodInfoPtr_get_CanThrottle_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_get_ErrorMaterial_Private_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr_get_AllowTick_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr_IsTooFarUpdate_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668810);
		NativeMethodInfoPtr_IsTooFarRender_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_SetOutOfFrustumState_Private_Void_Bounds_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_ProcessParticlesSchedule_Private_Void_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_ScheduleFrameJobs_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_CompleteFrameJobs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_UpdateViewDependedParticleDataSchedule_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668816);
		NativeMethodInfoPtr_PrepareParticleFrameData_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668817);
		NativeMethodInfoPtr_RenderParticles_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668818);
		NativeMethodInfoPtr_TickParticlesCore_Private_Void_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668819);
		NativeMethodInfoPtr_WarmupParticles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668820);
		NativeMethodInfoPtr_CallDeathEventIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668821);
		NativeMethodInfoPtr_TickParticles_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668822);
		NativeMethodInfoPtr_TickSingle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668823);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668824);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668825);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668826);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668827);
		NativeMethodInfoPtr_IsIdentity_Private_Static_Boolean_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668828);
		NativeMethodInfoPtr_IsNanOrInfinite_Private_Static_Boolean_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668829);
		NativeMethodInfoPtr_PointWorldPosition_Private_Static_Void_byref_float3_float3_quaternion_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668830);
		NativeMethodInfoPtr_InterpolateTime_Private_Static_Void_Single_NativeArray_1_Single_Single_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668831);
		NativeMethodInfoPtr_RelativeValue_Private_Static_float3_Single_NativeArray_1_float3_NativeArray_1_Single_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668832);
		NativeMethodInfoPtr_RelativeValue_Private_Static_float4_Single_NativeArray_1_float4_NativeArray_1_Single_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668833);
		NativeMethodInfoPtr_RelativeValue_Private_Static_Single_Single_NativeArray_1_Single_NativeArray_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668834);
		NativeMethodInfoPtr_ExpandBounds_Private_Static_Void_NativeArray_1_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668835);
		NativeMethodInfoPtr_FromToRotation_Private_Static_quaternion_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668836);
		NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668837);
		NativeMethodInfoPtr_DisposeBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668838);
		NativeMethodInfoPtr_InitializeVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668839);
		NativeMethodInfoPtr_AllocateParameterBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668840);
		NativeMethodInfoPtr_DisposeParameterBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668841);
		NativeMethodInfoPtr_InitializeBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668842);
		NativeMethodInfoPtr_SoftRestart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668843);
		NativeMethodInfoPtr_SetBlendMode_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668844);
		NativeMethodInfoPtr_UpdateMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668845);
		NativeMethodInfoPtr_GenerateRenderMatricesSchedule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668846);
		NativeMethodInfoPtr_RenderMeshes_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668847);
		NativeMethodInfoPtr_CreateMeshEmitterData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668848);
		NativeMethodInfoPtr_DisposeMeshEmitterData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668849);
		NativeMethodInfoPtr_BuildParticleVertexBuffersSchedule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668850);
		NativeMethodInfoPtr_UpdateSpriteMesh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668851);
		NativeMethodInfoPtr_RenderSprites_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668852);
		NativeMethodInfoPtr_CreateSpriteEmitterData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668853);
		NativeMethodInfoPtr_DisposeSpriteEmitterData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668854);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr, 100668855);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54465, XrefRangeEnd = 54468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnDeath(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54468, XrefRangeEnd = 54471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnDeath(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Particle GetParticle(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParticle_Public_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Particle*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetParticle(int index, Particle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Particle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &particle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParticle_Public_Void_Int32_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetForcedLifetime(float lifetime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lifetime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForcedLifetime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54531, RefRangeEnd = 54532, XrefRangeStart = 54523, XrefRangeEnd = 54531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTooFarUpdate(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTooFarUpdate_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54532, RefRangeEnd = 54534, XrefRangeStart = 54532, XrefRangeEnd = 54532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTooFarRender(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTooFarRender_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54536, RefRangeEnd = 54537, XrefRangeStart = 54534, XrefRangeEnd = 54536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOutOfFrustumState(Bounds frustumBounds, Il2CppStructArray<Plane> frustumPlanes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frustumBounds);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frustumPlanes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOutOfFrustumState_Private_Void_Bounds_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54560, RefRangeEnd = 54561, XrefRangeStart = 54537, XrefRangeEnd = 54560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessParticlesSchedule(float time, float delta, int numToSpawn, bool computeBounds = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numToSpawn;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &computeBounds;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessParticlesSchedule_Private_Void_Single_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54565, RefRangeEnd = 54566, XrefRangeStart = 54561, XrefRangeEnd = 54565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScheduleFrameJobs(float time, float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleFrameJobs_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 54569, RefRangeEnd = 54576, XrefRangeStart = 54566, XrefRangeEnd = 54569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompleteFrameJobs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteFrameJobs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54604, RefRangeEnd = 54605, XrefRangeStart = 54576, XrefRangeEnd = 54604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateViewDependedParticleDataSchedule(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateViewDependedParticleDataSchedule_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54620, RefRangeEnd = 54622, XrefRangeStart = 54605, XrefRangeEnd = 54620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareParticleFrameData(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareParticleFrameData_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54633, RefRangeEnd = 54635, XrefRangeStart = 54622, XrefRangeEnd = 54633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderParticles(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderParticles_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54640, RefRangeEnd = 54643, XrefRangeStart = 54635, XrefRangeEnd = 54640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickParticlesCore(float period, ref float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&period);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref delta);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickParticlesCore_Private_Void_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54643, XrefRangeEnd = 54645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WarmupParticles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WarmupParticles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54645, XrefRangeEnd = 54646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CallDeathEventIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallDeathEventIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54659, RefRangeEnd = 54661, XrefRangeStart = 54646, XrefRangeEnd = 54659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickParticles(float delta, bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delta);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickParticles_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54661, XrefRangeEnd = 54666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TickSingle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TickSingle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54666, XrefRangeEnd = 54667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54667, XrefRangeEnd = 54675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54675, XrefRangeEnd = 54684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54684, XrefRangeEnd = 54685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54685, XrefRangeEnd = 54690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIdentity(quaternion q)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIdentity_Private_Static_Boolean_quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54690, RefRangeEnd = 54692, XrefRangeStart = 54690, XrefRangeEnd = 54690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNanOrInfinite(float3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNanOrInfinite_Private_Static_Boolean_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54692, XrefRangeEnd = 54694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PointWorldPosition(ref float3 position, float3 location, quaternion rotation, float3 origin, quaternion originRotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref position);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(float3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(quaternion**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &originRotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointWorldPosition_Private_Static_Void_byref_float3_float3_quaternion_float3_quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54696, RefRangeEnd = 54697, XrefRangeStart = 54694, XrefRangeEnd = 54696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InterpolateTime(float relativeTime, NativeArray<float> times, float repeats, out int outIndex, out float outTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&relativeTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)times));
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &repeats;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outIndex);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolateTime_Private_Static_Void_Single_NativeArray_1_Single_Single_byref_Int32_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54704, RefRangeEnd = 54706, XrefRangeStart = 54697, XrefRangeEnd = 54704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 RelativeValue(float relativeTime, NativeArray<float3> values, NativeArray<float> times, float repeats, float3 baseValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&relativeTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)times));
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &repeats;
		*(float3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeValue_Private_Static_float3_Single_NativeArray_1_float3_NativeArray_1_Single_Single_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54713, RefRangeEnd = 54714, XrefRangeStart = 54706, XrefRangeEnd = 54713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float4 RelativeValue(float relativeTime, NativeArray<float4> values, NativeArray<float> times, float repeats, float4 baseValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&relativeTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)times));
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &repeats;
		*(float4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeValue_Private_Static_float4_Single_NativeArray_1_float4_NativeArray_1_Single_Single_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54714, XrefRangeEnd = 54721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RelativeValue(float relativeTime, NativeArray<float> values, NativeArray<float> times, float repeats, float baseValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&relativeTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)times));
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &repeats;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeValue_Private_Static_Single_Single_NativeArray_1_Single_NativeArray_1_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54721, RefRangeEnd = 54722, XrefRangeStart = 54721, XrefRangeEnd = 54721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExpandBounds(NativeArray<float3> bounds, float3 point, float3 extents = default(float3))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bounds));
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &extents;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandBounds_Private_Static_Void_NativeArray_1_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54732, RefRangeEnd = 54733, XrefRangeStart = 54722, XrefRangeEnd = 54732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static quaternion FromToRotation(float3 from, float3 to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromToRotation_Private_Static_quaternion_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54746, RefRangeEnd = 54748, XrefRangeStart = 54733, XrefRangeEnd = 54746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(bool force = false, bool hard = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&force);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hard;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54778, RefRangeEnd = 54781, XrefRangeStart = 54748, XrefRangeEnd = 54778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 54790, RefRangeEnd = 54793, XrefRangeStart = 54781, XrefRangeEnd = 54790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeVariables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54812, RefRangeEnd = 54813, XrefRangeStart = 54793, XrefRangeEnd = 54812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateParameterBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateParameterBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54813, XrefRangeEnd = 54829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeParameterBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeParameterBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54847, XrefRangeStart = 54829, XrefRangeEnd = 54846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54847, XrefRangeEnd = 54851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SoftRestart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SoftRestart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54886, RefRangeEnd = 54887, XrefRangeStart = 54851, XrefRangeEnd = 54886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBlendMode(Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBlendMode_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54887, XrefRangeEnd = 54923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54937, RefRangeEnd = 54938, XrefRangeStart = 54923, XrefRangeEnd = 54937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateRenderMatricesSchedule()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRenderMatricesSchedule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54996, RefRangeEnd = 54997, XrefRangeStart = 54938, XrefRangeEnd = 54996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderMeshes(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMeshes_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55045, RefRangeEnd = 55046, XrefRangeStart = 54997, XrefRangeEnd = 55045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMeshEmitterData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMeshEmitterData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55046, XrefRangeEnd = 55054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeMeshEmitterData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeMeshEmitterData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55067, RefRangeEnd = 55068, XrefRangeStart = 55054, XrefRangeEnd = 55067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildParticleVertexBuffersSchedule()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildParticleVertexBuffersSchedule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55088, RefRangeEnd = 55089, XrefRangeStart = 55068, XrefRangeEnd = 55088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpriteMesh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpriteMesh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55104, RefRangeEnd = 55105, XrefRangeStart = 55089, XrefRangeEnd = 55104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderSprites(UnityEngine.Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSprites_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55135, RefRangeEnd = 55136, XrefRangeStart = 55105, XrefRangeEnd = 55135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateSpriteEmitterData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSpriteEmitterData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55156, RefRangeEnd = 55157, XrefRangeStart = 55136, XrefRangeEnd = 55156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeSpriteEmitterData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeSpriteEmitterData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55157, XrefRangeEnd = 55180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnrealEmitter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnrealEmitter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UnrealEmitter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
