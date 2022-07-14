using Microsoft.AspNetCore.Mvc;
using TodoListBE.Models;
using TodoListBE.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoListBE.Controllers
{
    [Route("Beta/api/TodoList")]
    [ApiController]
    public class TodoListBEController : ControllerBase
    {
        private readonly ITodosService _todosService;
        public TodoListBEController(ITodosService todosService)
        {
            _todosService = todosService;
        }

        // GET: api/<TodoListBEController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosService.GetTodos());
        }

        // GET api/<TodoListBEController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoListBEController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_todosService.AddTodo(todo));
        }

        // PUT api/<TodoListBEController>/5
        [HttpPut()]
        public IActionResult Put(Todo todo)
        {
            return Ok(_todosService.UpdateTodo(todo));
        }

        // DELETE api/<TodoListBEController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_todosService.DelTodo(id));
        }
    }
}
