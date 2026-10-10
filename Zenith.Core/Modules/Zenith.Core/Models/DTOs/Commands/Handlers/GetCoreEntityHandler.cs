using Modules.Zenith.Core.Models;
using Modules.Zenith.Core.Queries;

namespace Modules.Zenith.Core.Handlers;

public class GetCoreEntityHandler
{
    public CoreEntity Handle(GetCoreEntityQuery query)
    {
        return new CoreEntity
        {
            Id = query.Id,
            Name = "Loaded from Zenith.Core"
        };
    }
}
