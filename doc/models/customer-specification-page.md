
# Customer Specification Page

## Structure

`CustomerSpecificationPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | - |
| `Results` | [`List<CustomerSpecification>`](../../doc/models/customer-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "meta": {
    "offset": 222,
    "size": 28
  },
  "results": [
    {
      "type": "BUSINESS",
      "country": "country7",
      "commerceType": "commerceType7",
      "requiredFields": [
        "requiredFields7"
      ],
      "additional": [
        {
          "field": "field6",
          "type": "DECIMAL",
          "description": "description2",
          "displayName": "displayName0",
          "required": false
        },
        {
          "field": "field7",
          "type": "BOOLEAN",
          "description": "description3",
          "displayName": "displayName1",
          "required": true
        },
        {
          "field": "field8",
          "type": "ENUMERATION",
          "description": "description4",
          "displayName": "displayName2",
          "required": false
        }
      ]
    }
  ]
}
```

