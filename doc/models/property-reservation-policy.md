
# Property Reservation Policy

## Structure

`PropertyReservationPolicy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckIn` | `DateTime?` | Optional | - |
| `CheckOut` | `DateTime?` | Optional | - |
| `MinStayDays` | `int?` | Optional | - |
| `MaxStayDays` | `int?` | Optional | - |
| `CancellationPolicy` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "checkIn": "2016-03-13T12:52:32.123Z",
  "checkOut": "2016-03-13T12:52:32.123Z",
  "minStayDays": 30,
  "maxStayDays": 120,
  "cancellationPolicy": "cancellationPolicy8"
}
```

