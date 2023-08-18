
# Direct Debit Consent

## Structure

`DirectDebitConsent`

## Inherits From

[`Consent`](../../doc/models/consent.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Optional | - |
| `Frequency` | [`FrequencyEnum?`](../../doc/models/frequency-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "DirectDebitConsent",
  "timeOfConsent": "2016-03-13T12:52:32.123Z",
  "version": 136,
  "frequency": "WEEKLY"
}
```

