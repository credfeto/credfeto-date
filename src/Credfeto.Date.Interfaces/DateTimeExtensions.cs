using System;
using System.Diagnostics.CodeAnalysis;

namespace Credfeto.Date.Interfaces;

public static class DateTimeExtensions
{
    public static DateTimeOffset AsDateTimeOffset(in this DateTime dateTime)
    {
        return dateTime.Kind == DateTimeKind.Utc
            ? new(dateTime: dateTime, offset: TimeSpan.Zero)
            : MustBeInUtc(dateTime);
    }

    [DoesNotReturn]
    private static DateTimeOffset MustBeInUtc(in DateTime dateTime)
    {
        throw new ArgumentOutOfRangeException(nameof(dateTime), actualValue: dateTime, message: "DateTime must be in UTC");
    }
}