// <copyright file="WebhookPreferences.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YapstoneOnboardingAPIs.Standard;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// WebhookPreferences.
    /// </summary>
    public class WebhookPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPreferences"/> class.
        /// </summary>
        public WebhookPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPreferences"/> class.
        /// </summary>
        /// <param name="onboardingWebhook">onboardingWebhook.</param>
        /// <param name="onboardingWebhookAuthentication">onboardingWebhookAuthentication.</param>
        public WebhookPreferences(
            string onboardingWebhook = null,
            Models.WebhookAuthenticationPreference onboardingWebhookAuthentication = null)
        {
            this.OnboardingWebhook = onboardingWebhook;
            this.OnboardingWebhookAuthentication = onboardingWebhookAuthentication;
        }

        /// <summary>
        /// Client supplied URL that will be notified for all onboarding events.
        /// </summary>
        [JsonProperty("onboardingWebhook", NullValueHandling = NullValueHandling.Ignore)]
        public string OnboardingWebhook { get; set; }

        /// <summary>
        /// Gets or sets OnboardingWebhookAuthentication.
        /// </summary>
        [JsonProperty("onboardingWebhookAuthentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookAuthenticationPreference OnboardingWebhookAuthentication { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WebhookPreferences : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is WebhookPreferences other &&                ((this.OnboardingWebhook == null && other.OnboardingWebhook == null) || (this.OnboardingWebhook?.Equals(other.OnboardingWebhook) == true)) &&
                ((this.OnboardingWebhookAuthentication == null && other.OnboardingWebhookAuthentication == null) || (this.OnboardingWebhookAuthentication?.Equals(other.OnboardingWebhookAuthentication) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OnboardingWebhook = {(this.OnboardingWebhook == null ? "null" : this.OnboardingWebhook)}");
            toStringOutput.Add($"this.OnboardingWebhookAuthentication = {(this.OnboardingWebhookAuthentication == null ? "null" : this.OnboardingWebhookAuthentication.ToString())}");
        }
    }
}