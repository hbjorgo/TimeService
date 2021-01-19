# TimeService
[![CI](https://github.com/hbjorgo/TimeService/workflows/CI/badge.svg)](https://github.com/hbjorgo/TimeService)
[![Nuget](https://img.shields.io/nuget/v/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)
[![Nuget](https://img.shields.io/nuget/dt/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)

Configurable and simple time service for .Net that makes it easy to unit test your code.

## Usage
Install as NuGet package
```shell
dotnet add package HeboTech.TimeService
```

Example usage in production code
```csharp
// Set up during application startup
TimeService.SetProvider(new SystemTimeProvider());

// Use as a static service
DateTime time = TimeService.UtcNow;
```

Example usage when running unit tests
```csharp
// Set up during test initialization
DateTime testTime = new DateTime(2020, 1, 1, 12, 0, 0, DateTimeKind.Utc);
ManualTimeProvider testProvider = new ManualTimeProvider(testTime);
TimeService.SetProvider(testProvider);

// Unit testing:

// TimeService returns the set time
Assert.AreEqual(testTime, TimeService.UtcNow);

// Add a TimeSpan to the current time
testProvider.Elapse(TimeSpan.FromDays(1));

// TimeService returns the new time
Assert.AreEqual(testTime.AddDays(1), TimeService.UtcNow);
```

Feedback is welcome 🙂
