# Customers

```csharp
CustomersController customersController = client.CustomersController;
```

## Class Name

`CustomersController`

## Methods

* [Get Customers](../../doc/controllers/customers.md#get-customers)
* [Create Customer](../../doc/controllers/customers.md#create-customer)
* [Get Customer](../../doc/controllers/customers.md#get-customer)
* [Update Customer](../../doc/controllers/customers.md#update-customer)
* [Delete Customer](../../doc/controllers/customers.md#delete-customer)
* [Verify Customer](../../doc/controllers/customers.md#verify-customer)


# Get Customers

Retrieve all Customers.

```csharp
GetCustomersAsync(
    int? offset = 0,
    int? limit = 20,
    string correlationRefLabel = null,
    string correlationRefValue = null,
    string marketplaceId = null,
    string merchantId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `offset` | `int?` | Query, Optional | Offset the list of returned results by this amount. Default is `0`.<br>**Default**: `0` |
| `limit` | `int?` | Query, Optional | Number of items to retrieve.<br>**Default**: `20` |
| `correlationRefLabel` | `string` | Query, Optional | Filter by `correlationRef.label`. |
| `correlationRefValue` | `string` | Query, Optional | Filter by `correlationRef.value`. |
| `marketplaceId` | `string` | Query, Optional | Filter by `marketplaceId`. |
| `merchantId` | `string` | Query, Optional | Filter by `merchantId`. |

## Response Type

[`Task<Models.CustomerPage>`](../../doc/models/customer-page.md)

## Example Usage

```csharp
int? offset = 0;
int? limit = 20;
try
{
    CustomerPage result = await customersController.GetCustomersAsync(offset, limit, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Customer

Create a Customer.

```csharp
CreateCustomerAsync(
    Models.CreateCustomerRequest request,
    string xYapStoneIdempotentKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.Customer>`](../../doc/models/customer.md)

## Example Usage

```csharp
CreateCustomerRequest request = new CreateCustomerRequest
{
    Country = "country0",
    LegalEntity = new LegalEntity
    {
        Type = "LegalEntity",
    },
};

try
{
    Customer result = await customersController.CreateCustomerAsync(request, null);
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


# Get Customer

Retrieve a Customer by id.

```csharp
GetCustomerAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Customer>`](../../doc/models/customer.md)

## Example Usage

```csharp
string id = "id0";
try
{
    Customer result = await customersController.GetCustomerAsync(id);
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


# Update Customer

Update a Customer by id.

```csharp
UpdateCustomerAsync(
    string id,
    Models.UpdateCustomerRequest request,
    string xYapStoneIdempotentKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`UpdateCustomerRequest`](../../doc/models/update-customer-request.md) | Body, Required | - |
| `xYapStoneIdempotentKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.Customer>`](../../doc/models/customer.md)

## Example Usage

```csharp
string id = "id0";
UpdateCustomerRequest request = new UpdateCustomerRequest
{
    Country = "country0",
    LegalEntity = new LegalEntity
    {
        Type = "LegalEntity",
    },
};

try
{
    Customer result = await customersController.UpdateCustomerAsync(id, request, null);
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


# Delete Customer

Delete a Customer by id.

```csharp
DeleteCustomerAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Customer>`](../../doc/models/customer.md)

## Example Usage

```csharp
string id = "id0";
try
{
    Customer result = await customersController.DeleteCustomerAsync(id);
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


# Verify Customer

Perform verification of a Customers supplied details.

```csharp
VerifyCustomerAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

[`Task<Models.Customer>`](../../doc/models/customer.md)

## Example Usage

```csharp
string id = "id0";
try
{
    Customer result = await customersController.VerifyCustomerAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

