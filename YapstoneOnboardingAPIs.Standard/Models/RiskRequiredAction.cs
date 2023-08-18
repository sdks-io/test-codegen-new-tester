// <copyright file="RiskRequiredAction.cs" company="APIMatic">
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
    /// RiskRequiredAction.
    /// </summary>
    public class RiskRequiredAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRequiredAction"/> class.
        /// </summary>
        public RiskRequiredAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskRequiredAction"/> class.
        /// </summary>
        /// <param name="actionCode">actionCode.</param>
        /// <param name="message">message.</param>
        public RiskRequiredAction(
            string actionCode = null,
            string message = null)
        {
            this.ActionCode = actionCode;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets ActionCode.
        /// </summary>
        [JsonProperty("actionCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RiskRequiredAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is RiskRequiredAction other &&                ((this.ActionCode == null && other.ActionCode == null) || (this.ActionCode?.Equals(other.ActionCode) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActionCode = {(this.ActionCode == null ? "null" : this.ActionCode)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}