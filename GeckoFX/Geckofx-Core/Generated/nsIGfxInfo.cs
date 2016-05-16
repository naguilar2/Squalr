// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIGfxInfo.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    /// <summary>
    ///NOTE: this interface is completely undesigned, not stable and likely to change </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1194ba76-aeb5-48df-abfd-844740ce3696")]
	public interface nsIGfxInfo
	{
		
		/// <summary>
        /// These are win32-specific
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetD2DEnabledAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDWriteEnabledAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDWriteVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDWriteVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCleartypeParametersAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCleartypeParameters);
		
		/// <summary>
        /// The name of the display adapter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDescriptionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDescription2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDescription2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriver);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriver2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriver2);
		
		/// <summary>
        ///These types are inspired by DXGI_ADAPTER_DESC </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterVendorIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterVendorID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterVendorID2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterVendorID2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDeviceIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDeviceID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDeviceID2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDeviceID2);
		
		/// <summary>
        /// The amount of RAM in MB in the display adapter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterRAMAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterRAM);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterRAM2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterRAM2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverVersionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverVersion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverVersion2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverVersion2);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverDateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverDate);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverDate2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAdapterDriverDate2);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsGPU2ActiveAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFailures(ref uint failureCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] failures);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogFailure([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase failure);
		
		/// <summary>
        /// Ask about a feature, and return the status of that feature
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFeatureStatus(int aFeature);
		
		/// <summary>
        /// Ask about a feature, return the minimum driver version required for it if its status is
        /// FEATURE_BLOCKED_DRIVER_VERSION, otherwise return an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFeatureSuggestedDriverVersion(int aFeature, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// WebGL info; valid params are "full-renderer", "vendor", "renderer", "version",
        /// "shading_language_version", "extensions".  These return info from
        /// underlying GL impl that's used to implement WebGL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWebGLParameter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aParam, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// only useful on X11
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetInfo(System.IntPtr jsContext);
	}
	
	/// <summary>nsIGfxInfoConsts </summary>
	public class nsIGfxInfoConsts
	{
		
		// <summary>
        //Whether Direct2D is supported for content rendering. </summary>
		public const long FEATURE_DIRECT2D = 1;
		
		// <summary>
        //Whether Direct3D 9 is supported for layers. </summary>
		public const long FEATURE_DIRECT3D_9_LAYERS = 2;
		
		// <summary>
        //Whether Direct3D 10.0 is supported for layers. </summary>
		public const long FEATURE_DIRECT3D_10_LAYERS = 3;
		
		// <summary>
        //Whether Direct3D 10.1 is supported for layers. </summary>
		public const long FEATURE_DIRECT3D_10_1_LAYERS = 4;
		
		// <summary>
        //Whether OpenGL is supported for layers </summary>
		public const long FEATURE_OPENGL_LAYERS = 5;
		
		// <summary>
        //Whether WebGL is supported via OpenGL. </summary>
		public const long FEATURE_WEBGL_OPENGL = 6;
		
		// <summary>
        //Whether WebGL is supported via ANGLE (D3D9 -- does not check for the presence of ANGLE libs). </summary>
		public const long FEATURE_WEBGL_ANGLE = 7;
		
		// <summary>
        //Whether WebGL antialiasing is supported. </summary>
		public const long FEATURE_WEBGL_MSAA = 8;
		
		// <summary>
        //Whether Stagefright is supported </summary>
		public const long FEATURE_STAGEFRIGHT = 9;
		
		// <summary>
        //Whether Webrtc Hardware acceleration is supported </summary>
		public const long FEATURE_WEBRTC_HW_ACCELERATION = 10;
		
		// <summary>
        //We don't explicitly block or discourage the feature. Which means we'll try getting it from the
        // hardware, and see what happens. </summary>
		public const long FEATURE_NO_INFO = 1;
		
		// <summary>
        //We don't know the status of the feature yet. The analysis probably hasn't finished yet. </summary>
		public const long FEATURE_STATUS_UNKNOWN = 2;
		
		// <summary>
        //This feature is blocked on this driver version. Updating driver will typically unblock it. </summary>
		public const long FEATURE_BLOCKED_DRIVER_VERSION = 3;
		
		// <summary>
        //This feature is blocked on this device, regardless of driver version.
        // Typically means we hit too many driver crashes without a good reason to hope for them to
        // get fixed soon. </summary>
		public const long FEATURE_BLOCKED_DEVICE = 4;
		
		// <summary>
        //This feature is available and can be used, but is not suggested (e.g. shouldn't be used by default </summary>
		public const long FEATURE_DISCOURAGED = 5;
		
		// <summary>
        //This feature is blocked on this OS version. </summary>
		public const long FEATURE_BLOCKED_OS_VERSION = 6;
	}
}
