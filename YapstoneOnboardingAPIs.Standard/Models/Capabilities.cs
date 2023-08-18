// <copyright file="Capabilities.cs" company="APIMatic">
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
    /// Capabilities.
    /// </summary>
    public class Capabilities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities"/> class.
        /// </summary>
        public Capabilities()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities"/> class.
        /// </summary>
        /// <param name="granted">granted.</param>
        /// <param name="denied">denied.</param>
        public Capabilities(
            List<Models.Capability> granted = null,
            List<Models.DeniedCapability> denied = null)
        {
            this.Granted = granted;
            this.Denied = denied;
        }

        /// <summary>
        /// Gets or sets Granted.
        /// </summary>
        [JsonProperty("granted", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Capability> Granted { get; set; }

        /// <summary>
        /// Gets or sets Denied.
        /// </summary>
        [JsonProperty("denied", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeniedCapability> Denied { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Capabilities : ({string.Join(", ", toStringOutput)})";
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
            return obj is Capabilities other &&                ((this.Granted == null && other.Granted == null) || (this.Granted?.Equals(other.Granted) == true)) &&
                ((this.Denied == null && other.Denied == null) || (this.Denied?.Equals(other.Denied) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Granted = {(this.Granted == null ? "null" : $"[{string.Join(", ", this.Granted)} ]")}");
            toStringOutput.Add($"this.Denied = {(this.Denied == null ? "null" : $"[{string.Join(", ", this.Denied)} ]")}");
        }
    }
}