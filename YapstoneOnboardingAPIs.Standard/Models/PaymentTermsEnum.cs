// <copyright file="PaymentTermsEnum.cs" company="APIMatic">
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
    /// PaymentTermsEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTermsEnum
    {
        /// <summary>
        /// SINGLECHARGE.
        /// </summary>
        [EnumMember(Value = "SINGLE_CHARGE")]
        SINGLECHARGE,

        /// <summary>
        /// MULTIPLECHARGES.
        /// </summary>
        [EnumMember(Value = "MULTIPLE_CHARGES")]
        MULTIPLECHARGES
    }
}