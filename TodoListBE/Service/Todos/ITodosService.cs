using TodoListBE.Models;

namespace TodoListBE.Service.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos(); // Phương thức lấy ra list todo
        Boolean AddTodo(Todo todo);
        Boolean UpdateTodo(Todo todo);
        Boolean DelTodo(int id);
    }
}
