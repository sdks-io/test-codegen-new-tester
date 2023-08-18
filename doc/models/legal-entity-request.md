
# Legal Entity Request

## Structure

`LegalEntityRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`LegalEntityTypeEnum`](../../doc/models/legal-entity-type-enum.md) | Required | - |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | - |
| `Website` | `string` | Optional | - |
| `SocialNetworks` | [`List<SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `Kyc` | `object` | Optional | - |

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

