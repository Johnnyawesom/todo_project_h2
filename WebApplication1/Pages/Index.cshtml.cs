using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.src.models;
using WebApplication1.src.services.interfaces;
using WebApplication1.src.services.services;

namespace WebApplication1.Pages
{
     
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITodoService _todoService;
        public List<TodoModels> ShowToDoModels { get; set; }


        private readonly ITodoRepo _todo;
        public IndexModel(ILogger<IndexModel> logger, ITodoRepo itodo, ITodoService todoService)
        {
            _logger = logger;
            _todo = itodo;
            _todoService = todoService;
        }   

        public void OnGet()
        {
           ShowToDoModels = _todoService.GetAllTodoNotes();
        }

        public void Create()
        {
            _todoService.CreateTodo("Name","TaskDescription", "Title", false);
            
        }

        public void Update(TodoModels todo)
        {
            _todoService.Update(todo);
        }

        public void Delete()
        {
            _todoService.Delete(Guid.NewGuid());
        }


    }
}