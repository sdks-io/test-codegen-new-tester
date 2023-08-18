// <copyright file="CapabilityTypeEnum.cs" company="APIMatic">
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
    /// CapabilityTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapabilityTypeEnum
    {
        /// <summary>
        /// DIRECTDEBT.
        /// </summary>
        [EnumMember(Value = "DIRECT_DEBT")]
        DIRECTDEBT,

        /// <summary>
        /// CHARGE.
        /// </summary>
        [EnumMember(Value = "CHARGE")]
        CHARGE,

        /// <summary>
        /// PAYOUT.
        /// </summary>
        [EnumMember(Value = "PAYOUT")]
        PAYOUT,

        /// <summary>
        /// THREEDSECURE.
        /// </summary>
        [EnumMember(Value = "THREE_D_SECURE")]
        THREEDSECURE
    }
}