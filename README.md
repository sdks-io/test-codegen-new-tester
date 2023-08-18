
# Getting Started with Yapstone Onboarding APIs

## Introduction

APIs for onboarding and managing merchants, customers, instruments, assets, offerings and fees.

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (YapstoneOnboardingAPIs.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the YapstoneOnboardingAPIs.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `YapstoneOnboardingAPIs.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `YapstoneOnboardingAPIs.Standard` and click `OK`. By doing this, we have added a reference of the `YapstoneOnboardingAPIs.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Yapstone%20Onboarding%20APIs-CSharp&workspaceName=YapstoneOnboardingAPIs&projectName=YapstoneOnboardingAPIs.Standard&rootNamespace=YapstoneOnboardingAPIs.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

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

## Authorization

This API uses `OAuth 2 Client Credentials Grant`.

## Client Credentials Grant

Your application must obtain user authorization before it can execute an endpoint call in case this SDK chooses to use *OAuth 2.0 Client Credentials Grant*. This authorization includes the following steps

The `FetchToken()` method will exchange the OAuth client credentials for an *access token*. The access token is an object containing information for authorizing client requests and refreshing the token itself.

You must have initialized the client with [scopes]($h/__authorize/Scopes) for which you need permission to access.

```csharp
var authManager = client.ClientCredentialsAuth;

try
{
    OAuthToken token = authManager.FetchToken();
    // re-instantiate the client with OAuth token
    client = client.ToBuilder().OAuthToken(token).Build();
}
catch (ApiException e)
{
    // TODO Handle exception
}
```

The client can now make authorized endpoint calls.

### Scopes

Scopes enable your application to only request access to the resources it needs while enabling users to control the amount of access they grant to your application. Available scopes are defined in the `OAuthScopeEnum` enumeration.

| Scope Name | Description |
|  --- | --- |
| `TEST` | test |

### Storing an access token for reuse

It is recommended that you store the access token for reuse.

```csharp
// store token
SaveTokenToDatabase(client.ClientCredentialsAuth.OAuthToken);
```

### Creating a client from a stored token

To authorize a client from a stored access token, just set the access token in Configuration along with the other configuration parameters before creating the client:

```csharp
// load token later
OAuthToken token = LoadTokenFromDatabase();

// Provide token along with other configuration properties while instantiating the client
YapstoneOnboardingAPIsClient client = client.ToBuilder().OAuthToken(token).Build();
```

### Complete example

```csharp
using YapstoneOnboardingAPIs.Standard;
using YapstoneOnboardingAPIs.Standard.Models;
using YapstoneOnboardingAPIs.Standard.Exceptions;
using YapstoneOnboardingAPIs.Standard.Authentication;
using System.Collections.Generic;
namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            YapstoneOnboardingAPIs.Standard.YapstoneOnboardingAPIsClient client = new YapstoneOnboardingAPIs.Standard.YapstoneOnboardingAPIsClient.Builder()
                .OAuthScopes(new List<OAuthScopeEnum>() { OAuthScopeEnum.Test })
                .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
                .Environment(YapstoneOnboardingAPIs.Standard.Environment.Production)
                .DefaultHost("www.example.com/v3")
                .Build();
            try
            {
                OAuthToken token = LoadTokenFromDatabase();

                // Set the token if it is not set before
                if (token == null)
                {
                    var authManager = client.ClientCredentialsAuth;
                    token = authManager.FetchToken();
                }

                SaveTokenToDatabase(token);
                client = client.ToBuilder().OAuthToken(token).Build();
            }
            catch (OAuthProviderException e)
            {
                // TODO Handle exception
            }
        }

        //function for storing token to database
        static void SaveTokenToDatabase(OAuthToken token)
        {
            //Save token here
        }

        //function for loading token from database
        static OAuthToken LoadTokenFromDatabase()
        {
            OAuthToken token = null;
            //token = Get token here
            return token;
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```

## List of APIs

* [O Auth Authorization](doc/controllers/o-auth-authorization.md)
* [Customers](doc/controllers/customers.md)
* [Instruments](doc/controllers/instruments.md)
* [Specifications](doc/controllers/specifications.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

