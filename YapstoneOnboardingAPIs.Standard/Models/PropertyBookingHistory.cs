// <copyright file="PropertyBookingHistory.cs" company="APIMatic">
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
    /// PropertyBookingHistory.
    /// </summary>
    public class PropertyBookingHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyBookingHistory"/> class.
        /// </summary>
        public PropertyBookingHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyBookingHistory"/> class.
        /// </summary>
        /// <param name="activeSince">activeSince.</param>
        /// <param name="chargeCount">chargeCount.</param>
        /// <param name="chargebackCount">chargebackCount.</param>
        /// <param name="chargeVolume">chargeVolume.</param>
        /// <param name="chargebackVolume">chargebackVolume.</param>
        public PropertyBookingHistory(
            DateTime? activeSince = null,
            int? chargeCount = null,
            int? chargebackCount = null,
            Models.Money chargeVolume = null,
            Models.Money chargebackVolume = null)
        {
            this.ActiveSince = activeSince;
            this.ChargeCount = chargeCount;
            this.ChargebackCount = chargebackCount;
            this.ChargeVolume = chargeVolume;
            this.ChargebackVolume = chargebackVolume;
        }

        /// <summary>
        /// Gets or sets ActiveSince.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("activeSince", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ActiveSince { get; set; }

        /// <summary>
        /// Gets or sets ChargeCount.
        /// </summary>
        [JsonProperty("chargeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeCount { get; set; }

        /// <summary>
        /// Gets or sets ChargebackCount.
        /// </summary>
        [JsonProperty("chargebackCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargebackCount { get; set; }

        /// <summary>
        /// Gets or sets ChargeVolume.
        /// </summary>
        [JsonProperty("chargeVolume", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ChargeVolume { get; set; }

        /// <summary>
        /// Gets or sets ChargebackVolume.
        /// </summary>
        [JsonProperty("chargebackVolume", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money ChargebackVolume { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyBookingHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyBookingHistory other &&                ((this.ActiveSince == null && other.ActiveSince == null) || (this.ActiveSince?.Equals(other.ActiveSince) == true)) &&
                ((this.ChargeCount == null && other.ChargeCount == null) || (this.ChargeCount?.Equals(other.ChargeCount) == true)) &&
                ((this.ChargebackCount == null && other.ChargebackCount == null) || (this.ChargebackCount?.Equals(other.ChargebackCount) == true)) &&
                ((this.ChargeVolume == null && other.ChargeVolume == null) || (this.ChargeVolume?.Equals(other.ChargeVolume) == true)) &&
                ((this.ChargebackVolume == null && other.ChargebackVolume == null) || (this.ChargebackVolume?.Equals(other.ChargebackVolume) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActiveSince = {(this.ActiveSince == null ? "null" : this.ActiveSince.ToString())}");
            toStringOutput.Add($"this.ChargeCount = {(this.ChargeCount == null ? "null" : this.ChargeCount.ToString())}");
            toStringOutput.Add($"this.ChargebackCount = {(this.ChargebackCount == null ? "null" : this.ChargebackCount.ToString())}");
            toStringOutput.Add($"this.ChargeVolume = {(this.ChargeVolume == null ? "null" : this.ChargeVolume.ToString())}");
            toStringOutput.Add($"this.ChargebackVolume = {(this.ChargebackVolume == null ? "null" : this.ChargebackVolume.ToString())}");
        }
    }
}