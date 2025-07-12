using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_Api.Dtos;
using ToDo_Api.Models;
using ToDo_Api.Services;

namespace ToDo_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ToDoServices _toDoServices;

        public TodoController(ToDoServices toDoServices)
        {
            _toDoServices = toDoServices;
        }

        [HttpPost]
        public IActionResult CreateTodoItem([FromBody] TodoItemDto toDo)
        {
            return Ok(_toDoServices.CreateTodoItem(toDo));
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] TodoItemDto toDo, int id)
        {
            return Ok(_toDoServices.Edit(toDo, id));
        }

        [HttpPut("Complete/{id}")]
        public IActionResult IsCompleted(int id)
        {
            return Ok(_toDoServices.IsComplted(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_toDoServices.Delete(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_toDoServices.GetAll());
        }

        [HttpGet("GetCompleted")]
        public IActionResult GetCompleted()
        {
            return Ok(_toDoServices.GetCompleted());
        }

        [HttpGet("GetUnCompleted")]
        public IActionResult GetUnCompleted()
        {
            return Ok(_toDoServices.GetUncompleted());
        }

    }
}
