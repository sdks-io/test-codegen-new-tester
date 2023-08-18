// <copyright file="BusinessTypeEnum.cs" company="APIMatic">
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
    /// BusinessTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessTypeEnum
    {
        /// <summary>
        /// SOLEPROPRIETOR.
        /// </summary>
        [EnumMember(Value = "SOLE_PROPRIETOR")]
        SOLEPROPRIETOR,

        /// <summary>
        /// PARTNERSHIP.
        /// </summary>
        [EnumMember(Value = "PARTNERSHIP")]
        PARTNERSHIP,

        /// <summary>
        /// SCORP.
        /// </summary>
        [EnumMember(Value = "S_CORP")]
        SCORP,

        /// <summary>
        /// LLC.
        /// </summary>
        [EnumMember(Value = "LLC")]
        LLC,

        /// <summary>
        /// CORPORATION.
        /// </summary>
        [EnumMember(Value = "CORPORATION")]
        CORPORATION
    }
}