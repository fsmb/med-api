# Get AVR Report

Gets the AVR report for a physician. The report is returned as a PDF.

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
| 200 OK | PDF file | Success |
| 400 Bad Request | | FID is invalid. |
| 401 Unauthorized | | Unauthorized. |
| 404 Not Found | | Physician not found. |

## Security

Required scopes

- med.avr_read

## Examples

[Get AVR PDF](#get-avr-pdf) 

***

### Get AVR PDF

#### Sample Request

```http
GET {baseUrl}/v1/avr/999999915
```

#### Sample Response

Status code: 200

Body: PDF file
