// <copyright file="IndividualName.cs" company="APIMatic">
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
    /// IndividualName.
    /// </summary>
    public class IndividualName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualName"/> class.
        /// </summary>
        public IndividualName()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualName"/> class.
        /// </summary>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        /// <param name="honorificPrefix">honorificPrefix.</param>
        /// <param name="middle">middle.</param>
        /// <param name="additionalLast">additionalLast.</param>
        /// <param name="honorificSuffix">honorificSuffix.</param>
        public IndividualName(
            string first,
            string last,
            Models.HonorificPrefixEnum? honorificPrefix = null,
            string middle = null,
            string additionalLast = null,
            string honorificSuffix = null)
        {
            this.HonorificPrefix = honorificPrefix;
            this.First = first;
            this.Middle = middle;
            this.Last = last;
            this.AdditionalLast = additionalLast;
            this.HonorificSuffix = honorificSuffix;
        }

        /// <summary>
        /// Gets or sets HonorificPrefix.
        /// </summary>
        [JsonProperty("honorificPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HonorificPrefixEnum? HonorificPrefix { get; set; }

        /// <summary>
        /// Gets or sets First.
        /// </summary>
        [JsonProperty("first")]
        public string First { get; set; }

        /// <summary>
        /// Gets or sets Middle.
        /// </summary>
        [JsonProperty("middle", NullValueHandling = NullValueHandling.Ignore)]
        public string Middle { get; set; }

        /// <summary>
        /// Gets or sets Last.
        /// </summary>
        [JsonProperty("last")]
        public string Last { get; set; }

        /// <summary>
        /// Gets or sets AdditionalLast.
        /// </summary>
        [JsonProperty("additionalLast", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalLast { get; set; }

        /// <summary>
        /// Gets or sets HonorificSuffix.
        /// </summary>
        [JsonProperty("honorificSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string HonorificSuffix { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndividualName : ({string.Join(", ", toStringOutput)})";
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
            return obj is IndividualName other &&                ((this.HonorificPrefix == null && other.HonorificPrefix == null) || (this.HonorificPrefix?.Equals(other.HonorificPrefix) == true)) &&
                ((this.First == null && other.First == null) || (this.First?.Equals(other.First) == true)) &&
                ((this.Middle == null && other.Middle == null) || (this.Middle?.Equals(other.Middle) == true)) &&
                ((this.Last == null && other.Last == null) || (this.Last?.Equals(other.Last) == true)) &&
                ((this.AdditionalLast == null && other.AdditionalLast == null) || (this.AdditionalLast?.Equals(other.AdditionalLast) == true)) &&
                ((this.HonorificSuffix == null && other.HonorificSuffix == null) || (this.HonorificSuffix?.Equals(other.HonorificSuffix) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HonorificPrefix = {(this.HonorificPrefix == null ? "null" : this.HonorificPrefix.ToString())}");
            toStringOutput.Add($"this.First = {(this.First == null ? "null" : this.First)}");
            toStringOutput.Add($"this.Middle = {(this.Middle == null ? "null" : this.Middle)}");
            toStringOutput.Add($"this.Last = {(this.Last == null ? "null" : this.Last)}");
            toStringOutput.Add($"this.AdditionalLast = {(this.AdditionalLast == null ? "null" : this.AdditionalLast)}");
            toStringOutput.Add($"this.HonorificSuffix = {(this.HonorificSuffix == null ? "null" : this.HonorificSuffix)}");
        }
    }
}