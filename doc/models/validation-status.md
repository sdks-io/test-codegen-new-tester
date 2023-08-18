
# Validation Status

## Structure

`ValidationStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | [`StateEnum?`](../../doc/models/state-enum.md) | Optional | - |
| `RequiredActions` | [`List<ValidationAction>`](../../doc/models/validation-action.md) | Optional | - |

## Example (as JSON)

```json
{
  "state": "INVALID",
  "requiredActions": [
    {
      "field": "field6",
      "errorCode": "errorCode8",
      "message": "message2"
    },
    {
      "field": "field7",
      "errorCode": "errorCode9",
      "message": "message3"
    },
    {
      "field": "field8",
      "errorCode": "errorCode0",
      "message": "message4"
    }
  ]
}
```

