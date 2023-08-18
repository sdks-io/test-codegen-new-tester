// <copyright file="LegalEntityRequest.cs" company="APIMatic">
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
    /// LegalEntityRequest.
    /// </summary>
    public class LegalEntityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntityRequest"/> class.
        /// </summary>
        public LegalEntityRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntityRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="website">website.</param>
        /// <param name="socialNetworks">socialNetworks.</param>
        /// <param name="digitalCurrencyAddresses">digitalCurrencyAddresses.</param>
        /// <param name="kyc">kyc.</param>
        public LegalEntityRequest(
            Models.LegalEntityTypeEnum type,
            Models.Address address = null,
            Models.Phone phone = null,
            string email = null,
            string website = null,
            List<Models.SocialNetwork> socialNetworks = null,
            List<string> digitalCurrencyAddresses = null,
            object kyc = null)
        {
            this.Type = type;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Website = website;
            this.SocialNetworks = socialNetworks;
            this.DigitalCurrencyAddresses = digitalCurrencyAddresses;
            this.Kyc = kyc;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.LegalEntityTypeEnum Type { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LegalEntityRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is LegalEntityRequest other &&                this.Type.Equals(other.Type) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.SocialNetworks == null && other.SocialNetworks == null) || (this.SocialNetworks?.Equals(other.SocialNetworks) == true)) &&
                ((this.DigitalCurrencyAddresses == null && other.DigitalCurrencyAddresses == null) || (this.DigitalCurrencyAddresses?.Equals(other.DigitalCurrencyAddresses) == true)) &&
                ((this.Kyc == null && other.Kyc == null) || (this.Kyc?.Equals(other.Kyc) == true));
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
        }
    }
}