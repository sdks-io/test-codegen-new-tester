// <copyright file="StateEnum.cs" company="APIMatic">
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
    /// StateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// INVALID.
        /// </summary>
        [EnumMember(Value = "INVALID")]
        INVALID,

        /// <summary>
        /// VALID.
        /// </summary>
        [EnumMember(Value = "VALID")]
        VALID
    }
}