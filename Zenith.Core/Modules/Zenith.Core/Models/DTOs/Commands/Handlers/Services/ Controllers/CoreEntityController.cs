using Modules.Zenith.Core.Services;

namespace Modules.Zenith.Core.Controllers;

public class CoreEntityController
{
    private readonly CoreEntityService _service = new();

    public object Create(string name)
    {
        var entity = _service.Create(name);
        return new { entity.Id, entity.Name };
    }
}
