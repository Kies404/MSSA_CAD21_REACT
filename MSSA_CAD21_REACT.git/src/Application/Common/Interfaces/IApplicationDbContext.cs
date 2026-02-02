using MSSA_CAD21_REACT.git.Domain.Entities;

namespace MSSA_CAD21_REACT.git.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
