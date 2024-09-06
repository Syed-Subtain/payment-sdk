
# Getting Started with Discriminator Test

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package PaymentSDK --version 19.69.39
```

You can also view the package at:
https://www.nuget.org/packages/PaymentSDK/19.69.39

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
DiscriminatorTestClient client = new DiscriminatorTestClient.Builder()
    .Build();
```

## List of APIs

* [Pet](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/controllers/pet.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-request.md)
* [HttpResponse](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-string-response.md)
* [HttpContext](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/Syed-Subtain/payment-sdk/tree/19.69.39/doc/api-exception.md)

