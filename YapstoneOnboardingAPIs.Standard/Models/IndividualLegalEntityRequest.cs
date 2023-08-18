// <copyright file="IndividualLegalEntityRequest.cs" company="APIMatic">
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
    /// IndividualLegalEntityRequest.
    /// </summary>
    public class IndividualLegalEntityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualLegalEntityRequest"/> class.
        /// </summary>
        public IndividualLegalEntityRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualLegalEntityRequest"/> class.
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
        /// <param name="gender">gender.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="countryOfBirth">countryOfBirth.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="identificationDocuments">identificationDocuments.</param>
        public IndividualLegalEntityRequest(
            Models.LegalEntityType1Enum type,
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            object kyc = null,
            Models.IndividualName name = null,
            Models.GenderEnum? gender = null,
            DateTime? dateOfBirth = null,
            string countryOfBirth = null,
            string nationality = null,
            List<Models.IdentityDocument> identificationDocuments = null)
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
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.CountryOfBirth = countryOfBirth;
            this.Nationality = nationality;
            this.IdentificationDocuments = identificationDocuments;
        }

        /// <summary>
        /// This must always be supplied and contain the value "INDIVIDUAL".
        /// </summary>
        [JsonProperty("type")]
        public Models.LegalEntityType1Enum Type { get; set; }

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
        public Models.IndividualName Name { get; set; }

        /// <summary>
        /// Gets or sets Gender.
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenderEnum? Gender { get; set; }

        /// <summary>
        /// Gets or sets DateOfBirth.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets CountryOfBirth.
        /// </summary>
        [JsonProperty("countryOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// Gets or sets Nationality.
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets IdentificationDocuments.
        /// </summary>
        [JsonProperty("identificationDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdentityDocument> IdentificationDocuments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndividualLegalEntityRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is IndividualLegalEntityRequest other &&                this.Type.Equals(other.Type) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.SocialNetworks == null && other.SocialNetworks == null) || (this.SocialNetworks?.Equals(other.SocialNetworks) == true)) &&
                ((this.DigitalCurrencyAddresses == null && other.DigitalCurrencyAddresses == null) || (this.DigitalCurrencyAddresses?.Equals(other.DigitalCurrencyAddresses) == true)) &&
                ((this.Kyc == null && other.Kyc == null) || (this.Kyc?.Equals(other.Kyc) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Gender == null && other.Gender == null) || (this.Gender?.Equals(other.Gender) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.CountryOfBirth == null && other.CountryOfBirth == null) || (this.CountryOfBirth?.Equals(other.CountryOfBirth) == true)) &&
                ((this.Nationality == null && other.Nationality == null) || (this.Nationality?.Equals(other.Nationality) == true)) &&
                ((this.IdentificationDocuments == null && other.IdentificationDocuments == null) || (this.IdentificationDocuments?.Equals(other.IdentificationDocuments) == true));
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Gender = {(this.Gender == null ? "null" : this.Gender.ToString())}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.CountryOfBirth = {(this.CountryOfBirth == null ? "null" : this.CountryOfBirth)}");
            toStringOutput.Add($"this.Nationality = {(this.Nationality == null ? "null" : this.Nationality)}");
            toStringOutput.Add($"this.IdentificationDocuments = {(this.IdentificationDocuments == null ? "null" : $"[{string.Join(", ", this.IdentificationDocuments)} ]")}");
        }
    }
}