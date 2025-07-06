using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Networking.ClientPackets.SelectionHall;

public class AuthLogin : ClientPacket
{
	private static readonly IntPtr NativeFieldInfoPtr__selectedGameServer;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameServerInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0;

	public unsafe GameServerInfo _selectedGameServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectedGameServer);
			return new GameServerInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectedGameServer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameServerInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameServerInfo>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static AuthLogin()
	{
		Il2CppClassPointerStore<AuthLogin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Networking.ClientPackets.SelectionHall", "AuthLogin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthLogin>.NativeClassPtr);
		NativeFieldInfoPtr__selectedGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthLogin>.NativeClassPtr, "_selectedGameServer");
		NativeMethodInfoPtr__ctor_Public_Void_GameServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthLogin>.NativeClassPtr, 100664903);
		NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthLogin>.NativeClassPtr, 100664904);
	}

	[CallerCount(0)]
	public unsafe AuthLogin(GameServerInfo gameServerInfo)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthLogin>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gameServerInfo));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17237, XrefRangeEnd = 17243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteMessage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AuthLogin(IntPtr pointer)
		: base(pointer)
	{
	}
}
