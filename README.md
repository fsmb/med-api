# MED API

This is the source for technical information for the MED API. This API can be used to handle basic physician validation and obtain summary licensure or physician information. 

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code please contact [FSMB](mailto:pdc@fsmb.org).

- URL
  - Demo: https://services-med-demo.fsmb.org/
  - Production: https://services-med.fsmb.org/
- [Postman Collection](https://www.getpostman.com/collections/2017e45ba7c7fe1def97)
- [OpenAPI Specification](https://services-med-demo.fsmb.org/_swagger/v2)
- [Authentication Docs](https://github.com/fsmb/api-docs/blob/master/docs/authentication.md)

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/2017e45ba7c7fe1def97#?env%5BMED%20(Demo)%5D=W3sia2V5IjoiYmFzZVVybCIsInZhbHVlIjoiaHR0cHM6Ly9zZXJ2aWNlcy1tZWQtZGVtby5mc21iLm9yZyIsImVuYWJsZWQiOnRydWV9LHsia2V5IjoiY2xpZW50SWQiLCJ2YWx1ZSI6IkRPX05PVF9TRVQiLCJlbmFibGVkIjp0cnVlfSx7ImtleSI6ImNsaWVudFNlY3JldCIsInZhbHVlIjoiRE9fTk9UX1NFVCIsImVuYWJsZWQiOnRydWV9LHsia2V5IjoiYWNjZXNzVG9rZW4iLCJ2YWx1ZSI6IlNFVF9CWV9BVVRIRU5USUNBVElPTiIsImVuYWJsZWQiOnRydWV9XQ==)

## Change Log

| Version | Date | Release Notes |
| - | - | -|
| 2.11 | 12/4/2020 | Updated Postman collection and added verification indicators to training. |
| 2.10 | 11/16/2020 | Added optional authorization endpoint to MedAPI. |
| 2.9 | 10/29/2020 | Updated PDC Profile endpoint. |
| 2.8 | 9/10/2020 | Included NCCPA certification information in PDC profile for ABMS scope. |
| 2.7 | 8/19/2020 | Added ABMS certification scope and information to PDC profile. |
| 2.3 | 2/19/2020 | Added new BoardOrders resource. | 
| 2.2 | 12/17/2019 | Updated Urls. |
| 2.1 | 11/13/2019 | Added training endpoint to Practitioner resource. |
| 2.0 | 6/6/2019 | Updated search endpoint. | 
| 1.2 | 3/13/2019 | Retrieve a physician's PDC profile. |
| 1.1 | 1/25/2017 | |
| 1.0 | 9/22/2016 | Initial version |

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
