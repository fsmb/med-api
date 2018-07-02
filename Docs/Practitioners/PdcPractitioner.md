# PdcPractitioner

Holds the board order and licensing information of the medical professional

| Name | Type   | Description |
| ---- | ------ | ----------- |
| fid  | string | Federation ID of the medical professional |
| boardOrders | [BoardOrder](#boardOrder) array| A collection of the professional's board orders |
| licenses | [License](#license) array | a collection of the professional's licenses |

## Board Order

Holds relevant information regarding a board order

| Name | Type   | Description |
| ---- | ------ | ----------- |
| category  | string | The type of board order issued |
| actions | [CodedDescription](CodedDescription.md) array| The actions taken |

## License

Holds relevant information regarding a license

| Name | Type   | Description |
| ---- | ------ | ----------- |
| issuerName  | string | Name of the entity who issued the license |
| issuerShortName | string | An abbreviation of the name of the entity who issued the license |
| licenseNumber | string | The license number |