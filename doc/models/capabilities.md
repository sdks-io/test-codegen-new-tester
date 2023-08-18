
# Capabilities

## Structure

`Capabilities`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Granted` | [`List<Capability>`](../../doc/models/capability.md) | Optional | - |
| `Denied` | [`List<DeniedCapability>`](../../doc/models/denied-capability.md) | Optional | - |

## Example (as JSON)

```json
{
  "granted": [
    {
      "type": "Capability"
    }
  ],
  "denied": [
    {
      "type": "DIRECT_DEBT",
      "reasons": [
        "reasons5",
        "reasons6",
        "reasons7"
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
        "reasons6"
      ],
      "requiredActions": [
        {
          "key1": "val1",
          "key2": "val2"
        }
      ]
    }
  ]
}
```

