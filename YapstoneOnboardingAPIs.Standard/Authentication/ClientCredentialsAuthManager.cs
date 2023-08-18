// <copyright file="ClientCredentialsAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using YapstoneOnboardingAPIs.Standard.Controllers;
    using YapstoneOnboardingAPIs.Standard.Http.Request;
    using YapstoneOnboardingAPIs.Standard.Models;
    using YapstoneOnboardingAPIs.Standard.Utilities;
    using YapstoneOnboardingAPIs.Standard.Exceptions;
    using APIMatic.Core.Authentication;
    using APIMatic.Core;

    /// <summary>
    /// ClientCredentialsAuthManager Class.
    /// </summary>
    public class ClientCredentialsAuthManager : AuthManager, IClientCredentialsAuth
    {
        private OAuthAuthorizationController oAuthApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredOAuthManager"/> class.
        /// </summary>
        /// <param name="oAuthClientId"> OAuth 2 Client ID.</param>
        /// <param name="oAuthClientSecret"> OAuth 2 Client Secret.</param>
        /// <param name="oAuthToken"> OAuth 2 token.</param>
        /// <param name="oAuthScopes"> List of OAuth 2 scopes.</param>
        public ClientCredentialsAuthManager(
            string oAuthClientId,
            string oAuthClientSecret,
            OAuthToken oAuthToken,
            List<Models.OAuthScopeEnum> oAuthScopes)
        {
            this.OAuthClientId = oAuthClientId;
            this.OAuthClientSecret = oAuthClientSecret;
            this.OAuthToken = oAuthToken;
            this.OAuthScopes = oAuthScopes;
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization", $"Bearer {OAuthToken?.AccessToken}")));
        }

        /// <summary>
        /// Gets string value for oAuthClientId.
        /// </summary>
        public string OAuthClientId { get; }

        /// <summary>
        /// Gets string value for oAuthClientSecret.
        /// </summary>
        public string OAuthClientSecret { get; }

        /// <summary>
        /// Gets Models.OAuthToken value for oAuthToken.
        /// </summary>
        public Models.OAuthToken OAuthToken { get; }

        /// <summary>
        /// Gets List of Models.OAuthScopeEnum value for oAuthScopes.
        /// </summary>
        public List<Models.OAuthScopeEnum> OAuthScopes { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oAuthClientId"> The string value for credentials.</param>
        /// <param name="oAuthClientSecret"> The string value for credentials.</param>
        /// <param name="oAuthToken"> The Models.OAuthToken value for credentials.</param>
        /// <param name="oAuthScopes"> The List of Models.OAuthScopeEnum value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oAuthClientId, string oAuthClientSecret, Models.OAuthToken oAuthToken, List<Models.OAuthScopeEnum> oAuthScopes)
        {
            return oAuthClientId.Equals(this.OAuthClientId)
                    && oAuthClientSecret.Equals(this.OAuthClientSecret)
                    && ((oAuthToken == null && this.OAuthToken == null) || (oAuthToken != null && this.OAuthToken != null && oAuthToken.Equals(this.OAuthToken)))
                    && ((oAuthScopes == null && this.OAuthScopes == null) || (oAuthScopes != null && this.OAuthScopes != null && oAuthScopes.Equals(this.OAuthScopes)));
        }

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public Models.OAuthToken FetchToken(Dictionary<string, object> additionalParameters = null)
            => ApiHelper.RunTask(FetchTokenAsync(additionalParameters));
       

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public async Task<Models.OAuthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null)
        {
            var token = await oAuthApi.RequestTokenAsync(BuildBasicAuthheader(),
                scope: this.OAuthScopes.GetValues(),
                fieldParameters: additionalParameters);

            if (token.ExpiresIn != null && token.ExpiresIn != 0)
            {
                token.Expiry = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + token.ExpiresIn;
            }

            return token;
        }
 
        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        public bool IsTokenExpired()
        {
           if (this.OAuthToken == null)
           {
               throw new InvalidOperationException("OAuth token is missing.");
           }
        
           return this.OAuthToken.Expiry != null
               && this.OAuthToken.Expiry < (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public void ApplyGlobalConfiguration(GlobalConfiguration globalConfiguration)
        {
            oAuthApi = new OAuthAuthorizationController(globalConfiguration);
        }
        /// <summary>
        /// Validates the authentication parameters for the HTTP Request.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (OAuthToken == null)
            {
                throw new ApiException(
                        "Client is not authorized.An OAuth token is needed to make API calls.");
            }

            if (IsTokenExpired())
            {
                throw new ApiException(
                        "OAuth token is expired. A valid token is needed to make API calls.");
            }
        }


        /// <summary>
        /// Build basic auth header.
        /// </summary>
        /// <returns> string. </returns>
        private string BuildBasicAuthheader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OAuthClientId + ':' + this.OAuthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }
}