
# Create Customer Request

## Structure

`CreateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | If not supplied, derived from the legal entity name. |
| `Country` | `string` | Required | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `Timezone` | `string` | Optional | Time Zone ID. If not supplied will be derived from the `country` usually the capital city. |
| `DefaultCurrency` | `string` | Optional | Default currency for this customer, if not supplied derived from the `country`. |
| `DefaultLanguage` | `string` | Optional | Default language for this customer, if not supplied derived from the `country`. |
| `LegalEntity` | [`LegalEntity`](../../doc/models/legal-entity.md) | Required | - |
| `Options` | [`CustomerOptions`](../../doc/models/customer-options.md) | Optional | - |

## Example (as JSON)

```json
{
  "correlationRefs": [
    {
      "label": "label7",
      "value": "value9"
    }
  ],
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "parent": {
    "type": "MARKETPLACE",
    "id": "id0"
  },
  "displayName": "displayName2",
  "country": "country4",
  "timezone": "timezone0",
  "legalEntity": {
    "type": "LegalEntity",
    "address": {
      "line1": "line16",
      "line2": "line28",
      "line3": "line36",
      "line4": "line48",
      "city": "city4"
    },
    "phone": {
      "number": "number0",
      "extension": "extension8"
    },
    "email": "email8",
    "website": "website6"
  }
}
```

