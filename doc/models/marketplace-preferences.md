
# Marketplace Preferences

## Structure

`MarketplacePreferences`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Network` | [`NetworkPreferences`](../../doc/models/network-preferences.md) | Optional | - |
| `Webhook` | [`WebhookPreferences`](../../doc/models/webhook-preferences.md) | Optional | - |
| `Cors` | [`MarketplaceCORSPreferences`](../../doc/models/marketplace-cors-preferences.md) | Optional | - |

## Example (as JSON)

```json
{
  "network": {
    "merchantCategoryCode": "merchantCategoryCode8",
    "merchantIdentifictionNumber": "merchantIdentifictionNumber0",
    "gatewayIdentificationNumber": "gatewayIdentificationNumber8",
    "terminalIdentificationNumber": "terminalIdentificationNumber4"
  },
  "webhook": {
    "onboardingWebhook": "onboardingWebhook6",
    "onboardingWebhookAuthentication": {
      "type": "AUTHORIZATION_HEADER",
      "value": "value8"
    }
  },
  "cors": {
    "onboarding": {
      "allowedOrigins": [
        "allowedOrigins6",
        "allowedOrigins5"
      ]
    }
  }
}
```

