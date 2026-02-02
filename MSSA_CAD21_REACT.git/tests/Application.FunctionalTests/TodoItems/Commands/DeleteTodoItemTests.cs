using MSSA_CAD21_REACT.git.Application.TodoItems.Commands.CreateTodoItem;
using MSSA_CAD21_REACT.git.Application.TodoItems.Commands.DeleteTodoItem;
using MSSA_CAD21_REACT.git.Application.TodoLists.Commands.CreateTodoList;
using MSSA_CAD21_REACT.git.Domain.Entities;

namespace MSSA_CAD21_REACT.git.Application.FunctionalTests.TodoItems.Commands;

using static Testing;

public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await Should.ThrowAsync<NotFoundException>(() => SendAsync(command));
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.ShouldBeNull();
    }
}
