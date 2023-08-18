// <copyright file="ValidationStatus.cs" company="APIMatic">
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
    /// ValidationStatus.
    /// </summary>
    public class ValidationStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationStatus"/> class.
        /// </summary>
        public ValidationStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationStatus"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="requiredActions">requiredActions.</param>
        public ValidationStatus(
            Models.StateEnum? state = null,
            List<Models.ValidationAction> requiredActions = null)
        {
            this.State = state;
            this.RequiredActions = requiredActions;
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StateEnum? State { get; set; }

        /// <summary>
        /// Gets or sets RequiredActions.
        /// </summary>
        [JsonProperty("requiredActions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ValidationAction> RequiredActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ValidationStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is ValidationStatus other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.RequiredActions == null && other.RequiredActions == null) || (this.RequiredActions?.Equals(other.RequiredActions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.RequiredActions = {(this.RequiredActions == null ? "null" : $"[{string.Join(", ", this.RequiredActions)} ]")}");
        }
    }
}