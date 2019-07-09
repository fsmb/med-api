# Profile

Provides profile information about a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| fid  | string | 9 | Required. The medical professional's FID. |
|identity| [Identification](#identification) |  | Required. The medical professional's identity information. |
|names |[ProfessionalName[]](#professionalname) |  | Required. A collection of the medical professional's names. |
|addresses| [Address[]](#address) |  | Required. A collection of the medical professional's addresses. |
|emailAddresses|[EmailAddress[]](#emailaddress) |  | Required. A collection of the medical professional's email addresses. |
|phones|[Phone[]](#phone) |  | Required. A collection of the medical professional's phone numbers. |
|medicalEducation|[MedicalEducation[]](#medicaleducation) |  | Required. A collection of the medical professional's Medical Education. |
|ecfmg|[ECFMG](#ecfmg)|  | The medical professional's ECFMG information. |
|fifthPathway|[FifthPathway](#fifthpathway) |  | The medical professional's Fifth Pathway information. |
|accreditedTraining| [AccreditedTraning[]](#accreditedtraining) |  | A collection of the medical professional's accredited training. |
|otherTraining| [OtherTraining[]](#othertraining) |  | A collection of the medical professional's other training. |
|activities| [Activity[]](#activity) |  | A collection of the medical professional's activities. |

## AccreditedTraining

Provides the accredited training information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| accreditationType | string | 5 | The type of accreditation. |
| programCode | string | 10 | Required. The program code. |
| program | [Program](#program) |  | Required. Program information. |
| specialty | [Specialty](#specialty) |  | Required. Specialty information. |
| programType | string | 80 | Required. The program type. |
| trainingStatus | string | 80 | Required. The medical professional's training status. |
| beginDate | string (date) |  | The date the medical professional started the accredited training. |
| endDate | string (date) |  | The date the medical professional finished the accredited training. |

## Activity

Provides information about an activity a medical professional took part in

| Name | Type | Field Length | Description |
| - | - | - | - |
| type | string | 80 | Required. The type of activity. |
| inProgress | boolean |  | Indicates whether the activity is still in progress. |
| beginDate | string (date) |  | The date the activity started. |
| endDate | string (date) |  | The date the activity finished, if it has finished. |
| description | string | 80 | Required. The description of the activity. |
| addressLines| string[] | 100 | Required. A collection of address lines of where the activity has taken, or is taking, place. |
| city | string | 40 | Required. The name of the city where the activity has taken, or is taking, place. |
| stateOrProvince | [Region](#region) |  | Required. The region where the activity has taken, or is taking, place. |
| postalCode | string | 9 | The postal code where the activity has taken, or is taking, place. |
| position | string | 80 | The medical professional's position during the activity. |
| department | string | 80 | The department the medical professional was in during the activity. |
| wasEmployed | boolean |  | Indicates whether the medical professional was employed during the activity. |
| hadStaffPrivilages | boolean |  | Indicates whether the medical professional had staff privileges over the duration of the activity. |
| wasAffiliated | boolean |  | Indicates whether the medical professional had any affiliations during the duration of the activity. |
| percentageClinical | integer |  | Represents how much of the activity was clinical. |
| percentageAdministrative | integer |  | Represents how much of the activity was administrative. |

## Address

Provides the address information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| isPrimary  | boolean |  | Required. Indicates whether the provided address is the medical professional's primary address. |
| addressType | string | 80 | Required. Indicates what the address is for (e.g. Home, Business). |
| lines | string[] | 100 | A collection of address lines of the address. |
| city | string | 40 | Required. The city name of the address. |
| stateOrProvince| [Region](#region)|  | Required. The state or province of the address. |
| postalCode | string | 9 | Required. The postal code of the address. |

## CodedDescription

Acts as a wrapper around a code and user-friendly description of the code

| Name | Type | Description |
| - | - | - |
| code  | string | The code. |
| description | string | The user-friendly description of the code. |

## ECFMG

Provides the ECFMG certification information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| ecfmgId | string | 8 | Required. The medical professional's ECFMG ID. |
| IssueDate | string (date) |  | The issue date of the certification. |

## EmailAddress

Provides the email address information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - | 
| isPrimary  | boolean |  | Indicates whether the provided email address is the medical professional's primary email address. |
| email | string | 80 | Required. The medical professional's email address. |

## FifthPathway

Provides the Fifth Pathway certification information of a medical professional 

| Name | Type | Field Length | Description |
| - | - | - | - | 
| school | [FifthPathwaySchool](#fifthpathwayschool) |  | Required. The school the medical professional attended to receive their Fifth Pathway certification. |
|startDate | string (date) |  | The date the medical professional started attendance at the Fifth Pathway school. |
|endDate | string (date) |  | The date the medical professional finished attending the Fifth Pathway school. |
|certificateDate | string (date) |  | The date the medical professional received their Fifth Pathway certification. |

## FifthPathwaySchool

Provides the Fifth Pathway medical school information of a medical professional 

| Name | Type | Field Length | Description |
| - | - | - | - |
| name  | string | 80 | Required. The name of the school. |
| affiliatedInstitution| string | 80 | Required. The institution associated with the school. |
| cibisCode | string | 6 | Required. The code that CIBIS uses to identify the school. |
| schoolType | [CodedDescription](#codeddescription) |  | The degree information. |
| city | string | 40 | The name of the city where the school is located. |
| stateOrProvince | [Region](#region) |  | The state or province where the school is located. | 

## Identification

Provides the identification information of the medical professional

| Name | Type |  Field Length | Description |
| - | - | - | - |
| ssnLast4  | string | 4 | The last four digits of the medical professional's SSN. |
| npi | string | 10 | The National Provider Identifier. |
| usmleId | string | 8 | The medical professional's USMLE identification number. |
| birthDate | string (date) |  | The medical professional's date of birth. |
| birthCity | string | 40 | Required. The medical professional's city of birth. |
| birthStateOrProvince | [Region](#region) |  | Required. The medical professional's state or province of  birth. |
| gender | string | 1 | Required. The medical professional's gender. |

## MedicalEducation

Provides the medical education information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - | 
| school  | [School](#school) |  | Required. School information. |
| beginDate | string (date) |  | The date a medical professional started attending  a school. |
| endDate | string (date) |  | The date a medical professional finished attending a school. |
| degree | [CodedDescription](#codeddescription) |  | The degree. |
| graduationDate | string (date) |  | The date the medical professional who attended the school graduated. | 

## OtherTraining

Provides the other training information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| program | [Program](#program) |  | Required. Program information. |
| specialty | [Specialty](#specialty) |  | Required. Specialty information. |
| programType | string | 80 | Required. The program type. |
| trainingStatus | string | 80 | Required. The medical professional's training status. |
| beginDate | string (date) |  | The date the medical professional started the training. |
| endDate | string (date) |  | The date the medical professional finished the training. |

## Phone

Provides the phone information of a medical professional

| Name | Type   | Field Length | Description |
| ---- | ------ | ------------ | ----------- |
| isPrimary  | boolean |  | Indicates whether the provided email address is the medical professional's primary. |
| phoneType | string | 80 | Indicates the phone type. |
| phoneNumber | string | 10 | The medical professional's phone number. |
| extension | string | 4 | The extension for the phone number. |

## ProfessionalName

Provides the name information of a medical professional

| Name | Type | Field Length | Description |
| - | - | - | - |
| isLegal  | boolean |  | Indicates whether the provided name is their legal name. |
| firstName| string | 50 | Required. The medical professional's first name. |
| middleName | string | 50 | The medical professional's middle name. |
| lastName | string | 50 | Required. The medical professional's last name. |
| suffix | string | 4 | The suffix the medical professional uses. |

## Program

Provides a medical professional's relevant program data 

| Name | Type | Field Length | Description |
| - | - | - | - |
| hospitalName | string | 80 | Required. The hospital's name. |
| affiliatedInstitution | string | 80 | The institution the program is affiliated with. |
| city | string | 40 | Required. The city where the hospital is located. |
| stateOrProvince | [Region](#region) |  | Required. The region where the hospital is located. |

## Region

Represents a state or province

| Name | Type | Field Length | Description |
| - | - | - | - |
| code  | string | 3 |Required. The state or province code. |
| description | string | 80 | Required. The name of the state or province. |
| countryCode | string | 2 | The ISO country code. |
| countryDescription | string | 80 | The name of the country. |

## School

Provides the medical school information of a medical professional 

| Name | Type | Field Length | Description |
| - | - | - | - |
| name  | string | 80 | Required. The name of the school. |
| cibisCode | string | 6 | The code that CIBIS uses to identify the school. |
| schoolType | [CodedDescription](#codeddescription) |  | Required. Practitioner Type for the school. |
| city | string | 40 | The name of the city where the school is located. |
| stateOrProvince | [Region](#region) |  | The state or province where the school is located. | 

## Specialty

Provides specialty information

| Name | Type | Field Length | Description |
| - | - | - | - |
| description | string | 160 | Required. Describes the specialty. |
