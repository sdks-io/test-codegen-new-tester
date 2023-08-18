
# Update Asset Request

## Structure

`UpdateAssetRequest`

## Inherits From

[`BaseType`](../../doc/models/base-type.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |

## Example (as JSON)

```json
{
  "type": "UpdateAssetRequest",
  "parent": {
    "type": "SUB_MERCHANT",
    "id": "id8"
  },
  "displayName": "displayName4",
  "preferences": {
    "key1": "val1",
    "key2": "val2"
  },
  "correlationRefs": [
    {
      "label": "label7",
      "value": "value9"
    }
  ],
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  }
}
```

