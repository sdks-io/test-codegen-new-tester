
# Required Fields

## Structure

`RequiredFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Merchant` | [`CountrySpecificationRequiredFields`](../../doc/models/country-specification-required-fields.md) | Optional | - |
| `Instrument` | [`CountrySpecificationRequiredFields`](../../doc/models/country-specification-required-fields.md) | Optional | - |
| `Customer` | [`CountrySpecificationRequiredFields`](../../doc/models/country-specification-required-fields.md) | Optional | - |
| `Property` | [`CountrySpecificationRequiredFields`](../../doc/models/country-specification-required-fields.md) | Optional | - |

## Example (as JSON)

```json
{
  "merchant": {
    "required": [
      "required4",
      "required5",
      "required6"
    ],
    "optional": [
      "optional5"
    ]
  },
  "instrument": {
    "required": [
      "required6",
      "required7",
      "required8"
    ],
    "optional": [
      "optional7"
    ]
  },
  "customer": {
    "required": [
      "required0"
    ],
    "optional": [
      "optional1",
      "optional2"
    ]
  },
  "property": {
    "required": [
      "required8",
      "required9",
      "required0"
    ],
    "optional": [
      "optional9"
    ]
  }
}
```

