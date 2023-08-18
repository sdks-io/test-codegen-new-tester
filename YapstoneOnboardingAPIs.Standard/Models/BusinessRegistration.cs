// <copyright file="BusinessRegistration.cs" company="APIMatic">
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
    /// BusinessRegistration.
    /// </summary>
    public class BusinessRegistration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRegistration"/> class.
        /// </summary>
        public BusinessRegistration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRegistration"/> class.
        /// </summary>
        /// <param name="formationDate">formationDate.</param>
        /// <param name="formationCountry">formationCountry.</param>
        /// <param name="formationState">formationState.</param>
        public BusinessRegistration(
            DateTime? formationDate = null,
            string formationCountry = null,
            string formationState = null)
        {
            this.FormationDate = formationDate;
            this.FormationCountry = formationCountry;
            this.FormationState = formationState;
        }

        /// <summary>
        /// Gets or sets FormationDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("formationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FormationDate { get; set; }

        /// <summary>
        /// Gets or sets FormationCountry.
        /// </summary>
        [JsonProperty("formationCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string FormationCountry { get; set; }

        /// <summary>
        /// Gets or sets FormationState.
        /// </summary>
        [JsonProperty("formationState", NullValueHandling = NullValueHandling.Ignore)]
        public string FormationState { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BusinessRegistration : ({string.Join(", ", toStringOutput)})";
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
            return obj is BusinessRegistration other &&                ((this.FormationDate == null && other.FormationDate == null) || (this.FormationDate?.Equals(other.FormationDate) == true)) &&
                ((this.FormationCountry == null && other.FormationCountry == null) || (this.FormationCountry?.Equals(other.FormationCountry) == true)) &&
                ((this.FormationState == null && other.FormationState == null) || (this.FormationState?.Equals(other.FormationState) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FormationDate = {(this.FormationDate == null ? "null" : this.FormationDate.ToString())}");
            toStringOutput.Add($"this.FormationCountry = {(this.FormationCountry == null ? "null" : this.FormationCountry)}");
            toStringOutput.Add($"this.FormationState = {(this.FormationState == null ? "null" : this.FormationState)}");
        }
    }
}