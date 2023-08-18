// <copyright file="EntityStatusHistory.cs" company="APIMatic">
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
    /// EntityStatusHistory.
    /// </summary>
    public class EntityStatusHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStatusHistory"/> class.
        /// </summary>
        public EntityStatusHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStatusHistory"/> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="state">state.</param>
        /// <param name="disabledReasons">disabledReasons.</param>
        public EntityStatusHistory(
            DateTime? timestamp = null,
            Models.EntityStateEnum? state = null,
            List<string> disabledReasons = null)
        {
            this.Timestamp = timestamp;
            this.State = state;
            this.DisabledReasons = disabledReasons;
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
        public Models.EntityStateEnum? State { get; set; }

        /// <summary>
        /// Gets or sets DisabledReasons.
        /// </summary>
        [JsonProperty("disabledReasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DisabledReasons { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EntityStatusHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is EntityStatusHistory other &&                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.DisabledReasons == null && other.DisabledReasons == null) || (this.DisabledReasons?.Equals(other.DisabledReasons) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.DisabledReasons = {(this.DisabledReasons == null ? "null" : $"[{string.Join(", ", this.DisabledReasons)} ]")}");
        }
    }
}