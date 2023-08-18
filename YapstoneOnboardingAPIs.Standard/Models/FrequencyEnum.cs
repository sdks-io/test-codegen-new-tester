// <copyright file="FrequencyEnum.cs" company="APIMatic">
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
    /// FrequencyEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyEnum
    {
        /// <summary>
        /// WEEKLY.
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        /// <summary>
        /// MONTHLY.
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY
    }
}