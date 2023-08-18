
# Risk Status

## Structure

`RiskStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Decision` | [`RiskDecisionEnum?`](../../doc/models/risk-decision-enum.md) | Optional | - |
| `DeclinedReasons` | `List<string>` | Optional | - |
| `RequiredActions` | [`List<RiskRequiredAction>`](../../doc/models/risk-required-action.md) | Optional | - |
| `History` | [`List<RiskStatusHistory>`](../../doc/models/risk-status-history.md) | Optional | - |

## Example (as JSON)

```json
{
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
  ],
  "history": [
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "decision": "APPROVED",
      "declinedReasons": [
        "declinedReasons9",
        "declinedReasons0",
        "declinedReasons1"
      ],
      "requiredActions": [
        {
          "actionCode": "actionCode2",
          "message": "message4"
        },
        {
          "actionCode": "actionCode3",
          "message": "message5"
        }
      ]
    },
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "decision": "UNDER_REVIEW",
      "declinedReasons": [
        "declinedReasons0"
      ],
      "requiredActions": [
        {
          "actionCode": "actionCode3",
          "message": "message5"
        },
        {
          "actionCode": "actionCode4",
          "message": "message6"
        },
        {
          "actionCode": "actionCode5",
          "message": "message7"
        }
      ]
    }
  ]
}
```

