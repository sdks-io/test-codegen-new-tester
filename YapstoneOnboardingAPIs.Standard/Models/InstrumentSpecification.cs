// <copyright file="InstrumentSpecification.cs" company="APIMatic">
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
    /// InstrumentSpecification.
    /// </summary>
    public class InstrumentSpecification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentSpecification"/> class.
        /// </summary>
        public InstrumentSpecification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentSpecification"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="supportedCountries">supportedCountries.</param>
        /// <param name="supportedCurrencies">supportedCurrencies.</param>
        /// <param name="requiredFields">requiredFields.</param>
        /// <param name="details">details.</param>
        /// <param name="fingerprints">fingerprints.</param>
        public InstrumentSpecification(
            string name = null,
            string displayName = null,
            List<string> supportedCountries = null,
            List<string> supportedCurrencies = null,
            List<string> requiredFields = null,
            List<Models.FieldSpecification> details = null,
            List<Models.FingerprintSpecification> fingerprints = null)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.SupportedCountries = supportedCountries;
            this.SupportedCurrencies = supportedCurrencies;
            this.RequiredFields = requiredFields;
            this.Details = details;
            this.Fingerprints = fingerprints;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country codes.
        /// </summary>
        [JsonProperty("supportedCountries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedCountries { get; set; }

        /// <summary>
        /// Gets or sets SupportedCurrencies.
        /// </summary>
        [JsonProperty("supportedCurrencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedCurrencies { get; set; }

        /// <summary>
        /// Gets or sets RequiredFields.
        /// </summary>
        [JsonProperty("requiredFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequiredFields { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FieldSpecification> Details { get; set; }

        /// <summary>
        /// Gets or sets Fingerprints.
        /// </summary>
        [JsonProperty("fingerprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FingerprintSpecification> Fingerprints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstrumentSpecification : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstrumentSpecification other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.SupportedCountries == null && other.SupportedCountries == null) || (this.SupportedCountries?.Equals(other.SupportedCountries) == true)) &&
                ((this.SupportedCurrencies == null && other.SupportedCurrencies == null) || (this.SupportedCurrencies?.Equals(other.SupportedCurrencies) == true)) &&
                ((this.RequiredFields == null && other.RequiredFields == null) || (this.RequiredFields?.Equals(other.RequiredFields) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Fingerprints == null && other.Fingerprints == null) || (this.Fingerprints?.Equals(other.Fingerprints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.SupportedCountries = {(this.SupportedCountries == null ? "null" : $"[{string.Join(", ", this.SupportedCountries)} ]")}");
            toStringOutput.Add($"this.SupportedCurrencies = {(this.SupportedCurrencies == null ? "null" : $"[{string.Join(", ", this.SupportedCurrencies)} ]")}");
            toStringOutput.Add($"this.RequiredFields = {(this.RequiredFields == null ? "null" : $"[{string.Join(", ", this.RequiredFields)} ]")}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : $"[{string.Join(", ", this.Details)} ]")}");
            toStringOutput.Add($"this.Fingerprints = {(this.Fingerprints == null ? "null" : $"[{string.Join(", ", this.Fingerprints)} ]")}");
        }
    }
}