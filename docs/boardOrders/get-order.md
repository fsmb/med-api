# Get order

Get a medical professional's board order with their associated fid and the board order ID.

```HTTP
GET {baseUrl}/v2/physicianOrders/{fid}/{orderId}
```

## URI Parameters

| Name | In | Required | Type | Description |
| ---- | -- | -------- | ---- | ----------- |
| baseUrl | path | True | string | The API URL. |
| fid | path | True | string | The medical professional's FID. |
| orderId | path | True | long | The ID of the Board Order. |

## Responses

| Name | Description     | Type  |
| ---- | --------------- | ----- |
| 200  | OK              | PDF File. |
| 404  | Not Found       | |

## Security

### Scopes

| Scope | Description |
| - | - |
| med.order_read | Grants the ability to read a physician's public board order information. |

