# TimeService
[![CI](https://github.com/hbjorgo/TimeService/workflows/CI/badge.svg)](https://github.com/hbjorgo/TimeService)
[![Nuget](https://img.shields.io/nuget/v/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)
[![Nuget](https://img.shields.io/nuget/dt/HeboTech.TimeService)](https://www.nuget.org/packages/HeboTech.TimeService/)

Testable and configurable time service for .Net.

## Usage
Install as NuGet package
```shell
dotnet add package HeboTech.TimeService
```

Example usage in production code
```csharp
// Set up during application startup
TimeService.SetTimeProvider(new SystemTimeProvider());

// Use as a static service
DateTime time = TimeService.UtcNow;
```

Example usage when running unit tests
```csharp
// Set up during test initialization
DateTime testTime = new DateTime(2020, 1, 1, 12, 0, 0, DateTimeKind.Utc);
ManualTimeProvider testProvider = new ManualTimeProvider(testTime);
TimeService.SetTimeProvider(testProvider);

// Unit testing:

// TimeService returns the set time
Assert.AreEqual(testTime, TimeService.UtcNow);

// Add a TimeSpan to the current time
provider.Elapse(TimeSpan.FromDays(1));

// TimeService returns the new time
Assert.AreEqual(testTime.AddDays(1), TimeService.UtcNow);
```

For more examples, check out the TestConsole project in the code.

Feedback is welcome 🙂
