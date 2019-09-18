# PDC Profile

## Physician 

Provides profile information about a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| fid  | string | 9 | Required. The medical professional's FID. |
| npi | string | 10 | [Deprecated - Use npiNumbers]The medical professional's NPI number. |
| gender  | string | 1 | The medical professional's gender. |
| medicalEducation  | [MedicalEducationTraining](#medicaleducationtraining) |  | The medical professional's medical education. |
| names  | [PhysicianNames](#physiciannames) |  | The medical professional's names. |
| addresses  | [PhysicianAddresses](#physicianaddresses) |  | The medical professional's addresses. |
| deaNumbers | [DEA[]](#dea) | | A collection of the medical professional's DEA numbers |
| npiNumbers | [NPI[]](#npi) | | A collection of the  medical professional's NPI numbers | 
| licensure  | [Licensure](#licensure) |  | The medical professional's licensure information. |
| boardOrders  | [BoardOrders](#boardorders) |  | The medical professional's board order information. |

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

| Name | Type | Field Length | Description |
| - | - | - | - | 
| name  | string | 80 | Required. School name. |
| cibisCode | string | 6 | Required. School CIBIS code. |
| type | [SchoolType](#schooltype) |  | Required. School type | 

## SchoolType

Provides the medical school type

| Name | Type | Field Length | Description |
| - | - | - | - |
| type  | string | 5 | Required. School type. |
| description | string | 80 | Required. School type description. |

## Degree

Provides the medical degree

| Name | Type | Field Length | Description |
| - | - | - | - | 
| code  | string | 5 | Required. Degree code. |
| description | string | 80 | Required. Degree description. |

## DEA

Provides DEA registration number information

| Name | Type | Field Length | Description |
| - | - | - | - |
| deaNumber | string | 9 | The medical professional's DEA number |  
| drugSchedules | string | 13 | The medical professional's drug schedules |  
| expirationDate | string (date) |  | The expiration date for the DEA |  
| reportedDate | string (date) |  | The date the DEA was reported to FSMB |  
| address | [PhysicianAddress](#physicianaddress) |  | The medical professional's address registered with DEA |

## NPI

Provides NPI number information

| Name | Type | Field Length | Description |
| - | - | - | - |
| npiNumber | string | 10 | The medical professional's NPI number |
| entityType | string |  | The type of entity the NPI was issued to. |
| deactivatedDate | string( date) |  | The date the NPI was deactivated |
| reactivatedDate | string (date) |  | The date the NPI was reactivated |
| reportedDate | string (date) |  | The date the NPI was reported to FSMB |
| enumerationDate | string (date) | | The date the NPI was issued to the physician |

## PhysicianNames

Provides the medical professional's names

| Name | Type | Description |
| - | - | - |
| names  | [PhysicianName[]](#physicianname) | A collection fo the medical professional's names. |

## PhysicianName

Provides name

| Name | Type | Field Length | Description |
| - | - | - | - |
| firstName  | string | 50 | Required. First name. |
| middleName  | string | 50 | Middle name. |
| lastName  | string | 50 | Required. Last name. |
| suffix  | string | 4 | Suffix name. |

## PhysicianAddresses

Provides the medical professional's addresses

| Name | Type | Description |
| - | - | - |
| addresses  | [PhysicianAddress[]](#physicianaddress) | A collection of the medical professional's addresses. |

## PhysicianAddress

Provides address

| Name | Type | Field Length |Description |
| - | - | - | - |
| city  | string | 40 | Required. City. |
| stateOrProvince  | [StateOrProvince](#stateorprovince) |  | Required. State. |

## StateOrProvince

Represents a state or province

| Name | Type | Field Length | Description |
| - | - | - | - |
| code  | string | 3 | Required. The state or province code. |
| description | string | 80 | Required. The name of the state or province. |

## Licensure

Provides the medical professional's licensure information

| Name | Type | Description |
| - | - | - |
| licenses  | [License[]](#license) | A collection of the medical professional's licenses. |

## License

Provides license information

| Name | Type | Field Length | Description |
| - | - | - | - | 
| licensingEntity  | [ReportingEntity](#reportingentity) |  | Required. The entity who issued the license. |
| stateOrProvince  | [StateOrProvince](#stateorprovince) |  | Required. The state where the entity is located. |
| licenseNumber  | string | 16 | Required. The license number. |
| statusCode  | string | 5 | Status code. |
| statusDescription  | string | 80 | Status description. |
| issueDate  | string (date) |  | The date the license was issued. |
| expireDate  | string (date) |  | The date the license expires. |
| reportDate  | string (date) |  | The date the license was reported to FSMB. |

## ReportingEntity

Represents a reporting entity

| Name | Type | Field Length | Description |
| - | - | - | - |
| description | string | 80 | Required. The name of the reporting entity. |

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

| Name | Type | Field Length | Description |
| - | - | - | - |
| actionCode  | string | 5 | Required. The action code. |
| actionCodeDescription  | string | 100 | Required. The description of the action taken. |
| category  | string | 80 | Required. The type of action taken. |
| effectiveDate  | string (date) |  | The date the action took effect. |
| expirateDate  | string (date) |  | The date the action expires. |
| termDays  | int |  | The number of days the action is for. |
| termMonths  | int |  | The number of months the action is for. |
| termYears  | int |  | The number of years the action is for. |
| isIndefinite  | boolean |  | Indicates whether the action taken is indfinite. |
| note  | string | 1000 | Note about the action. |
| actionStayedCode  | string | 5 | Action stayed code. |
| actionStayedDescription  | string | 80 | Action stayed description. |

## BoardOrderBasis

Provides board order basis information

| Name | Type | Field Length | Description |
| - | - | - | - |
| code  | string | 5 | Required. The basis code. |
| description  | string | 100 | Required. The basis description. |

## BoardOrderCategory

Provides board order category information

| Name | Type | Field Length | Description |
| - | - | - | - |
| code  | string | 5 | Required. The category code. |
| description  | string | 80 | Required. The category description. |
