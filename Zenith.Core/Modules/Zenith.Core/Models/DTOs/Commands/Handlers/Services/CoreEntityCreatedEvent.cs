using Modules.Zenith.Core.Models;

namespace Modules.Zenith.Core.Events;

public class CoreEntityCreatedEvent
{
    public CoreEntity Entity { get; }

    public CoreEntityCreatedEvent(CoreEntity entity)
    {
        Entity = entity;
    }
}
