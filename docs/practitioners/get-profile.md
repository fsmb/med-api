# Get Profile

Get a medical professional's profile information with their associated FID

```HTTP 
GET {baseUrl}/v2/practitioners/{fid}/profile
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string| The API URL. |
| fid | path | True | string | The medical professional's FID. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [Profile](definition-profile.md) |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.cdc_read | Grants the ability to read a physician's profile. |

## Example

Input:

```HTTP
GET {baseUrl}/v1/practitioners/999999907/profile
```

Output:

```json
{
    "fid": "999999907",
    "identity": {
        "usmleId": "n/a",
        "birthDate": "1988-09-02",
        "birthCity": "",
        "birthStateOrProvince": {
            "code": "",
            "description": "",
            "countryCode": "",
            "countryDescription": "Unite"
        },
        "gender": "M"
    },
    "names": [
        {
            "isLegal": true,
            "firstName": "Javier",
            "middleName": "Martinez",
            "lastName": "Torres"
        }
    ]
}
```

For more examples go to [samples](/Samples/).
