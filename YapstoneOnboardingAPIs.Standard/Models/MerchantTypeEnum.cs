// <copyright file="MerchantTypeEnum.cs" company="APIMatic">
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
    /// MerchantTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MerchantTypeEnum
    {
        /// <summary>
        /// MERCHANT.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,

        /// <summary>
        /// SUBMERCHANT.
        /// </summary>
        [EnumMember(Value = "SUB_MERCHANT")]
        SUBMERCHANT
    }
}