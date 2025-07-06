using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.GameTypes;

[OriginalName("Assembly-Scripts.dll", "Scripts.GameTypes", "RespawnFlags")]
[Flags]
public enum RespawnFlags
{
	ToVillage = 0,
	ToClanHall = 2,
	ToCastle = 2,
	ToFlag = 3,
	Sweepable = 4,
	FixedRes = 5
}
