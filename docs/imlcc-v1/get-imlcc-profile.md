# Get IMLCC Profile

Gets the IMLCC profile for a physician.

```HTTP
GET :baseUrl/v1/imlcc/:fid/profile
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string (len: 9, digits) | The medical professional's FID. |

## Responses

| Name | Type  | Description |
| ---- | ------ | ----- |
| 200  | [ImlccProfile](/docs/definitions/imlcc/imlcc-profile.md) | OK |
| 404  | | Not Found |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.imlcc_read | Grants the ability to read a physician's IMLCC profile. |

## Example

Get profile

Sample Request

```HTTP
GET :baseUrl/v2/practitioners/999999907/profile
```

Sample Response

Status code: 200

Note: Output is elided. Refer to [ImlccProfile](/docs/definitions/imlcc/imlcc-profile.md) for a complete example.

```json
{
    "fid": "999999907",
    "names": [
        {
            "firstName": "Alexa",
            "middleName": "Wood",
            "lastName": "Checkey"
        }
    ],
    "npi": "1432567893",
    "birthDate": "1988-09-02T00:00:00",
    "medicalEducation": {
        "graduating": {
            "school": {
                "medicalSchoolName": "Philadelphia College of Osteopathic Medicine",
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
                },
                "country": "UNITED STATES",
                "isMedicalSchoolVerified": true,
                "medicalSchoolReportingFormat": "Licensure Information File"
            },
            "graduationYear": "2014",
            "isGradYearVerified": true,
            "gradYearReportingFormat": "Licensure Information File"
        }
    },
    "licensure": {
        "licenses": [
            {
                "licensingEntity": {
                    "description": "Texas Medical Board"
                },
                "stateOrProvince": {
                    "code": "TX",
                    "description": "Texas"
                },
                "licenseNumber": "TEST12345",
                "statusCode": "ACT",
                "statusDescription": "Active",
                "issueDate": "2014-07-01T00:00:00",
                "expireDate": "2030-06-30T00:00:00",
                "reportedDate": "2015-08-01T00:00:00"
            }
        ]
    }
}
```

For more examples go to [samples](/Samples/).

