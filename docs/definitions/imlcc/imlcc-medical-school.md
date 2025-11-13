# ImlccMedicalSchool

Medical school

| Name | Type | Required | Description |
| - | - | - | - |
| medicalSchoolName | string | Yes | School name |
| cibisCode | string | Yes | CIBIS code |
| schoolType | [ImlccSchoolType](imlcc-school-type.md) | Yes | Type of school |
| city | string | | City |
| stateOrProvince | [StateOrProvince](../state-or-province.md) | Yes | State or province |
| country | string | Yes | Country |
| isMedicalSchoolVerified | boolean | Yes | |
| medicalSchoolReportingFormat | string | No | |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*


