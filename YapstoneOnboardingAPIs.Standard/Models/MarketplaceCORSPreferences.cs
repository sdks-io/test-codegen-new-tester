// <copyright file="MarketplaceCORSPreferences.cs" company="APIMatic">
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
    /// MarketplaceCORSPreferences.
    /// </summary>
    public class MarketplaceCORSPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceCORSPreferences"/> class.
        /// </summary>
        public MarketplaceCORSPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceCORSPreferences"/> class.
        /// </summary>
        /// <param name="onboarding">onboarding.</param>
        public MarketplaceCORSPreferences(
            Models.CORSPreferences onboarding = null)
        {
            this.Onboarding = onboarding;
        }

        /// <summary>
        /// Gets or sets Onboarding.
        /// </summary>
        [JsonProperty("onboarding", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CORSPreferences Onboarding { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MarketplaceCORSPreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is MarketplaceCORSPreferences other &&                ((this.Onboarding == null && other.Onboarding == null) || (this.Onboarding?.Equals(other.Onboarding) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Onboarding = {(this.Onboarding == null ? "null" : this.Onboarding.ToString())}");
        }
    }
}