using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Services
{
    public class TradeStationService
    {
        // API credentials in Staging or SIM.
        public const string ClientID = "D364DF9D-B61F-4694-B950-07A2ADE5671E";
        public const string Secret = "515382EF-9A64-41A3-8169-A167700E0201";

        // Use your existing TradeStation logon for the respective environments.
        public const string Login = "Sometaro1";
        public const string Password = "poweruser";

        /// <summary>
        /// Obtaining authorization to access controlled resources
        /// Method: POST
        /// Path: /Security/Authorize
        /// URI Parameters: none
        /// Authentication: Client authorization only.
        /// Returns: AccessTokenResponse Object
        /// </summary>
        public AccessTokenResponse Authorize()
        {
            return null;
        }
    }
}