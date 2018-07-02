# Profile

Holds the profile information of the practitioner

| Name | Type   | Description |
| ---- | ------ | ----------- |
| fid  | string | The practitioner's federation ID |
|identity| [Identification](#identification)| The practitioner's identity information |
|names |[Name](#name)[]| The practitioners's names |
|addresses| [Address](#address)[] | The practitioner's addresses|
|emailAddresses|[EmailAddress](#emailAddress)[]| The practitioner's email addresses |
|phones|[Phone](#phone)[]| The practitioner's phone numbers|
|medicalEducation|[MedicalEducation](#medicalEducation)[]| The practitioner's Medical Education |
|ecfmg|[Ecfmg](#ecfmg)| The practitioner's Ecfmg information|
|fifthPathway|[FifthPathway](#fifthPathway)| The practitioner's Fifth Pathway information |
|accreditedTraining| [AccreditedTraning](#accreditedTraining)[]| The practitioner's accredited training |
|otherTraining| [OtherTraining](#otherTraining)[] | The practitioner's other training |
|activities| [Activity](#activity) []| The practitioner's activities|

## AccreditedTraining

Holds the accredited training information of the medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| accreditationType | string | The type of accreditation. Ex: ACGME, AOA |
| programCode | string | The program code |
| program | [Program](#program) | Program information |
| specialty | [Specialty](#specialty) | Specialty information |
| programType | string | The program type |
| trainingStatus | string | The practitioner's training status |
| beginDate | DateTime | The date the practitioner started the accredited training |
| endDate | DateTime | The date the practitioner finished the accredited training |

## Activity

Holds activity information

| Name | Type   | Description |
| ---- | ------ | ----------- |
| type | string | The type of activity |
| inProgress | boolean | Indicates whether the activity is still in progress |
| beginDate | DateTime | The date the activity started |
| endDate | DateTime | The date the activity finished, if it has finished |
| description | string | The description of the activity |
| addressLines| string array | The address lines of where the activity has taken, or is taking, place |
| city | string | The name of the city where the activity has taken, or is taking, place |
| stateOrProvince | [Region](#region) | The region where the activity has taken, or is taking, place |
| postalCode | string | The postalCode where the activity has taken, or is taking, place |
| position | string | The person's position during the activity |
| department | string | The department the person was located in during the activity |
| wasEmployed | boolean | Indicates whether the person was employed during the activity |
| hadStaffPrivilages | boolean | Indicates whether the person had staff privileges over the duration of the activity |
| wasAffiliated | boolean | Indicates whether the person had any affiliations during the duration of the activity |
| percentageClinical | integer | How much of the activity was clinical? |
| percentageAdministrative | integer | How much of the activity was administrative? |

## Address

Holds the address information of the medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| isPrimary  | boolean | Indicates whether the provided address is the person's primary address |
| addressType | string | Indicates what the address is for. Ex: Home, Business |
| lines | string array | The address lines of the address |
| city | string | The city name of the address |
| stateOrProvince| [Region](#region)| The state or province of the address|
| postalCode | string | The postal code of the address |

## Ecfmg

Holds information regarding the practitioner's Ecfmg certification

| Name | Type   | Description |
| ---- | ------ | ----------- |
| ecfmgId | string | The practitioner's ecfmg ID |
| IssueDate | DateTime | The issue date of the certification |

## EmailAddress

Holds a person's email address

| Name | Type   | Description |
| ---- | ------ | ----------- |
| isPrimary  | boolean | Indicates whether the provided email address is the person's primary email address |
| email | string | The person's email address |

## FifthPathway

Holds information regarding the practitioner's Fifth Pathway certification

| Name | Type   | Description |
| ---- | ------ | ----------- |
| school | [FifthPathwaySchool](#fifthPathwaySchool) | The school the practitioner attended to receive their FifthPathway certification |
|startDate| DateTime | The date the practitioner started attendance at the Fifth Pathway school |
|endDate |DateTime| The date the practitioner finished attending the Fifth Pathway school |
|certificateDate | DateTime |The date the practitioner received their Fifth Pathway certification |

## FifthPathwaySchool

Holds information regarding a specified medical school

| Name | Type   | Description |
| ---- | ------ | ----------- |
| name  | string | The name of the school |
| affiliatedInstitution| string | The institution associated with the school, if any |
| cibisCode | string | The code that Cibis uses to identify the school |
| schoolType | [CodedDescription](CodedDescription.md) | The degree information |
| city | string | The name of the city where the school is located |
| stateOrProvince | [Region](#region) |  The state or province where the school is located | 

## Identification

Holds the federation id of the medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| ssnLast4  | string | The last four digits of the practitioner's SSN |
| npi | string | The Canadian unique identifier |
| usmleId | string | The practitioner's Usmle identification number |
| birthDate | DateTime | The practitioner's date of birth |
| birthCity | string | The practitioner's birth city |
| birthStateOrProvince | [Region](#region) | The practitioner's birth state or province |
| gender | string | The practitioner's gender |

## MedicalEducation

Holds information surrounding a person's medical education

| Name | Type   | Description |
| ---- | ------ | ----------- |
| school  | [School](#school) | School information |
| beginDate | DateTime | The date a person started attending  a school |
| endDate | DateTime | The date a person finished attending a school |
| degree | [CodedDescription](CodedDescription.md) | An object containing degree information |
| graduationDate | DateTime | The date the person who attended the school graduated | 

## Name

Holds name information

| Name | Type   | Description |
| ---- | ------ | ----------- |
| isLegal  | boolean | Indicates whether the provided name is their legal name |
| firstName| string | The person's first name |
| middleName | string | The person's middle name |
| lastName | string | The person's last name |
| suffix | string | The suffix the person uses |

## OtherTraining

Holds the other training information of the medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| program | [Program](#program) | Program information |
| specialty | [Specialty](#specialty) | Specialty information |
| programType | string | The program type |
| trainingStatus | string | The practitioner's training status |
| beginDate | DateTime | The date the practitioner started the training |
| endDate | DateTime | The date the practitioner finished the training |

## Phone

Holds a person's phone number

| Name | Type   | Description |
| ---- | ------ | ----------- |
| isPrimary  | boolean | Indicates whether the provided email address is the person's primary |
| phoneType | string | Indicates the phone type. Ex: Business, Home, Mobile |
| phoneNumber | string | The person's phone number |
| extension | string | The extension for the phone number, if necessary |

## Program

Holds a program's relevant data 

| Name | Type   | Description |
| ---- | ------ | ----------- |
| hospitalName | string | The hospital's name |
| affiliatedInstitution | string | The institution the program is affiliated with, if any |
| city | string | The city where the hospital is located |
| stateOrProvince | [Region](#region) | The region where the hospital is located |

## Region

Holds fields that describe a region

| Name | Type   | Description |
| ---- | ------ | ----------- |
| code  | string | The state or province code |
| description | string | The name of the state or province |
| countryCode | string | The country code |
| countryDescription | string | The name of the country |

## School

Holds information regarding a specified medical school

| Name | Type   | Description |
| ---- | ------ | ----------- |
| name  | string | The name of the school |
| cibisCode | string | The code that Cibis uses to identify the school |
| schoolType | [CodedDescription](CodedDescription.md) | Degree information |
| city | string | The name of the city where the school is located |
| stateOrProvince | [Region](#region) | The state or province where the school is located | 

## Specialty

Holds specialty information

| Name | Type   | Description |
| ---- | ------ | ----------- |
|description | string | describes the specialty |