using System;
using System.Diagnostics.CodeAnalysis;
using Credfeto.Date.Interfaces;

namespace Credfeto.Date;

public sealed class CurrentTimeSource : ICurrentTimeSource
{
    [SuppressMessage(
        category: "FunFair.CodeAnalysis",
        checkId: "FFS0005: Call Date Time abstraction",
        Justification = "This is implementing the referenced mechanism"
    )]
    public DateTimeOffset UtcNow()
    {
        return DateTimeOffset.UtcNow;
    }
}
