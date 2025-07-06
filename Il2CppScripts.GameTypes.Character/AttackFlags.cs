using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.GameTypes.Character;

[OriginalName("Assembly-Scripts.dll", "Scripts.GameTypes.Character", "AttackFlags")]
[Flags]
public enum AttackFlags
{
	Miss = 0x80,
	Shield = 0x40,
	Crit = 0x20,
	Soulshot = 0x10
}
