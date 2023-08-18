// <copyright file="WebhookAuthenticationPreference.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YapstoneOnboardingAPIs.Standard;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// WebhookAuthenticationPreference.
    /// </summary>
    public class WebhookAuthenticationPreference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationPreference"/> class.
        /// </summary>
        public WebhookAuthenticationPreference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAuthenticationPreference"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="mValue">value.</param>
        public WebhookAuthenticationPreference(
            Models.Type2Enum? type = null,
            string mValue = null)
        {
            this.Type = type;
            this.MValue = mValue;
        }

        /// <summary>
        /// The authentication mechanism to use when making webhook callbacks to client URLs.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type2Enum? Type { get; set; }

        /// <summary>
        /// For a type of AUTHORIZATION_HEADER this value should contain what will be placed into the Authorization header, for each webhook callback. When reading back this preference from a response this value field will contain a masked version of the originally supplied value.
        /// For a type of TLS_CLIENT_AUTHENTICATION this value should be left empty, and the server side will populate here the Public Key half in PEM format. This Public Key should then be used by the webhook implementation to authenticate the caller.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WebhookAuthenticationPreference : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is WebhookAuthenticationPreference other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}