namespace MSSA_CAD21_REACT.git.Web.Infrastructure;

public abstract class EndpointGroupBase
{
    public virtual string? GroupName { get; }
    public abstract void Map(RouteGroupBuilder groupBuilder);
}
