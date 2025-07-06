using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.Services;

[OriginalName("Assembly-Scripts.dll", "Scripts.Services", "KeyMods")]
[Flags]
public enum KeyMods
{
	None = 0,
	Ctrl = 2,
	Alt = 4,
	Shift = 8
}
