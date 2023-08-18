// <copyright file="CORSPreferences.cs" company="APIMatic">
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
    /// CORSPreferences.
    /// </summary>
    public class CORSPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CORSPreferences"/> class.
        /// </summary>
        public CORSPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CORSPreferences"/> class.
        /// </summary>
        /// <param name="allowedOrigins">allowedOrigins.</param>
        public CORSPreferences(
            List<string> allowedOrigins = null)
        {
            this.AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// Gets or sets AllowedOrigins.
        /// </summary>
        [JsonProperty("allowedOrigins", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedOrigins { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CORSPreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is CORSPreferences other &&                ((this.AllowedOrigins == null && other.AllowedOrigins == null) || (this.AllowedOrigins?.Equals(other.AllowedOrigins) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllowedOrigins = {(this.AllowedOrigins == null ? "null" : $"[{string.Join(", ", this.AllowedOrigins)} ]")}");
        }
    }
}