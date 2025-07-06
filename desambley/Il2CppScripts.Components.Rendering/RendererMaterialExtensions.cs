using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScripts.Components.Rendering;

public static class RendererMaterialExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAdditiveColor_Public_Static_Void_Renderer_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBrightness_Public_Static_Void_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSharedMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSharedMaterial_Public_Static_Void_Renderer_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReplacementMaterial_Public_Static_Void_Renderer_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOverlayMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOverlayMaterial_Public_Static_Void_Renderer_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAlphaMaterials_Public_Static_Void_Renderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAlphaMaterials_Public_Static_Void_Renderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveMaterials_Public_Static_Void_Renderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterials_Public_Static_Void_Renderer_0;

	static RendererMaterialExtensions()
	{
		Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.Components.Rendering", "RendererMaterialExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669943);
		NativeMethodInfoPtr_SetAdditiveColor_Public_Static_Void_Renderer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669944);
		NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669945);
		NativeMethodInfoPtr_SetBrightness_Public_Static_Void_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669946);
		NativeMethodInfoPtr_SetSharedMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669947);
		NativeMethodInfoPtr_SetSharedMaterial_Public_Static_Void_Renderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669948);
		NativeMethodInfoPtr_SetReplacementMaterial_Public_Static_Void_Renderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669949);
		NativeMethodInfoPtr_SetOverlayMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669950);
		NativeMethodInfoPtr_SetOverlayMaterial_Public_Static_Void_Renderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669951);
		NativeMethodInfoPtr_CreateAlphaMaterials_Public_Static_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669952);
		NativeMethodInfoPtr_DestroyAlphaMaterials_Public_Static_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669953);
		NativeMethodInfoPtr_SaveMaterials_Public_Static_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669954);
		NativeMethodInfoPtr_RestoreMaterials_Public_Static_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererMaterialExtensions>.NativeClassPtr, 100669955);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67764, XrefRangeEnd = 67770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColor(this Renderer renderer, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67770, XrefRangeEnd = 67776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAdditiveColor(this Renderer renderer, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAdditiveColor_Public_Static_Void_Renderer_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67776, XrefRangeEnd = 67782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAlpha(this Renderer renderer, float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67782, XrefRangeEnd = 67800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBrightness(this Renderer renderer, float brightness)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &brightness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBrightness_Public_Static_Void_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 67809, RefRangeEnd = 67810, XrefRangeStart = 67800, XrefRangeEnd = 67809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSharedMaterials(this Renderer renderer, Il2CppReferenceArray<Material> materials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSharedMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 67836, RefRangeEnd = 67838, XrefRangeStart = 67810, XrefRangeEnd = 67836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSharedMaterial(this Renderer renderer, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSharedMaterial_Public_Static_Void_Renderer_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67838, XrefRangeEnd = 67847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReplacementMaterial(this Renderer renderer, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReplacementMaterial_Public_Static_Void_Renderer_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67847, XrefRangeEnd = 67856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOverlayMaterials(this Renderer renderer, Il2CppReferenceArray<Material> materials)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOverlayMaterials_Public_Static_Void_Renderer_Il2CppReferenceArray_1_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67856, XrefRangeEnd = 67882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOverlayMaterial(this Renderer renderer, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOverlayMaterial_Public_Static_Void_Renderer_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67882, XrefRangeEnd = 67891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateAlphaMaterials(this Renderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAlphaMaterials_Public_Static_Void_Renderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67891, XrefRangeEnd = 67900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyAlphaMaterials(this Renderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAlphaMaterials_Public_Static_Void_Renderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67900, XrefRangeEnd = 67909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveMaterials(this Renderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveMaterials_Public_Static_Void_Renderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 67918, RefRangeEnd = 67919, XrefRangeStart = 67909, XrefRangeEnd = 67918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestoreMaterials(this Renderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreMaterials_Public_Static_Void_Renderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RendererMaterialExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
