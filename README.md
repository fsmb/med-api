# MED API


This is the source for technical information for the Federation of State Medical Boards' Federation Credentials Verification Service (MED) [REST API](https://en.wikipedia.org/wiki/Representational_state_transfer). 
The MED API is one of the interfaces available for MED data retrieval by state medical boards (SMBs). 

If you are interested in learning more about this API, using it in your application or accessing the [Postman]( https://www.getpostman.com/) collection,  please contact [FSMB](mailto:pdc@fsmb.org).


## Authentication 

The Med API uses OAuth2 credentialing authentication.

A client id and client secret are necessary for authentication. 
Contact FSMB for access to a client id and client secret. 
Using the client id and client secret execute the authentication request. 
You will receive an access token of type bearer in the response.
All subsequent requests will require the token as an authorization header. 
After a set period of time the token will expire, and it will be necessary to get another token.

For more information regarding OAuth2 go to the website: https://oauth.net/2/


## HTTP Status Codes

These are codes you can receive in the response of a request

| HTTP Status Code | Description     |
| ---------------- | --------------- |
| 200              | OK              |
| 204              | No Content      |
| 400              | Bad Request     |
| 401              | Unauthorized    |
| 403              | Forbidden       |
| 500              | Server Error    |
| 501              | Not Implemented |

## HTTP Verbs

| HTTP Verb | Does   |
| --------- | ------ |
| GET       | Read   |
| POST      | Insert |
| PUT       | Update/Replace |
| PATCH     | Update/Modify |
| DELETE    | Delete |

## Resources

- [Practitioners](docs/practitioners/README.md)
- [Licensure](docs/licensure/README.md)