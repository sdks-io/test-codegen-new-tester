// <copyright file="PeriodEnum.cs" company="APIMatic">
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
    /// PeriodEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeriodEnum
    {
        /// <summary>
        /// DAILY.
        /// </summary>
        [EnumMember(Value = "DAILY")]
        DAILY,

        /// <summary>
        /// WEEKLY.
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        /// <summary>
        /// MONTHLY.
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        /// <summary>
        /// YEARLY.
        /// </summary>
        [EnumMember(Value = "YEARLY")]
        YEARLY
    }
}