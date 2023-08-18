// <copyright file="BusinessLegalEntity.cs" company="APIMatic">
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
    /// BusinessLegalEntity.
    /// </summary>
    public class BusinessLegalEntity : LegalEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntity"/> class.
        /// </summary>
        public BusinessLegalEntity()
        {
            this.Type = "BusinessLegalEntity";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntity"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="website">website.</param>
        /// <param name="socialNetworks">socialNetworks.</param>
        /// <param name="digitalCurrencyAddresses">digitalCurrencyAddresses.</param>
        /// <param name="identificationDocuments">identificationDocuments.</param>
        /// <param name="additional">additional.</param>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="businessType">businessType.</param>
        /// <param name="dba">dba.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="principalOwner">principalOwner.</param>
        /// <param name="additionalOwners">additionalOwners.</param>
        /// <param name="identityDocuments">identityDocuments.</param>
        /// <param name="registration">registration.</param>
        public BusinessLegalEntity(
            string type = "BusinessLegalEntity",
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            List<Models.IdentityDocument> identificationDocuments = null,
            object additional = null,
            object type = "BusinessLegalEntity",
            string name = null,
            Models.BusinessTypeEnum? businessType = null,
            List<string> dba = null,
            Models.IndividualLegalEntity primaryContact = null,
            Models.LegalEntity principalOwner = null,
            List<Models.LegalEntity> additionalOwners = null,
            List<Models.IdentityDocument> identityDocuments = null,
            Models.BusinessRegistration registration = null)
            : base(
                type,
                address,
                phone,
                email,
                website,
                socialNetworks,
                digitalCurrencyAddresses,
                identificationDocuments,
                additional)
        {
            this.Type = type;
            this.Name = name;
            this.BusinessType = businessType;
            this.Dba = dba;
            this.PrimaryContact = primaryContact;
            this.PrincipalOwner = principalOwner;
            this.AdditionalOwners = additionalOwners;
            this.IdentityDocuments = identityDocuments;
            this.Registration = registration;
        }

        /// <summary>
        /// This must always be supplied and contain the value "BUSINESS".
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public new object Type { get; set; }

        /// <summary>
        /// The business's legal name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets BusinessType.
        /// </summary>
        [JsonProperty("businessType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessTypeEnum? BusinessType { get; set; }

        /// <summary>
        /// Doing Busines As
        /// </summary>
        [JsonProperty("dba", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Dba { get; set; }

        /// <summary>
        /// Gets or sets PrimaryContact.
        /// </summary>
        [JsonProperty("primaryContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndividualLegalEntity PrimaryContact { get; set; }

        /// <summary>
        /// Gets or sets PrincipalOwner.
        /// </summary>
        [JsonProperty("principalOwner", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LegalEntity PrincipalOwner { get; set; }

        /// <summary>
        /// An array of any owners with at least 25% ownership of the company, excluding the principal owner responsible for the account.
        /// </summary>
        [JsonProperty("additionalOwners", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LegalEntity> AdditionalOwners { get; set; }

        /// <summary>
        /// Gets or sets IdentityDocuments.
        /// </summary>
        [JsonProperty("identityDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdentityDocument> IdentityDocuments { get; set; }

        /// <summary>
        /// Gets or sets Registration.
        /// </summary>
        [JsonProperty("registration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessRegistration Registration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BusinessLegalEntity : ({string.Join(", ", toStringOutput)})";
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
            return obj is BusinessLegalEntity other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.BusinessType == null && other.BusinessType == null) || (this.BusinessType?.Equals(other.BusinessType) == true)) &&
                ((this.Dba == null && other.Dba == null) || (this.Dba?.Equals(other.Dba) == true)) &&
                ((this.PrimaryContact == null && other.PrimaryContact == null) || (this.PrimaryContact?.Equals(other.PrimaryContact) == true)) &&
                ((this.PrincipalOwner == null && other.PrincipalOwner == null) || (this.PrincipalOwner?.Equals(other.PrincipalOwner) == true)) &&
                ((this.AdditionalOwners == null && other.AdditionalOwners == null) || (this.AdditionalOwners?.Equals(other.AdditionalOwners) == true)) &&
                ((this.IdentityDocuments == null && other.IdentityDocuments == null) || (this.IdentityDocuments?.Equals(other.IdentityDocuments) == true)) &&
                ((this.Registration == null && other.Registration == null) || (this.Registration?.Equals(other.Registration) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.BusinessType = {(this.BusinessType == null ? "null" : this.BusinessType.ToString())}");
            toStringOutput.Add($"this.Dba = {(this.Dba == null ? "null" : $"[{string.Join(", ", this.Dba)} ]")}");
            toStringOutput.Add($"this.PrimaryContact = {(this.PrimaryContact == null ? "null" : this.PrimaryContact.ToString())}");
            toStringOutput.Add($"this.PrincipalOwner = {(this.PrincipalOwner == null ? "null" : this.PrincipalOwner.ToString())}");
            toStringOutput.Add($"this.AdditionalOwners = {(this.AdditionalOwners == null ? "null" : $"[{string.Join(", ", this.AdditionalOwners)} ]")}");
            toStringOutput.Add($"this.IdentityDocuments = {(this.IdentityDocuments == null ? "null" : $"[{string.Join(", ", this.IdentityDocuments)} ]")}");
            toStringOutput.Add($"this.Registration = {(this.Registration == null ? "null" : this.Registration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}