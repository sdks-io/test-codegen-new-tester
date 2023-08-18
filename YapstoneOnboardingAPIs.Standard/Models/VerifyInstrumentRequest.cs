// <copyright file="VerifyInstrumentRequest.cs" company="APIMatic">
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
    /// VerifyInstrumentRequest.
    /// </summary>
    public class VerifyInstrumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyInstrumentRequest"/> class.
        /// </summary>
        public VerifyInstrumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyInstrumentRequest"/> class.
        /// </summary>
        /// <param name="details">details.</param>
        public VerifyInstrumentRequest(
            Dictionary<string, string> details = null)
        {
            this.Details = details;
        }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VerifyInstrumentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is VerifyInstrumentRequest other &&                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
        }
    }
}