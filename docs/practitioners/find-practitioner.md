# Search

Finds a medical professional based upon the search criteria provided
 
```HTTP 
GET {baseUrl}/v1/practitioners/search?name={name}&birthDate={date}&ssnlast4={ssn}&licenseNumber={license}
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API URL. |
| `name` | query | True | string | The full name of the medical professional.  |
| `date` | query | True | DateTime| The birth date of the medical professional formatted as `mm/dd/yyyy`. |
| `ssn` | query | * | string | The last four numbers of the medical professional's social security number (SSN). |
|`license`| query | * | string| The medical professional's license number. |

<sub>*If ssn is provided then license is not required and vice versa. Only provide one or the other. </sub>

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [MedicalProfessionalIdentity](definition-medicalprofessionalidentity.md)  |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |

## Examples

### Find by Name, Birth Date and SSN
This is finding a medical professional by name, birth date and SSN. 

Input:

```HTTP
GET {baseUrl}/v1/practitioners/search?name=Alexa Wood Checkey&birthDate=09/02/1988&ssnlast4=8888
```

Output:
 
```json
{ 
  "fid": "999999907" 
} 
```

### Find by Name, Birth Date and License
This is finding a medical professional by name, birth date and License. 

Input:

```HTTP
GET {baseUrl}/v1/practitioners/search?name=Alexa Wood Checkey&birthDate=09/02/1988&licenseNumber=TEST12345
```

Output:
 
```json
{ 
  "fid": "999999907" 
} 
```

For more examples go to [samples](/Samples/).
