using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.GameTypes.Skill;

[Serializable]
[OriginalName("Assembly-Scripts.dll", "Scripts.GameTypes.Skill", "SkillOperateType")]
public enum SkillOperateType
{
	Passive,
	Active,
	Toggle,
	Chance
}
