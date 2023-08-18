// <copyright file="GenderEnum.cs" company="APIMatic">
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
    /// GenderEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderEnum
    {
        /// <summary>
        /// FEMALE.
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE,

        /// <summary>
        /// MALE.
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }
}