// <copyright file="EntityStatus.cs" company="APIMatic">
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
    /// EntityStatus.
    /// </summary>
    public class EntityStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStatus"/> class.
        /// </summary>
        public EntityStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStatus"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="disabledReasons">disabledReasons.</param>
        /// <param name="history">history.</param>
        /// <param name="validation">validation.</param>
        public EntityStatus(
            Models.EntityStateEnum? state = null,
            List<string> disabledReasons = null,
            List<Models.EntityStatusHistory> history = null,
            Models.ValidationStatus validation = null)
        {
            this.State = state;
            this.DisabledReasons = disabledReasons;
            this.History = history;
            this.Validation = validation;
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EntityStateEnum? State { get; set; }

        /// <summary>
        /// Gets or sets DisabledReasons.
        /// </summary>
        [JsonProperty("disabledReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DisabledReasons { get; set; }

        /// <summary>
        /// Gets or sets History.
        /// </summary>
        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EntityStatusHistory> History { get; set; }

        /// <summary>
        /// Gets or sets Validation.
        /// </summary>
        [JsonProperty("validation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ValidationStatus Validation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EntityStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is EntityStatus other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.DisabledReasons == null && other.DisabledReasons == null) || (this.DisabledReasons?.Equals(other.DisabledReasons) == true)) &&
                ((this.History == null && other.History == null) || (this.History?.Equals(other.History) == true)) &&
                ((this.Validation == null && other.Validation == null) || (this.Validation?.Equals(other.Validation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.DisabledReasons = {(this.DisabledReasons == null ? "null" : $"[{string.Join(", ", this.DisabledReasons)} ]")}");
            toStringOutput.Add($"this.History = {(this.History == null ? "null" : $"[{string.Join(", ", this.History)} ]")}");
            toStringOutput.Add($"this.Validation = {(this.Validation == null ? "null" : this.Validation.ToString())}");
        }
    }
}