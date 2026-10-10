namespace Modules.Zenith.Core.Commands;

public class CreateCoreEntityCommand
{
    public string Name { get; set; } = string.Empty;
}
`

📁 Queries/GetCoreEntityQuery.cs

`csharp
namespace Modules.Zenith.Core.Queries;

public class GetCoreEntityQuery
{
    public Guid Id { get; set; }
}
