
# Instrument

## Structure

`Instrument`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Created` | `DateTime?` | Optional | - |
| `Updated` | `DateTime?` | Optional | - |
| `CorrelationRefs` | [`List<CorrelationRef>`](../../doc/models/correlation-ref.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | - |
| `Type` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Country` | `string` | Optional | ISO 3166-1 alpha-2 or alpha-3 country code. |
| `DisplayName` | `string` | Optional | - |
| `NamesOnAccount` | [`List<NameOnAccount>`](../../doc/models/name-on-account.md) | Optional | - |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | - |
| `Details` | `object` | Optional | - |
| `Fingerprints` | [`List<Fingerprint>`](../../doc/models/fingerprint.md) | Optional | - |
| `Status` | [`InstrumentStatus`](../../doc/models/instrument-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "created": "2016-03-13T12:52:32.123Z",
  "updated": "2016-03-13T12:52:32.123Z",
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

