# Get AVR Profile

Gets the AVR profile for a physician.

```http
GET {baseUrl}/v1/avr/{fid}
```

## URI Parameters

| Name | In | Required | Type | Description |
| - | - | - | - | - |
| baseUrl | path | True | string | The API URL. |
| fid | path | True | string | FID of the physician. |

## Responses

| Name | Type | Description |
| - | - | - |
| 200 OK | [AvrProfile](types/avr-profile.md) | Success |
| 400 Bad Request | | FID is invalid. |
| 401 Unauthorized | | Unauthorized. |
| 404 Not Found | | Physician not found. |

## Security

Required scopes

- med.avr_read

## Examples

[Get AVR](#get-avr) 

***

### Get AVR

#### Sample Request

```http
GET {baseUrl}/v1/avr/999999915
```

#### Sample Response

Status code: 200

Note: Output is elided. Refer to [AVR Profile](types/avr-profile.md) for a complete example.

```json
{
   "fid": "999999915",
   "reportDateUtc": "2026-06-16T12:00:00Z",
   "identity": {
      "birthDate": "1978-08-08",
      "npi": null
   },
   "names": {
      "legalName": {
          "firstName": "Philip",
          "middleName": "James",
          "lastName": "Testman"          
      },
      "alternateNames": []
   }   
}
```
