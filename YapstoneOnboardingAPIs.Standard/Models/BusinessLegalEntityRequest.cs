// <copyright file="BusinessLegalEntityRequest.cs" company="APIMatic">
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
    /// BusinessLegalEntityRequest.
    /// </summary>
    public class BusinessLegalEntityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntityRequest"/> class.
        /// </summary>
        public BusinessLegalEntityRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLegalEntityRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="website">website.</param>
        /// <param name="socialNetworks">socialNetworks.</param>
        /// <param name="digitalCurrencyAddresses">digitalCurrencyAddresses.</param>
        /// <param name="kyc">kyc.</param>
        /// <param name="name">name.</param>
        /// <param name="businessType">businessType.</param>
        /// <param name="dba">dba.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="principalOwner">principalOwner.</param>
        /// <param name="additionalOwners">additionalOwners.</param>
        /// <param name="identityDocuments">identityDocuments.</param>
        /// <param name="registration">registration.</param>
        public BusinessLegalEntityRequest(
            Models.LegalEntityType2Enum type,
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            object kyc = null,
            string name = null,
            Models.BusinessTypeEnum? businessType = null,
            List<string> dba = null,
            Models.IndividualLegalEntity primaryContact = null,
            Models.LegalEntity principalOwner = null,
            List<Models.LegalEntity> additionalOwners = null,
            List<Models.IdentityDocument> identityDocuments = null,
            Models.BusinessRegistration registration = null)
        {
            this.Type = type;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Website = website;
            this.SocialNetworks = socialNetworks;
            this.DigitalCurrencyAddresses = digitalCurrencyAddresses;
            this.Kyc = kyc;
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
        [JsonProperty("type")]
        public Models.LegalEntityType2Enum Type { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Phone Phone { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Website.
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets SocialNetworks.
        /// </summary>
        [JsonProperty("socialNetworks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SocialNetwork> SocialNetworks { get; set; }

        /// <summary>
        /// Gets or sets DigitalCurrencyAddresses.
        /// </summary>
        [JsonProperty("digitalCurrencyAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DigitalCurrencyAddresses { get; set; }

        /// <summary>
        /// Gets or sets Kyc.
        /// </summary>
        [JsonProperty("kyc", NullValueHandling = NullValueHandling.Ignore)]
        public object Kyc { get; set; }

        /// <summary>
        /// Gets or sets Name.
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

            return $"BusinessLegalEntityRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BusinessLegalEntityRequest other &&                this.Type.Equals(other.Type) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.SocialNetworks == null && other.SocialNetworks == null) || (this.SocialNetworks?.Equals(other.SocialNetworks) == true)) &&
                ((this.DigitalCurrencyAddresses == null && other.DigitalCurrencyAddresses == null) || (this.DigitalCurrencyAddresses?.Equals(other.DigitalCurrencyAddresses) == true)) &&
                ((this.Kyc == null && other.Kyc == null) || (this.Kyc?.Equals(other.Kyc) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.BusinessType == null && other.BusinessType == null) || (this.BusinessType?.Equals(other.BusinessType) == true)) &&
                ((this.Dba == null && other.Dba == null) || (this.Dba?.Equals(other.Dba) == true)) &&
                ((this.PrimaryContact == null && other.PrimaryContact == null) || (this.PrimaryContact?.Equals(other.PrimaryContact) == true)) &&
                ((this.PrincipalOwner == null && other.PrincipalOwner == null) || (this.PrincipalOwner?.Equals(other.PrincipalOwner) == true)) &&
                ((this.AdditionalOwners == null && other.AdditionalOwners == null) || (this.AdditionalOwners?.Equals(other.AdditionalOwners) == true)) &&
                ((this.IdentityDocuments == null && other.IdentityDocuments == null) || (this.IdentityDocuments?.Equals(other.IdentityDocuments) == true)) &&
                ((this.Registration == null && other.Registration == null) || (this.Registration?.Equals(other.Registration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Website = {(this.Website == null ? "null" : this.Website)}");
            toStringOutput.Add($"this.SocialNetworks = {(this.SocialNetworks == null ? "null" : $"[{string.Join(", ", this.SocialNetworks)} ]")}");
            toStringOutput.Add($"this.DigitalCurrencyAddresses = {(this.DigitalCurrencyAddresses == null ? "null" : $"[{string.Join(", ", this.DigitalCurrencyAddresses)} ]")}");
            toStringOutput.Add($"Kyc = {(this.Kyc == null ? "null" : this.Kyc.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.BusinessType = {(this.BusinessType == null ? "null" : this.BusinessType.ToString())}");
            toStringOutput.Add($"this.Dba = {(this.Dba == null ? "null" : $"[{string.Join(", ", this.Dba)} ]")}");
            toStringOutput.Add($"this.PrimaryContact = {(this.PrimaryContact == null ? "null" : this.PrimaryContact.ToString())}");
            toStringOutput.Add($"this.PrincipalOwner = {(this.PrincipalOwner == null ? "null" : this.PrincipalOwner.ToString())}");
            toStringOutput.Add($"this.AdditionalOwners = {(this.AdditionalOwners == null ? "null" : $"[{string.Join(", ", this.AdditionalOwners)} ]")}");
            toStringOutput.Add($"this.IdentityDocuments = {(this.IdentityDocuments == null ? "null" : $"[{string.Join(", ", this.IdentityDocuments)} ]")}");
            toStringOutput.Add($"this.Registration = {(this.Registration == null ? "null" : this.Registration.ToString())}");
        }
    }
}