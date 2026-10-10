using Modules.Zenith.Core.Models;

namespace Modules.Zenith.Core.Services;

public class CoreEntityService
{
    public CoreEntity Create(string name)
        => new CoreEntity { Name = name };
}
