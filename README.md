# MED API

The MED API provides common search functionality for FSMB data. This API can be used to find basic information about physicians. 

Refer to the [Getting Started](https://github.com/fsmb/api-docs) guide to learn more general information about FSMB APIs, terminology, authentication, FSMB codes and more. For more information and to begin using this API please contact [FSMB](mailto:pdc@fsmb.org).

- URL
  - Demo: `https://services-med-demo.fsmb.org/`
  - Production: `https://services-med.fsmb.org/`  
- Authentication URL `<baseUrl>/connect/token`
- [Postman Workspace](https://www.postman.com/crimson-shadow-2749/workspace/public-fsmb/collection/1384052-7eb29d9c-dac0-4d7b-b706-a4a2a029fbfc?action=share&creator=1384052&active-environment=1384052-a89b4dab-0ca9-4159-ad5c-0b8c0b1c141d)
- [OpenAPI Specification](https://services-med-demo.fsmb.org/_swagger/v2)

## Change Log

| Date | Release Notes |
| - | -|
| 3 Feb 2021 | Added profession to PDC Profile.
| 4 Dec 2020 | Updated Postman collection and added verification indicators to training. |
| 16 Nov 2020 | Added optional authorization endpoint to MedAPI. |
| 20 Oct 2020 | Updated PDC Profile endpoint. |
| 10 Sep 2020 | Included NCCPA certification information in PDC profile for ABMS scope. |
| 19 Aug 2020 | Added ABMS certification scope and information to PDC profile. |
| 19 Feb 2020 | Added new BoardOrders resource. | 
| 17 Dec 2019 | Updated Urls. |
| 13 Nov 2019 | Added training endpoint to Practitioner resource. |
| 6 Jun 2019 | Updated search endpoint. | 
| 13 Mar 2019 | Retrieve a physician's PDC profile. |
| 22 Sep 2016 | Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| med.bio_read | Grants the ability to read a physician's verified information. |
| med.cdc_read | Grants the ability to read a physician's profile. |
| med.read | Grants the ability to read basic physician information. |
| med.order_read | Grants the ability to read a physician's public board order information. |
| med.pdc_read | Grants the ability to read a physician's PDC profile. |
| med.pdc_read.abms | Includes ABMS certifications and NCCPA certification info with a physician's PDC profile. |
| med.source_read | Grants the ability to read basic board order and licensure information. |

## Resources

- [Licensure](docs/licensure/README.md)
- [Practitioners](docs/practitioners/README.md)
- [BoardOrders](docs/boardOrders/README.md)
