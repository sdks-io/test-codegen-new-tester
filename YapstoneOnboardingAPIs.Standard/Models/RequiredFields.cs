// <copyright file="RequiredFields.cs" company="APIMatic">
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
    /// RequiredFields.
    /// </summary>
    public class RequiredFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredFields"/> class.
        /// </summary>
        public RequiredFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredFields"/> class.
        /// </summary>
        /// <param name="merchant">merchant.</param>
        /// <param name="instrument">instrument.</param>
        /// <param name="customer">customer.</param>
        /// <param name="property">property.</param>
        public RequiredFields(
            Models.CountrySpecificationRequiredFields merchant = null,
            Models.CountrySpecificationRequiredFields instrument = null,
            Models.CountrySpecificationRequiredFields customer = null,
            Models.CountrySpecificationRequiredFields property = null)
        {
            this.Merchant = merchant;
            this.Instrument = instrument;
            this.Customer = customer;
            this.Property = property;
        }

        /// <summary>
        /// Gets or sets Merchant.
        /// </summary>
        [JsonProperty("merchant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CountrySpecificationRequiredFields Merchant { get; set; }

        /// <summary>
        /// Gets or sets Instrument.
        /// </summary>
        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CountrySpecificationRequiredFields Instrument { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CountrySpecificationRequiredFields Customer { get; set; }

        /// <summary>
        /// Gets or sets Property.
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CountrySpecificationRequiredFields Property { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequiredFields : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequiredFields other &&                ((this.Merchant == null && other.Merchant == null) || (this.Merchant?.Equals(other.Merchant) == true)) &&
                ((this.Instrument == null && other.Instrument == null) || (this.Instrument?.Equals(other.Instrument) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Property == null && other.Property == null) || (this.Property?.Equals(other.Property) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Merchant = {(this.Merchant == null ? "null" : this.Merchant.ToString())}");
            toStringOutput.Add($"this.Instrument = {(this.Instrument == null ? "null" : this.Instrument.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Property = {(this.Property == null ? "null" : this.Property.ToString())}");
        }
    }
}