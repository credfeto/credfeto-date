using System;

namespace Credfeto.Date.Interfaces;

public interface ICurrentTimeSource
{
    DateTimeOffset UtcNow();
}