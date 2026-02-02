using MSSA_CAD21_REACT.git.Domain.Events;
using Microsoft.Extensions.Logging;

namespace MSSA_CAD21_REACT.git.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("MSSA_CAD21_REACT.git Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
