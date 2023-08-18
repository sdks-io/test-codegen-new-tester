// <copyright file="PayeePage.cs" company="APIMatic">
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
    /// PayeePage.
    /// </summary>
    public class PayeePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeePage"/> class.
        /// </summary>
        public PayeePage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeePage"/> class.
        /// </summary>
        /// <param name="meta">meta.</param>
        /// <param name="results">results.</param>
        public PayeePage(
            Models.Meta meta = null,
            List<Models.Payee> results = null)
        {
            this.Meta = meta;
            this.Results = results;
        }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Meta Meta { get; set; }

        /// <summary>
        /// Gets or sets Results.
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Payee> Results { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayeePage : ({string.Join(", ", toStringOutput)})";
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
            return obj is PayeePage other &&                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true)) &&
                ((this.Results == null && other.Results == null) || (this.Results?.Equals(other.Results) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
            toStringOutput.Add($"this.Results = {(this.Results == null ? "null" : $"[{string.Join(", ", this.Results)} ]")}");
        }
    }
}