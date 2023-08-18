// <copyright file="PropertyRateDetails.cs" company="APIMatic">
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
    /// PropertyRateDetails.
    /// </summary>
    public class PropertyRateDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRateDetails"/> class.
        /// </summary>
        public PropertyRateDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRateDetails"/> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        /// <param name="cleaningFee">cleaningFee.</param>
        /// <param name="sameDayChargeAllowed">sameDayChargeAllowed.</param>
        /// <param name="autoPricing">autoPricing.</param>
        /// <param name="rentingFrequency">rentingFrequency.</param>
        /// <param name="paymentTerms">paymentTerms.</param>
        public PropertyRateDetails(
            Models.Money min = null,
            Models.Money max = null,
            Models.Money cleaningFee = null,
            bool? sameDayChargeAllowed = null,
            bool? autoPricing = null,
            Models.RentingFrequencyEnum? rentingFrequency = null,
            Models.PaymentTermsEnum? paymentTerms = null)
        {
            this.Min = min;
            this.Max = max;
            this.CleaningFee = cleaningFee;
            this.SameDayChargeAllowed = sameDayChargeAllowed;
            this.AutoPricing = autoPricing;
            this.RentingFrequency = rentingFrequency;
            this.PaymentTerms = paymentTerms;
        }

        /// <summary>
        /// Gets or sets Min.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Min { get; set; }

        /// <summary>
        /// Gets or sets Max.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money Max { get; set; }

        /// <summary>
        /// Gets or sets CleaningFee.
        /// </summary>
        [JsonProperty("cleaningFee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money CleaningFee { get; set; }

        /// <summary>
        /// Gets or sets SameDayChargeAllowed.
        /// </summary>
        [JsonProperty("sameDayChargeAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SameDayChargeAllowed { get; set; }

        /// <summary>
        /// Gets or sets AutoPricing.
        /// </summary>
        [JsonProperty("autoPricing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPricing { get; set; }

        /// <summary>
        /// Gets or sets RentingFrequency.
        /// </summary>
        [JsonProperty("rentingFrequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RentingFrequencyEnum? RentingFrequency { get; set; }

        /// <summary>
        /// Gets or sets PaymentTerms.
        /// </summary>
        [JsonProperty("paymentTerms", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentTermsEnum? PaymentTerms { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyRateDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyRateDetails other &&                ((this.Min == null && other.Min == null) || (this.Min?.Equals(other.Min) == true)) &&
                ((this.Max == null && other.Max == null) || (this.Max?.Equals(other.Max) == true)) &&
                ((this.CleaningFee == null && other.CleaningFee == null) || (this.CleaningFee?.Equals(other.CleaningFee) == true)) &&
                ((this.SameDayChargeAllowed == null && other.SameDayChargeAllowed == null) || (this.SameDayChargeAllowed?.Equals(other.SameDayChargeAllowed) == true)) &&
                ((this.AutoPricing == null && other.AutoPricing == null) || (this.AutoPricing?.Equals(other.AutoPricing) == true)) &&
                ((this.RentingFrequency == null && other.RentingFrequency == null) || (this.RentingFrequency?.Equals(other.RentingFrequency) == true)) &&
                ((this.PaymentTerms == null && other.PaymentTerms == null) || (this.PaymentTerms?.Equals(other.PaymentTerms) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Min = {(this.Min == null ? "null" : this.Min.ToString())}");
            toStringOutput.Add($"this.Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"this.CleaningFee = {(this.CleaningFee == null ? "null" : this.CleaningFee.ToString())}");
            toStringOutput.Add($"this.SameDayChargeAllowed = {(this.SameDayChargeAllowed == null ? "null" : this.SameDayChargeAllowed.ToString())}");
            toStringOutput.Add($"this.AutoPricing = {(this.AutoPricing == null ? "null" : this.AutoPricing.ToString())}");
            toStringOutput.Add($"this.RentingFrequency = {(this.RentingFrequency == null ? "null" : this.RentingFrequency.ToString())}");
            toStringOutput.Add($"this.PaymentTerms = {(this.PaymentTerms == null ? "null" : this.PaymentTerms.ToString())}");
        }
    }
}