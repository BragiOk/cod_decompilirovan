using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Panels.Views.Login.GameLogin;
using Il2CppScripts.UI.Panels.Views.Login.ServerList;
using UnityEngine;

namespace Il2CppScripts.UI.Panels.Views.Login;

public class LoginViewRoot : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Login;

	private static readonly IntPtr NativeFieldInfoPtr_ServerList;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameLoginPanel Login
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Login);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameLoginPanel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Login)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameLoginPanel));
		}
	}

	public unsafe ServerListTab ServerList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ServerList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ServerListTab>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ServerList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serverListTab));
		}
	}

	static LoginViewRoot()
	{
		Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Panels.Views.Login", "LoginViewRoot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr);
		NativeFieldInfoPtr_Login = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr, "Login");
		NativeFieldInfoPtr_ServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr, "ServerList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr, 100666916);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoginViewRoot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginViewRoot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LoginViewRoot(IntPtr pointer)
		: base(pointer)
	{
	}
}
