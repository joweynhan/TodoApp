using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Repository.MsSQL
{
    public class TodoDBRepository : ITodoRepository
    {
        //interact with database and perform CRUD
        //TodoDbContext _dbContext = new TodoDbContext();

        TodoDbContext _dbContext;

        public TodoDBRepository(TodoDbContext dbContext) //addscope for update
        {
            _dbContext = dbContext;
        }

        public Todo AddTodo(Todo newTodo)
        {
            _dbContext.Add(newTodo);
            //CRUD operations you need to save the details --> commit
            _dbContext.SaveChanges();
            return newTodo;
        }

        public Todo DeleteTodo(int todoId)
        {
            var todo = GetTodoById(todoId);
            if (todo != null)
            {
                _dbContext.Todos.Remove(todo);
                _dbContext.SaveChanges();
            }
            return todo;
        }

        public List<Todo> GetAllTodos()
        {
            return _dbContext.Todos.AsNoTracking().ToList(); //access the data from the database
        }
        public Todo GetTodoById(int Id)
        {
            //keeps track of it, if any changes happen to the object we can save it automaticallly
            // discard the default behavior of the entity framework not to track
            return _dbContext.Todos.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Todo UpdateTodo(int todoId, Todo newTodo)
        {
            _dbContext.Todos.Update(newTodo);
            _dbContext.SaveChanges();
            return newTodo;
        }
    }
}
