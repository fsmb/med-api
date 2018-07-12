# Retrieve Profile

Retrieves a medical professional's profile information with their associated FID

```HTTP 
GET {baseUrl}/v1/practitioners/{fid}/profile
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| `baseUrl` | path | True | string| The API url |
| `fid` | path | True | string | The medical professional's FID |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | [Profile](../types/profile.md) |
| 400  | Bad Request     |  |
| 401  | Unauthorized    |  |
| 500  | Server Error    |  |

## Scope

This request requires the OAuth scopes of `med.read` and `med.cdc_read` in order to execute.

## Example

Input:

```HTTP
GET {baseUrl}/v1/practitioners/205147010/profile
```

Output:

```json
{
    "fid": "205147010",
    "identity": {
        "usmleId": "n/a",
        "birthDate": "1950-01-23",
        "birthCity": "Euless",
        "birthStateOrProvince": {
            "code": "TX",
            "description": "Texas",
            "countryCode": "US",
            "countryDescription": "United States"
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

For language specific examples go to [samples](/Samples/)
