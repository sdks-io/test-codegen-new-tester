// <copyright file="BaseType.cs" company="APIMatic">
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
    /// BaseType.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CreateAssetRequest), "CreateAssetRequest")]
    [JsonSubtypes.KnownSubType(typeof(UpdateAssetRequest), "UpdateAssetRequest")]
    [JsonSubtypes.KnownSubType(typeof(CreatePropertyAssetRequest), "CreatePropertyAssetRequest")]
    [JsonSubtypes.KnownSubType(typeof(UpdatePropertyAssetRequest), "UpdatePropertyAssetRequest")]
    public class BaseType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseType"/> class.
        /// </summary>
        public BaseType()
        {
            this.Type = "BaseType";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseType"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="parent">parent.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="preferences">preferences.</param>
        public BaseType(
            string type = "BaseType",
            Models.Parent parent = null,
            string displayName = null,
            object preferences = null)
        {
            this.Type = type;
            this.Parent = parent;
            this.DisplayName = displayName;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Parent.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets Preferences.
        /// </summary>
        [JsonProperty("preferences", NullValueHandling = NullValueHandling.Ignore)]
        public object Preferences { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BaseType : ({string.Join(", ", toStringOutput)})";
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
            return obj is BaseType other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Preferences == null && other.Preferences == null) || (this.Preferences?.Equals(other.Preferences) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"Preferences = {(this.Preferences == null ? "null" : this.Preferences.ToString())}");
        }
    }
}