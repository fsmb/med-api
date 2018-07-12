# PdcPractitioner

Provides information about a medical professional related to board orders and licensure

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| fid  | string | False | FID of the medical professional |
| boardOrders | [BoardOrder](#boardOrder)[]| False | A collection of the professional's board orders |
| licenses | [License](#license)[] | False | A collection of the professional's licenses |

## BoardOrder

Provides information about a medical professional related to board orders

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| category  | string | False | The type of board order issued |
| actions | [CodedDescription](codedDescription.md)[]| False | A collection of actions taken against a medical professional |

## License

Provides information about a medical professional related to licensure

| Name | Type   | Required | Description |
| ---- | ------ | -------- | ----------- |
| issuerName  | string | True | Name of the entity who issued the license |
| issuerShortName | string | True | An abbreviation of the name of the entity who issued the license |
| licenseNumber | string | True | The license number |
