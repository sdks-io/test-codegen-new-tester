
# Create Instrument Request

## Structure

`CreateInstrumentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Options` | [`InstrumentOptions`](../../doc/models/instrument-options.md) | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `Type` | `string` | Required | - |
| `Currency` | `string` | Required | - |
| `Country` | `string` | Required | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `DisplayName` | `string` | Optional | - |
| `NamesOnAccount` | [`List<NameOnAccount>`](../../doc/models/name-on-account.md) | Required | - |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Details` | `object` | Required | - |

## Example (as JSON)

```json
{
  "type": "type0",
  "currency": "currency0",
  "country": "country4",
  "namesOnAccount": [
    {
      "type": "INDIVIDUAL",
      "name": "name6"
    }
  ],
  "details": {
    "key1": "val1",
    "key2": "val2"
  },
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
  "options": {
    "performVerification": false
  },
  "parent": {
    "type": "MARKETPLACE",
    "id": "id0"
  },
  "displayName": "displayName2"
}
```

