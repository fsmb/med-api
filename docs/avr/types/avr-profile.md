# AvrProfile

AVR profile

| Name | Type | Required | Description |
| - | - | - | - |
| fid | string (format: digits, len: 9) | Yes | FID of the physician |
| reportDateUtc | string (datetime) | Yes | Date and time, in UTC, the profile was generated |
| identity | [AvrIdentitySection](avr-identity-section.md) | Yes | Physician identity information |
| names | [AvrNamesSection](avr-names-section.md) | Yes | Physician names |
| medicalEducation | [AvrMedicalEducationSection](avr-medicaleducation-section.md) | Yes | Medical education |
| boardOrders | [AvrBoardOrdersSection](avr-boardorders-section.md) | Yes | Board orders |
| graduateMedicalEducation | [AvrGraduateMedicalEducationSection](avr-gme-section.md) | Yes | Graduate medical education |
| usmleExams | [AvrUsmleExamsSection](avr-exams-section.md) | Yes | USMLE exams |
| abmsCertifications | [AvrAbmsCertificationsSection](avr-abms-section.md) | Yes | ABMS certifications |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*

Example 

```json
{
    "fid": "999999915",
    "reportDateUtc": "2026-06-24T18:25:14.7055032Z",
    "identity": {
        "birthDate": "1978-08-08",
        "npi": "1435537299"
    },
    "names": {
        "legalName": {
            "firstName": "Philip",
            "middleName": "James",
            "lastName": "Testman"
        },
        "alternateNames": []
    },
    "medicalEducation": {
        "medicalSchoolName": "West Virginia University School of Medicine",
        "city": "Morgantown",
        "stateOrProvince": "West Virginia",
        "country": "UNITED STATES",
        "graduationYear": "2004"
    },
    "boardOrders": {
        "hasBoardOrders": true,
        "meetsImlccRequirements": false
    },
    "graduateMedicalEducation": {
        "isAma": false,
        "meetsImlccRequirements": false,
        "accreditedTraining": []
    },
    "usmleExams": {
        "meetsImlccRequirements": false,
        "exams": []
    },
    "abmsCertifications": {
        "meetsImlccRequirements": false,
        "certifications": []
    }
}
```
