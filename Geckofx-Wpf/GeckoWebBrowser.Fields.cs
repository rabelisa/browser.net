﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interop;
using Gecko.Interop;

namespace Gecko
{
	partial class GeckoWebBrowser
	{
		#region nsIWebBrowser interface fields
		/// <summary>
		/// nsIWebBrowser instance
		/// </summary>
		private ComPtr<nsIWebBrowser> _webBrowser;

		/// <summary>
		/// nsIWebBrowser casted to nsIBaseWindow
		/// </summary>
		private nsIBaseWindow _baseWindow;

		/// <summary>
		/// nsIWebBrowser casted no nsIWebNavigation
		/// </summary>
		private nsIWebNavigation _webNav;

		private nsIWebBrowserFocus _webBrowserFocus;

        GeckoWindow _Window;
        GeckoDomDocument _Document;
		#endregion


		#region WPF fields
		private HwndSource _source;
		#endregion

        private uint _chromeFlags;
        
        /// <summary>
        /// Additional DOM message listeners
        /// </summary>
        Dictionary<string, Action<string>> _messageEventListeners = new Dictionary<string, Action<string>>();


		public IntPtr JSContext { get; protected set; }


        public nsIWebBrowserFocus WebBrowserFocus
        {
            get
            {
                return this._webBrowserFocus;
            }
        }
	}
}
