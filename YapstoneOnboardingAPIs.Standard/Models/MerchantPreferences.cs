// <copyright file="MerchantPreferences.cs" company="APIMatic">
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
    /// MerchantPreferences.
    /// </summary>
    public class MerchantPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantPreferences"/> class.
        /// </summary>
        public MerchantPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantPreferences"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        public MerchantPreferences(
            Models.NetworkPreferences network = null)
        {
            this.Network = network;
        }

        /// <summary>
        /// Gets or sets Network.
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkPreferences Network { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MerchantPreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is MerchantPreferences other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
        }
    }
}