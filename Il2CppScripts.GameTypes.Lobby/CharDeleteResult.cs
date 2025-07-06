using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.GameTypes.Lobby;

[OriginalName("Assembly-Scripts.dll", "Scripts.GameTypes.Lobby", "CharDeleteResult")]
public enum CharDeleteResult
{
	OK = 0,
	REASON_YOU_MAY_NOT_DELETE_CLAN_MEMBER = 2,
	REASON_CLAN_LEADERS_MAY_NOT_BE_DELETED = 3
}
