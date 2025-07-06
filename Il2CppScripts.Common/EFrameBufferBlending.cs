using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.Common;

[OriginalName("Assembly-Scripts.dll", "Scripts.Common", "EFrameBufferBlending")]
public enum EFrameBufferBlending
{
	FB_Overwrite,
	FB_Modulate,
	FB_AlphaBlend,
	FB_AlphaModulate_MightNotFogCorrectly,
	FB_Translucent,
	FB_Darken,
	FB_Brighten,
	FB_Invisible,
	FB_ShadowBlend
}
