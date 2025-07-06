using Il2CppInterop.Common.Attributes;

namespace Il2CppScripts.Common;

[OriginalName("Assembly-Scripts.dll", "Scripts.Common", "EColorOperation")]
public enum EColorOperation
{
	CO_Use_Color_From_Material1,
	CO_Use_Color_From_Material2,
	CO_Multiply,
	CO_Add,
	CO_Subtract,
	CO_AlphaBlend_With_Mask,
	CO_Add_With_Mask_Modulation,
	CO_Use_Color_From_Mask
}
