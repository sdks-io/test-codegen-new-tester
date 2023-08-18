// <copyright file="HonorificPrefixEnum.cs" company="APIMatic">
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
    /// HonorificPrefixEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum HonorificPrefixEnum
    {
        /// <summary>
        /// MR.
        /// </summary>
        [EnumMember(Value = "MR")]
        MR,

        /// <summary>
        /// MRS.
        /// </summary>
        [EnumMember(Value = "MRS")]
        MRS,

        /// <summary>
        /// MS.
        /// </summary>
        [EnumMember(Value = "MS")]
        MS,

        /// <summary>
        /// MISS.
        /// </summary>
        [EnumMember(Value = "MISS")]
        MISS,

        /// <summary>
        /// DR.
        /// </summary>
        [EnumMember(Value = "DR")]
        DR
    }
}