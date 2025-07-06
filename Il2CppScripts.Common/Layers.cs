using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScripts.Common;

public static class Layers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreRaycast;

	private static readonly System.IntPtr NativeFieldInfoPtr_Movers;

	private static readonly System.IntPtr NativeFieldInfoPtr_Water;

	private static readonly System.IntPtr NativeFieldInfoPtr_Characters;

	private static readonly System.IntPtr NativeFieldInfoPtr_Items;

	private static readonly System.IntPtr NativeFieldInfoPtr_Triggers;

	private static readonly System.IntPtr NativeFieldInfoPtr_Paperdoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI;

	private static readonly System.IntPtr NativeFieldInfoPtr_Music;

	public unsafe static int Default
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)(&num));
		}
	}

	public unsafe static int IgnoreRaycast
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IgnoreRaycast, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IgnoreRaycast, (void*)(&num));
		}
	}

	public unsafe static int Movers
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Movers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Movers, (void*)(&num));
		}
	}

	public unsafe static int Water
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Water, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Water, (void*)(&num));
		}
	}

	public unsafe static int Characters
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Characters, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Characters, (void*)(&num));
		}
	}

	public unsafe static int Items
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Items, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Items, (void*)(&num));
		}
	}

	public unsafe static int Triggers
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Triggers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Triggers, (void*)(&num));
		}
	}

	public unsafe static int Paperdoll
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Paperdoll, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Paperdoll, (void*)(&num));
		}
	}

	public unsafe static int UI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI, (void*)(&num));
		}
	}

	public unsafe static int Music
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Music, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Music, (void*)(&num));
		}
	}

	static Layers()
	{
		Il2CppClassPointerStore<Layers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Common", "Layers");
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Default");
		NativeFieldInfoPtr_IgnoreRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "IgnoreRaycast");
		NativeFieldInfoPtr_Movers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Movers");
		NativeFieldInfoPtr_Water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Water");
		NativeFieldInfoPtr_Characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Characters");
		NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Items");
		NativeFieldInfoPtr_Triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Triggers");
		NativeFieldInfoPtr_Paperdoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Paperdoll");
		NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "UI");
		NativeFieldInfoPtr_Music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Music");
	}

	public Layers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
