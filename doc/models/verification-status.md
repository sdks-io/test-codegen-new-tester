
# Verification Status

## Structure

`VerificationStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | [`VerificationStateEnum?`](../../doc/models/verification-state-enum.md) | Optional | - |
| `Description` | `string` | Optional | - |
| `RequiredActions` | [`List<VerificationAction>`](../../doc/models/verification-action.md) | Optional | - |
| `History` | [`List<VerificationStatusHistory>`](../../doc/models/verification-status-history.md) | Optional | - |

## Example (as JSON)

```json
{
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
  ],
  "history": [
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "state": "ACTION_REQUIRED",
      "description": "description8",
      "requiredActions": [
        {
          "code": "code2",
          "description": "description4"
        },
        {
          "code": "code3",
          "description": "description5"
        }
      ]
    },
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "state": "IN_PROGRESS",
      "description": "description7",
      "requiredActions": [
        {
          "code": "code3",
          "description": "description5"
        },
        {
          "code": "code4",
          "description": "description6"
        },
        {
          "code": "code5",
          "description": "description7"
        }
      ]
    }
  ]
}
```

