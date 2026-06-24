# AvrAccreditedTraining

Accredited training

| Name | Type | Required | Description |
| - | - | - | - |
| accreditationEntity | string (len: 5) | No | Accreditation entity (e.g. ACGME) |
| programName | string (len: 200) | Yes | Program name |
| programCode | string (len: 10) | No | Program code |
| affiliatedInstitution | string (len: 200) | No | Affiliated institution |
| programSpecialty | string (len: 200) | Yes | Program specialty (e.g. Radiology) |
| programType | string (len: 50) | No | Program type (e.g. Residency) |
| trainingStatus | string (len: 50) | Yes | Training status (e.g. Completed) |
| startDate | string (date) | Yes | Start date of the training |
| endDate | string (date) | No | End date of the training, if completed |
| city | string (len: 50) | No | City of the program |
| stateOrProvince | string (len: 100) | No | State or province of the program |
| country | string (len: 100) No | Country of the program |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
