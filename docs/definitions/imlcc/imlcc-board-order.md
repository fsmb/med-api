# ImlccBoardOrder

Board order for IMLCC

| Name | Type | Required | Description |
| - | - | - | - |
| id | integer | Yes | Order ID |
| reportingEntity | [ReportingEntity](imlcc-reporting-entity.md) | Yes | Reporting entity |
| category | [BoardOrderCategory](imlcc-board-order-category.md) | Yes | Board order category |
| date | string (date) | No | Board order date |
| effectiveDate | string (date) | No | Effective date |
| hasAppeal | boolean | Yes | Appeal indicator |
| appealDate | string (date) | No | Appeal date |
| actions | [BoardOrderAction[]](imlcc-board-order-action.md) | No | Board order actions |
| bases | [BoardOrderBasis[]](imlcc-board-order-basis.md) | No | Board order bases |
| usmleId | string (format: digits, len: 8) | No | USMLE ID |

*Note: Any fields marked as deprecated will be removed in a future version of the API. New code should not rely on these fields. Existing code should be updated to use alternative fields.*
