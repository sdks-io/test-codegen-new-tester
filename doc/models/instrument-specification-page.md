
# Instrument Specification Page

## Structure

`InstrumentSpecificationPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | - |
| `Results` | [`List<InstrumentSpecification>`](../../doc/models/instrument-specification.md) | Optional | - |

## Example (as JSON)

```json
{
  "meta": {
    "offset": 222,
    "size": 28
  },
  "results": [
    {
      "name": "name3",
      "displayName": "displayName9",
      "supportedCountries": [
        "supportedCountries5",
        "supportedCountries6",
        "supportedCountries7"
      ],
      "supportedCurrencies": [
        "supportedCurrencies1",
        "supportedCurrencies2",
        "supportedCurrencies3"
      ],
      "requiredFields": [
        "requiredFields7"
      ]
    }
  ]
}
```

