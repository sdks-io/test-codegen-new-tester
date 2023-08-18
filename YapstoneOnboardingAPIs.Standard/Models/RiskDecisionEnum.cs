// <copyright file="RiskDecisionEnum.cs" company="APIMatic">
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
    /// RiskDecisionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RiskDecisionEnum
    {
        /// <summary>
        /// NOTEVALUATED.
        /// </summary>
        [EnumMember(Value = "NOT_EVALUATED")]
        NOTEVALUATED,

        /// <summary>
        /// UNDERREVIEW.
        /// </summary>
        [EnumMember(Value = "UNDER_REVIEW")]
        UNDERREVIEW,

        /// <summary>
        /// APPROVED.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED,

        /// <summary>
        /// DECLINED.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        DECLINED
    }
}