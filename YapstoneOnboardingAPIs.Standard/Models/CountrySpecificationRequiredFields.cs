// <copyright file="CountrySpecificationRequiredFields.cs" company="APIMatic">
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
    /// CountrySpecificationRequiredFields.
    /// </summary>
    public class CountrySpecificationRequiredFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySpecificationRequiredFields"/> class.
        /// </summary>
        public CountrySpecificationRequiredFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySpecificationRequiredFields"/> class.
        /// </summary>
        /// <param name="required">required.</param>
        /// <param name="optional">optional.</param>
        public CountrySpecificationRequiredFields(
            List<string> required = null,
            List<string> optional = null)
        {
            this.Required = required;
            this.Optional = optional;
        }

        /// <summary>
        /// Gets or sets Required.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Required { get; set; }

        /// <summary>
        /// Gets or sets Optional.
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Optional { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CountrySpecificationRequiredFields : ({string.Join(", ", toStringOutput)})";
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
            return obj is CountrySpecificationRequiredFields other &&                ((this.Required == null && other.Required == null) || (this.Required?.Equals(other.Required) == true)) &&
                ((this.Optional == null && other.Optional == null) || (this.Optional?.Equals(other.Optional) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Required = {(this.Required == null ? "null" : $"[{string.Join(", ", this.Required)} ]")}");
            toStringOutput.Add($"this.Optional = {(this.Optional == null ? "null" : $"[{string.Join(", ", this.Optional)} ]")}");
        }
    }
}