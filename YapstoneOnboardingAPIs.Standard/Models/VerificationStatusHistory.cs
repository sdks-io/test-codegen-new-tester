// <copyright file="VerificationStatusHistory.cs" company="APIMatic">
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
    /// VerificationStatusHistory.
    /// </summary>
    public class VerificationStatusHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationStatusHistory"/> class.
        /// </summary>
        public VerificationStatusHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationStatusHistory"/> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="state">state.</param>
        /// <param name="description">description.</param>
        /// <param name="requiredActions">requiredActions.</param>
        public VerificationStatusHistory(
            DateTime? timestamp = null,
            Models.VerificationStateEnum? state = null,
            string description = null,
            List<Models.VerificationAction> requiredActions = null)
        {
            this.Timestamp = timestamp;
            this.State = state;
            this.Description = description;
            this.RequiredActions = requiredActions;
        }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VerificationStateEnum? State { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets RequiredActions.
        /// </summary>
        [JsonProperty("requiredActions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.VerificationAction> RequiredActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VerificationStatusHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is VerificationStatusHistory other &&                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.RequiredActions == null && other.RequiredActions == null) || (this.RequiredActions?.Equals(other.RequiredActions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.RequiredActions = {(this.RequiredActions == null ? "null" : $"[{string.Join(", ", this.RequiredActions)} ]")}");
        }
    }
}