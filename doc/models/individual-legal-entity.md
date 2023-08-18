
# Individual Legal Entity

## Structure

`IndividualLegalEntity`

## Inherits From

[`LegalEntity`](../../doc/models/legal-entity.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Optional | This must always be supplied and contain the value "INDIVIDUAL". |
| `Name` | [`IndividualName`](../../doc/models/individual-name.md) | Optional | - |
| `Gender` | [`GenderEnum?`](../../doc/models/gender-enum.md) | Optional | - |
| `DateOfBirth` | `DateTime?` | Optional | - |
| `CountryOfBirth` | `string` | Optional | - |
| `Nationality` | `string` | Optional | - |
| `IdentificationDocuments` | [`List<IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "IndividualLegalEntity",
  "address": {
    "line1": "line12",
    "line2": "line24",
    "line3": "line32",
    "line4": "line44",
    "city": "city0"
  },
  "phone": {
    "number": "number6",
    "extension": "extension2"
  },
  "email": "email2",
  "website": "website0",
  "name": {
    "honorificPrefix": "DR",
    "first": "first6",
    "middle": "middle6",
    "last": "last0",
    "additionalLast": "additionalLast4",
    "honorificSuffix": "honorificSuffix6"
  },
  "gender": "OTHER",
  "dateOfBirth": "2016-03-13",
  "countryOfBirth": "countryOfBirth0"
}
```

