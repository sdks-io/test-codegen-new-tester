// <copyright file="Customer.cs" company="APIMatic">
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
    /// Customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="correlationRefs">correlationRefs.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="parent">parent.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="country">country.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="defaultCurrency">defaultCurrency.</param>
        /// <param name="defaultLanguage">defaultLanguage.</param>
        /// <param name="legalEntity">legalEntity.</param>
        /// <param name="status">status.</param>
        public Customer(
            string id = null,
            DateTime? created = null,
            DateTime? updated = null,
            List<Models.CorrelationRef> correlationRefs = null,
            Dictionary<string, string> metadata = null,
            Models.Parent parent = null,
            string displayName = null,
            string country = null,
            string timezone = null,
            string defaultCurrency = null,
            string defaultLanguage = null,
            Models.LegalEntity legalEntity = null,
            Models.CustomerStatus status = null)
        {
            this.Id = id;
            this.Created = created;
            this.Updated = updated;
            this.CorrelationRefs = correlationRefs;
            this.Metadata = metadata;
            this.Parent = parent;
            this.DisplayName = displayName;
            this.Country = country;
            this.Timezone = timezone;
            this.DefaultCurrency = defaultCurrency;
            this.DefaultLanguage = defaultLanguage;
            this.LegalEntity = legalEntity;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets Updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

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
        /// Gets or sets Parent.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country code.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("legalEntity", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LegalEntity LegalEntity { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerStatus Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Customer : ({string.Join(", ", toStringOutput)})";
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
            return obj is Customer other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Created == null && other.Created == null) || (this.Created?.Equals(other.Created) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.CorrelationRefs == null && other.CorrelationRefs == null) || (this.CorrelationRefs?.Equals(other.CorrelationRefs) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Timezone == null && other.Timezone == null) || (this.Timezone?.Equals(other.Timezone) == true)) &&
                ((this.DefaultCurrency == null && other.DefaultCurrency == null) || (this.DefaultCurrency?.Equals(other.DefaultCurrency) == true)) &&
                ((this.DefaultLanguage == null && other.DefaultLanguage == null) || (this.DefaultLanguage?.Equals(other.DefaultLanguage) == true)) &&
                ((this.LegalEntity == null && other.LegalEntity == null) || (this.LegalEntity?.Equals(other.LegalEntity) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated.ToString())}");
            toStringOutput.Add($"this.CorrelationRefs = {(this.CorrelationRefs == null ? "null" : $"[{string.Join(", ", this.CorrelationRefs)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Timezone = {(this.Timezone == null ? "null" : this.Timezone)}");
            toStringOutput.Add($"this.DefaultCurrency = {(this.DefaultCurrency == null ? "null" : this.DefaultCurrency)}");
            toStringOutput.Add($"this.DefaultLanguage = {(this.DefaultLanguage == null ? "null" : this.DefaultLanguage)}");
            toStringOutput.Add($"this.LegalEntity = {(this.LegalEntity == null ? "null" : this.LegalEntity.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}