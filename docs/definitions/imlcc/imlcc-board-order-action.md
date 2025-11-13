# ImlccBoardOrderAction

Board order action

| Name | Type | Required | Description |
| - | - | - | - |
| actionCode | string | Yes | Action code |
| actionCodeDescription | string | Yes | Action code description |
| category | string | Yes | Action category |
| effectiveDate | string (date) | No | Effective date |
| expirationDate | string (date) | No | Expiration date |
| termDays | integer | No | Term days |
| termMonths | integer | No | Term months |
| termYears | integer | No | Term years |
| isPrejudicial | boolean | No | Prejudicial indicator |
| isIndefinite | boolean | Yes | Indefinite indicator |
| note | string | No | Notes |
| actionStayedCode | string | No | Action stayed code |
| actionStayDescription | string | No | Action stayed description |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
