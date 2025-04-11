using System;
using Credfeto.Date.Interfaces;
using FunFair.Test.Common;
using Xunit;

namespace Credfeto.Date.Tests;

public sealed class DateTimeExtensionsTests : TestBase
{
    [Fact]
    public void DateInUtcConvertsToDateTimeOffset()
    {
        DateTime date = new(
            year: 2021,
            month: 1,
            day: 1,
            hour: 0,
            minute: 0,
            second: 0,
            kind: DateTimeKind.Utc
        );

        DateTimeOffset result = date.AsDateTimeOffset();

        Assert.Equal(expected: date, actual: result.DateTime);
        Assert.Equal(expected: TimeSpan.Zero, actual: result.Offset);
    }

    [Theory]
    [InlineData(DateTimeKind.Local)]
    [InlineData(DateTimeKind.Unspecified)]
    public void DateNotInUtcDoesNotConvertToDateTimeOffset(DateTimeKind dateTimeKind)
    {
        DateTime date = new(
            year: 2021,
            month: 1,
            day: 1,
            hour: 0,
            minute: 0,
            second: 0,
            kind: dateTimeKind
        );

        Assert.Throws<ArgumentOutOfRangeException>(() => date.AsDateTimeOffset());
    }
}
