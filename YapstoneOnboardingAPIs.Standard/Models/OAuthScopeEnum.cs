// <copyright file="OAuthScopeEnum.cs" company="APIMatic">
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
    using System.Reflection;
    using YapstoneOnboardingAPIs.Standard;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// OAuthScopeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthScopeEnum
    {
        /// <summary>
        ///test
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test
    }

    static class OAuthScopeEnumExtention
    {
        internal static string GetValues(this IEnumerable<OAuthScopeEnum> values)
        {
            return values != null ? string.Join(" ", values.Select(s => s.GetValue()).Where(s => !string.IsNullOrEmpty(s)).ToArray()) : null;
        }

        private static string GetValue(this Enum value)
        {
            return value.GetType()
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;
        }
    }
}