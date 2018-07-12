# Retrieve Board Orders and Licenses

Retrieves Board Orders and Licenses associated with a FID
 
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
GET {baseUrl}/v1/practitioners/205147010/verification
```

Output:
 
```json
{ 
  "fid": "205147010", 
  "licenses": [ 
    { 
      "issuerName": "Medical Board of California", 
      "issuerShortName": "CALIFORNIA", 
      "licenseNumber": "A-51871" 
    } 
  ], 
  "orders": [ 
    { 
      "category": "Restriction of license or license privilege", 
      "actions": [ 
        { 
          "actionCode": "A0019", 
          "actionDescription": "MEDICAL LICENSE PLACED ON PROBATION" 
        }, 
        { 
          "actionCode": "A0035", 
          "actionDescription": "MEDICAL PRACTICE TO BE MONITORED/SUPERVISED" 
        } 
      ] 
    }
  ] 
} 
```

For language specific examples go to [samples](/Samples/)

