# AvrAbmsCertification

ABMS certification

| Name | Type | Required | Description |
| - | - | - | - |
| memberBoard | string (len: 80) | Yes | ABMS member board name |
| certificationType | string (len: 80) | Yes | Certification type |
| certificationStatus | string (len: 80) | Yes | Certification status (e.g. Active, Inactive, Expired) |
| expirationDay | string (format: dd, digits, len: 2) | No | Expiration day |
| expirationMonth | string (format: mm, len: 2) | No | Expiration month |
| expirationYear | string (format: yyyy, len: 4) | No | Expiration year |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
