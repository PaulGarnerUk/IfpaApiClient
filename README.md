# IfpaApiClient

A portable .NET Standard library to call the REST API provided by the IFPA (International Flipper Pinball Association). Contains a client dll and a models library.

## Example usage

To use the library you'll first need to [apply for an API key](https://www.ifpapinball.com/api/request_api_key.php)

Then instantiate the client using the provided key...

```c#
var apiClient = new IfpaClient("YourApiKey");
```

And make API calls by using methods on the client, eg

```c#
var playerApiResponse = apiClient.Player.Get(123);

if (playerApiResponse.Success) Console.WriteLine(playerApiResponse.Data.Information.FirstName);
else Console.WriteLine(playerApiResponse.Error.Code)
```

All the method calls should be discoverable by dotting through the apiClient object, and each method call returns models to help quickly get to the data required.
