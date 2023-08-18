
# Country Specification

## Structure

`CountrySpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `DefaultCurrency` | `string` | Optional | - |
| `SupportedInstrumentTypes` | `List<string>` | Optional | - |
| `SupportedInstrumentCurrencies` | `List<string>` | Optional | - |
| `SupportedCapabilities` | [`List<CapabilityTypeEnum>`](../../doc/models/capability-type-enum.md) | Optional | - |
| `RequiredFields` | [`RequiredFields`](../../doc/models/required-fields.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "defaultCurrency": "defaultCurrency4",
  "supportedInstrumentTypes": [
    "supportedInstrumentTypes2",
    "supportedInstrumentTypes3"
  ],
  "supportedInstrumentCurrencies": [
    "supportedInstrumentCurrencies0"
  ],
  "supportedCapabilities": [
    "THREE_D_SECURE"
  ]
}
```

