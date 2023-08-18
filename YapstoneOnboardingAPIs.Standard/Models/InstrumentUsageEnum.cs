// <copyright file="InstrumentUsageEnum.cs" company="APIMatic">
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
    /// InstrumentUsageEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstrumentUsageEnum
    {
        /// <summary>
        /// REUSABLE.
        /// </summary>
        [EnumMember(Value = "REUSABLE")]
        REUSABLE,

        /// <summary>
        /// ONETIME.
        /// </summary>
        [EnumMember(Value = "ONE_TIME")]
        ONETIME,

        /// <summary>
        /// CONSUMED.
        /// </summary>
        [EnumMember(Value = "CONSUMED")]
        CONSUMED
    }
}