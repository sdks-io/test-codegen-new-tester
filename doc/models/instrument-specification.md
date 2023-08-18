
# Instrument Specification

## Structure

`InstrumentSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | ISO 3166-1 alpha-2 or alpha-3 country codes. |
| `SupportedCurrencies` | `List<string>` | Optional | - |
| `RequiredFields` | `List<string>` | Optional | - |
| `Details` | [`List<FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `Fingerprints` | [`List<FingerprintSpecification>`](../../doc/models/fingerprint-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "displayName": "displayName2",
  "supportedCountries": [
    "supportedCountries8",
    "supportedCountries9",
    "supportedCountries0"
  ],
  "supportedCurrencies": [
    "supportedCurrencies4",
    "supportedCurrencies5",
    "supportedCurrencies6"
  ],
  "requiredFields": [
    "requiredFields0"
  ]
}
```

