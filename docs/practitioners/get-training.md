# Get training

Get a medical professional's training information with their associated FID.

```HTTP 
GET {baseUrl}/v2/practitioners/{fid}/training
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string | The medical professional's FID. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [Training](definition-training.md) |
| 204 | No Content | |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.bio_read | Grants the ability to read a physician's verified information. |

## Example

Input:

```HTTP
GET {{baseUrl}}/v2/practitioners/999999915/training
```

Output:

```json
{
    "accreditedTraining": [
        {
            "accreditationType": "ACGME",
            "programCode": "1102500201",
            "program": {
                "isFsmbClosedProgram": false,
                "hospitalName": "Mercy Health Program",
                "affiliatedInstitution": "Mercy Health",
                "city": "Muskegon",
                "stateOrProvince": {
                    "code": "MI",
                    "description": "Michigan",
                    "countryCode": "US",
                    "countryDescription": "United States"
                }
            },
            "specialty": {
                "description": "Emergency Medicine"
            },
            "programType": "Residency",
            "trainingStatus": "Completed",
            "beginDate": "2004-09-09T00:00:00",
            "endDate": "2006-07-24T00:00:00"
        }
    ]
}
```


For more examples go to [samples](/Samples/).
