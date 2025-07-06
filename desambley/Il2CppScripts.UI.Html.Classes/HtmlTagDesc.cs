using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScripts.UI.Html.Tags;
using Il2CppSystem;

namespace Il2CppScripts.UI.Html.Classes;

[System.Serializable]
public class HtmlTagDesc : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsText;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ignore;

	private static readonly System.IntPtr NativeFieldInfoPtr_DontSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr_Element;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string Tag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool IsOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOpen)) = flag;
		}
	}

	public unsafe bool IsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsText)) = flag;
		}
	}

	public unsafe bool HasBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasBody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasBody)) = flag;
		}
	}

	public unsafe bool Ignore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ignore);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ignore)) = flag;
		}
	}

	public unsafe bool DontSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontSpawn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontSpawn)) = flag;
		}
	}

	public unsafe HtmlElement Element
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Element);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HtmlElement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Element)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)htmlElement));
		}
	}

	static HtmlTagDesc()
	{
		Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-Scripts.dll", "Scripts.UI.Html.Classes", "HtmlTagDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr);
		NativeFieldInfoPtr_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "Tag");
		NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "IsOpen");
		NativeFieldInfoPtr_IsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "IsText");
		NativeFieldInfoPtr_HasBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "HasBody");
		NativeFieldInfoPtr_Ignore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "Ignore");
		NativeFieldInfoPtr_DontSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "DontSpawn");
		NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, "Element");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr, 100666027);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 11, RefRangeEnd = 28, XrefRangeStart = 11, XrefRangeEnd = 28, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HtmlTagDesc()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlTagDesc>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HtmlTagDesc(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
