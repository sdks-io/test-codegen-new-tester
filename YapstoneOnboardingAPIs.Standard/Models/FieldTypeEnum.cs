// <copyright file="FieldTypeEnum.cs" company="APIMatic">
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
    /// FieldTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldTypeEnum
    {
        /// <summary>
        /// STRING.
        /// </summary>
        [EnumMember(Value = "STRING")]
        STRING,

        /// <summary>
        /// INTEGER.
        /// </summary>
        [EnumMember(Value = "INTEGER")]
        INTEGER,

        /// <summary>
        /// DECIMAL.
        /// </summary>
        [EnumMember(Value = "DECIMAL")]
        DECIMAL,

        /// <summary>
        /// BOOLEAN.
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN,

        /// <summary>
        /// ENUMERATION.
        /// </summary>
        [EnumMember(Value = "ENUMERATION")]
        ENUMERATION,

        /// <summary>
        /// DURATION.
        /// </summary>
        [EnumMember(Value = "DURATION")]
        DURATION,

        /// <summary>
        /// DATEYEAR.
        /// </summary>
        [EnumMember(Value = "DATE_YEAR")]
        DATEYEAR,

        /// <summary>
        /// DATEYEARMONTH.
        /// </summary>
        [EnumMember(Value = "DATE_YEAR_MONTH")]
        DATEYEARMONTH,

        /// <summary>
        /// DATEYEARMONTHDAY.
        /// </summary>
        [EnumMember(Value = "DATE_YEAR_MONTH_DAY")]
        DATEYEARMONTHDAY,

        /// <summary>
        /// DATETIME.
        /// </summary>
        [EnumMember(Value = "DATE_TIME")]
        DATETIME
    }
}