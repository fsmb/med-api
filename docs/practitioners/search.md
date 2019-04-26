# Search

Finds a medical professional based upon the search criteria provided
 
```HTTP 
GET {baseUrl}/v2/practitioners/search?firstName={firstname}&lastName={lastname}&middleName={middlename}&suffix={suffix}&licenseNumber={license}&&deaNumber={dea}&npi={npi}
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| firstName | query | True | string | The first name of the medical professional.  |
| middleName | query | False | string | The middle name of the medical professional.  |
| lastName | query | True | string | The last name of the medical professional.  |
| suffix | query | False | string | The suffix of the medical professional.  |
| npi | query | * | string | The medical professional's NPI number. |
| deaNumber | query | * | string | The medical professional's DEA number. |
| licenseNumber | query | * | string| The medical professional's license number. |

<sub>*At least one of the medical professinoal's identifying numbers is required to search. (npi,licenseNumber,deaNumber)</sub>

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

### Find by FirstName, LastName and License number
This is finding a medical professional by first name, last name and license number.

Input:

```HTTP
GET {{baseUrl}}/v2/practitioners/search?firstName=alexa&lastName=wood checkey&licenseNumber=TEST12345
```

Output:
 
```json
{ 
  "fid": "999999907" 
} 
```

