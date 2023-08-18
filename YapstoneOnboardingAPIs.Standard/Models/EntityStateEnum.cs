// <copyright file="EntityStateEnum.cs" company="APIMatic">
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
    /// EntityStateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityStateEnum
    {
        /// <summary>
        /// ENABLED.
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED,

        /// <summary>
        /// DISABLED.
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        /// <summary>
        /// USERDISABLED.
        /// </summary>
        [EnumMember(Value = "USER_DISABLED")]
        USERDISABLED
    }
}