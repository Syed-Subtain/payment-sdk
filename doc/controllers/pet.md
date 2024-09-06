# Pet

```csharp
PetController petController = client.PetController;
```

## Class Name

`PetController`


# Createpet

create pet

```csharp
CreatepetAsync(
    Models.Pet body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Pet`](../../doc/models/pet.md) | Body, Required | this is pet |

## Response Type

`Task`

## Example Usage

```csharp
Pet body = new GermanShepherd
{
    PetType = "GermanShepherd",
};

try
{
    await petController.CreatepetAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

