// <copyright file="CreateInstrumentRequest.cs" company="APIMatic">
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
    /// CreateInstrumentRequest.
    /// </summary>
    public class CreateInstrumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstrumentRequest"/> class.
        /// </summary>
        public CreateInstrumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInstrumentRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="currency">currency.</param>
        /// <param name="country">country.</param>
        /// <param name="namesOnAccount">namesOnAccount.</param>
        /// <param name="details">details.</param>
        /// <param name="correlationRefs">correlationRefs.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="options">options.</param>
        /// <param name="parent">parent.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="address">address.</param>
        public CreateInstrumentRequest(
            string type,
            string currency,
            string country,
            List<Models.NameOnAccount> namesOnAccount,
            object details,
            List<Models.CorrelationRef> correlationRefs = null,
            Dictionary<string, string> metadata = null,
            Models.InstrumentOptions options = null,
            Models.Parent parent = null,
            string displayName = null,
            Models.Address address = null)
        {
            this.CorrelationRefs = correlationRefs;
            this.Metadata = metadata;
            this.Options = options;
            this.Parent = parent;
            this.Type = type;
            this.Currency = currency;
            this.Country = country;
            this.DisplayName = displayName;
            this.NamesOnAccount = namesOnAccount;
            this.Address = address;
            this.Details = details;
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
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstrumentOptions Options { get; set; }

        /// <summary>
        /// Gets or sets Parent.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country code.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets NamesOnAccount.
        /// </summary>
        [JsonProperty("namesOnAccount")]
        public List<Models.NameOnAccount> NamesOnAccount { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details")]
        public object Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateInstrumentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateInstrumentRequest other &&                ((this.CorrelationRefs == null && other.CorrelationRefs == null) || (this.CorrelationRefs?.Equals(other.CorrelationRefs) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.NamesOnAccount == null && other.NamesOnAccount == null) || (this.NamesOnAccount?.Equals(other.NamesOnAccount) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CorrelationRefs = {(this.CorrelationRefs == null ? "null" : $"[{string.Join(", ", this.CorrelationRefs)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.NamesOnAccount = {(this.NamesOnAccount == null ? "null" : $"[{string.Join(", ", this.NamesOnAccount)} ]")}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
        }
    }
}