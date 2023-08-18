
# Risk Status History

## Structure

`RiskStatusHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTime?` | Optional | - |
| `Decision` | [`RiskDecisionEnum?`](../../doc/models/risk-decision-enum.md) | Optional | - |
| `DeclinedReasons` | `List<string>` | Optional | - |
| `RequiredActions` | [`List<RiskRequiredAction>`](../../doc/models/risk-required-action.md) | Optional | - |

## Example (as JSON)

```json
{
  "timestamp": "2016-03-13T12:52:32.123Z",
  "decision": "APPROVED",
  "declinedReasons": [
    "declinedReasons7"
  ],
  "requiredActions": [
    {
      "actionCode": "actionCode0",
      "message": "message2"
    },
    {
      "actionCode": "actionCode1",
      "message": "message3"
    },
    {
      "actionCode": "actionCode2",
      "message": "message4"
    }
  ]
}
```

