
# Payment Method Specification

## Structure

`PaymentMethodSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `SupportedCurrencies` | `List<string>` | Optional | ISO 4217 currency code. |
| `RequiredFields` | `List<string>` | Optional | - |
| `Details` | [`List<FieldSpecification>`](../../doc/models/field-specification.md) | Optional | Describes payment method specific details, accepted in the payment request. |
| `Actions` | [`List<FieldSpecification>`](../../doc/models/field-specification.md) | Optional | Describes action fields returned in the payment response. |
| `SupportedInstrumentTypes` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
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
  ],
  "details": [
    {
      "field": "field9",
      "type": "DURATION",
      "description": "description5",
      "displayName": "displayName3",
      "required": true
    },
    {
      "field": "field0",
      "type": "DATE_YEAR",
      "description": "description6",
      "displayName": "displayName4",
      "required": false
    },
    {
      "field": "field1",
      "type": "DATE_YEAR_MONTH",
      "description": "description7",
      "displayName": "displayName5",
      "required": true
    }
  ]
}
```

