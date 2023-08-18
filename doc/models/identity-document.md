
# Identity Document

## Structure

`IdentityDocument`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayText` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `Details` | `Dictionary<string, string>` | Optional | - |
| `Fingerprints` | [`List<Fingerprint>`](../../doc/models/fingerprint.md) | Optional | - |

## Example (as JSON)

```json
{
  "displayText": "displayText0",
  "type": "type0",
  "details": {
    "key0": "details5",
    "key1": "details6",
    "key2": "details7"
  },
  "fingerprints": [
    {
      "type": "type7",
      "value": "value9"
    },
    {
      "type": "type8",
      "value": "value0"
    }
  ]
}
```

