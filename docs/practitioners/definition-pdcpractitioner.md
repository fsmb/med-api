# PdcPractitioner

Provides information about a medical professional related to board orders and licensure

| Name | Type | Description |
| - | - | - |
| fid  | string | FID of the medical professional. |
| boardOrders | [BoardOrder[]](#boardOrder) |  A collection of the professional's board orders. |
| licenses | [License[]](#license) | A collection of the professional's licenses. |

## BoardOrder

Provides information about a medical professional related to board orders

| Name | Type | Description |
| - | - | - |
| category  | string | The type of board order issued. |
| actions | [CodedDescription[]](#codeddescription) | A collection of actions taken against a medical professional. |

## CodedDescription

Acts as a wrapper around a code and user-friendly description of the code

| Name | Type | Description |
| - | - | - |
| code  | string | The code. |
| description | string | The user-friendly description of the code. |

## License

Provides information about a medical professional related to licensure

| Name | Type | Description |
| - | - | - |
| issuerName  | string | Required. Name of the entity who issued the license. |
| issuerShortName | string | Required. An abbreviation of the name of the entity who issued the license. |
| licenseNumber | string | Required. The license number. |
