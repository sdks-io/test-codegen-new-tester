
# Property Rate Details

## Structure

`PropertyRateDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Min` | [`Money`](../../doc/models/money.md) | Optional | - |
| `Max` | [`Money`](../../doc/models/money.md) | Optional | - |
| `CleaningFee` | [`Money`](../../doc/models/money.md) | Optional | - |
| `SameDayChargeAllowed` | `bool?` | Optional | - |
| `AutoPricing` | `bool?` | Optional | - |
| `RentingFrequency` | [`RentingFrequencyEnum?`](../../doc/models/renting-frequency-enum.md) | Optional | - |
| `PaymentTerms` | [`PaymentTermsEnum?`](../../doc/models/payment-terms-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "min": {
    "currency": "currency2",
    "value": 144
  },
  "max": {
    "currency": "currency0",
    "value": 226
  },
  "cleaningFee": {
    "currency": "currency8",
    "value": 8
  },
  "sameDayChargeAllowed": false,
  "autoPricing": false
}
```

