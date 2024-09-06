# Pet

```csharp
PetController petController = client.PetController;
```

## Class Name

`PetController`

## Methods

* [Createpet](../../doc/controllers/pet.md#createpet)
* [Get Birds](../../doc/controllers/pet.md#get-birds)


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


# Get Birds

```csharp
GetBirdsAsync(
    Models.Bird type)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`Bird`](../../doc/models/bird.md) | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
Bird type = new PinkRobin
{
    BirdType = "PinkRobin",
};

try
{
    await petController.GetBirdsAsync(type);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

