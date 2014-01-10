using System;
using System.Runtime.Serialization;

namespace Custom.Services
{
    [DataContract]
    public class AccessTokenResponse
    {
        /// <summary>
        /// Number of seconds token will expire in
        /// </summary>
        [DataMember(Name="expires_in")]
        public int expires_in { get; set; }

        /// <summary>
        /// Access Token
        /// </summary>
        [DataMember(Name = "token")]
        public string token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "token_type")]
        public string token_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "userid")]
        public string userid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "refresh_token")]
        public string refresh_token { get; set; }
    }
}