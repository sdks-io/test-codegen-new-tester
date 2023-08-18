// <copyright file="CustomerSpecification.cs" company="APIMatic">
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
    /// CustomerSpecification.
    /// </summary>
    public class CustomerSpecification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSpecification"/> class.
        /// </summary>
        public CustomerSpecification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSpecification"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="country">country.</param>
        /// <param name="commerceType">commerceType.</param>
        /// <param name="requiredFields">requiredFields.</param>
        /// <param name="additional">additional.</param>
        /// <param name="identityDocuments">identityDocuments.</param>
        public CustomerSpecification(
            Models.LegalEntityTypeEnum? type = null,
            string country = null,
            string commerceType = null,
            List<string> requiredFields = null,
            List<Models.FieldSpecification> additional = null,
            List<Models.RequiredIdentityDocuments> identityDocuments = null)
        {
            this.Type = type;
            this.Country = country;
            this.CommerceType = commerceType;
            this.RequiredFields = requiredFields;
            this.Additional = additional;
            this.IdentityDocuments = identityDocuments;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LegalEntityTypeEnum? Type { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 or alpha-3 country code.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets CommerceType.
        /// </summary>
        [JsonProperty("commerceType", NullValueHandling = NullValueHandling.Ignore)]
        public string CommerceType { get; set; }

        /// <summary>
        /// Gets or sets RequiredFields.
        /// </summary>
        [JsonProperty("requiredFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequiredFields { get; set; }

        /// <summary>
        /// Gets or sets Additional.
        /// </summary>
        [JsonProperty("additional", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FieldSpecification> Additional { get; set; }

        /// <summary>
        /// A list of required identity documents, each entity in the list should be considered as an OR condition. Only a single entry need be satisfied.
        /// </summary>
        [JsonProperty("identityDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RequiredIdentityDocuments> IdentityDocuments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerSpecification : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerSpecification other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CommerceType == null && other.CommerceType == null) || (this.CommerceType?.Equals(other.CommerceType) == true)) &&
                ((this.RequiredFields == null && other.RequiredFields == null) || (this.RequiredFields?.Equals(other.RequiredFields) == true)) &&
                ((this.Additional == null && other.Additional == null) || (this.Additional?.Equals(other.Additional) == true)) &&
                ((this.IdentityDocuments == null && other.IdentityDocuments == null) || (this.IdentityDocuments?.Equals(other.IdentityDocuments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CommerceType = {(this.CommerceType == null ? "null" : this.CommerceType)}");
            toStringOutput.Add($"this.RequiredFields = {(this.RequiredFields == null ? "null" : $"[{string.Join(", ", this.RequiredFields)} ]")}");
            toStringOutput.Add($"this.Additional = {(this.Additional == null ? "null" : $"[{string.Join(", ", this.Additional)} ]")}");
            toStringOutput.Add($"this.IdentityDocuments = {(this.IdentityDocuments == null ? "null" : $"[{string.Join(", ", this.IdentityDocuments)} ]")}");
        }
    }
}