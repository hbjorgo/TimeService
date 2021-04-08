# TimeService
[![CI](https://github.com/hbjorgo/TimeService/workflows/CI/badge.svg)](https://github.com/hbjorgo/TimeService)
[![Nuget](https://img.shields.io/nuget/v/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)
[![Nuget](https://img.shields.io/nuget/dt/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)

Configurable and simple time service for .Net that makes it easy to unit test your code.

Feedback is welcome 🙂

## Usage
Install as NuGet package
```shell
dotnet add package HeboTech.TimeService
```

Example usage in production code
```csharp
// Set up during application startup
TimeService.Set(TimeProviders.SystemTime);

// Use as a static service
DateTime time = TimeService.Now;
```

Example usage when running unit tests
```csharp
// Set the time
DateTime startTime = new DateTime(2020, 1, 2);
TimeService.Set(() => startTime);

// TimeService returns the set time
Assert.AreEqual(startTime, TimeService.Now);

// Set a new time
DateTime newTime = new DateTime(2021, 2, 3);
TimeService.Set(() => newTime);

Assert.Equal(newTime, TimeService.Now);
```
