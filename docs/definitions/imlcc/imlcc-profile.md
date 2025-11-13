# ImlccProfile

IMLCC physician profile

| Name | Type | Required | Description |
| - | - | - | - |
| fid | string (format: digits, len: 9) | Yes | FID of the physician |
| names | [ImlccPhysicianName[]](imlcc-physician-name.md) | Yes | Physician names |
| npi | string (format: digits, len: 10) | No | NPI |
| birthDate | string (date) | No | Date of birth |
| medicalEducation | [ImlccMedicalEducation](imlcc-medical-education.md) | Yes | Medical education |
| accreditedTraining | [ImlccAccreditedTraining[]](imlcc-accredited-training.md) | No | Accredited postgraduate training |
| exams | [ImlccExam[]](imlcc-exam.md) | No | Exams |
| abmsBoards | [ImlccAbmsBoard[]](imlcc-abms-board.md) | No | ABMS board certifications |
| boardOrders | [ImlccBoardOrder[]](imlcc-board-order.md) | No | Board orders |
| licensure | [ImlccLicensure](imlcc-licensure.md) | No | Licensure |
| amaProfile | [ImlccAmaProfile](imlcc-ama-profile.md) | No | AMA information |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

## Example

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
    "accreditedTraining": [],
    "exams": [],
    "abmsBoards": [],
    "boardOrders": [],
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
            },
            {
                "licensingEntity": {
                    "description": "Oklahoma Board of Osteopathic Examiners"
                },
                "stateOrProvince": {
                    "code": "OK",
                    "description": "Oklahoma"
                },
                "licenseNumber": "TEST101928",
                "statusCode": "ACT",
                "statusDescription": "Active",
                "issueDate": "2014-06-15T00:00:00",
                "expireDate": "2030-06-30T00:00:00",
                "reportedDate": "2011-11-11T00:00:00"
            }
        ]
    }
}
```
