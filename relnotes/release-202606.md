# Release June 2026

[What's New](#whats-new) \
[Breaking Changes](#breaking-changes) \
[Deprecated Features](#deprecated-features)

## What's New

- This release includes an upgrade of the runtime used by the API resulting in faster performance. See [Breaking Changes](#breaking-changes) for important information.
- This release adds a new [AVR](/docs/avr/readme.md) resource for retrieving the Provider Bridge AVR report for clients that previously used Provider Bridge directly.

## Breaking Changes

### Error Handling

As part of the runtime upgrade the JSON object returned by the API in the cases where the API reports an error has changed. Previously the FSMB-specific Error Response
object was returned. Going forward the standardized [RFC7807 Problem Details](https://tools.ietf.org/html/rfc7807) object is used for reporting errors. The new object is 
returned consistently for any status codes that report errors such as 400s and 500s.

For most clients that just check the status code no changes need to be made. Endpoints continue to return the same status codes as before. In some cases a client may want
more information about why an error occurred, such as for 400s, and may use the fields of the returned object to extract the specific error. In this case client code will
need to be updated to account for the differing formats.

| Old Field | New Field | Description |
| - | - | - |
| `code` | `type` | Provides a unique error code describing the error. The old field was a name while the new field is a URL, per the RFC. |
| `title` | `message` | A short summary of the problem in human-readable terms. |
| | `detail` | For some errors, a more detailed explanation of the error. |

Client code that is not updated to the newer format will continue to work based upon the status codes but will not have access to the more detailed error information, if available.

## Deprecated Features

- The `Imlcc` resource is deprecated. This resource was an internal resource and not designed for general use.
