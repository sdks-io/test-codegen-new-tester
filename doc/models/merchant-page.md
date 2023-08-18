
# Merchant Page

## Structure

`MerchantPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | - |
| `Results` | [`List<Merchant>`](../../doc/models/merchant.md) | Optional | - |

## Example (as JSON)

```json
{
  "meta": {
    "offset": 222,
    "size": 28
  },
  "results": [
    {
      "id": "id3",
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "correlationRefs": [
        {
          "label": "label0",
          "value": "value2"
        }
      ],
      "metadata": {
        "key0": "metadata0",
        "key1": "metadata1",
        "key2": "metadata2"
      }
    }
  ]
}
```

