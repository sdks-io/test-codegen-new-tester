// <copyright file="RentingFrequencyEnum.cs" company="APIMatic">
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
    /// RentingFrequencyEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RentingFrequencyEnum
    {
        /// <summary>
        /// LESSTHANONEMONTH.
        /// </summary>
        [EnumMember(Value = "LESS_THAN_ONE_MONTH")]
        LESSTHANONEMONTH,

        /// <summary>
        /// ONETOTHREEMONTHS.
        /// </summary>
        [EnumMember(Value = "ONE_TO_THREE_MONTHS")]
        ONETOTHREEMONTHS,

        /// <summary>
        /// THREETOSIXMONTHS.
        /// </summary>
        [EnumMember(Value = "THREE_TO_SIX_MONTHS")]
        THREETOSIXMONTHS,

        /// <summary>
        /// SIXORMOREMONTHS.
        /// </summary>
        [EnumMember(Value = "SIX_OR_MORE_MONTHS")]
        SIXORMOREMONTHS
    }
}