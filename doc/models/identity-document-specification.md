
# Identity Document Specification

## Structure

`IdentityDocumentSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Types` | [`List<LegalEntityTypeEnum>`](../../doc/models/legal-entity-type-enum.md) | Optional | - |
| `SupportedCountries` | `List<string>` | Optional | - |
| `Details` | [`List<FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `Fingerprints` | [`List<FingerprintSpecification>`](../../doc/models/fingerprint-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "displayName": "displayName2",
  "types": [
    "BUSINESS",
    "INDIVIDUAL",
    "BUSINESS"
  ],
  "supportedCountries": [
    "supportedCountries8",
    "supportedCountries9",
    "supportedCountries0"
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

