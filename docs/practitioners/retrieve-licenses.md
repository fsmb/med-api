# Retrieve Board Orders and Licenses

Retrieves board orders and licenses associated with a FID

```HTTP 
GET {baseUrl}/v1/practitioners/{fid}/verification
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API URL. |
| `fid` | path | True | string | The practitioner's FID/ |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [PdcPractitioner](definition-pdcpractitioner.md)  |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.source_read | Grants the ability to read a physician's profile. |

## Example

Input:

```HTTP
GET {baseUrl}/v1/practitioners/999999949/verification
```

Output:
 
```json
{ 
  "fid": "999999949", 
  "licenses": [ 
    { 
      "issuerName": "Texas Medical Board", 
      "issuerShortName": "TEXAS", 
      "licenseNumber": "TEST5544" 
    } 
  ], 
  "orders": [ 
    { 
      "category": "Loss of license", 
      "actions": [ 
        { 
          "actionCode": "A0019", 
          "actionDescription": "SUMMARY/EMERGENCY/IMMEDIATE/TEMPORARY SUSPENSION OF MEDICAL LICENSE" 
        } 
      ] 
    }
  ] 
} 
```

For more examples go to [samples](/Samples/).
