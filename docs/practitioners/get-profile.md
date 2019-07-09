# Get Profile

Get a medical professional's profile information with their associated FID

```HTTP 
GET {baseUrl}/v2/practitioners/{fid}/profile
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string | The medical professional's FID. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [Profile](definition-profile.md) |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.cdc_read | Grants the ability to read a physician's profile. |

## Example

Input:

```HTTP
GET {baseUrl}/v2/practitioners/999999907/profile
```

Output:

```json
{
    "fid": "999999907",
    "identity": {
        "usmleId": "88888888",
        "birthDate": "1988-09-02T00:00:00",
        "birthCity": "Ten Sleep",
        "birthStateOrProvince": {
            "code": "WY",
            "description": "Wyoming",
            "countryCode": "US",
            "countryDescription": "United States"
        },
        "gender": "F"
    },
    "names": [
        {
            "isLegal": true,
            "firstName": "Alexa",
            "middleName": "Wood",
            "lastName": "Checkey"
        }
    ],
    "addresses": [
        {
            "isPrimary": true,
            "addressType": "Business",
            "lines": [
                "6544 Main Street"
            ],
            "city": "Nashville",
            "stateOrProvince": {
                "code": "TN",
                "description": "Tennessee",
                "countryCode": "US",
                "countryDescription": "United States"
            },
            "postalCode": "64564"
        }
    ],
    "emailAddresses": [
        {
            "isPrimary": true,
            "email": "fsmbqa@fsmb.org"
        }
    ],
    "phones": [
        {
            "isPrimary": true,
            "phoneType": "Business",
            "phoneNumber": "6465458789",
            "extension": "654"
        }
    ],
    "medicalEducation": [
        {
            "school": {
                "name": "Philadelphia College of Osteopathic Medicine",
                "cibisCode": "039060",
                "schoolType": {
                    "code": "DO",
                    "description": "Doctor of Osteopathic Medicine"
                },
                "city": "Philadelphia",
                "stateOrProvince": {
                    "code": "PA",
                    "description": "Pennsylvania",
                    "countryCode": "US",
                    "countryDescription": "United States"
                }
            },
            "beginDate": "2010-08-01T00:00:00",
            "endDate": "2014-05-22T00:00:00",
            "degree": {
                "code": "DO",
                "description": "Doctor of Osteopathy"
            },
            "graduationDate": "2014-05-22T00:00:00"
        }
    ],
    "accreditedTraining": [
        {
            "accreditationType": "ACGME",
            "programCode": "1492621053",
            "program": {
                "hospitalName": " Mayo Graduate School of Medicine",
                "affiliatedInstitution": " Mayo Graduate School of Medicine",
                "city": "Rochester",
                "stateOrProvince": {
                    "code": "MN",
                    "description": "Minnesota",
                    "countryCode": "US",
                    "countryDescription": "United States"
                }
            },
            "specialty": {
                "description": "Internal Medicine"
            },
            "programType": "Residency",
            "trainingStatus": "Completed",
            "beginDate": "2015-11-21T00:00:00",
            "endDate": "2016-10-17T00:00:00"
        }
    ]
}
```

For more examples go to [samples](/Samples/).
