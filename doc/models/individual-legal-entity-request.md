
# Individual Legal Entity Request

## Structure

`IndividualLegalEntityRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`LegalEntityType1Enum`](../../doc/models/legal-entity-type-1-enum.md) | Required | This must always be supplied and contain the value "INDIVIDUAL".<br>**Default**: `LegalEntityType1Enum.INDIVIDUAL` |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | - |
| `Website` | `string` | Optional | - |
| `SocialNetworks` | [`List<SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `Kyc` | `object` | Optional | - |
| `Name` | [`IndividualName`](../../doc/models/individual-name.md) | Optional | - |
| `Gender` | [`GenderEnum?`](../../doc/models/gender-enum.md) | Optional | - |
| `DateOfBirth` | `DateTime?` | Optional | - |
| `CountryOfBirth` | `string` | Optional | - |
| `Nationality` | `string` | Optional | - |
| `IdentificationDocuments` | [`List<IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "INDIVIDUAL",
  "address": {
    "line1": "line18",
    "line2": "line20",
    "line3": "line38",
    "line4": "line40",
    "city": "city6"
  },
  "phone": {
    "number": "number8",
    "extension": "extension6"
  },
  "email": "email6",
  "website": "website4",
  "socialNetworks": [
    {
      "type": "INSTAGRAM",
      "handle": "handle9"
    },
    {
      "type": "PINTEREST",
      "handle": "handle0"
    }
  ]
}
```

