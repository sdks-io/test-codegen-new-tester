
# Base Type 2

## Structure

`BaseType2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `DisplayName` | `string` | Optional | - |
| `Capabilities` | [`Capabilities`](../../doc/models/capabilities.md) | Optional | - |
| `Preferences` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "type": "BaseType2",
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
  }
}
```

