# Specifications

```csharp
SpecificationsController specificationsController = client.SpecificationsController;
```

## Class Name

`SpecificationsController`

## Methods

* [Get Customer Specifications](../../doc/controllers/specifications.md#get-customer-specifications)
* [Get Instrument Specifications](../../doc/controllers/specifications.md#get-instrument-specifications)
* [Get Instrument Specification](../../doc/controllers/specifications.md#get-instrument-specification)
* [Get Identity Document Specifications](../../doc/controllers/specifications.md#get-identity-document-specifications)
* [Get Identity Document Specification](../../doc/controllers/specifications.md#get-identity-document-specification)
* [Get Payment Method Specifications](../../doc/controllers/specifications.md#get-payment-method-specifications)
* [Get Payment Method Specification](../../doc/controllers/specifications.md#get-payment-method-specification)


# Get Customer Specifications

```csharp
GetCustomerSpecificationsAsync(
    string type = null,
    string country = null,
    string commerceType = null,
    int? offset = 0,
    int? limit = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string` | Query, Optional | Filter by `type`. |
| `country` | `string` | Query, Optional | Filter by `country`. |
| `commerceType` | `string` | Query, Optional | Filter by `commerceType`. |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |

## Response Type

[`Task<Models.CustomerSpecificationPage>`](../../doc/models/customer-specification-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    CustomerSpecificationPage result = await specificationsController.GetCustomerSpecificationsAsync(null, null, null, offset, limit);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Instrument Specifications

```csharp
GetInstrumentSpecificationsAsync(
    string country = null,
    string currency = null,
    int? offset = 0,
    int? limit = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `country` | `string` | Query, Optional | Filter by `country`. |
| `currency` | `string` | Query, Optional | Filter by `currency`. |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |

## Response Type

[`Task<Models.InstrumentSpecificationPage>`](../../doc/models/instrument-specification-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    InstrumentSpecificationPage result = await specificationsController.GetInstrumentSpecificationsAsync(null, null, offset, limit);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Instrument Specification

```csharp
GetInstrumentSpecificationAsync(
    string name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Template, Required | - |

## Response Type

[`Task<Models.InstrumentSpecification>`](../../doc/models/instrument-specification.md)

## Example Usage

```csharp
string name = "name0";
try
{
    InstrumentSpecification result = await specificationsController.GetInstrumentSpecificationAsync(name);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Get Identity Document Specifications

```csharp
GetIdentityDocumentSpecificationsAsync(
    string type = null,
    string country = null,
    int? offset = 0,
    int? limit = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string` | Query, Optional | Filter by `type`. |
| `country` | `string` | Query, Optional | Filter by `country`. |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |

## Response Type

[`Task<Models.IdentityDocumentSpecificationPage>`](../../doc/models/identity-document-specification-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    IdentityDocumentSpecificationPage result = await specificationsController.GetIdentityDocumentSpecificationsAsync(null, null, offset, limit);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Identity Document Specification

```csharp
GetIdentityDocumentSpecificationAsync(
    string name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Template, Required | - |

## Response Type

[`Task<Models.IdentityDocumentSpecification>`](../../doc/models/identity-document-specification.md)

## Example Usage

```csharp
string name = "name0";
try
{
    IdentityDocumentSpecification result = await specificationsController.GetIdentityDocumentSpecificationAsync(name);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Get Payment Method Specifications

```csharp
GetPaymentMethodSpecificationsAsync(
    string currency = null,
    string country = null,
    int? offset = 0,
    int? limit = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `currency` | `string` | Query, Optional | Filter by `currency`. |
| `country` | `string` | Query, Optional | Filter by `country`. |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |

## Response Type

[`Task<Models.PaymentMethodSpecificationPage>`](../../doc/models/payment-method-specification-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    PaymentMethodSpecificationPage result = await specificationsController.GetPaymentMethodSpecificationsAsync(null, null, offset, limit);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Payment Method Specification

```csharp
GetPaymentMethodSpecificationAsync(
    string name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Template, Required | - |

## Response Type

[`Task<Models.PaymentMethodSpecification>`](../../doc/models/payment-method-specification.md)

## Example Usage

```csharp
string name = "name0";
try
{
    PaymentMethodSpecification result = await specificationsController.GetPaymentMethodSpecificationAsync(name);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | [`ErrorsException`](../../doc/models/errors-exception.md) |

