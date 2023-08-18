// <copyright file="InstrumentOptions.cs" company="APIMatic">
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
    /// InstrumentOptions.
    /// </summary>
    public class InstrumentOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentOptions"/> class.
        /// </summary>
        public InstrumentOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentOptions"/> class.
        /// </summary>
        /// <param name="performVerification">performVerification.</param>
        public InstrumentOptions(
            bool? performVerification = null)
        {
            this.PerformVerification = performVerification;
        }

        /// <summary>
        /// Gets or sets PerformVerification.
        /// </summary>
        [JsonProperty("performVerification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PerformVerification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstrumentOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstrumentOptions other &&                ((this.PerformVerification == null && other.PerformVerification == null) || (this.PerformVerification?.Equals(other.PerformVerification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PerformVerification = {(this.PerformVerification == null ? "null" : this.PerformVerification.ToString())}");
        }
    }
}