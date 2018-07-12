# Profile

Provides profile information about a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| fid  | string | True | The medical professional's FID |
|identity| [Identification](#identification)| True | The medical professional's identity information |
|names |[ProfessionalName](#professionalname)[]| True | A collection of the medical professional's names |
|names |[ProfessionalName](#professionalname)[]| True | A collection of the medical professional's names |
|addresses| [Address](#address)[] | True | A collection of the medical professional's addresses|
|emailAddresses|[EmailAddress](#emailaddress)[]| True | A collection of the medical professional's email addresses |
|phones|[Phone](#phone)[]| True | A collection of the medical professional's phone numbers|
|medicalEducation|[MedicalEducation](#medicaleducation)[]| True | A collection of the medical professional's Medical Education |
|ecfmg|[ECFMG](#ecfmg)| False | The medical professional's ECFMG information|
|fifthPathway|[FifthPathway](#fifthpathway)| False | The medical professional's Fifth Pathway information |
|accreditedTraining| [AccreditedTraning](#accreditedtraining)[]| False | A collection of the medical professional's accredited training |
|otherTraining| [OtherTraining](#othertraining)[] | False | A collection of the medical professional's other training |
|activities| [Activity](#activity)[]| False |A collection of the medical professional's activities|

## AccreditedTraining

Provides the accredited training information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| accreditationType | string | False | The type of accreditation |
| programCode | string | True | The program code |
| program | [Program](#program) | True | Program information |
| specialty | [Specialty](#specialty) | True | Specialty information |
| programType | string | True | The program type |
| trainingStatus | string | True | The medical professional's training status |
| beginDate | DateTime | False | The date the medical professional started the accredited training |
| endDate | DateTime | False | The date the medical professional finished the accredited training |

## Activity

Provides information about an activity a medical professional took part in

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| type | string | True | The type of activity |
| inProgress | boolean | False | Indicates whether the activity is still in progress |
| beginDate | DateTime | False | The date the activity started |
| endDate | DateTime | False | The date the activity finished, if it has finished |
| description | string | True | The description of the activity |
| addressLines| string[] | True | A collection of address lines of where the activity has taken, or is taking, place |
| city | string | True | The name of the city where the activity has taken, or is taking, place |
| stateOrProvince | [Region](#region) | True | The region where the activity has taken, or is taking, place |
| postalCode | string | False | The postal code where the activity has taken, or is taking, place |
| position | string | False | The medical professional's position during the activity |
| department | string | False | The department the medical professional was in during the activity |
| wasEmployed | boolean | False | Indicates whether the medical professional was employed during the activity |
| hadStaffPrivilages | boolean | False | Indicates whether the medical professional had staff privileges over the duration of the activity |
| wasAffiliated | boolean | False | Indicates whether the medical professional had any affiliations during the duration of the activity |
| percentageClinical | integer | False | Represents how much of the activity was clinical |
| percentageAdministrative | integer | False | Represents how much of the activity was administrative |

## Address

Provides the address information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| isPrimary  | boolean | True | Indicates whether the provided address is the medical professional's primary address |
| addressType | string | True | Indicates what the address is for. Ex: Home, Business |
| lines | string[] | False | A collection of address lines of the address |
| city | string | True | The city name of the address |
| stateOrProvince| [Region](#region)| True | The state or province of the address|
| postalCode | string | True |The postal code of the address |

## ECFMG

Provides the ECFMG certification information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| ecfmgId | string | True | The medical professional's ECFMG ID |
| IssueDate | DateTime | False | The issue date of the certification |

## EmailAddress

Provides the email address information of a medical professional

| Name | Type   |Required | Description |
| ---- | ------ | ------- | ----------- |
| isPrimary  | boolean | False | Indicates whether the provided email address is the medical professional's primary email address |
| email | string | True |The medical professional's email address |

## FifthPathway

Provides the Fifth Pathway certification information of a medical professional 

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| school | [FifthPathwaySchool](#fifthpathwayschool) | True | The school the medical professional attended to receive their Fifth Pathway certification |
|startDate| DateTime | False | The date the medical professional started attendance at the Fifth Pathway school |
|endDate |DateTime| False | The date the medical professional finished attending the Fifth Pathway school |
|certificateDate | DateTime | False |The date the medical professional received their Fifth Pathway certification |

## FifthPathwaySchool

Provides the Fifth Pathway medical school information of a medical professional 

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| name  | string | True | The name of the school |
| affiliatedInstitution| string | True | The institution associated with the school |
| cibisCode | string | True |The code that CIBIS uses to identify the school |
| schoolType | [CodedDescription](codedDescription.md) | False | The degree information |
| city | string | False | The name of the city where the school is located |
| stateOrProvince | [Region](#region) | False | The state or province where the school is located | 

## Identification

Provides the identification information of the medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| ssnLast4  | string | False | The last four digits of the medical professional's SSN |
| npi | string | False | The National Provider Identifier |
| usmleId | string | False | The medical professional's USMLE identification number |
| birthDate | DateTime | False | The medical professional's date of birth |
| birthCity | string | True | The medical professional's city of birth |
| birthStateOrProvince | [Region](#region) | True | The medical professional's state or province of  birth  |
| gender | string | True | The medical professional's gender |

## MedicalEducation

Provides the medical education information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| school  | [School](#school) | True | School information |
| beginDate | DateTime | False |The date a medical professional started attending  a school |
| endDate | DateTime | False | The date a medical professional finished attending a school |
| degree | [CodedDescription](codedDescription.md) | False | The degree |
| graduationDate | DateTime | False |The date the medical professional who attended the school graduated | 

## OtherTraining

Provides the other training information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| program | [Program](#program) | True | Program information |
| specialty | [Specialty](#specialty) | True | Specialty information |
| programType | string | True | The program type |
| trainingStatus | string | True | The medical professional's training status |
| beginDate | DateTime | False | The date the medical professional started the training |
| endDate | DateTime | False | The date the medical professional finished the training |

## Phone

Provides the phone information of a medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| isPrimary  | boolean | Indicates whether the provided email address is the medical professional's primary |
| phoneType | string | Indicates the phone type |
| phoneNumber | string | The medical professional's phone number |
| extension | string | The extension for the phone number |

## ProfessionalName

Provides the name information of a medical professional

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| isLegal  | boolean | False | Indicates whether the provided name is their legal name |
| firstName| string | True | The medical professional's first name |
| middleName | string | False | The medical professional's middle name |
| lastName | string | True | The medical professional's last name |
| suffix | string | False | The suffix the medical professional uses |

## Program

Provides a medical professional's relevant program data 

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| hospitalName | string | True | The hospital's name |
| affiliatedInstitution | string | False | The institution the program is affiliated with |
| city | string | True | The city where the hospital is located |
| stateOrProvince | [Region](#region) | True | The region where the hospital is located |

## Region

Represents a state or province

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| code  | string | True | The state or province code |
| description | string | True | The name of the state or province |
| countryCode | string | The ISO country code |
| countryDescription | string | The name of the country |

## School

Provides the medical school information of a medical professional 

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| name  | string | True | The name of the school |
| cibisCode | string | False| The code that CIBIS uses to identify the school |
| schoolType | [CodedDescription](codedDescription.md) | True | Practitioner Type for the school |
| city | string | False | The name of the city where the school is located |
| stateOrProvince | [Region](#region) | False | The state or province where the school is located | 

## Specialty

Provides specialty information

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
|description | string | True | Describes the specialty |
