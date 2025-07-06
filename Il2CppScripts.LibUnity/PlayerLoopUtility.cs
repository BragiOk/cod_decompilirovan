using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.LowLevel;

namespace Il2CppScripts.LibUnity;

public class PlayerLoopUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ReturnInjectedSubSystem_Private_Static_PlayerLoopSystem_PlayerLoopSystem_PlayerLoopSystem_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReturnInjectedSubSystem_Private_Static_PlayerLoopSystem_PlayerLoopSystem_PlayerLoopSystem_0, Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InjectSubSystemAfter_Public_Static_Void_PlayerLoopSystem_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InjectSubSystemAfter_Public_Static_Void_PlayerLoopSystem_0, Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnInjectedSubSystem_Private_Static_PlayerLoopSystem_PlayerLoopSystem_PlayerLoopSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InjectSubSystemAfter_Public_Static_Void_PlayerLoopSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PlayerLoopUtility()
	{
		Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.LibUnity", "PlayerLoopUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr);
		NativeMethodInfoPtr_ReturnInjectedSubSystem_Private_Static_PlayerLoopSystem_PlayerLoopSystem_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr, 100665248);
		NativeMethodInfoPtr_InjectSubSystemAfter_Public_Static_Void_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr, 100665249);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr, 100665250);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20238, XrefRangeEnd = 20264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerLoopSystem ReturnInjectedSubSystem<T>(PlayerLoopSystem def, PlayerLoopSystem injected)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)def));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)injected));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReturnInjectedSubSystem_Private_Static_PlayerLoopSystem_PlayerLoopSystem_PlayerLoopSystem_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayerLoopSystem(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20264, XrefRangeEnd = 20269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InjectSubSystemAfter<T>(PlayerLoopSystem playerLoopSystem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)playerLoopSystem));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InjectSubSystemAfter_Public_Static_Void_PlayerLoopSystem_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerLoopUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlayerLoopUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
