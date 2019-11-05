# MED API

This is the source for technical information for the MED API. This API can be used to handle basic physician validation and obtain summary licensure or physician information. 

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code please contact [FSMB](mailto:pdc@fsmb.org).

- URL
  - Demo: https://demo-services.fsmb.org/med/
  - Production: https://services.fsmb.org/med/
- [Postman Collection](https://www.getpostman.com/collections/2017e45ba7c7fe1def97)
- [OpenAPI Specification](https://demo-services.fsmb.org/med/_swagger/v1)

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/2017e45ba7c7fe1def97)
## Change Log

| Version | Date | Release Notes |
| - | - | -|
| 2.1 | 11/13/2019 | Added training endpoint to Practitioner resource. |
| 2.0 | 6/6/2019 | Updated search endpoint. | 
| 1.2 | 3/13/2019 | Retrieve a physician's PDC profile. |
| 1.1 | 1/25/2017 | |
| 1.0 | 9/22/2016 | Initial version |

## Security

### Scopes 

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.source_read | Grants the ability to read basic board order and licensure information. |
| med.cdc_read | Grants the ability to read a physician's profile. |
| med.pdc_read | Grants the ability to read a physician's PDC profile. |
| med.bio_read | Grants the ability to read a physician's verified information. |

## Resources

Refer to the section on [test data](docs/test-data.md) for information about test data that can be used in the Demo environment.

- [Licensure](docs/licensure/README.md)
- [Practitioners](docs/practitioners/README.md)
