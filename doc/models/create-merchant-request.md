
# Create Merchant Request

## Structure

`CreateMerchantRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Type` | [`MerchantTypeEnum`](../../doc/models/merchant-type-enum.md) | Required | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`LegalEntityRequest`](../../doc/models/legal-entity-request.md) | Optional | - |
| `Consents` | [`List<Consent>`](../../doc/models/consent.md) | Optional | - |
| `Preferences` | [`MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | - |

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
  "type": "MERCHANT",
  "displayName": "displayName2",
  "country": "country4",
  "timezone": "timezone0"
}
```

