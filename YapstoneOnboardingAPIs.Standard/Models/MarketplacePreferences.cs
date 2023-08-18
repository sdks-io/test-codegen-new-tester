// <copyright file="MarketplacePreferences.cs" company="APIMatic">
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
    /// MarketplacePreferences.
    /// </summary>
    public class MarketplacePreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePreferences"/> class.
        /// </summary>
        public MarketplacePreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePreferences"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="cors">cors.</param>
        public MarketplacePreferences(
            Models.NetworkPreferences network = null,
            Models.WebhookPreferences webhook = null,
            Models.MarketplaceCORSPreferences cors = null)
        {
            this.Network = network;
            this.Webhook = webhook;
            this.Cors = cors;
        }

        /// <summary>
        /// Gets or sets Network.
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkPreferences Network { get; set; }

        /// <summary>
        /// Gets or sets Webhook.
        /// </summary>
        [JsonProperty("webhook", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookPreferences Webhook { get; set; }

        /// <summary>
        /// Gets or sets Cors.
        /// </summary>
        [JsonProperty("cors", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MarketplaceCORSPreferences Cors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MarketplacePreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is MarketplacePreferences other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true)) &&
                ((this.Cors == null && other.Cors == null) || (this.Cors?.Equals(other.Cors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook.ToString())}");
            toStringOutput.Add($"this.Cors = {(this.Cors == null ? "null" : this.Cors.ToString())}");
        }
    }
}