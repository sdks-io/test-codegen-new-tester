// <copyright file="FieldSpecification.cs" company="APIMatic">
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
    /// FieldSpecification.
    /// </summary>
    public class FieldSpecification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSpecification"/> class.
        /// </summary>
        public FieldSpecification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSpecification"/> class.
        /// </summary>
        /// <param name="field">field.</param>
        /// <param name="type">type.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="required">required.</param>
        /// <param name="minimumLength">minimumLength.</param>
        /// <param name="maximumLength">maximumLength.</param>
        /// <param name="masked">masked.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="enumValues">enumValues.</param>
        public FieldSpecification(
            string field = null,
            Models.FieldTypeEnum? type = null,
            string description = null,
            string displayName = null,
            bool? required = null,
            long? minimumLength = null,
            long? maximumLength = null,
            bool? masked = null,
            bool? readOnly = null,
            List<string> enumValues = null)
        {
            this.Field = field;
            this.Type = type;
            this.Description = description;
            this.DisplayName = displayName;
            this.Required = required;
            this.MinimumLength = minimumLength;
            this.MaximumLength = maximumLength;
            this.Masked = masked;
            this.ReadOnly = readOnly;
            this.EnumValues = enumValues;
        }

        /// <summary>
        /// The field name within the `details` section of an `Instrument` or `IdentityDocument`.
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// The type of the field.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FieldTypeEnum? Type { get; set; }

        /// <summary>
        /// Detailed description of the field.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Human friendly name for the field, for display purposes in UIs.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates if the specified field is required or optional.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// If present then the value may not be less than the specified minimum length. Only applicable for the 'STRING' type.
        /// </summary>
        [JsonProperty("minimumLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinimumLength { get; set; }

        /// <summary>
        /// If present then the value may not exceed the specified maximum length. Only applicable for the 'STRING' type.
        /// </summary>
        [JsonProperty("maximumLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaximumLength { get; set; }

        /// <summary>
        /// If true, then the field will not be available to the caller in the clear, instead as masked version will be returned.
        /// </summary>
        [JsonProperty("masked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Masked { get; set; }

        /// <summary>
        /// If true, then the detail cannot be populated by the caller, but instead will be generated internally.
        /// </summary>
        [JsonProperty("readOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// If the specification type is 'ENUMERATION' then the input will be validated against these accepted values.
        /// </summary>
        [JsonProperty("enumValues", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnumValues { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FieldSpecification : ({string.Join(", ", toStringOutput)})";
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
            return obj is FieldSpecification other &&                ((this.Field == null && other.Field == null) || (this.Field?.Equals(other.Field) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Required == null && other.Required == null) || (this.Required?.Equals(other.Required) == true)) &&
                ((this.MinimumLength == null && other.MinimumLength == null) || (this.MinimumLength?.Equals(other.MinimumLength) == true)) &&
                ((this.MaximumLength == null && other.MaximumLength == null) || (this.MaximumLength?.Equals(other.MaximumLength) == true)) &&
                ((this.Masked == null && other.Masked == null) || (this.Masked?.Equals(other.Masked) == true)) &&
                ((this.ReadOnly == null && other.ReadOnly == null) || (this.ReadOnly?.Equals(other.ReadOnly) == true)) &&
                ((this.EnumValues == null && other.EnumValues == null) || (this.EnumValues?.Equals(other.EnumValues) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Field = {(this.Field == null ? "null" : this.Field)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.Required = {(this.Required == null ? "null" : this.Required.ToString())}");
            toStringOutput.Add($"this.MinimumLength = {(this.MinimumLength == null ? "null" : this.MinimumLength.ToString())}");
            toStringOutput.Add($"this.MaximumLength = {(this.MaximumLength == null ? "null" : this.MaximumLength.ToString())}");
            toStringOutput.Add($"this.Masked = {(this.Masked == null ? "null" : this.Masked.ToString())}");
            toStringOutput.Add($"this.ReadOnly = {(this.ReadOnly == null ? "null" : this.ReadOnly.ToString())}");
            toStringOutput.Add($"this.EnumValues = {(this.EnumValues == null ? "null" : $"[{string.Join(", ", this.EnumValues)} ]")}");
        }
    }
}