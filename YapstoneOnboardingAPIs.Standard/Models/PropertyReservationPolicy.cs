// <copyright file="PropertyReservationPolicy.cs" company="APIMatic">
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
    /// PropertyReservationPolicy.
    /// </summary>
    public class PropertyReservationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReservationPolicy"/> class.
        /// </summary>
        public PropertyReservationPolicy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReservationPolicy"/> class.
        /// </summary>
        /// <param name="checkIn">checkIn.</param>
        /// <param name="checkOut">checkOut.</param>
        /// <param name="minStayDays">minStayDays.</param>
        /// <param name="maxStayDays">maxStayDays.</param>
        /// <param name="cancellationPolicy">cancellationPolicy.</param>
        public PropertyReservationPolicy(
            DateTime? checkIn = null,
            DateTime? checkOut = null,
            int? minStayDays = null,
            int? maxStayDays = null,
            string cancellationPolicy = null)
        {
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.MinStayDays = minStayDays;
            this.MaxStayDays = maxStayDays;
            this.CancellationPolicy = cancellationPolicy;
        }

        /// <summary>
        /// Gets or sets CheckIn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("checkIn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CheckIn { get; set; }

        /// <summary>
        /// Gets or sets CheckOut.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("checkOut", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CheckOut { get; set; }

        /// <summary>
        /// Gets or sets MinStayDays.
        /// </summary>
        [JsonProperty("minStayDays", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinStayDays { get; set; }

        /// <summary>
        /// Gets or sets MaxStayDays.
        /// </summary>
        [JsonProperty("maxStayDays", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxStayDays { get; set; }

        /// <summary>
        /// Gets or sets CancellationPolicy.
        /// </summary>
        [JsonProperty("cancellationPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationPolicy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyReservationPolicy : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyReservationPolicy other &&                ((this.CheckIn == null && other.CheckIn == null) || (this.CheckIn?.Equals(other.CheckIn) == true)) &&
                ((this.CheckOut == null && other.CheckOut == null) || (this.CheckOut?.Equals(other.CheckOut) == true)) &&
                ((this.MinStayDays == null && other.MinStayDays == null) || (this.MinStayDays?.Equals(other.MinStayDays) == true)) &&
                ((this.MaxStayDays == null && other.MaxStayDays == null) || (this.MaxStayDays?.Equals(other.MaxStayDays) == true)) &&
                ((this.CancellationPolicy == null && other.CancellationPolicy == null) || (this.CancellationPolicy?.Equals(other.CancellationPolicy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckIn = {(this.CheckIn == null ? "null" : this.CheckIn.ToString())}");
            toStringOutput.Add($"this.CheckOut = {(this.CheckOut == null ? "null" : this.CheckOut.ToString())}");
            toStringOutput.Add($"this.MinStayDays = {(this.MinStayDays == null ? "null" : this.MinStayDays.ToString())}");
            toStringOutput.Add($"this.MaxStayDays = {(this.MaxStayDays == null ? "null" : this.MaxStayDays.ToString())}");
            toStringOutput.Add($"this.CancellationPolicy = {(this.CancellationPolicy == null ? "null" : this.CancellationPolicy)}");
        }
    }
}