using Modules.Zenith.Core.Models;
using Modules.Zenith.Core.Commands;

namespace Modules.Zenith.Core.Handlers;

public class CreateCoreEntityHandler
{
    public CoreEntity Handle(CreateCoreEntityCommand command)
    {
        return new CoreEntity
        {
            Name = command.Name
        };
    }
}
