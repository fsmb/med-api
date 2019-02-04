# Retrieve Board Orders and Licenses

Retrieves board orders and licenses associated with a FID

```HTTP 
GET {baseUrl}/v1/practitioners/{fid}/verification
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API url |
| `fid` | path | True | string | The practitioner's FID |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [PdcPractitioner](../types/pdcPractitioner.md)  |
| 400  | Bad Request     |  |
| 401  | Unauthorized    |  |
| 500  | Server Error    |  |

## Scope

This request requires the OAuth scopes of `med.read` and `med.source_read` in order to execute.

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

For language specific examples go to [samples](/Samples/)

