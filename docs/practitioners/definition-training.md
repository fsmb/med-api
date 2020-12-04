# Training

Provides training information about a medical professional

| Name | Type | Description |
| - | - | - |
|accreditedTraining| [PhysicianAccreditedTraining](#accreditedtraining)[] | A collection of the medical professional's accredited training. |
|trainingVerification| [TrainingVerification](#trainingverification) | Provides indicators if training verifications are available. |

## PhysicianAccreditedTraining

Provides the accredited training information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| accreditationType | string | 5 | The type of accreditation. |
| programCode | string | 10 | Required. The program code. |
| program | [ProgramDetails](#programDetails) |  | Required. Program information. |
| specialty | [Specialty](#specialty) |  | Required. Specialty information. |
| programType | string | 80 | The program type. |
| trainingStatus | string | 80 | The medical professional's training status. |
| beginDate | string (date) |  | The date the medical professional started the accredited training. |
| endDate | string (date) |  | The date the medical professional finished the accredited training. |

## ProgramDetails

Provides a medical professional's relevant program data 

| Name | Type | Field Length | Description |
| - | - | - | - |
| hospitalName | string | 80 | Required. The hospital's name. |
| affiliatedInstitution | string | 80 | The institution the program is affiliated with. |
| city | string | 40 | Required. The city where the hospital is located. |
| stateOrProvince | [Region](#region) |  | Required. The region where the hospital is located. |
| isFsmbClosedProgram | boolean | | Required. Indicates whether program is an FSMB-held closed program. |

## Specialty

Provides specialty information

| Name | Type | Field Length | Description |
| - | - | - | - |
| description | string | 160 | Required. Describes the specialty. |

## Region

Represents a state or province

| Name | Type | Field Length | Description |
| - | - | - | - |
| code  | string | 3 |Required. The state or province code. |
| description | string | 80 | Required. The name of the state or province. |
| countryCode | string | 2 | The ISO country code. |
| countryDescription | string | 80 | The name of the country. |

## TrainingVerification

Represents whether training verifications are available

| Name | Type | Description |
| - | - | - |
| medicalEducationVerificationsAvailable | boolean | Required. Indicates if the physician has medical education verifications available. |
| accreditedTrainingVerificationsAvailable | boolean | Required. Indicates if the physician has accredited training verifications available. |
