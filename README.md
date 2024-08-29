
# Getting Started with APIMATIC Calculator

## Introduction

Simple calculator API hosted on APIMATIC

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package test-csharp --version 3.30.36
```

You can also view the package at:
https://www.nuget.org/packages/test-csharp/3.30.36

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
APIMATICCalculator.Standard.APIMATICCalculatorClient client = new APIMATICCalculator.Standard.APIMATICCalculatorClient.Builder()
    .Environment(APIMATICCalculator.Standard.Environment.Production)
    .Build();
```

## List of APIs

* [Simple Calculator](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/controllers/simple-calculator.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-request.md)
* [HttpResponse](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-string-response.md)
* [HttpContext](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/Syed-Subtain/payment-sdk/tree/3.30.36/doc/api-exception.md)

