// <copyright file="DirectDebitConsent.cs" company="APIMatic">
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
    /// DirectDebitConsent.
    /// </summary>
    public class DirectDebitConsent : Consent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitConsent"/> class.
        /// </summary>
        public DirectDebitConsent()
        {
            this.Type = "DirectDebitConsent";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitConsent"/> class.
        /// </summary>
        /// <param name="timeOfConsent">timeOfConsent.</param>
        /// <param name="version">version.</param>
        /// <param name="type">type.</param>
        /// <param name="type">type.</param>
        /// <param name="frequency">frequency.</param>
        public DirectDebitConsent(
            DateTime timeOfConsent,
            int version,
            string type = "DirectDebitConsent",
            object type = "DirectDebitConsent",
            Models.FrequencyEnum? frequency = null)
            : base(
                timeOfConsent,
                version,
                type)
        {
            this.Type = type;
            this.Frequency = frequency;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public new object Type { get; set; }

        /// <summary>
        /// Gets or sets Frequency.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FrequencyEnum? Frequency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitConsent : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitConsent other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}