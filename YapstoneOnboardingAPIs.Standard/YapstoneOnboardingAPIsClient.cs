// <copyright file="YapstoneOnboardingAPIsClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using YapstoneOnboardingAPIs.Standard.Authentication;
    using YapstoneOnboardingAPIs.Standard.Controllers;
    using YapstoneOnboardingAPIs.Standard.Http.Client;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class YapstoneOnboardingAPIsClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://{defaultHost}" },
                    { Server.AccessTokenServer, "https://api-prod-sandbox.yapstone.com/v3/oauth2" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly ClientCredentialsAuthManager clientCredentialsAuthManager;
        private readonly Lazy<CustomersController> customers;
        private readonly Lazy<InstrumentsController> instruments;
        private readonly Lazy<SpecificationsController> specifications;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private YapstoneOnboardingAPIsClient(
            Environment environment,
            string defaultHost,
            string oAuthClientId,
            string oAuthClientSecret,
            Models.OAuthToken oAuthToken,
            List<Models.OAuthScopeEnum> oAuthScopes,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.DefaultHost = defaultHost;
            this.HttpClientConfiguration = httpClientConfiguration;
            clientCredentialsAuthManager = new ClientCredentialsAuthManager(oAuthClientId, oAuthClientSecret, oAuthToken, oAuthScopes);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", clientCredentialsAuthManager}
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Template(templateParameter => templateParameter.Setup("defaultHost", this.DefaultHost)))
                .UserAgent(userAgent)
                .Build();
            clientCredentialsAuthManager.ApplyGlobalConfiguration(globalConfiguration);

            this.customers = new Lazy<CustomersController>(
                () => new CustomersController(globalConfiguration));
            this.instruments = new Lazy<InstrumentsController>(
                () => new InstrumentsController(globalConfiguration));
            this.specifications = new Lazy<SpecificationsController>(
                () => new SpecificationsController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets CustomersController controller.
        /// </summary>
        public CustomersController CustomersController => this.customers.Value;

        /// <summary>
        /// Gets InstrumentsController controller.
        /// </summary>
        public InstrumentsController InstrumentsController => this.instruments.Value;

        /// <summary>
        /// Gets SpecificationsController controller.
        /// </summary>
        public SpecificationsController SpecificationsController => this.specifications.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets DefaultHost.
        /// DefaultHost value.
        /// </summary>
        public string DefaultHost { get; }


        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        public IClientCredentialsAuth ClientCredentialsAuth => this.clientCredentialsAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the YapstoneOnboardingAPIsClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .DefaultHost(this.DefaultHost)
                .OAuthToken(clientCredentialsAuthManager.OAuthToken)
                .OAuthScopes(clientCredentialsAuthManager.OAuthScopes)
                .ClientCredentialsAuth(clientCredentialsAuthManager.OAuthClientId, clientCredentialsAuthManager.OAuthClientSecret)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"DefaultHost = {this.DefaultHost}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> YapstoneOnboardingAPIsClient.</returns>
        internal static YapstoneOnboardingAPIsClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("YAPSTONE_ONBOARDING_AP_IS_STANDARD_ENVIRONMENT");
            string defaultHost = System.Environment.GetEnvironmentVariable("YAPSTONE_ONBOARDING_AP_IS_STANDARD_DEFAULT_HOST");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("YAPSTONE_ONBOARDING_AP_IS_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("YAPSTONE_ONBOARDING_AP_IS_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (defaultHost != null)
            {
                builder.DefaultHost(defaultHost);
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ClientCredentialsAuth(oAuthClientId, oAuthClientSecret);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = YapstoneOnboardingAPIs.Standard.Environment.Production;
            private string defaultHost = "www.example.com/v3";
            private string oAuthClientId = "";
            private string oAuthClientSecret = "";
            private Models.OAuthToken oAuthToken = null;
            private List<Models.OAuthScopeEnum> oAuthScopes = null;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="oAuthClientId">OAuthClientId.</param>
            /// <param name="oAuthClientSecret">OAuthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder ClientCredentialsAuth(string oAuthClientId, string oAuthClientSecret)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
                return this;
            }

            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oAuthToken">OAuthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthToken(Models.OAuthToken oAuthToken)
            {
                this.oAuthToken = oAuthToken;
                return this;
            }

            /// <summary>
            /// Sets OAuthScopes.
            /// </summary>
            /// <param name="oAuthScopes">OAuthScopes.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthScopes(List<Models.OAuthScopeEnum> oAuthScopes)
            {
                this.oAuthScopes = oAuthScopes;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets DefaultHost.
            /// </summary>
            /// <param name="defaultHost"> DefaultHost. </param>
            /// <returns> Builder. </returns>
            public Builder DefaultHost(string defaultHost)
            {
                this.defaultHost = defaultHost ?? throw new ArgumentNullException(nameof(defaultHost));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Creates an object of the YapstoneOnboardingAPIsClient using the values provided for the builder.
            /// </summary>
            /// <returns>YapstoneOnboardingAPIsClient.</returns>
            public YapstoneOnboardingAPIsClient Build()
            {

                return new YapstoneOnboardingAPIsClient(
                    environment,
                    defaultHost,
                    oAuthClientId,
                    oAuthClientSecret,
                    oAuthToken,
                    oAuthScopes,
                    httpClientConfig.Build());
            }
        }
    }
}
