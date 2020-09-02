# Get PDC Profile

Get a medical professional's PDC profile information with their associated FID

```HTTP 
GET {baseUrl}/v2/practitioners/{fid}/pdcprofile
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string | The medical professional's FID. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [PdcProfile](definition-pdcprofile.md) |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.pdc_read | Grants the ability to read a physician's pdc profile. |
| med.pdc_read.abms | Includes ABMS certifications with a physician's PDC profile. |

## Example

Input:

```HTTP
GET {{baseUrl}}/v2/practitioners/999999915/pdcprofile
```

Output:

```json
{
    "fid": "999999915",
    "medicalEducation": {
        "graduating": {
            "school": {
                "name": "West Virginia University School of Medicine",
                "cibisCode": "049030",
                "type": {
                    "type": "MD",
                    "description": "Doctor of Medicine"
                }
            },
            "degree": {
                "code": "MD",
                "description": "Doctor of Medicine"
            },
            "graduationYear": 2004
        }
    },
    "gender": "M",
    "names": {
        "names": [
            {
                "firstName": "Philip",
                "middleName": "James",
                "lastName": "Testman"
            },
            {
                "firstName": "Jimmy",
                "lastName": "Testman"
            }
        ]
    },
    "addresses": {
        "addresses": [
            {
                "city": "Anytown",
                "stateOrProvince": {
                    "code": "PA",
                    "description": "Pennsylvania"
                }
            }
        ]
    },
    "licensure": {
        "licenses": [
            {
                "licensingEntity": {
                    "description": "Alabama State Board of Medical Examiners"
                },
                "stateOrProvince": {
                    "code": "AL",
                    "description": "Alabama"
                },
                "licenseNumber": "TEST1111",
                "statusCode": "ACT",
                "statusDescription": "Active",
                "issueDate": "2010-07-01T00:00:00",
                "expireDate": "2020-06-30T00:00:00",
                "reportedDate": "2011-11-11T00:00:00"
            },
            {
                "licensingEntity": {
                    "description": "Arizona Medical Board"
                },
                "stateOrProvince": {
                    "code": "AZ",
                    "description": "Arizona"
                },
                "licenseNumber": "TEST3333",
                "statusCode": "ACT",
                "statusDescription": "Active",
                "issueDate": "2010-07-01T00:00:00",
                "expireDate": "2020-06-30T00:00:00",
                "reportedDate": "2011-11-11T00:00:00"
            },
            {
                "licensingEntity": {
                    "description": "New Hampshire Board of Medicine"
                },
                "stateOrProvince": {
                    "code": "NH",
                    "description": "New Hampshire"
                },
                "licenseNumber": "TEST555",
                "statusCode": "ACT",
                "statusDescription": "Active",
                "issueDate": "2004-07-01T00:00:00",
                "expireDate": "2020-06-30T00:00:00",
                "reportedDate": "2011-11-11T00:00:00"
            },
            {
                "licensingEntity": {
                    "description": "Alaska State Medical Board"
                },
                "stateOrProvince": {
                    "code": "AK",
                    "description": "Alaska"
                },
                "licenseNumber": "TEST2222",
                "statusCode": "EXP",
                "statusDescription": "Expired",
                "issueDate": "2001-07-01T00:00:00",
                "expireDate": "2012-06-30T00:00:00",
                "reportedDate": "2011-11-11T00:00:00"
            }
        ]
    },
    "boardOrders": {
        "orders": [
            {
                "id": 3000552,
                "reportingEntity": {
                    "description": "Alabama State Board of Medical Examiners"
                },
                "category": {
                    "code": "LL",
                    "description": "Loss of license"
                },
                "date": "2019-02-04T00:00:00",
                "effectiveDate": "2019-02-07T00:00:00",
                "hasAppeal": false,
                "actions": [
                    {
                        "actionCode": "A0313",
                        "actionCodeDescription": "LICENSE RELINQUISHED",
                        "category": "Surrendered",
                        "effectiveDate": "2019-02-06T00:00:00",
                        "isIndefinite": true
                    }
                ],
                "bases": [
                    {
                        "code": "B0078",
                        "description": "Convicted of Murder"
                    }
                ]
            },
            {
                "id": 3000553,
                "reportingEntity": {
                    "description": "Alaska State Medical Board"
                },
                "category": {
                    "code": "RL",
                    "description": "Restriction of license or license privilege"
                },
                "date": "2018-02-01T00:00:00",
                "effectiveDate": "2018-02-05T00:00:00",
                "hasAppeal": false,
                "actions": [
                    {
                        "actionCode": "A0044",
                        "actionCodeDescription": "CONDITIONS ON LICENSE MODIFIED/AMENDED",
                        "category": "Conditions",
                        "effectiveDate": "2018-02-05T00:00:00",
                        "expirationDate": "2018-03-05T00:00:00",
                        "termDays": 30,
                        "isIndefinite": false
                    }
                ],
                "bases": [
                    {
                        "code": "B0111",
                        "description": "Breach of Confidentiality"
                    }
                ]
            },
            {
                "id": 3000555,
                "reportingEntity": {
                    "description": "Arizona Medical Board"
                },
                "category": {
                    "code": "OP",
                    "description": "Other prejudicial action"
                },
                "date": "2017-02-06T00:00:00",
                "effectiveDate": "2017-02-07T00:00:00",
                "hasAppeal": false,
                "actions": [
                    {
                        "actionCode": "A0197",
                        "actionCodeDescription": "MEDICAID/MEDICARE SUSPENSION",
                        "category": "CMS-Suspension",
                        "effectiveDate": "2017-02-06T00:00:00",
                        "expirationDate": "2018-02-06T00:00:00",
                        "termYears": 1,
                        "isIndefinite": false
                    }
                ],
                "bases": [
                    {
                        "code": "B0233",
                        "description": "Breach of Corporate Integrity Agreement"
                    }
                ]
            },
            {
                "id": 3000554,
                "reportingEntity": {
                    "description": "New Hampshire Board of Medicine"
                },
                "category": {
                    "code": "NP",
                    "description": "Non-prejudicial action"
                },
                "date": "2016-01-04T00:00:00",
                "effectiveDate": "2016-01-05T00:00:00",
                "hasAppeal": true,
                "appealDate": "2018-03-01T00:00:00",
                "actions": [
                    {
                        "actionCode": "A0202",
                        "actionCodeDescription": "ACCUSATION FILED",
                        "category": "Accusation",
                        "effectiveDate": "2016-01-05T00:00:00",
                        "expirationDate": "2016-06-06T00:00:00",
                        "termMonths": 6,
                        "isIndefinite": false,
                        "note": "Action Comment",
                        "actionStayedCode": "D0006",
                        "actionStayedDescription": "Action stayed"
                    }
                ],
                "bases": [
                    {
                        "code": "B0043",
                        "description": "Alteration/Falsification of Medical Record(s)"
                    }
                ]
            }
        ]
    },
    "abmsCertifications": [
        {
            "memberBoardName": "American Board of Internal Medicine",
            "memberBoardShortName": "ABIM",
            "certificates": [
                {
                    "certificate": "Cardiovascular Disease",
                    "certificateType": "Subspecialty"
                },
                {
                    "certificate": "Internal Medicine",
                    "certificateType": "General"
                }
            ]
        }
    ]
}
```

For more examples go to [samples](/Samples/).
