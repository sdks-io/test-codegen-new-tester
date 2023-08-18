// <copyright file="LegalEntityTypeEnum.cs" company="APIMatic">
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
    /// LegalEntityTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegalEntityTypeEnum
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