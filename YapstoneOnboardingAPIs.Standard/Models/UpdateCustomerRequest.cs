// <copyright file="UpdateCustomerRequest.cs" company="APIMatic">
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
    /// UpdateCustomerRequest.
    /// </summary>
    public class UpdateCustomerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        public UpdateCustomerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        /// <param name="country">country.</param>
        /// <param name="legalEntity">legalEntity.</param>
        /// <param name="correlationRefs">correlationRefs.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="defaultCurrency">defaultCurrency.</param>
        /// <param name="defaultLanguage">defaultLanguage.</param>
        /// <param name="options">options.</param>
        public UpdateCustomerRequest(
            string country,
            Models.LegalEntity legalEntity,
            List<Models.CorrelationRef> correlationRefs = null,
            Dictionary<string, string> metadata = null,
            string displayName = null,
            string timezone = null,
            string defaultCurrency = null,
            string defaultLanguage = null,
            Models.CustomerOptions options = null)
        {
            this.CorrelationRefs = correlationRefs;
            this.Metadata = metadata;
            this.DisplayName = displayName;
            this.Country = country;
            this.Timezone = timezone;
            this.DefaultCurrency = defaultCurrency;
            this.DefaultLanguage = defaultLanguage;
            this.LegalEntity = legalEntity;
            this.Options = options;
        }

        /// <summary>
        /// Gets or sets CorrelationRefs.
        /// </summary>
        [JsonProperty("correlationRefs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CorrelationRef> CorrelationRefs { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country code.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Timezone.
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets DefaultCurrency.
        /// </summary>
        [JsonProperty("defaultCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Gets or sets DefaultLanguage.
        /// </summary>
        [JsonProperty("defaultLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or sets LegalEntity.
        /// </summary>
        [JsonProperty("legalEntity")]
        public Models.LegalEntity LegalEntity { get; set; }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerOptions Options { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCustomerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateCustomerRequest other &&                ((this.CorrelationRefs == null && other.CorrelationRefs == null) || (this.CorrelationRefs?.Equals(other.CorrelationRefs) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Timezone == null && other.Timezone == null) || (this.Timezone?.Equals(other.Timezone) == true)) &&
                ((this.DefaultCurrency == null && other.DefaultCurrency == null) || (this.DefaultCurrency?.Equals(other.DefaultCurrency) == true)) &&
                ((this.DefaultLanguage == null && other.DefaultLanguage == null) || (this.DefaultLanguage?.Equals(other.DefaultLanguage) == true)) &&
                ((this.LegalEntity == null && other.LegalEntity == null) || (this.LegalEntity?.Equals(other.LegalEntity) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CorrelationRefs = {(this.CorrelationRefs == null ? "null" : $"[{string.Join(", ", this.CorrelationRefs)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Timezone = {(this.Timezone == null ? "null" : this.Timezone)}");
            toStringOutput.Add($"this.DefaultCurrency = {(this.DefaultCurrency == null ? "null" : this.DefaultCurrency)}");
            toStringOutput.Add($"this.DefaultLanguage = {(this.DefaultLanguage == null ? "null" : this.DefaultLanguage)}");
            toStringOutput.Add($"this.LegalEntity = {(this.LegalEntity == null ? "null" : this.LegalEntity.ToString())}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
        }
    }
}