# MED API

This is the source for technical information for the Federation of State Medical Boards' MED API. This API can be used to obtain basic physician validation and licensure information. 

To learn more about FSMB APIs refer to the [Getting Started](https://github.com/fsmb/api-docs) guide. To learn more about this API and to begin using it in your code please contact [FSMB](mailto:pdc@fsmb.org).

## Authentication

The following OAuth2 scopes are defined for this API.

| Scope | Description |
| - | - |
| med.read | Provides read access to the API. |
| med.source_read | Provides read access to basic physician information. |

## API URLs

The following URLs are used to access the MED API.

- Demo: https://demo-services.fsmb.org/med/
- Production: https://services.fsmb.org/med/

## Resources

- [Practitioners](docs/practitioners/README.md)
- [Licensure](docs/licensure/README.md)
