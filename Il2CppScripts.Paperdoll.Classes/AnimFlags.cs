using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.Paperdoll.Classes;

[OriginalName("Assembly-Scripts.dll", "Scripts.Paperdoll.Classes", "AnimFlags")]
[Flags]
public enum AnimFlags
{
	Stance = 1,
	Indexed = 2,
	FreezeFrame = 4,
	HideWeapon = 8,
	AlwaysUpdate = 0x10
}
