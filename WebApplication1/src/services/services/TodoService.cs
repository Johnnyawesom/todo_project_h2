using WebApplication1.src.models;
using WebApplication1.src.services.interfaces;

namespace WebApplication1.src.services.services

{
    public class TodoService : ITodoService
    {
        public ITodoRepo _repo;

        public TodoService(ITodoRepo repo) 
        {
            _repo = repo;
        }

        public void CreateTodo(string name, string taskdescription, string title, bool isCompleted)
        {
            if (taskdescription.Length > 25)
            {
                throw new Exception("Must be 25 characters or less");
            }
            
            _repo.Create(name, taskdescription, title, isCompleted);

        }

        public void Delete(Guid id)
        {
            _repo.Delete(id);
        }

        public List<TodoModels> GetAllTodoNotes()
        {
           return _repo.GetAllNotes();

        }

        public TodoModels GetTodoById(Guid id)
        {
            throw new NotImplementedException();
        }


        public void Update(TodoModels todo)
        {
            throw new NotImplementedException();
        }
    }
}
