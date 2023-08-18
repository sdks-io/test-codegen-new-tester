
# Field Specification

## Structure

`FieldSpecification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Field` | `string` | Optional | The field name within the `details` section of an `Instrument` or `IdentityDocument`. |
| `Type` | [`FieldTypeEnum?`](../../doc/models/field-type-enum.md) | Optional | The type of the field. |
| `Description` | `string` | Optional | Detailed description of the field. |
| `DisplayName` | `string` | Optional | Human friendly name for the field, for display purposes in UIs. |
| `Required` | `bool?` | Optional | Indicates if the specified field is required or optional. |
| `MinimumLength` | `long?` | Optional | If present then the value may not be less than the specified minimum length. Only applicable for the 'STRING' type. |
| `MaximumLength` | `long?` | Optional | If present then the value may not exceed the specified maximum length. Only applicable for the 'STRING' type. |
| `Masked` | `bool?` | Optional | If true, then the field will not be available to the caller in the clear, instead as masked version will be returned. |
| `ReadOnly` | `bool?` | Optional | If true, then the detail cannot be populated by the caller, but instead will be generated internally. |
| `EnumValues` | `List<string>` | Optional | If the specification type is 'ENUMERATION' then the input will be validated against these accepted values. |

## Example (as JSON)

```json
{
  "field": "field6",
  "type": "STRING",
  "description": "description0",
  "displayName": "displayName2",
  "required": false
}
```

