
# Merchant Volume Projection

## Structure

`MerchantVolumeProjection`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Period` | [`PeriodEnum`](../../doc/models/period-enum.md) | Required | - |
| `Amount` | [`Money`](../../doc/models/money.md) | Required | - |

## Example (as JSON)

```json
{
  "period": "DAILY",
  "amount": {
    "currency": "currency2",
    "value": 110
  }
}
```

