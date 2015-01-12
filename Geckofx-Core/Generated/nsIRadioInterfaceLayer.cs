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
// Generated by IDLImporter from file nsIRadioInterfaceLayer.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6e0f45b8-410e-11e3-8c8e-b715b2cd0128")]
	public interface nsIRilNetworkInterface : nsINetworkInterface
	{
		
		/// <summary>
        /// Current network state, one of the NETWORK_STATE_* constants.
        ///
        /// When this changes, network interface implementations notify the
        /// 'network-interface-state-changed' observer notification.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStateAttribute();
		
		/// <summary>
        /// Network type. One of the NETWORK_TYPE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetTypeAttribute();
		
		/// <summary>
        /// Name of the network interface. This identifier is unique.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>
        /// IP Address
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIpAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIp);
		
		/// <summary>
        /// Netmask
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNetmaskAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetmask);
		
		/// <summary>
        /// Broadcast
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBroadcastAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBroadcast);
		
		/// <summary>
        /// Default gateway
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetGatewayAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGateway);
		
		/// <summary>
        /// Primary DNS address
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDns1Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDns1);
		
		/// <summary>
        /// Secondary DNS address
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDns2Attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDns2);
		
		/// <summary>
        /// The host name of the http proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHttpProxyHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpProxyHost);
		
		/// <summary>
        /// The port number of the http proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetHttpProxyPortAttribute();
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetServiceIdAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIccIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIccId);
		
		/// <summary>
        ///The following attributes are for MMS proxy settings. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMmscAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMmsc);
		
		/// <summary>
        /// Empty string if not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMmsProxyAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMmsProxy);
		
		/// <summary>
        /// Empty string if not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMmsPortAttribute();
	}
	
	/// <summary>
    /// -1 if not set.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1e602d20-d066-4399-8997-daf36b3158ef")]
	public interface nsIRILDataCallInfo
	{
		
		/// <summary>
        /// Current data call state, one of the
        /// nsINetworkInterface::NETWORK_STATE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetApnAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aApn);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIfnameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIfname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIpAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetmaskAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetmask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBroadcastAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBroadcast);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGwAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aGw);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetDnsAttribute();
	}
	
	/// <summary>nsIRILDataCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5bcac053-c245-46f0-bb45-d0039bfb89f5")]
	public interface nsIRILDataCallback
	{
		
		/// <summary>
        /// Notified when a data call changes state.
        ///
        /// @param dataCall
        /// A nsIRILDataCallInfo object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DataCallStateChanged([MarshalAs(UnmanagedType.Interface)] nsIRILDataCallInfo dataCall);
		
		/// <summary>
        /// Called when nsIRadioInterfaceLayer is asked to enumerate the current
        /// data call state.
        ///
        /// @param datacalls
        /// Array of nsIRILDataCallInfo objects.
        /// @param length
        /// Lenght of the aforementioned array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReceiveDataCallList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIRILDataCallInfo[] dataCalls, uint length);
	}
	
	/// <summary>nsIVoicemailInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c0c5cb9f-6372-4b5a-b74c-baacc2da5e4f")]
	public interface nsIVoicemailInfo
	{
		
		/// <summary>Member GetNumberAttribute </summary>
		/// <param name='aNumber'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNumber);
		
		/// <summary>Member GetDisplayNameAttribute </summary>
		/// <param name='aDisplayName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);
	}
	
	/// <summary>nsIRilContext </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("95e1be50-c912-11e2-8b8b-0800200c9a66")]
	public interface nsIRilContext
	{
		
		/// <summary>Member GetRadioStateAttribute </summary>
		/// <param name='aRadioState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRadioStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aRadioState);
		
		/// <summary>Member GetCardStateAttribute </summary>
		/// <param name='aCardState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCardStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCardState);
		
		/// <summary>Member GetRetryCountAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRetryCountAttribute();
		
		/// <summary>Member GetImsiAttribute </summary>
		/// <param name='aImsi'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImsiAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aImsi);
		
		/// <summary>Member GetNetworkSelectionModeAttribute </summary>
		/// <param name='aNetworkSelectionMode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetworkSelectionModeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNetworkSelectionMode);
		
		/// <summary>Member GetIccInfoAttribute </summary>
		/// <returns>A nsIDOMMozIccInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozIccInfo GetIccInfoAttribute();
		
		/// <summary>Member GetVoiceAttribute </summary>
		/// <returns>A nsIDOMMozMobileConnectionInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozMobileConnectionInfo GetVoiceAttribute();
		
		/// <summary>Member GetDataAttribute </summary>
		/// <returns>A nsIDOMMozMobileConnectionInfo</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozMobileConnectionInfo GetDataAttribute();
	}
	
	/// <summary>nsIRilSendWorkerMessageCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3bc96351-53b0-47a1-a888-c74c64b60f25")]
	public interface nsIRilSendWorkerMessageCallback
	{
		
		/// <summary>Member HandleResponse </summary>
		/// <param name='response'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleResponse(Gecko.JsVal response);
	}
	
	/// <summary>nsIRadioInterface </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5b14cf79-2846-4226-b07f-9b9977b525fe")]
	public interface nsIRadioInterface
	{
		
		/// <summary>Member GetRilContextAttribute </summary>
		/// <returns>A nsIRilContext</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRilContext GetRilContextAttribute();
		
		/// <summary>
        /// PDP APIs
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupDataCallByType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase apntype);
		
		/// <summary>Member DeactivateDataCallByType </summary>
		/// <param name='apntype'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeactivateDataCallByType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase apntype);
		
		/// <summary>Member GetDataCallStateByType </summary>
		/// <param name='apntype'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDataCallStateByType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase apntype);
		
		/// <summary>Member RegisterDataCallCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterDataCallCallback([MarshalAs(UnmanagedType.Interface)] nsIRILDataCallback callback);
		
		/// <summary>Member UnregisterDataCallCallback </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterDataCallCallback([MarshalAs(UnmanagedType.Interface)] nsIRILDataCallback callback);
		
		/// <summary>Member UpdateRILNetworkInterface </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateRILNetworkInterface();
		
		/// <summary>
        /// SMS-related functionality.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSegmentInfoForText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>Member SendSMS </summary>
		/// <param name='number'> </param>
		/// <param name='message'> </param>
		/// <param name='silent'> </param>
		/// <param name='request'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendSMS([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>Member SendWorkerMessage </summary>
		/// <param name='type'> </param>
		/// <param name='message'> </param>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendWorkerMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, Gecko.JsVal message, [MarshalAs(UnmanagedType.Interface)] nsIRilSendWorkerMessageCallback callback);
		
		/// <summary>Member GetSmscAddress </summary>
		/// <param name='request'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSmscAddress([MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
	}
	
	/// <summary>nsIRadioInterfaceLayer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("86a5c280-5641-11e3-949a-0800200c9a66")]
	public interface nsIRadioInterfaceLayer
	{
		
		/// <summary>Member GetNumRadioInterfacesAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumRadioInterfacesAttribute();
		
		/// <summary>Member GetRadioInterface </summary>
		/// <param name='clientId'> </param>
		/// <returns>A nsIRadioInterface</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRadioInterface GetRadioInterface(uint clientId);
		
		/// <summary>
        /// If not available, throws exception; otherwise, a valid number.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClientIdByIccId([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase iccId);
		
		/// <summary>Member SetMicrophoneMuted </summary>
		/// <param name='muted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMuted([MarshalAs(UnmanagedType.U1)] bool muted);
	}
}
