// <copyright file="NetworkPreferences.cs" company="APIMatic">
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
    /// NetworkPreferences.
    /// </summary>
    public class NetworkPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPreferences"/> class.
        /// </summary>
        public NetworkPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPreferences"/> class.
        /// </summary>
        /// <param name="merchantCategoryCode">merchantCategoryCode.</param>
        /// <param name="merchantIdentifictionNumber">merchantIdentifictionNumber.</param>
        /// <param name="gatewayIdentificationNumber">gatewayIdentificationNumber.</param>
        /// <param name="terminalIdentificationNumber">terminalIdentificationNumber.</param>
        public NetworkPreferences(
            string merchantCategoryCode = null,
            string merchantIdentifictionNumber = null,
            string gatewayIdentificationNumber = null,
            string terminalIdentificationNumber = null)
        {
            this.MerchantCategoryCode = merchantCategoryCode;
            this.MerchantIdentifictionNumber = merchantIdentifictionNumber;
            this.GatewayIdentificationNumber = gatewayIdentificationNumber;
            this.TerminalIdentificationNumber = terminalIdentificationNumber;
        }

        /// <summary>
        /// Gets or sets MerchantCategoryCode.
        /// </summary>
        [JsonProperty("merchantCategoryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Gets or sets MerchantIdentifictionNumber.
        /// </summary>
        [JsonProperty("merchantIdentifictionNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantIdentifictionNumber { get; set; }

        /// <summary>
        /// Gets or sets GatewayIdentificationNumber.
        /// </summary>
        [JsonProperty("gatewayIdentificationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets TerminalIdentificationNumber.
        /// </summary>
        [JsonProperty("terminalIdentificationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalIdentificationNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkPreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkPreferences other &&                ((this.MerchantCategoryCode == null && other.MerchantCategoryCode == null) || (this.MerchantCategoryCode?.Equals(other.MerchantCategoryCode) == true)) &&
                ((this.MerchantIdentifictionNumber == null && other.MerchantIdentifictionNumber == null) || (this.MerchantIdentifictionNumber?.Equals(other.MerchantIdentifictionNumber) == true)) &&
                ((this.GatewayIdentificationNumber == null && other.GatewayIdentificationNumber == null) || (this.GatewayIdentificationNumber?.Equals(other.GatewayIdentificationNumber) == true)) &&
                ((this.TerminalIdentificationNumber == null && other.TerminalIdentificationNumber == null) || (this.TerminalIdentificationNumber?.Equals(other.TerminalIdentificationNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantCategoryCode = {(this.MerchantCategoryCode == null ? "null" : this.MerchantCategoryCode)}");
            toStringOutput.Add($"this.MerchantIdentifictionNumber = {(this.MerchantIdentifictionNumber == null ? "null" : this.MerchantIdentifictionNumber)}");
            toStringOutput.Add($"this.GatewayIdentificationNumber = {(this.GatewayIdentificationNumber == null ? "null" : this.GatewayIdentificationNumber)}");
            toStringOutput.Add($"this.TerminalIdentificationNumber = {(this.TerminalIdentificationNumber == null ? "null" : this.TerminalIdentificationNumber)}");
        }
    }
}