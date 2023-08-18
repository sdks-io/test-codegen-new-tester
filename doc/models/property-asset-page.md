
# Property Asset Page

## Structure

`PropertyAssetPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | - |
| `Results` | [`List<PropertyAsset>`](../../doc/models/property-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "meta": {
    "offset": 222,
    "size": 28
  },
  "results": [
    {
      "type": "PropertyAsset",
      "parent": {
        "type": "MERCHANT",
        "id": "id4"
      },
      "displayName": "displayName6",
      "capabilities": {
        "granted": [
          {
            "type": "Capability"
          }
        ],
        "denied": [
          {
            "type": "DIRECT_DEBT",
            "reasons": [
              "reasons3",
              "reasons4",
              "reasons5"
            ],
            "requiredActions": [
              {
                "key1": "val1",
                "key2": "val2"
              },
              {
                "key1": "val1",
                "key2": "val2"
              },
              {
                "key1": "val1",
                "key2": "val2"
              }
            ]
          },
          {
            "type": "CHARGE",
            "reasons": [
              "reasons4"
            ],
            "requiredActions": [
              {
                "key1": "val1",
                "key2": "val2"
              }
            ]
          }
        ]
      },
      "preferences": {
        "key1": "val1",
        "key2": "val2"
      },
      "id": "id6",
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "correlationRefs": [
        {
          "label": "label3",
          "value": "value5"
        }
      ],
      "metadata": {
        "key0": "metadata7",
        "key1": "metadata8",
        "key2": "metadata9"
      },
      "name": "name3",
      "address": {
        "line1": "line11",
        "line2": "line23",
        "line3": "line31",
        "line4": "line43",
        "city": "city9"
      },
      "details": {
        "capacity": 241,
        "bedroomCount": 167,
        "bathroomCount": 85,
        "amenities": [
          "amenities8",
          "amenities9",
          "amenities0"
        ]
      },
      "rating": {
        "score": 137.21,
        "rating": 169.89,
        "ratingCount": 131,
        "inquiryCount": 141,
        "complaintCount": 211
      }
    }
  ]
}
```

