using ToDo.Api.Models.TodoItem;
using ToDo.Shared.Dtos.TodoItem;

namespace ToDo.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
