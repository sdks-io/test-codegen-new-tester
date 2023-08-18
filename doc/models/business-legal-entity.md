
# Business Legal Entity

## Structure

`BusinessLegalEntity`

## Inherits From

[`LegalEntity`](../../doc/models/legal-entity.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Optional | This must always be supplied and contain the value "BUSINESS". |
| `Name` | `string` | Optional | The business's legal name. |
| `BusinessType` | [`BusinessTypeEnum?`](../../doc/models/business-type-enum.md) | Optional | - |
| `Dba` | `List<string>` | Optional | Doing Busines As |
| `PrimaryContact` | [`IndividualLegalEntity`](../../doc/models/individual-legal-entity.md) | Optional | - |
| `PrincipalOwner` | [`LegalEntity`](../../doc/models/legal-entity.md) | Optional | - |
| `AdditionalOwners` | [`List<LegalEntity>`](../../doc/models/legal-entity.md) | Optional | An array of any owners with at least 25% ownership of the company, excluding the principal owner responsible for the account. |
| `IdentityDocuments` | [`List<IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |
| `Registration` | [`BusinessRegistration`](../../doc/models/business-registration.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "BusinessLegalEntity",
  "address": {
    "line1": "line18",
    "line2": "line20",
    "line3": "line38",
    "line4": "line40",
    "city": "city6"
  },
  "phone": {
    "number": "number2",
    "extension": "extension6"
  },
  "email": "email6",
  "website": "website6",
  "name": "name0",
  "businessType": "S_CORP",
  "dba": [
    "dba0"
  ],
  "primaryContact": {
    "type": "IndividualLegalEntity",
    "address": {
      "line1": "line14",
      "line2": "line26",
      "line3": "line34",
      "line4": "line46",
      "city": "city2"
    },
    "phone": {
      "number": "number8",
      "extension": "extension0"
    },
    "email": "email0",
    "website": "website8",
    "name": {
      "honorificPrefix": "MR",
      "first": "first2",
      "middle": "middle2",
      "last": "last6",
      "additionalLast": "additionalLast0",
      "honorificSuffix": "honorificSuffix2"
    },
    "gender": "MALE",
    "dateOfBirth": "2016-03-13",
    "countryOfBirth": "countryOfBirth6"
  }
}
```

