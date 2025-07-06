using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScripts.Tables;

public class AccessoryEntry : DataEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_name;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_0_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_1_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_2_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_3_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_4_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_5_Roll;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_X;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_Y;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_Z;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_Pitch;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_Yaw;

	private static readonly IntPtr NativeFieldInfoPtr_Hair_6_Roll;

	private static readonly IntPtr NativeMethodInfoPtr_GetAccessoryData_Public_AccessoryData_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float Hair_0_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_X)) = num;
		}
	}

	public unsafe float Hair_0_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Y)) = num;
		}
	}

	public unsafe float Hair_0_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Z)) = num;
		}
	}

	public unsafe float Hair_0_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Pitch)) = num;
		}
	}

	public unsafe float Hair_0_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Yaw)) = num;
		}
	}

	public unsafe float Hair_0_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_0_Roll)) = num;
		}
	}

	public unsafe float Hair_1_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_X)) = num;
		}
	}

	public unsafe float Hair_1_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Y)) = num;
		}
	}

	public unsafe float Hair_1_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Z)) = num;
		}
	}

	public unsafe float Hair_1_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Pitch)) = num;
		}
	}

	public unsafe float Hair_1_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Yaw)) = num;
		}
	}

	public unsafe float Hair_1_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_1_Roll)) = num;
		}
	}

	public unsafe float Hair_2_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_X)) = num;
		}
	}

	public unsafe float Hair_2_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Y)) = num;
		}
	}

	public unsafe float Hair_2_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Z)) = num;
		}
	}

	public unsafe float Hair_2_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Pitch)) = num;
		}
	}

	public unsafe float Hair_2_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Yaw)) = num;
		}
	}

	public unsafe float Hair_2_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_2_Roll)) = num;
		}
	}

	public unsafe float Hair_3_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_X)) = num;
		}
	}

	public unsafe float Hair_3_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Y)) = num;
		}
	}

	public unsafe float Hair_3_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Z)) = num;
		}
	}

	public unsafe float Hair_3_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Pitch)) = num;
		}
	}

	public unsafe float Hair_3_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Yaw)) = num;
		}
	}

	public unsafe float Hair_3_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_3_Roll)) = num;
		}
	}

	public unsafe float Hair_4_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_X)) = num;
		}
	}

	public unsafe float Hair_4_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Y)) = num;
		}
	}

	public unsafe float Hair_4_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Z)) = num;
		}
	}

	public unsafe float Hair_4_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Pitch)) = num;
		}
	}

	public unsafe float Hair_4_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Yaw)) = num;
		}
	}

	public unsafe float Hair_4_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_4_Roll)) = num;
		}
	}

	public unsafe float Hair_5_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_X)) = num;
		}
	}

	public unsafe float Hair_5_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Y)) = num;
		}
	}

	public unsafe float Hair_5_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Z)) = num;
		}
	}

	public unsafe float Hair_5_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Pitch)) = num;
		}
	}

	public unsafe float Hair_5_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Yaw)) = num;
		}
	}

	public unsafe float Hair_5_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_5_Roll)) = num;
		}
	}

	public unsafe float Hair_6_X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_X);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_X)) = num;
		}
	}

	public unsafe float Hair_6_Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Y)) = num;
		}
	}

	public unsafe float Hair_6_Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Z)) = num;
		}
	}

	public unsafe float Hair_6_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Pitch)) = num;
		}
	}

	public unsafe float Hair_6_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Yaw)) = num;
		}
	}

	public unsafe float Hair_6_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hair_6_Roll)) = num;
		}
	}

	static AccessoryEntry()
	{
		Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Tables", "AccessoryEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "name");
		NativeFieldInfoPtr_Hair_0_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_X");
		NativeFieldInfoPtr_Hair_0_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_Y");
		NativeFieldInfoPtr_Hair_0_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_Z");
		NativeFieldInfoPtr_Hair_0_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_Pitch");
		NativeFieldInfoPtr_Hair_0_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_Yaw");
		NativeFieldInfoPtr_Hair_0_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_0_Roll");
		NativeFieldInfoPtr_Hair_1_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_X");
		NativeFieldInfoPtr_Hair_1_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_Y");
		NativeFieldInfoPtr_Hair_1_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_Z");
		NativeFieldInfoPtr_Hair_1_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_Pitch");
		NativeFieldInfoPtr_Hair_1_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_Yaw");
		NativeFieldInfoPtr_Hair_1_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_1_Roll");
		NativeFieldInfoPtr_Hair_2_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_X");
		NativeFieldInfoPtr_Hair_2_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_Y");
		NativeFieldInfoPtr_Hair_2_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_Z");
		NativeFieldInfoPtr_Hair_2_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_Pitch");
		NativeFieldInfoPtr_Hair_2_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_Yaw");
		NativeFieldInfoPtr_Hair_2_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_2_Roll");
		NativeFieldInfoPtr_Hair_3_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_X");
		NativeFieldInfoPtr_Hair_3_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_Y");
		NativeFieldInfoPtr_Hair_3_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_Z");
		NativeFieldInfoPtr_Hair_3_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_Pitch");
		NativeFieldInfoPtr_Hair_3_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_Yaw");
		NativeFieldInfoPtr_Hair_3_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_3_Roll");
		NativeFieldInfoPtr_Hair_4_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_X");
		NativeFieldInfoPtr_Hair_4_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_Y");
		NativeFieldInfoPtr_Hair_4_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_Z");
		NativeFieldInfoPtr_Hair_4_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_Pitch");
		NativeFieldInfoPtr_Hair_4_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_Yaw");
		NativeFieldInfoPtr_Hair_4_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_4_Roll");
		NativeFieldInfoPtr_Hair_5_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_X");
		NativeFieldInfoPtr_Hair_5_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_Y");
		NativeFieldInfoPtr_Hair_5_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_Z");
		NativeFieldInfoPtr_Hair_5_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_Pitch");
		NativeFieldInfoPtr_Hair_5_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_Yaw");
		NativeFieldInfoPtr_Hair_5_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_5_Roll");
		NativeFieldInfoPtr_Hair_6_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_X");
		NativeFieldInfoPtr_Hair_6_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_Y");
		NativeFieldInfoPtr_Hair_6_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_Z");
		NativeFieldInfoPtr_Hair_6_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_Pitch");
		NativeFieldInfoPtr_Hair_6_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_Yaw");
		NativeFieldInfoPtr_Hair_6_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, "Hair_6_Roll");
		NativeMethodInfoPtr_GetAccessoryData_Public_AccessoryData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr, 100663660);
	}

	[CallerCount(0)]
	public unsafe AccessoryData GetAccessoryData(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAccessoryData_Public_AccessoryData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AccessoryData*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AccessoryEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessoryEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AccessoryEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
