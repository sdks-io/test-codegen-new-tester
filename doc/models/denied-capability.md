
# Denied Capability

## Structure

`DeniedCapability`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`CapabilityTypeEnum`](../../doc/models/capability-type-enum.md) | Required | - |
| `Reasons` | `List<string>` | Optional | - |
| `RequiredActions` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "type": "PAYOUT",
  "reasons": [
    "reasons7",
    "reasons8",
    "reasons9"
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
}
```

