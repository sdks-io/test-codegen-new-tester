// <copyright file="CountrySpecification.cs" company="APIMatic">
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
    /// CountrySpecification.
    /// </summary>
    public class CountrySpecification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySpecification"/> class.
        /// </summary>
        public CountrySpecification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySpecification"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="defaultCurrency">defaultCurrency.</param>
        /// <param name="supportedInstrumentTypes">supportedInstrumentTypes.</param>
        /// <param name="supportedInstrumentCurrencies">supportedInstrumentCurrencies.</param>
        /// <param name="supportedCapabilities">supportedCapabilities.</param>
        /// <param name="requiredFields">requiredFields.</param>
        public CountrySpecification(
            string id = null,
            string defaultCurrency = null,
            List<string> supportedInstrumentTypes = null,
            List<string> supportedInstrumentCurrencies = null,
            List<Models.CapabilityTypeEnum> supportedCapabilities = null,
            Models.RequiredFields requiredFields = null)
        {
            this.Id = id;
            this.DefaultCurrency = defaultCurrency;
            this.SupportedInstrumentTypes = supportedInstrumentTypes;
            this.SupportedInstrumentCurrencies = supportedInstrumentCurrencies;
            this.SupportedCapabilities = supportedCapabilities;
            this.RequiredFields = requiredFields;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets DefaultCurrency.
        /// </summary>
        [JsonProperty("defaultCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Gets or sets SupportedInstrumentTypes.
        /// </summary>
        [JsonProperty("supportedInstrumentTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedInstrumentTypes { get; set; }

        /// <summary>
        /// Gets or sets SupportedInstrumentCurrencies.
        /// </summary>
        [JsonProperty("supportedInstrumentCurrencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedInstrumentCurrencies { get; set; }

        /// <summary>
        /// Gets or sets SupportedCapabilities.
        /// </summary>
        [JsonProperty("supportedCapabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CapabilityTypeEnum> SupportedCapabilities { get; set; }

        /// <summary>
        /// Gets or sets RequiredFields.
        /// </summary>
        [JsonProperty("requiredFields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RequiredFields RequiredFields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CountrySpecification : ({string.Join(", ", toStringOutput)})";
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
            return obj is CountrySpecification other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.DefaultCurrency == null && other.DefaultCurrency == null) || (this.DefaultCurrency?.Equals(other.DefaultCurrency) == true)) &&
                ((this.SupportedInstrumentTypes == null && other.SupportedInstrumentTypes == null) || (this.SupportedInstrumentTypes?.Equals(other.SupportedInstrumentTypes) == true)) &&
                ((this.SupportedInstrumentCurrencies == null && other.SupportedInstrumentCurrencies == null) || (this.SupportedInstrumentCurrencies?.Equals(other.SupportedInstrumentCurrencies) == true)) &&
                ((this.SupportedCapabilities == null && other.SupportedCapabilities == null) || (this.SupportedCapabilities?.Equals(other.SupportedCapabilities) == true)) &&
                ((this.RequiredFields == null && other.RequiredFields == null) || (this.RequiredFields?.Equals(other.RequiredFields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.DefaultCurrency = {(this.DefaultCurrency == null ? "null" : this.DefaultCurrency)}");
            toStringOutput.Add($"this.SupportedInstrumentTypes = {(this.SupportedInstrumentTypes == null ? "null" : $"[{string.Join(", ", this.SupportedInstrumentTypes)} ]")}");
            toStringOutput.Add($"this.SupportedInstrumentCurrencies = {(this.SupportedInstrumentCurrencies == null ? "null" : $"[{string.Join(", ", this.SupportedInstrumentCurrencies)} ]")}");
            toStringOutput.Add($"this.SupportedCapabilities = {(this.SupportedCapabilities == null ? "null" : $"[{string.Join(", ", this.SupportedCapabilities)} ]")}");
            toStringOutput.Add($"this.RequiredFields = {(this.RequiredFields == null ? "null" : this.RequiredFields.ToString())}");
        }
    }
}