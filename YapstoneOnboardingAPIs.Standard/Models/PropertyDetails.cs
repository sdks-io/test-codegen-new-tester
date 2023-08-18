// <copyright file="PropertyDetails.cs" company="APIMatic">
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
    /// PropertyDetails.
    /// </summary>
    public class PropertyDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDetails"/> class.
        /// </summary>
        public PropertyDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDetails"/> class.
        /// </summary>
        /// <param name="capacity">capacity.</param>
        /// <param name="bedroomCount">bedroomCount.</param>
        /// <param name="bathroomCount">bathroomCount.</param>
        /// <param name="amenities">amenities.</param>
        public PropertyDetails(
            int? capacity = null,
            int? bedroomCount = null,
            int? bathroomCount = null,
            List<string> amenities = null)
        {
            this.Capacity = capacity;
            this.BedroomCount = bedroomCount;
            this.BathroomCount = bathroomCount;
            this.Amenities = amenities;
        }

        /// <summary>
        /// Gets or sets Capacity.
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets BedroomCount.
        /// </summary>
        [JsonProperty("bedroomCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BedroomCount { get; set; }

        /// <summary>
        /// Gets or sets BathroomCount.
        /// </summary>
        [JsonProperty("bathroomCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BathroomCount { get; set; }

        /// <summary>
        /// Gets or sets Amenities.
        /// </summary>
        [JsonProperty("amenities", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Amenities { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyDetails other &&                ((this.Capacity == null && other.Capacity == null) || (this.Capacity?.Equals(other.Capacity) == true)) &&
                ((this.BedroomCount == null && other.BedroomCount == null) || (this.BedroomCount?.Equals(other.BedroomCount) == true)) &&
                ((this.BathroomCount == null && other.BathroomCount == null) || (this.BathroomCount?.Equals(other.BathroomCount) == true)) &&
                ((this.Amenities == null && other.Amenities == null) || (this.Amenities?.Equals(other.Amenities) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Capacity = {(this.Capacity == null ? "null" : this.Capacity.ToString())}");
            toStringOutput.Add($"this.BedroomCount = {(this.BedroomCount == null ? "null" : this.BedroomCount.ToString())}");
            toStringOutput.Add($"this.BathroomCount = {(this.BathroomCount == null ? "null" : this.BathroomCount.ToString())}");
            toStringOutput.Add($"this.Amenities = {(this.Amenities == null ? "null" : $"[{string.Join(", ", this.Amenities)} ]")}");
        }
    }
}