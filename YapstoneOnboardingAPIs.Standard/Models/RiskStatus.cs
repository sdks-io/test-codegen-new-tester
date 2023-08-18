// <copyright file="RiskStatus.cs" company="APIMatic">
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
    /// RiskStatus.
    /// </summary>
    public class RiskStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskStatus"/> class.
        /// </summary>
        public RiskStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskStatus"/> class.
        /// </summary>
        /// <param name="decision">decision.</param>
        /// <param name="declinedReasons">declinedReasons.</param>
        /// <param name="requiredActions">requiredActions.</param>
        /// <param name="history">history.</param>
        public RiskStatus(
            Models.RiskDecisionEnum? decision = null,
            List<string> declinedReasons = null,
            List<Models.RiskRequiredAction> requiredActions = null,
            List<Models.RiskStatusHistory> history = null)
        {
            this.Decision = decision;
            this.DeclinedReasons = declinedReasons;
            this.RequiredActions = requiredActions;
            this.History = history;
        }

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

        /// <summary>
        /// Gets or sets History.
        /// </summary>
        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RiskStatusHistory> History { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RiskStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is RiskStatus other &&                ((this.Decision == null && other.Decision == null) || (this.Decision?.Equals(other.Decision) == true)) &&
                ((this.DeclinedReasons == null && other.DeclinedReasons == null) || (this.DeclinedReasons?.Equals(other.DeclinedReasons) == true)) &&
                ((this.RequiredActions == null && other.RequiredActions == null) || (this.RequiredActions?.Equals(other.RequiredActions) == true)) &&
                ((this.History == null && other.History == null) || (this.History?.Equals(other.History) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Decision = {(this.Decision == null ? "null" : this.Decision.ToString())}");
            toStringOutput.Add($"this.DeclinedReasons = {(this.DeclinedReasons == null ? "null" : $"[{string.Join(", ", this.DeclinedReasons)} ]")}");
            toStringOutput.Add($"this.RequiredActions = {(this.RequiredActions == null ? "null" : $"[{string.Join(", ", this.RequiredActions)} ]")}");
            toStringOutput.Add($"this.History = {(this.History == null ? "null" : $"[{string.Join(", ", this.History)} ]")}");
        }
    }
}