
# Business Legal Entity Request

## Structure

`BusinessLegalEntityRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`LegalEntityType2Enum`](../../doc/models/legal-entity-type-2-enum.md) | Required | This must always be supplied and contain the value "BUSINESS".<br>**Default**: `LegalEntityType2Enum.BUSINESS` |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | - |
| `Website` | `string` | Optional | - |
| `SocialNetworks` | [`List<SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `Kyc` | `object` | Optional | - |
| `Name` | `string` | Optional | - |
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
  "type": "BUSINESS",
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

