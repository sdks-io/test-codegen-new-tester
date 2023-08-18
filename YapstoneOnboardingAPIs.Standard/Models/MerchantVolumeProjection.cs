// <copyright file="MerchantVolumeProjection.cs" company="APIMatic">
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
    /// MerchantVolumeProjection.
    /// </summary>
    public class MerchantVolumeProjection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantVolumeProjection"/> class.
        /// </summary>
        public MerchantVolumeProjection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantVolumeProjection"/> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="amount">amount.</param>
        public MerchantVolumeProjection(
            Models.PeriodEnum period,
            Models.Money amount)
        {
            this.Period = period;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty("period")]
        public Models.PeriodEnum Period { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Money Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MerchantVolumeProjection : ({string.Join(", ", toStringOutput)})";
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
            return obj is MerchantVolumeProjection other &&                this.Period.Equals(other.Period) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Period = {this.Period}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}