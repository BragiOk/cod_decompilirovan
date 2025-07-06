using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.Common;

[OriginalName("Assembly-Scripts.dll", "Scripts.Common", "AttachMethod")]
public enum AttachMethod
{
	None = 0,
	Trail = 1,
	Origin = 8,
	LeftHand = 2,
	RightHand = 3,
	AliasSpecified = 4,
	BoneSpecified = 5,
	Location = 6,
	Cubic = 7
}
