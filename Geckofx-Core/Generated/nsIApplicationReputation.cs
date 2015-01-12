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
// Generated by IDLImporter from file nsIApplicationReputation.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// A service for asynchronously querying an application reputation service
    /// based on metadata of the downloaded file.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c12a510-eb1c-11e2-a98a-fa916188709b")]
	public interface nsIApplicationReputationService
	{
		
		/// <summary>
        /// Start querying the application reputation service.
        ///
        /// @param aQuery
        /// The nsIApplicationReputationQuery containing metadata of the
        /// downloaded file.
        ///
        /// @param aCallback
        /// The callback for receiving the results of the query.
        ///
        /// @remarks aCallback may not be null.  onComplete is guaranteed to be called
        /// on aCallback. This function may not be called more than once with
        /// the same query object. If any of the attributes of aQuery have
        /// not been set or have been set with empty data (with the exception
        /// of sourceURI), then a valid request can still be constructed and
        /// will solicit a valid response, but won't produce any useful
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void QueryReputation([MarshalAs(UnmanagedType.Interface)] nsIApplicationReputationQuery aQuery, [MarshalAs(UnmanagedType.Interface)] nsIApplicationReputationCallback aCallback);
	}
	
	/// <summary>
    /// A single-use, write-once interface for recording the metadata of the
    /// downloaded file. nsIApplicationReputationService.Start() may only be called
    /// once with a single query.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5a054991-e489-4a1c-a0aa-ea7c69b20e3d")]
	public interface nsIApplicationReputationQuery
	{
		
		/// <summary>
        /// The nsIURI from which the file was downloaded. This may not be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetSourceURIAttribute();
		
		/// <summary>
        /// The target filename for the downloaded file, as inferred from the source
        /// URI or provided by the Content-Disposition attachment file name. If this
        /// is not set by the caller, it will be passed as an empty string but the
        /// query won't produce any useful information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSuggestedFileNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSuggestedFileName);
		
		/// <summary>
        /// The size of the downloaded file in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFileSizeAttribute();
		
		/// <summary>
        /// The SHA256 hash of the downloaded file in raw bytes. If this is not set by
        /// the caller, it will be passed as an empty string but the query won't
        /// produce any useful information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSha256HashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSha256Hash);
	}
	
	/// <summary>nsIApplicationReputationCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9a228470-cfe5-11e2-8b8b-0800200c9a66")]
	public interface nsIApplicationReputationCallback
	{
		
		/// <summary>
        /// Callback for the result of the application reputation query.
        /// @param aStatus
        /// NS_OK if and only if the query succeeded. If it did, then
        /// shouldBlock is meaningful (otherwise it defaults to false). This
        /// may be NS_ERROR_FAILURE if the response cannot be parsed, or
        /// NS_ERROR_NOT_AVAILABLE if the service has been disabled or is not
        /// reachable.
        /// @param aShouldBlock
        /// Whether or not the download should be blocked.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnComplete([MarshalAs(UnmanagedType.U1)] bool aShouldBlock, int aStatus);
	}
}
