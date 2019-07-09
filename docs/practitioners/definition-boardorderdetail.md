# BoardOrderDetail

Provides information about a medical professional related to board orders and licensure

| Name | Type | Field Length | Description |
| - | - | - | - |
| fid  | string | 9 | FID of the medical professional. |
| orders | [BoardOrder[]](#boardOrder) |  | A collection of the professional's board orders. |
| licenses | [BoardOrderLicense[]](#boardorderlicense) |  | A collection of the professional's licenses. |

## BoardOrder

Provides information about a medical professional related to board orders

| Name | Type | Field Length | Description |
| - | - | - | - | 
| category  | string | 80 | The type of board order issued. |
| actions | [BoardOrderAction[]](#boardorderaction) | | A collection of actions taken against a medical professional. |

## BoardOrderAction

Board order action information.

| Name | Type | Field Length | Description |
| - | - | - | - | 
| actionCode  | string | 5 | The code. |
| actionDescription | string | 100 | The user-friendly description of the code. |

## BoardOrderLicense

Provides information about a medical professional related to licensure

| Name | Type | Field Length | Description |
| - | - | - | - |
| issuerName  | string | 80 | Required. Name of the entity who issued the license. |
| issuerShortName | string | 25 | Required. An abbreviation of the name of the entity who issued the license. |
| licenseNumber | string | 16 | Required. The license number. |
