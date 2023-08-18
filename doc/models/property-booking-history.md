
# Property Booking History

## Structure

`PropertyBookingHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActiveSince` | `DateTime?` | Optional | - |
| `ChargeCount` | `int?` | Optional | - |
| `ChargebackCount` | `int?` | Optional | - |
| `ChargeVolume` | [`Money`](../../doc/models/money.md) | Optional | - |
| `ChargebackVolume` | [`Money`](../../doc/models/money.md) | Optional | - |

## Example (as JSON)

```json
{
  "activeSince": "2016-03-13",
  "chargeCount": 184,
  "chargebackCount": 142,
  "chargeVolume": {
    "currency": "currency4",
    "value": 184
  },
  "chargebackVolume": {
    "currency": "currency8",
    "value": 112
  }
}
```

