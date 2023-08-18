
# Property Asset

## Structure

`PropertyAsset`

## Inherits From

[`Asset`](../../doc/models/asset.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `object` | Optional | - |
| `Name` | `string` | Optional | - |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Details` | [`PropertyDetails`](../../doc/models/property-details.md) | Optional | - |
| `Rating` | [`PropertyRating`](../../doc/models/property-rating.md) | Optional | - |
| `ReservationPolicy` | [`PropertyReservationPolicy`](../../doc/models/property-reservation-policy.md) | Optional | - |
| `RateDetails` | [`PropertyRateDetails`](../../doc/models/property-rate-details.md) | Optional | - |
| `BookingHistory` | [`PropertyBookingHistory`](../../doc/models/property-booking-history.md) | Optional | - |
| `Status` | [`EntityStatus`](../../doc/models/entity-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "PropertyAsset",
  "parent": {
    "type": "SUB_MERCHANT",
    "id": "id8"
  },
  "displayName": "displayName4",
  "capabilities": {
    "granted": [
      {
        "type": "Capability"
      }
    ],
    "denied": [
      {
        "type": "PAYOUT",
        "reasons": [
          "reasons1",
          "reasons2",
          "reasons3"
        ],
        "requiredActions": [
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          },
          {
            "key1": "val1",
            "key2": "val2"
          }
        ]
      },
      {
        "type": "THREE_D_SECURE",
        "reasons": [
          "reasons2"
        ],
        "requiredActions": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ]
      }
    ]
  },
  "preferences": {
    "key1": "val1",
    "key2": "val2"
  },
  "id": "id8",
  "created": "2016-03-13T12:52:32.123Z",
  "updated": "2016-03-13T12:52:32.123Z",
  "correlationRefs": [
    {
      "label": "label5",
      "value": "value7"
    }
  ],
  "metadata": {
    "key0": "metadata5",
    "key1": "metadata6",
    "key2": "metadata7"
  },
  "name": "name0",
  "address": {
    "line1": "line18",
    "line2": "line20",
    "line3": "line38",
    "line4": "line40",
    "city": "city6"
  },
  "details": {
    "capacity": 68,
    "bedroomCount": 250,
    "bathroomCount": 168,
    "amenities": [
      "amenities5",
      "amenities6",
      "amenities7"
    ]
  },
  "rating": {
    "score": 71.48,
    "rating": 104.16,
    "ratingCount": 48,
    "inquiryCount": 224,
    "complaintCount": 38
  }
}
```

