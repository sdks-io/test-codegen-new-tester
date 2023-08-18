// <copyright file="IdentityDocument.cs" company="APIMatic">
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
    /// IdentityDocument.
    /// </summary>
    public class IdentityDocument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDocument"/> class.
        /// </summary>
        public IdentityDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDocument"/> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        /// <param name="fingerprints">fingerprints.</param>
        public IdentityDocument(
            string displayText = null,
            string type = null,
            Dictionary<string, string> details = null,
            List<Models.Fingerprint> fingerprints = null)
        {
            this.DisplayText = displayText;
            this.Type = type;
            this.Details = details;
            this.Fingerprints = fingerprints;
        }

        /// <summary>
        /// Gets or sets DisplayText.
        /// </summary>
        [JsonProperty("displayText", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// Gets or sets Fingerprints.
        /// </summary>
        [JsonProperty("fingerprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Fingerprint> Fingerprints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IdentityDocument : ({string.Join(", ", toStringOutput)})";
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
            return obj is IdentityDocument other &&                ((this.DisplayText == null && other.DisplayText == null) || (this.DisplayText?.Equals(other.DisplayText) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Fingerprints == null && other.Fingerprints == null) || (this.Fingerprints?.Equals(other.Fingerprints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DisplayText = {(this.DisplayText == null ? "null" : this.DisplayText)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"this.Fingerprints = {(this.Fingerprints == null ? "null" : $"[{string.Join(", ", this.Fingerprints)} ]")}");
        }
    }
}