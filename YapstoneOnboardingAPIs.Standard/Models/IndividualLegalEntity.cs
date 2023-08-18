// <copyright file="IndividualLegalEntity.cs" company="APIMatic">
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
    /// IndividualLegalEntity.
    /// </summary>
    public class IndividualLegalEntity : LegalEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualLegalEntity"/> class.
        /// </summary>
        public IndividualLegalEntity()
        {
            this.Type = "IndividualLegalEntity";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualLegalEntity"/> class.
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
        /// <param name="gender">gender.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="countryOfBirth">countryOfBirth.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="identificationDocuments">identificationDocuments.</param>
        public IndividualLegalEntity(
            string type = "IndividualLegalEntity",
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            List<Models.IdentityDocument> identificationDocuments = null,
            object additional = null,
            object type = "IndividualLegalEntity",
            Models.IndividualName name = null,
            Models.GenderEnum? gender = null,
            DateTime? dateOfBirth = null,
            string countryOfBirth = null,
            string nationality = null,
            List<Models.IdentityDocument> identificationDocuments = null)
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
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.CountryOfBirth = countryOfBirth;
            this.Nationality = nationality;
            this.IdentificationDocuments = identificationDocuments;
        }

        /// <summary>
        /// This must always be supplied and contain the value "INDIVIDUAL".
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public new object Type { get; set; }

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
        public new List<Models.IdentityDocument> IdentificationDocuments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndividualLegalEntity : ({string.Join(", ", toStringOutput)})";
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
            return obj is IndividualLegalEntity other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Gender == null && other.Gender == null) || (this.Gender?.Equals(other.Gender) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.CountryOfBirth == null && other.CountryOfBirth == null) || (this.CountryOfBirth?.Equals(other.CountryOfBirth) == true)) &&
                ((this.Nationality == null && other.Nationality == null) || (this.Nationality?.Equals(other.Nationality) == true)) &&
                ((this.IdentificationDocuments == null && other.IdentificationDocuments == null) || (this.IdentificationDocuments?.Equals(other.IdentificationDocuments) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Gender = {(this.Gender == null ? "null" : this.Gender.ToString())}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.CountryOfBirth = {(this.CountryOfBirth == null ? "null" : this.CountryOfBirth)}");
            toStringOutput.Add($"this.Nationality = {(this.Nationality == null ? "null" : this.Nationality)}");
            toStringOutput.Add($"this.IdentificationDocuments = {(this.IdentificationDocuments == null ? "null" : $"[{string.Join(", ", this.IdentificationDocuments)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}