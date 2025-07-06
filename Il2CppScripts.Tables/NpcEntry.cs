using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScripts.Tables;

public class NpcEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_short_name;

	private static readonly IntPtr NativeFieldInfoPtr_priority;

	private static readonly IntPtr NativeFieldInfoPtr_class_name;

	private static readonly IntPtr NativeFieldInfoPtr_mesh;

	private static readonly IntPtr NativeFieldInfoPtr_materials;

	private static readonly IntPtr NativeFieldInfoPtr_col_radius;

	private static readonly IntPtr NativeFieldInfoPtr_col_height;

	private static readonly IntPtr NativeFieldInfoPtr_weapon_scale;

	private static readonly IntPtr NativeFieldInfoPtr_emitter_size;

	private static readonly IntPtr NativeFieldInfoPtr_run_speed;

	private static readonly IntPtr NativeFieldInfoPtr_walk_speed;

	private static readonly IntPtr NativeFieldInfoPtr_model_y_offset;

	private static readonly IntPtr NativeFieldInfoPtr_model_scale;

	private static readonly IntPtr NativeFieldInfoPtr_mount_bone;

	private static readonly IntPtr NativeFieldInfoPtr_mount_use_rotation;

	private static readonly IntPtr NativeFieldInfoPtr_disable_hit_reaction;

	private static readonly IntPtr NativeFieldInfoPtr_dialog_rotate;

	private static readonly IntPtr NativeFieldInfoPtr_disable_character_collision;

	private static readonly IntPtr NativeFieldInfoPtr_swish_sound;

	private static readonly IntPtr NativeFieldInfoPtr_atk_voc_sound;

	private static readonly IntPtr NativeFieldInfoPtr_receive_damage;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string short_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_short_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_short_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int priority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
		}
	}

	public unsafe string class_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_class_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_class_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppStringArray materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float col_radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col_radius)) = num;
		}
	}

	public unsafe float col_height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col_height);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col_height)) = num;
		}
	}

	public unsafe float weapon_scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon_scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon_scale)) = num;
		}
	}

	public unsafe float emitter_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emitter_size);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emitter_size)) = num;
		}
	}

	public unsafe int run_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_run_speed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_run_speed)) = num;
		}
	}

	public unsafe int walk_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walk_speed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walk_speed)) = num;
		}
	}

	public unsafe float model_y_offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model_y_offset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model_y_offset)) = num;
		}
	}

	public unsafe float model_scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model_scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model_scale)) = num;
		}
	}

	public unsafe string mount_bone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mount_bone);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mount_bone)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool mount_use_rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mount_use_rotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mount_use_rotation)) = flag;
		}
	}

	public unsafe bool disable_hit_reaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable_hit_reaction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable_hit_reaction)) = flag;
		}
	}

	public unsafe bool dialog_rotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog_rotate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog_rotate)) = flag;
		}
	}

	public unsafe bool disable_character_collision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable_character_collision);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable_character_collision)) = flag;
		}
	}

	public unsafe Il2CppStringArray swish_sound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swish_sound);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swish_sound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStringArray atk_voc_sound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atk_voc_sound);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atk_voc_sound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStringArray receive_damage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receive_damage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receive_damage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static NpcEntry()
	{
		Il2CppClassPointerStore<NpcEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "NpcEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr);
		NativeFieldInfoPtr_short_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "short_name");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "priority");
		NativeFieldInfoPtr_class_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "class_name");
		NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "mesh");
		NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "materials");
		NativeFieldInfoPtr_col_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "col_radius");
		NativeFieldInfoPtr_col_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "col_height");
		NativeFieldInfoPtr_weapon_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "weapon_scale");
		NativeFieldInfoPtr_emitter_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "emitter_size");
		NativeFieldInfoPtr_run_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "run_speed");
		NativeFieldInfoPtr_walk_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "walk_speed");
		NativeFieldInfoPtr_model_y_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "model_y_offset");
		NativeFieldInfoPtr_model_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "model_scale");
		NativeFieldInfoPtr_mount_bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "mount_bone");
		NativeFieldInfoPtr_mount_use_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "mount_use_rotation");
		NativeFieldInfoPtr_disable_hit_reaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "disable_hit_reaction");
		NativeFieldInfoPtr_dialog_rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "dialog_rotate");
		NativeFieldInfoPtr_disable_character_collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "disable_character_collision");
		NativeFieldInfoPtr_swish_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "swish_sound");
		NativeFieldInfoPtr_atk_voc_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "atk_voc_sound");
		NativeFieldInfoPtr_receive_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, "receive_damage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr, 100663718);
	}

	[CallerCount(0)]
	public unsafe NpcEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NpcEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
