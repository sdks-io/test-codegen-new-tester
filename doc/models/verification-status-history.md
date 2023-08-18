
# Verification Status History

## Structure

`VerificationStatusHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime?` | Optional | - |
| `State` | [`VerificationStateEnum?`](../../doc/models/verification-state-enum.md) | Optional | - |
| `Description` | `string` | Optional | - |
| `RequiredActions` | [`List<VerificationAction>`](../../doc/models/verification-action.md) | Optional | - |

## Example (as JSON)

```json
{
  "timestamp": "2016-03-13T12:52:32.123Z",
  "state": "DECLINED",
  "description": "description0",
  "requiredActions": [
    {
      "code": "code0",
      "description": "description2"
    },
    {
      "code": "code1",
      "description": "description3"
    },
    {
      "code": "code2",
      "description": "description4"
    }
  ]
}
```

