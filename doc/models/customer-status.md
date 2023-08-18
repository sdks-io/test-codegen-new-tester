
# Customer Status

## Structure

`CustomerStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | [`EntityStateEnum?`](../../doc/models/entity-state-enum.md) | Optional | - |
| `DisabledReasons` | `List<string>` | Optional | - |
| `History` | [`List<EntityStatusHistory>`](../../doc/models/entity-status-history.md) | Optional | - |
| `Validation` | [`ValidationStatus`](../../doc/models/validation-status.md) | Optional | - |
| `Verification` | [`VerificationStatus`](../../doc/models/verification-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "state": "USER_DISABLED",
  "disabledReasons": [
    "disabledReasons1",
    "disabledReasons2",
    "disabledReasons3"
  ],
  "history": [
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "state": "ENABLED",
      "disabledReasons": [
        "disabledReasons9"
      ]
    },
    {
      "timestamp": "2016-03-13T12:52:32.123Z",
      "state": "USER_DISABLED",
      "disabledReasons": [
        "disabledReasons8",
        "disabledReasons9",
        "disabledReasons0"
      ]
    }
  ],
  "validation": {
    "state": "INVALID",
    "requiredActions": [
      {
        "field": "field4",
        "errorCode": "errorCode6",
        "message": "message0"
      },
      {
        "field": "field5",
        "errorCode": "errorCode7",
        "message": "message1"
      },
      {
        "field": "field6",
        "errorCode": "errorCode8",
        "message": "message2"
      }
    ]
  },
  "verification": {
    "state": "UNVERIFIED",
    "description": "description4",
    "requiredActions": [
      {
        "code": "code4",
        "description": "description6"
      },
      {
        "code": "code5",
        "description": "description7"
      },
      {
        "code": "code6",
        "description": "description8"
      }
    ],
    "history": [
      {
        "timestamp": "2016-03-13T12:52:32.123Z",
        "state": "IN_PROGRESS",
        "description": "description2",
        "requiredActions": [
          {
            "code": "code8",
            "description": "description0"
          },
          {
            "code": "code9",
            "description": "description1"
          },
          {
            "code": "code0",
            "description": "description2"
          }
        ]
      },
      {
        "timestamp": "2016-03-13T12:52:32.123Z",
        "state": "UNVERIFIED",
        "description": "description1",
        "requiredActions": [
          {
            "code": "code9",
            "description": "description1"
          }
        ]
      },
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
          }
        ]
      }
    ]
  }
}
```

