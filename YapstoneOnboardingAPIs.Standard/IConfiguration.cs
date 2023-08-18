// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard
{
    using System;
    using System.Net;
    using YapstoneOnboardingAPIs.Standard.Authentication;
    using YapstoneOnboardingAPIs.Standard.Models;

    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets DefaultHost value.
        /// </summary>
        string DefaultHost { get; }

        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        IClientCredentialsAuth ClientCredentialsAuth { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}