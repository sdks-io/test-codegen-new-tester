
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `DefaultHost` | `string` | *Default*: `"www.example.com/v3"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `OAuthClientId` | `string` | OAuth 2 Client ID |
| `OAuthClientSecret` | `string` | OAuth 2 Client Secret |
| `OAuthToken` | `Models.OAuthToken` | Object for storing information about the OAuth token |
| `OAuthScopes` | `List<Models.OAuthScopeEnum>` |  |

The API client can be initialized as follows:

```csharp
YapstoneOnboardingAPIs.Standard.YapstoneOnboardingAPIsClient client = new YapstoneOnboardingAPIs.Standard.YapstoneOnboardingAPIsClient.Builder()
    .OAuthScopes(new List<OAuthScopeEnum>() { OAuthScopeEnum.Test })
    .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
    .Environment(YapstoneOnboardingAPIs.Standard.Environment.Production)
    .DefaultHost("www.example.com/v3")
    .Build();
```

## Yapstone Onboarding APIsClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| CustomersController | Gets CustomersController controller. |
| InstrumentsController | Gets InstrumentsController controller. |
| SpecificationsController | Gets SpecificationsController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Auth | Gets the AuthManager. | `AuthManager` |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| DefaultHost | DefaultHost value. | `string` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Yapstone Onboarding APIsClient using the values provided for the builder. | `Builder` |

## Yapstone Onboarding APIsClient Builder Class

Class to build instances of Yapstone Onboarding APIsClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |

