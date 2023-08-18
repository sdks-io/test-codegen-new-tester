# Instruments

```csharp
InstrumentsController instrumentsController = client.InstrumentsController;
```

## Class Name

`InstrumentsController`

## Methods

* [Get Instruments](../../doc/controllers/instruments.md#get-instruments)
* [Create Instrument](../../doc/controllers/instruments.md#create-instrument)
* [Get Instrument](../../doc/controllers/instruments.md#get-instrument)
* [Update Instrument](../../doc/controllers/instruments.md#update-instrument)
* [Delete Instrument](../../doc/controllers/instruments.md#delete-instrument)
* [Verify Instrument](../../doc/controllers/instruments.md#verify-instrument)


# Get Instruments

Retrieve all Instruments.

```csharp
GetInstrumentsAsync(
    int? offset = 0,
    int? limit = 20,
    string marketplaceId = null,
    string merchantId = null,
    string customerId = null,
    string correlationRefLabel = null,
    string correlationRefValue = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |
| `marketplaceId` | `string` | Query, Optional | Filter by `marketplaceId`. |
| `merchantId` | `string` | Query, Optional | Filter by `merchantId`. |
| `customerId` | `string` | Query, Optional | Filter by `customerId`. |
| `correlationRefLabel` | `string` | Query, Optional | Filter by `correlationRef.label`. |
| `correlationRefValue` | `string` | Query, Optional | Filter by `correlationRef.value`. |

## Response Type

[`Task<Models.InstrumentPage>`](../../doc/models/instrument-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    InstrumentPage result = await instrumentsController.GetInstrumentsAsync(offset, limit, null, null, null, null, null);
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
| 400 | Bad Request | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Create Instrument

Create an Instrument.

```csharp
CreateInstrumentAsync(
    Models.CreateInstrumentRequest request,
    string xYapStoneIdempotentKey = null,
    Dictionary<string, string> metadata = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`CreateInstrumentRequest`](../../doc/models/create-instrument-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |
| `metadata` | `Dictionary<string, string>` | Query, Optional | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
CreateInstrumentRequest request = new CreateInstrumentRequest
{
    Type = "type4",
    Currency = "currency6",
    Country = "country0",
    NamesOnAccount = new List<Models.NameOnAccount>
    {
        new NameOnAccount
        {
            Type = LegalEntityTypeEnum.INDIVIDUAL,
            Name = "name2",
        },
    },
    Details = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};

try
{
    Instrument result = await instrumentsController.CreateInstrumentAsync(request, null, null);
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
| 409 | Conflict | [`ErrorsException`](../../doc/models/errors-exception.md) |
| 422 | Unprocessable Entity | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Get Instrument

Retrieve an Instrument by id.

```csharp
GetInstrumentAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
try
{
    Instrument result = await instrumentsController.GetInstrumentAsync(id);
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


# Update Instrument

Update an Instrument by id.

```csharp
UpdateInstrumentAsync(
    string id,
    Models.UpdateInstrumentRequest request,
    string xYapStoneIdempotentKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`UpdateInstrumentRequest`](../../doc/models/update-instrument-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
UpdateInstrumentRequest request = new UpdateInstrumentRequest
{
    Type = "type4",
    Currency = "currency6",
    Country = "country0",
    NamesOnAccount = new List<Models.NameOnAccount>
    {
        new NameOnAccount
        {
            Type = LegalEntityTypeEnum.INDIVIDUAL,
            Name = "name2",
        },
    },
    Details = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};

try
{
    Instrument result = await instrumentsController.UpdateInstrumentAsync(id, request, null);
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
| 409 | Conflict | [`ErrorsException`](../../doc/models/errors-exception.md) |
| 422 | Unprocessable Entity | [`ErrorsException`](../../doc/models/errors-exception.md) |


# Delete Instrument

Delete an Instrument by id.

```csharp
DeleteInstrumentAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
try
{
    Instrument result = await instrumentsController.DeleteInstrumentAsync(id);
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


# Verify Instrument

Request verification of an Instrument by id.

```csharp
VerifyInstrumentAsync(
    string id,
    Models.VerifyInstrumentRequest request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`VerifyInstrumentRequest`](../../doc/models/verify-instrument-request.md) | Body, Required | - |

## Response Type

[`Task<Models.Instrument>`](../../doc/models/instrument.md)

## Example Usage

```csharp
string id = "id0";
VerifyInstrumentRequest request = new VerifyInstrumentRequest
{
};

try
{
    Instrument result = await instrumentsController.VerifyInstrumentAsync(id, request);
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

