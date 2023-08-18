
# Merchant

## Structure

`Merchant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Type` | [`MerchantTypeEnum?`](../../doc/models/merchant-type-enum.md) | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Timezone` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `DefaultLanguage` | `string` | Optional | - |
| `LegalEntity` | [`LegalEntity`](../../doc/models/legal-entity.md) | Optional | - |
| `VolumeProjection` | [`MerchantVolumeProjection`](../../doc/models/merchant-volume-projection.md) | Optional | - |
| `Consents` | [`List<Consent>`](../../doc/models/consent.md) | Optional | - |
| `Capabilities` | [`Capabilities`](../../doc/models/capabilities.md) | Optional | - |
| `Preferences` | [`MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | - |
| `Status` | [`EntityStatus`](../../doc/models/entity-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "created": "2016-03-13T12:52:32.123Z",
  "updated": "2016-03-13T12:52:32.123Z",
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
  }
}
```

