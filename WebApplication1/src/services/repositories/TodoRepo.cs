using WebApplication1.src.services.interfaces;
using WebApplication1.src.models;
using WebApplication1.src.services.services;

    namespace WebApplication1.src.services.repositories
{
    public class TodoRepo : ITodoRepo
    {
        public List<TodoModels> _todoData = new List<TodoModels>();

        public void Create(string name, string taskdescription, string title, bool IsCompleted)
        {
            _todoData.Add(new TodoModels() { Name = name, TaskDescription = taskdescription, Title = title, CreatedTime = DateTime.Now, Id = Guid.NewGuid() });
        }

        public void Delete(Guid id)
        {
            _todoData.Remove(_todoData.Find(x => x.Id == id));
        }

        public List<TodoModels> GetAllNotes() 
        {
            
            return _todoData;
        }

        public TodoModels GetSpecificNote(Guid id)
        {
            return (_todoData.Find(x => x.Id == id));
             
        }

        
    }
}
