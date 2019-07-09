# Get Board Orders and Licenses

Get board orders and licenses associated with a FID

```HTTP 
GET {baseUrl}/v2/practitioners/{fid}/verification
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string | The practitioner's FID/ |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [BoardOrderDetail](definition-boardorderdetail.md)  |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.source_read | Grants the ability to read a physician's profile. |

## Test Data

The following FIDs have been set up to return pre-defined data for this endpoint.

| FID | Response |
| - | - |
| 999999907 | License but no board orders. |
| 999999915 | Multiple licenses and board orders. |
| 999999923 | License but no board orders. |
| 999999931 | License but no board orders. |
| 999999949 | License and board order. |
| 999999956 | License but no board orders. |
| * | No data |

## Example

Input:

```HTTP
GET {{baseUrl}}/v2/practitioners/999999949/verification
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
                    "actionCode": "A0013",
                    "actionDescription": "SUMMARY/EMERGENCY/IMMEDIATE/TEMPORARY SUSPENSION OF MEDICAL LICENSE"
                }
            ]
        }
    ]
}
```

For more examples go to [samples](/Samples/).
