using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.GameTypes.Lobby;

[OriginalName("Assembly-Scripts.dll", "Scripts.GameTypes.Lobby", "CharCreateResult")]
public enum CharCreateResult
{
	REASON_CREATION_FAILED = 0,
	REASON_TOO_MANY_CHARACTERS = 1,
	REASON_NAME_ALREADY_EXISTS = 2,
	REASON_16_ENG_CHARS = 3,
	OK = 100
}
