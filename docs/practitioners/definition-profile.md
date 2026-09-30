# Profile

Provides profile information about a medical professional

| Name | Type | Required | Description |
| - | - | - | - |
| fid  | string (len: 9, format: digits) | Y | FID of the physician |
| identity| [Identification](#identification) | Y | Identity information |
| names | [ProfessionalName[]](#professionalname) | Y | List of names |
| addresses | [Address[]](#address) | Y | List of mailing addresses |
| emailAddresses | [EmailAddress[]](#emailaddress) | Y | List of email addresses |
| phones | [Phone[]](#phone) | Y | List of phone numbers |
| medicalEducation | [MedicalEducation[]](#medicaleducation) | Y | Medical education |
| ecfmg | [ECFMG](#ecfmg) | N | ECFMG information, if any |
| fifthPathway | [FifthPathway](#fifthpathway) | N | Fifth Pathway information, if any |
| accreditedTraining | [AccreditedTraning[]](#accreditedtraining) | N | Accredited training |
| otherTraining | [OtherTraining[]](#othertraining) | N | Nonaccredited training |
| activities | [Activity[]](#activity) | N | Activities |

## AccreditedTraining

Provides the accredited training information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - |
| accreditationType | string (len: 5) | Y | Accreditation type (e.g. ACGME) |
| programCode | string (len: 10)  | Y | Program code |
| program | [Program](#program) | Y | Program information |
| specialty | [Specialty](#specialty) | Y | Specialty information |
| programType | string (len: 80) | Y | Type of program |
| trainingStatus | string (len: 80) | Y | Training status (e.g. Active, Complete) |
| beginDate | string (date) | N | Start date of the training |
| endDate | string (date) | N | End date of the training |

## Activity

Provides information about an activity a medical professional took part in

| Name | Type | Required | Description |
| - | - | - | - |
| type | string (len: 80) | Y | Type of activity (e.g. Work) |
| inProgress | boolean | Y | Indicates whether the activity is still in progress |
| beginDate | string (date) | Y  | Start date of the activity |
| endDate | string (date) | N | End date of the activity, if completed |
| description | string (len: 80) | Y | Description of activity |
| addressLines| string[] (len: 100) | Y | List of address lines where the activity has taken, or is taking, place |
| city | string (len: 40) | Y | City where the activity has taken, or is taking, place. |
| stateOrProvince | [Region](#region) | Y | Region where the activity has taken, or is taking, place |
| postalCode | string (len: 9) | N | Postal code where the activity has taken, or is taking, place |
| position | string (len: 80) | Y | The medical professional's position during the activity |
| department | string (len: 80) | Y | The department the medical professional was in during the activity |
| wasEmployed | boolean | Y | Indicates whether the medical professional was employed during the activity |
| hadStaffPrivilages | boolean | Y | Indicates whether the medical professional had staff privileges over the duration of the activity |
| wasAffiliated | boolean | Y | Indicates whether the medical professional had any affiliations during the duration of the activity |
| percentageClinical | integer | Y | Percentage of the activity that was clinical |
| percentageAdministrative | integer | Y | Percentage of the activity that was administrative |

## Address

Provides the address information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - |
| isPrimary | boolean | Y | Indicates if this is the primary address |
| addressType | string (len: 80) | Y | Address type (e.g. Home, Business) |
| lines | string[] (len: 100) | Y | List of address lines |
| city | string (len: 40) | Y | City |
| stateOrProvince| [Region](#region) | Y | State or province |
| postalCode | string (len: 9) | Y | Postal code |

## CodedDescription

Acts as a wrapper around a code and user-friendly description of the code

| Name | Type | Required | Description |
| - | - | - | - | 
| code  | string (len: 5) | Y | Code |
| description | string (len: 80) | N | User-friendly description |

## ECFMG

Provides the ECFMG certification information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - |
| ecfmgId | string (len: 8) | Y |  ECFMG ID|
| IssueDate | string (date) | N | Issue date of the certification |

## EmailAddress

Provides the email address information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - | 
| isPrimary | boolean | Y | Indicates if this is the primary email address |
| email | string (len: 80) | Y | Email address |

## FifthPathway

Provides the Fifth Pathway certification information of a medical professional 

| Name | Type | Required | Description |
| - | - | - | - | 
| school | [FifthPathwaySchool](#fifthpathwayschool) | Y | Fifth Pathway school |
| startDate | string (date) | Y | Attendance start date |
| endDate | string (date) | Y | Attendance end date |
| certificateDate | string (date) | N | Fifth Pathway certification date |

## FifthPathwaySchool

Provides the Fifth Pathway medical school information of a medical professional 

| Name | Type | Required | Description |
| - | - | - | - |
| name  | string (len: 80) | Y | School name |
| affiliatedInstitution| string (len: 80) | Y | Institution associated with the school |
| cibisCode | string (len: 6) | Y | School CIBIS code |
| schoolType | [CodedDescription](#codeddescription) | Y | School degree type (e.g. MD, DO) |
| city | string (len: 40) | Y | City where school was located |
| stateOrProvince | [Region](#region) | Y | State or province where the school was located | 

## Identification

Provides the identification information of the medical professional

| Name | Type |  Required | Description |
| - | - | - | - |
| ssnLast4  | string (len: 4) | Y | SSN last four digits |
| npi | string (len: 10) | N | National Provider Identifier |
| usmleId | string (len: 8) | N | USMLE ID |
| birthDate | string (date) | Y | Date of birth |
| birthCity | string (len: 40) | Y | City of birth |
| birthStateOrProvince | [Region](#region) | Y | State or province of  birth |
| gender | string (len: 1) | Y | Gender (e.g. M, F) |

## MedicalEducation

Provides the medical education information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - | 
| school | [School](#school) | Y | School information |
| beginDate | string (date) | Y | Attendance start date |
| endDate | string (date) | Y | Attendance end date |
| degree | [CodedDescription](#codeddescription) | N | Degree, if graduated |
| graduationDate | string (date) | N | Graduation date, if graduated | 

## OtherTraining

Provides the other training information of a medical professional

| Name | Type | Required | Description |
| - | - | - | - |
| program | [Program](#program) | Y | Program information |
| specialty | [Specialty](#specialty) | Y | Specialty information |
| programType | string (len: 80) | Y | Program type |
| trainingStatus | string (len: 80) | Y | Training status (e.g. Active, Completed) |
| beginDate | string (date) | Y | Training start date |
| endDate | string (date) | Y | Training end date |

## Phone

Provides the phone information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | ------------ | ----------- |
| isPrimary  | boolean | Y | Indicates if this is the primary phone number |
| phoneType | string (len: 80) | Y | Phone type (e.g. Home, Business) |
| phoneNumber | string (len: 10) | Y | Phone number |
| extension | string (len: 4) | N | Phone extension |

## ProfessionalName

Physician name

| Name | Type | Required | Description |
| - | - | - | - |
| isLegal | boolean | Y | Indicates whether the provided name is the legal name |
| firstName| string (len: 50) | Y | First name (If `isSingularName` is true then this value should be ignored) |
| middleName | string (len: 50)  | N | Middle name, if any |
| lastName | string (len: 50) | Y | Last name |
| suffix | string (len: 4) | N | Suffix, if any |
| isSingularName | boolean | Y | Indicates if this is a singular name | 

## Program

Provides a medical professional's relevant program data 

| Name | Type | Required | Description |
| - | - | - | - |
| hospitalName | string (len: 80) | Y | Hospital name |
| affiliatedInstitution | string (len: 80) | N | Affiliated institution name, if any |
| city | string (len: 40) | Y | City |
| stateOrProvince | [Region](#region) | Y | State or province |

## Region

Represents a state or province

| Name | Type | Required | Description |
| - | - | - | - |
| code  | string (len: 3) | Y | State or province code |
| description | string (len: 80) | Y | State or province name |
| countryCode | string (len: 2) | Y | ISO country code |
| countryDescription | string (len: 80) | Y | Country name |

## School

Provides the medical school information of a medical professional 

| Name | Type | Required | Description |
| - | - | - | - |
| name  | string (len: 80) | Y | School name |
| cibisCode | string (len: 6) | Y | CIBIS code |
| schoolType | [CodedDescription](#codeddescription) | Y | School type (e.g. MD, DO) |
| city | string (len: 40) | Y | City where school is located |
| stateOrProvince | [Region](#region) | Y | State or province where the school is located | 

## Specialty

Provides specialty information

| Name | Type | Required | Description |
| - | - | - | - |
| description | string (len: 160) | Y | Specialty description |
