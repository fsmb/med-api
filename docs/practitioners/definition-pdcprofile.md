# PDC Profile

## Physician 

Provides profile information about a medical professional

| Name | Type | Description |
| - | - | - |
| fid  | string | Required. The medical professional's FID. |
| npi  | string | The medical professional's NPI number. |
| gender  | string | The medical professional's gender. |
| medicalEducation  | [MedicalEducationTraining](#medicaleducationtraining) | The medical professional's medical education. |
| names  | [PhysicianNames](#physiciannames) | The medical professional's names. |
| addresses  | [PhysicianAddresses](#physicianaddresses) | The medical professional's addresses. |
| licensure  | [Licensure](#licensure) | The medical professional's licensure information. |
| boardOrders  | [BoardOrders](#boardorders) | The medical professional's board order information. |

## MedicalEducationTraining

Provides the medical education information of a medical professional

| Name | Type | Description |
| - | - | - |
| graduating  | [MedicalEducation](#medicaleducation) | Required. The graduating medical education information. |

## MedicalEducation

Provides medical education information

| Name | Type | Description |
| - | - | - |
| school  | [School](#school) | Required. School information. |
| degree | [Degree](#degree) | The degree. |
| graduationYear | int | The year the medical professional graduated. | 

## School

Provides the medical school information

| Name | Type | Description |
| - | - | - |
| name  | string | Required. School name. |
| cibisCode | string | Required. School CIBIS code. |
| type | [SchoolType](#schooltype) | Required. School type | 

## SchoolType

Provides the medical school type

| Name | Type | Description |
| - | - | - |
| type  | string | Required. School type. |
| description | string | Required. School type description. |

## Degree

Provides the medical degree

| Name | Type | Description |
| - | - | - |
| code  | string | Required. Degree code. |
| description | string | Required. Degree description. |

## PhysicianNames

Provides the medical professional's names

| Name | Type | Description |
| - | - | - |
| names  | [PhysicianName[]](#physicianname) | A collection fo the medical professional's names. |

## PhysicianName

Provides name

| Name | Type | Description |
| - | - | - |
| firstName  | string | Required. First name. |
| middleName  | string | Middle name. |
| lastName  | string | Required. Last name. |
| suffix  | string | suffix name. |

## PhysicianAddresses

Provides the medical professional's addresses

| Name | Type | Description |
| - | - | - |
| addresses  | [PhysicianAddress[]](#physicianaddress) | A collection of the medical professional's addresses. |

## PhysicianAddress

Provides address

| Name | Type | Description |
| - | - | - |
| city  | string | Required. City. |
| stateOrProvince  | [StateOrProvince](#stateorprovince) | Required. State. |

## StateOrProvince

Represents a state or province

| Name | Type | Description |
| - | - | - |
| code  | string | Required. The state or province code. |
| description | string | Required. The name of the state or province. |

## Licensure

Provides the medical professional's licensure information
| Name | Type | Description |
| - | - | - |
| licenses  | [License[]](#license) | A collection of the medical professional's licenses. |

## License

Provides license information

| Name | Type | Description |
| - | - | - |
| licensingEntity  | [ReportingEntity](#reportingentity) | Required. The entity who issued the license. |
| stateOrProvince  | [StateOrProvince](#stateorprovince) | Required. The state where the entity is located. |
| licenseNumber  | string | Required. The license number. |
| statusCode  | string | Status code. |
| statusDescription  | string | Status description. |
| issueDate  | string (date) | The date the license was issued. |
| expireDate  | string (date) | The date the license expires. |
| reportDate  | string (date) | The date the license was reported to FSMB. |

## ReportingEntity

Represents a reporting entity

| Name | Type | Description |
| - | - | - |
| description | string | Required. The name of the reporting entity. |

## BoardOrders

Provides the medical professional's board order information

| Name | Type | Description |
| - | - | - |
| boardOrders  | [BoardOrder[]](#boardorder) | A collection of the medical professional's board orders. |

## BoardOrder

Provides board order information

| Name | Type | Description |
| - | - | - |
| id  | int | Required. The board order id. |
| reportingEntity  | [ReportingEntity](#reportingentity) | Required. The entity who issued the board order. |
| category  | [BoardOrderCategory](#boardordercategory) | Required. The type of board order. |
| actions  | [BoardOrderAction[]](#boardorderaction) | A collection of actions taken against the medical professional.  |
| bases  | [BoardOrderBasis[]](#boardorderbasis) | A collection of bases for which the actions were taken. |
| date  | string (date) | The date the order was issued. |
| effectiveDate  | string(date) | The date the order was in effect. |
| hasAppeal  | boolean | Indicates whether the order has an appeal. |
| appealDate  | string (date) | The date of the appeal. |

## BoardOrderAction

Provides board order action information

| Name | Type | Description |
| - | - | - |
| actionCode  | string | Required. The action code. |
| actionCodeDescription  | string | Required. The description of the action taken. |
| category  | string | Required. The type of action taken. |
| effectiveDate  | string (date) | The date the action took effect. |
| expirateDate  | string (date) | The date the action expires. |
| termDays  | int | The number of days the action is for. |
| termMonths  | int | The number of months the action is for. |
| termYears  | int | The number of years the action is for. |
| isIndefinite  | boolean | Indicates whether the action taken is indfinite. |
| note  | string | Note about the action. |
| actionStayedCode  | string | Action stayed code. |
| actionStayedDescription  | string | Action stayed description. |

## BoardOrderBasis

Provides board order basis information

| Name | Type | Description |
| - | - | - |
| code  | string | Required. The basis code. |
| description  | string | Required. The basis description. |

## BoardOrderCategory

Provides board order category information

| Name | Type | Description |
| - | - | - |
| code  | string | Required. The category code. |
| description  | string | Required. The category description. |