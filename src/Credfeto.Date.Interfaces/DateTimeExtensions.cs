using System;
using System.Diagnostics.CodeAnalysis;

namespace Credfeto.Date.Interfaces;

public static class DateTimeExtensions
{
    public static DateTimeOffset AsDateTimeOffset(in this DateTime dateTime)
    {
        if (dateTime.Kind != DateTimeKind.Utc)
        {
            return MustBeInUtc(dateTime);
        }

        return new(dateTime: dateTime, offset: TimeSpan.Zero);
    }

    [DoesNotReturn]
    private static DateTimeOffset MustBeInUtc(in DateTime dateTime)
    {
        throw new ArgumentOutOfRangeException(nameof(dateTime), actualValue: dateTime, message: "DateTime must be in UTC");
    }
}