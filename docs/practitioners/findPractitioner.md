# Find a Practitioner

Finds a medical professional based upon the search criteria provided
 
```HTTP 
GET {baseUrl}/v1/practitioners/search?name={name}&birthDate={date}&ssnlast4={ssn}&licenseNumber={license}
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API url |
| `name` | query | True | string | The full name of the medical professional  |
| `date` | query | True | DateTime| The birth date of the medical professional  formatted as mm/dd/yyyy |
| `ssn` | query | * | string | The last four numbers of the medical professional's social security number (SSN) |
|`license`| query | *| string| The medical professional's license number|

<sub>*If ssn is provided then license is not required and vice versa. Only provide one or the other. </sub>

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [MedicalProfessionalIdentity](../types/medicalProfessionalIdentity.md)  |
| 400  | Bad Request     |  |
| 401  | Unauthorized    |  |
| 500  | Server Error    |  |

## Scope

This request requires an OAuth scope of `med.read` in order to execute.

## Examples


### Find by Name, Birth Date and SSN
This is finding a medical professional by name, birth date and SSN. 

Input:

```HTTP
GET {baseUrl}/v1/practitioners/search?name=Javier Martinez Torres&birthDate=01/23/1950&ssnlast4=1234
```

Output:
 
```json
{ 
  "fid": "205147010" 
} 
```

### Find by Name, Birth Date and License
This is finding a medical professional by name, birth date and License. 

Input:

```HTTP
GET {baseUrl}/v1/practitioners/search?name=Javier Martinez Torres&birthDate=01/23/1950&licenseNumber=A-51871
```

Output:
 
```json
{ 
  "fid": "205147010" 
} 
```

For language specific examples go to [samples](/Samples/)
