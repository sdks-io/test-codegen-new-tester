// <copyright file="ThreeDSecureCapability.cs" company="APIMatic">
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
    /// ThreeDSecureCapability.
    /// </summary>
    public class ThreeDSecureCapability : Capability
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureCapability"/> class.
        /// </summary>
        public ThreeDSecureCapability()
        {
            this.Type = "ThreeDSecureCapability";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureCapability"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="type">type.</param>
        public ThreeDSecureCapability(
            string type = "ThreeDSecureCapability",
            object type = "ThreeDSecureCapability")
            : base(
                type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public new object Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDSecureCapability : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDSecureCapability other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}