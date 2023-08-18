// <copyright file="LegalEntityType2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using YapstoneOnboardingAPIs.Standard;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// LegalEntityType2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegalEntityType2Enum
    {
        /// <summary>
        /// INDIVIDUAL.
        /// </summary>
        [EnumMember(Value = "INDIVIDUAL")]
        INDIVIDUAL,

        /// <summary>
        /// BUSINESS.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        BUSINESS
    }
}