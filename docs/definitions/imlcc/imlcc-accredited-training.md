# ImlccAccreditedTraining

Accredited training information for IMLCC

| Name | Type | Required | Description |
| - | - | - | - |
| accreditationType | string | No | The type of accreditation (e.g. `ACGME`, `AOA`) |
| programCode | string | Yes | Program code |
| program | [Program](../program.md) | Yes | Program |
| specialty | [Specialty](../specialty.md) | Yes | Specialty |
| programType | string | Yes | Program type |
| trainingStatus | string | Yes | Training status |
| beginDate | string (date) | Yes | Start date |
| endDate | string (date) | Yes | End date |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
