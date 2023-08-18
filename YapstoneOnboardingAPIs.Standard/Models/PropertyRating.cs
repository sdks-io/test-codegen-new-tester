// <copyright file="PropertyRating.cs" company="APIMatic">
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
    /// PropertyRating.
    /// </summary>
    public class PropertyRating
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRating"/> class.
        /// </summary>
        public PropertyRating()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRating"/> class.
        /// </summary>
        /// <param name="score">score.</param>
        /// <param name="rating">rating.</param>
        /// <param name="ratingCount">ratingCount.</param>
        /// <param name="inquiryCount">inquiryCount.</param>
        /// <param name="complaintCount">complaintCount.</param>
        public PropertyRating(
            double? score = null,
            double? rating = null,
            int? ratingCount = null,
            int? inquiryCount = null,
            int? complaintCount = null)
        {
            this.Score = score;
            this.Rating = rating;
            this.RatingCount = ratingCount;
            this.InquiryCount = inquiryCount;
            this.ComplaintCount = complaintCount;
        }

        /// <summary>
        /// TODO: figure out what this is!
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets Rating.
        /// </summary>
        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rating { get; set; }

        /// <summary>
        /// Gets or sets RatingCount.
        /// </summary>
        [JsonProperty("ratingCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RatingCount { get; set; }

        /// <summary>
        /// Gets or sets InquiryCount.
        /// </summary>
        [JsonProperty("inquiryCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InquiryCount { get; set; }

        /// <summary>
        /// Gets or sets ComplaintCount.
        /// </summary>
        [JsonProperty("complaintCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComplaintCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyRating : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyRating other &&                ((this.Score == null && other.Score == null) || (this.Score?.Equals(other.Score) == true)) &&
                ((this.Rating == null && other.Rating == null) || (this.Rating?.Equals(other.Rating) == true)) &&
                ((this.RatingCount == null && other.RatingCount == null) || (this.RatingCount?.Equals(other.RatingCount) == true)) &&
                ((this.InquiryCount == null && other.InquiryCount == null) || (this.InquiryCount?.Equals(other.InquiryCount) == true)) &&
                ((this.ComplaintCount == null && other.ComplaintCount == null) || (this.ComplaintCount?.Equals(other.ComplaintCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Score = {(this.Score == null ? "null" : this.Score.ToString())}");
            toStringOutput.Add($"this.Rating = {(this.Rating == null ? "null" : this.Rating.ToString())}");
            toStringOutput.Add($"this.RatingCount = {(this.RatingCount == null ? "null" : this.RatingCount.ToString())}");
            toStringOutput.Add($"this.InquiryCount = {(this.InquiryCount == null ? "null" : this.InquiryCount.ToString())}");
            toStringOutput.Add($"this.ComplaintCount = {(this.ComplaintCount == null ? "null" : this.ComplaintCount.ToString())}");
        }
    }
}