// <copyright file="RiskStatusHistory.cs" company="APIMatic">
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
    /// RiskStatusHistory.
    /// </summary>
    public class RiskStatusHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskStatusHistory"/> class.
        /// </summary>
        public RiskStatusHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskStatusHistory"/> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="decision">decision.</param>
        /// <param name="declinedReasons">declinedReasons.</param>
        /// <param name="requiredActions">requiredActions.</param>
        public RiskStatusHistory(
            DateTime? timestamp = null,
            Models.RiskDecisionEnum? decision = null,
            List<string> declinedReasons = null,
            List<Models.RiskRequiredAction> requiredActions = null)
        {
            this.Timestamp = timestamp;
            this.Decision = decision;
            this.DeclinedReasons = declinedReasons;
            this.RequiredActions = requiredActions;
        }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets Decision.
        /// </summary>
        [JsonProperty("decision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RiskDecisionEnum? Decision { get; set; }

        /// <summary>
        /// Gets or sets DeclinedReasons.
        /// </summary>
        [JsonProperty("declinedReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeclinedReasons { get; set; }

        /// <summary>
        /// Gets or sets RequiredActions.
        /// </summary>
        [JsonProperty("requiredActions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RiskRequiredAction> RequiredActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RiskStatusHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is RiskStatusHistory other &&                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.Decision == null && other.Decision == null) || (this.Decision?.Equals(other.Decision) == true)) &&
                ((this.DeclinedReasons == null && other.DeclinedReasons == null) || (this.DeclinedReasons?.Equals(other.DeclinedReasons) == true)) &&
                ((this.RequiredActions == null && other.RequiredActions == null) || (this.RequiredActions?.Equals(other.RequiredActions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.Decision = {(this.Decision == null ? "null" : this.Decision.ToString())}");
            toStringOutput.Add($"this.DeclinedReasons = {(this.DeclinedReasons == null ? "null" : $"[{string.Join(", ", this.DeclinedReasons)} ]")}");
            toStringOutput.Add($"this.RequiredActions = {(this.RequiredActions == null ? "null" : $"[{string.Join(", ", this.RequiredActions)} ]")}");
        }
    }
}