
# Webhook Authentication Preference

## Structure

`WebhookAuthenticationPreference`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type2Enum?`](../../doc/models/type-2-enum.md) | Optional | The authentication mechanism to use when making webhook callbacks to client URLs. |
| `MValue` | `string` | Optional | For a type of AUTHORIZATION_HEADER this value should contain what will be placed into the Authorization header, for each webhook callback. When reading back this preference from a response this value field will contain a masked version of the originally supplied value.<br>For a type of TLS_CLIENT_AUTHENTICATION this value should be left empty, and the server side will populate here the Public Key half in PEM format. This Public Key should then be used by the webhook implementation to authenticate the caller. |

## Example (as JSON)

```json
{
  "type": "AUTHORIZATION_HEADER",
  "value": "value2"
}
```

