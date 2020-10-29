# Connect Token

Requests Bearer token that is required to authenticate prior to each API call. The Bearer token can be used until it expires, then another token must be retrieved.

```HTTP 
POST {baseUrl}/connect/token
```

## URI Parameters

| Name    | In   | Required | Type  | Description |
| ------- | ---- | -------- | ----- | ----------- |
| baseUrl | path | True | string | The API URL. |

## Body Parameters
The format for the request content is **x-www-form-urlencoded**. This will include client credentials and requesting scopes.

| Key           | Value          | Description     |
| ------------- | -------------- | --------------- |
| client_id | user.example | Client Id |
| client_secret | example secret | Client Secret |
| scope | med.read med.pdc_read | Space delimited list of scopes. |
| grant_type | client_credentials | Grant Type |

## Responses

| Name | Description     |
| ---- | --------------- |
| 200  | OK              |
| 400  | Bad Request     |


## Example

Input:

```HTTP
POST {baseUrl}/connect/token
```

Output:

```json
{
    "access_token": "ed062862dbc8d...",
    "expires_in": 3600,
    "token_type": "Bearer"
}
```

## Usage
The access token in the response must be included as an **authorization header** in all subsequent calls to the API.

| Key            | Value                 |
| -------------- | --------------------- |
| Authorization  | Bearer [access_token] |

More information about authentication can be found  [here]("https://github.com/fsmb/api-docs/blob/master/docs/authentication.md")

For more examples go to [samples](/Samples/).
