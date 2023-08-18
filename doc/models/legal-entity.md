
# Legal Entity

## Structure

`LegalEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Phone` | [`Phone`](../../doc/models/phone.md) | Optional | - |
| `Email` | `string` | Optional | - |
| `Website` | `string` | Optional | - |
| `SocialNetworks` | [`List<SocialNetwork>`](../../doc/models/social-network.md) | Optional | - |
| `DigitalCurrencyAddresses` | `List<string>` | Optional | - |
| `IdentificationDocuments` | [`List<IdentityDocument>`](../../doc/models/identity-document.md) | Optional | - |
| `Additional` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "type": "LegalEntity",
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
  "website": "website4"
}
```

