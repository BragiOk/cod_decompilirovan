using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScripts.GameTypes;

[System.Serializable]
public sealed class MacroCommand : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShortcutId;

	public unsafe MacroCommandType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(MacroCommandType*)num;
		}
		set
		{
			*(MacroCommandType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = macroCommandType;
		}
	}

	public unsafe int SkillId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillId)) = num;
		}
	}

	public unsafe string Cmd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cmd);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cmd)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int ShortcutRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutRow)) = num;
		}
	}

	public unsafe int ShortcutId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShortcutId)) = num;
		}
	}

	static MacroCommand()
	{
		Il2CppClassPointerStore<MacroCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.GameTypes", "MacroCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_SkillId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr, "SkillId");
		NativeFieldInfoPtr_Cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr, "Cmd");
		NativeFieldInfoPtr_ShortcutRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr, "ShortcutRow");
		NativeFieldInfoPtr_ShortcutId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr, "ShortcutId");
	}

	public MacroCommand(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MacroCommand()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MacroCommand>.NativeClassPtr))
	{
	}
}
