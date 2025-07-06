using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Interfaces;

public class IPlaySound : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_String_Single_Single_0;

	static IPlaySound()
	{
		Il2CppClassPointerStore<IPlaySound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Interfaces", "IPlaySound");
		NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlaySound>.NativeClassPtr, 100665505);
	}

	[CallerCount(0)]
	public unsafe virtual void PlaySound(string sound, float volume, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &radius;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_String_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPlaySound(IntPtr pointer)
		: base(pointer)
	{
	}
}
