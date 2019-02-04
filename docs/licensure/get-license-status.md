# Get License Status

Retrieves the number of licenses associated with a medical professional
 
```HTTP 
GET {baseUrl}/v1/licensure/{fid}/summary
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API URL. |
| `fid` | path | True | string | The FID of the practitioner. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [LicenseSummary](../types/licenseSummary.md) |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |

## Example

Input:

```HTTP
GET {baseUrl}/v1/licensure/999999949/summary
```

Output:

```json
{
    "fid": "999999949",
    "count": 1
}
```

For more examples go to [samples](/samples/)
