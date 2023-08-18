
# Identity Document Specification Page

## Structure

`IdentityDocumentSpecificationPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | - |
| `Results` | [`List<IdentityDocumentSpecification>`](../../doc/models/identity-document-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "meta": {
    "offset": 222,
    "size": 28
  },
  "results": [
    {
      "name": "name3",
      "displayName": "displayName9",
      "types": [
        "INDIVIDUAL",
        "BUSINESS",
        "INDIVIDUAL"
      ],
      "supportedCountries": [
        "supportedCountries5",
        "supportedCountries6",
        "supportedCountries7"
      ],
      "details": [
        {
          "field": "field2",
          "type": "DATE_YEAR_MONTH_DAY",
          "description": "description8",
          "displayName": "displayName6",
          "required": false
        },
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
        }
      ]
    }
  ]
}
```

