// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// TERMSOFSERVICE.
        /// </summary>
        [EnumMember(Value = "TERMS_OF_SERVICE")]
        TERMSOFSERVICE,

        /// <summary>
        /// DIRECTDEBT.
        /// </summary>
        [EnumMember(Value = "DIRECT_DEBT")]
        DIRECTDEBT
    }
}