// <copyright file="RequiredIdentityDocuments.cs" company="APIMatic">
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
    /// RequiredIdentityDocuments.
    /// </summary>
    public class RequiredIdentityDocuments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredIdentityDocuments"/> class.
        /// </summary>
        public RequiredIdentityDocuments()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredIdentityDocuments"/> class.
        /// </summary>
        /// <param name="allOf">allOf.</param>
        /// <param name="oneOf">oneOf.</param>
        public RequiredIdentityDocuments(
            List<string> allOf = null,
            List<string> oneOf = null)
        {
            this.AllOf = allOf;
            this.OneOf = oneOf;
        }

        /// <summary>
        /// A list of acceptable identity documents, of which all specified are required.
        /// </summary>
        [JsonProperty("allOf", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllOf { get; set; }

        /// <summary>
        /// A list of acceptable identity documents, from which one is required to be chosen.
        /// </summary>
        [JsonProperty("oneOf", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OneOf { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequiredIdentityDocuments : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequiredIdentityDocuments other &&                ((this.AllOf == null && other.AllOf == null) || (this.AllOf?.Equals(other.AllOf) == true)) &&
                ((this.OneOf == null && other.OneOf == null) || (this.OneOf?.Equals(other.OneOf) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllOf = {(this.AllOf == null ? "null" : $"[{string.Join(", ", this.AllOf)} ]")}");
            toStringOutput.Add($"this.OneOf = {(this.OneOf == null ? "null" : $"[{string.Join(", ", this.OneOf)} ]")}");
        }
    }
}