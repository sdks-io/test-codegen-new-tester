
# Update Property Asset Request

## Structure

`UpdatePropertyAssetRequest`

## Inherits From

[`UpdateAssetRequest`](../../doc/models/update-asset-request.md)

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

## Example (as JSON)

```json
{
  "type": "UpdatePropertyAssetRequest",
  "parent": {
    "type": "MERCHANT",
    "id": "id4"
  },
  "displayName": "displayName8",
  "preferences": {
    "key1": "val1",
    "key2": "val2"
  },
  "correlationRefs": [
    {
      "label": "label1",
      "value": "value3"
    },
    {
      "label": "label2",
      "value": "value4"
    }
  ],
  "metadata": {
    "key0": "metadata1",
    "key1": "metadata0"
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

