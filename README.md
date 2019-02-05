# MED API

This is the source for technical information for the MED API. This API can be used to handle basic physician validation and obtain summary licensure information. 

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code please contact [FSMB](mailto:pdc@fsmb.org).

- URL
  - Demo: https://demo-services.fsmb.org/med/
  - Production: https://services.fsmb.org/med/
- [Postman Collection](https://www.getpostman.com/collections/9a0b2ee0820c9b39c286)
- [OpenAPI Specification](https://demo-services.fsmb.org/med/_swagger/v1)

## Change Log

| Version | Date | Release Notes |
| - | - | -|
| 1.0 | 9/22/2016 | Initial version |
| 1.1 | 1/25/2017 | |

## Security

### Scopes 

| Scope | Description |
| - | - |
| med.read | Grants the ability to read basic physician information. |
| med.cdc_read | Grants the ability to read basic board order and licensure information. |
| med.source_read | Grants the ability to read a physician's profile. |

## Common Tasks

### Find a Physician

Use [find a physician](docs/practitioner/find-physician.md) to find a physician using their basic identity information.

### Get Licensure Information

Use [retrieve board orders and licenses](docs/practitioners/retrieve-licenses.md) to get basic licensure and board order information.

## Resources

- [Licensure](docs/licensure/readme.md)
- [Practitioners](docs/practitioners/readme.md)
