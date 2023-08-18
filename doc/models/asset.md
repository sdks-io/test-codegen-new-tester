
# Asset

## Structure

`Asset`

## Inherits From

[`BaseType2`](../../doc/models/base-type-2.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |

## Example (as JSON)

```json
{
  "type": "Asset",
  "parent": {
    "type": "MARKETPLACE",
    "id": "id0"
  },
  "displayName": "displayName2",
  "capabilities": {
    "granted": [
      {
        "type": "Capability"
      }
    ],
    "denied": [
      {
        "type": "PAYOUT",
        "reasons": [
          "reasons9",
          "reasons0",
          "reasons1"
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
        "type": "THREE_D_SECURE",
        "reasons": [
          "reasons0"
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

