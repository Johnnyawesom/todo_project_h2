using WebApplication1.src.models;

namespace WebApplication1.src.services.interfaces
{
    public interface ITodoService
    {
        void CreateTodo(string name, string taskdescription, string title, bool isCompleted);
        void Delete(Guid id);
        List<TodoModels> GetAllTodoNotes();

        TodoModels GetTodoById(Guid id);
        void Update(TodoModels todo);
    }


}
