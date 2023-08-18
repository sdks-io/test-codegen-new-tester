// <copyright file="PropertyAsset.cs" company="APIMatic">
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
    /// PropertyAsset.
    /// </summary>
    public class PropertyAsset : Asset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyAsset"/> class.
        /// </summary>
        public PropertyAsset()
        {
            this.Type = "PropertyAsset";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyAsset"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="parent">parent.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="id">id.</param>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="correlationRefs">correlationRefs.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="details">details.</param>
        /// <param name="rating">rating.</param>
        /// <param name="reservationPolicy">reservationPolicy.</param>
        /// <param name="rateDetails">rateDetails.</param>
        /// <param name="bookingHistory">bookingHistory.</param>
        /// <param name="status">status.</param>
        public PropertyAsset(
            string type = "PropertyAsset",
            Models.Parent parent = null,
            string displayName = null,
            Models.Capabilities capabilities = null,
            object preferences = null,
            string id = null,
            DateTime? created = null,
            DateTime? updated = null,
            List<Models.CorrelationRef> correlationRefs = null,
            Dictionary<string, string> metadata = null,
            object type = "PropertyAsset",
            string name = null,
            Models.Address address = null,
            Models.PropertyDetails details = null,
            Models.PropertyRating rating = null,
            Models.PropertyReservationPolicy reservationPolicy = null,
            Models.PropertyRateDetails rateDetails = null,
            Models.PropertyBookingHistory bookingHistory = null,
            Models.EntityStatus status = null)
            : base(
                type,
                parent,
                displayName,
                capabilities,
                preferences,
                id,
                created,
                updated,
                correlationRefs,
                metadata)
        {
            this.Type = type;
            this.Name = name;
            this.Address = address;
            this.Details = details;
            this.Rating = rating;
            this.ReservationPolicy = reservationPolicy;
            this.RateDetails = rateDetails;
            this.BookingHistory = bookingHistory;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public new object Type { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PropertyDetails Details { get; set; }

        /// <summary>
        /// Gets or sets Rating.
        /// </summary>
        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PropertyRating Rating { get; set; }

        /// <summary>
        /// Gets or sets ReservationPolicy.
        /// </summary>
        [JsonProperty("reservationPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PropertyReservationPolicy ReservationPolicy { get; set; }

        /// <summary>
        /// Gets or sets RateDetails.
        /// </summary>
        [JsonProperty("rateDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PropertyRateDetails RateDetails { get; set; }

        /// <summary>
        /// Gets or sets BookingHistory.
        /// </summary>
        [JsonProperty("bookingHistory", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PropertyBookingHistory BookingHistory { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EntityStatus Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyAsset : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyAsset other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Rating == null && other.Rating == null) || (this.Rating?.Equals(other.Rating) == true)) &&
                ((this.ReservationPolicy == null && other.ReservationPolicy == null) || (this.ReservationPolicy?.Equals(other.ReservationPolicy) == true)) &&
                ((this.RateDetails == null && other.RateDetails == null) || (this.RateDetails?.Equals(other.RateDetails) == true)) &&
                ((this.BookingHistory == null && other.BookingHistory == null) || (this.BookingHistory?.Equals(other.BookingHistory) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"this.Rating = {(this.Rating == null ? "null" : this.Rating.ToString())}");
            toStringOutput.Add($"this.ReservationPolicy = {(this.ReservationPolicy == null ? "null" : this.ReservationPolicy.ToString())}");
            toStringOutput.Add($"this.RateDetails = {(this.RateDetails == null ? "null" : this.RateDetails.ToString())}");
            toStringOutput.Add($"this.BookingHistory = {(this.BookingHistory == null ? "null" : this.BookingHistory.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}