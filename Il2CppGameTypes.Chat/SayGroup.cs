using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppGameTypes.Chat;

[Serializable]
[OriginalName("Assembly-Scripts.dll", "GameTypes.Chat", "SayGroup")]
public enum SayGroup
{
	All,
	Shout,
	Tell,
	Party,
	Clan,
	Trade,
	Alliance,
	Announcement,
	HeroVoice
}
