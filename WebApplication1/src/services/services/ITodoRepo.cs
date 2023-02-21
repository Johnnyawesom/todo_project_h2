using WebApplication1.src.models;

namespace WebApplication1.src.services.services
{
    public interface ITodoRepo
    {
        void Create(string name, string taskdescription, string title, bool isCompleted);
        void Delete(Guid id);
        List<TodoModels>GetAllNotes();
    }
}