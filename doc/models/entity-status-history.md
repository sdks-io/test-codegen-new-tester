
# Entity Status History

## Structure

`EntityStatusHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime?` | Optional | - |
| `State` | [`EntityStateEnum?`](../../doc/models/entity-state-enum.md) | Optional | - |
| `DisabledReasons` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "timestamp": "2016-03-13T12:52:32.123Z",
  "state": "USER_DISABLED",
  "disabledReasons": [
    "disabledReasons1",
    "disabledReasons2",
    "disabledReasons3"
  ]
}
```

