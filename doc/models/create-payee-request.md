
# Create Payee Request

## Structure

`CreatePayeeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`LegalEntity`](../../doc/models/legal-entity.md) | Optional | - |
| `Preferences` | `object` | Optional | - |

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
  "country": "country4"
}
```

