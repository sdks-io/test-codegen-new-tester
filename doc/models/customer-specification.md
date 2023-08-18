
# Customer Specification

## Structure

`CustomerSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`LegalEntityTypeEnum?`](../../doc/models/legal-entity-type-enum.md) | Optional | - |
| `Country` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `CommerceType` | `string` | Optional | - |
| `RequiredFields` | `List<string>` | Optional | - |
| `Additional` | [`List<FieldSpecification>`](../../doc/models/field-specification.md) | Optional | - |
| `IdentityDocuments` | [`List<RequiredIdentityDocuments>`](../../doc/models/required-identity-documents.md) | Optional | A list of required identity documents, each entity in the list should be considered as an OR condition. Only a single entry need be satisfied. |

## Example (as JSON)

```json
{
  "type": "INDIVIDUAL",
  "country": "country4",
  "commerceType": "commerceType0",
  "requiredFields": [
    "requiredFields0"
  ],
  "additional": [
    {
      "field": "field3",
      "type": "DATE_TIME",
      "description": "description9",
      "displayName": "displayName7",
      "required": true
    },
    {
      "field": "field4",
      "type": "STRING",
      "description": "description0",
      "displayName": "displayName8",
      "required": false
    },
    {
      "field": "field5",
      "type": "INTEGER",
      "description": "description1",
      "displayName": "displayName9",
      "required": true
    }
  ]
}
```

