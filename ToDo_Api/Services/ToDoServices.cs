using ToDo_Api.Dtos;
using ToDo_Api.Models;

namespace ToDo_Api.Services
{
    public class ToDoServices
    {
        public List<TodoItem> TodoItems { get; } = new();

        public bool CreateTodoItem(TodoItemDto toDo)
        {
            TodoItem i = new TodoItem();
            i.Id = TodoItems.Count + 1;
            i.Title = toDo.Title;
            i.Description = toDo.Description;
            TodoItems.Add(i);
            return true;
        }

        public bool Edit(TodoItemDto toDo, int id)
        {
            var item = TodoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return false;
            }
            item.Title = toDo.Title;
            item.Description = toDo.Description;
            return true;
        }

        public bool IsComplted(int id)
        {
            var item = TodoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return false;
            }
            item.IsCompleted = true;
            return true;
        }

  
        public bool Delete(int id)
        {
            var item = TodoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return false;
            }
            TodoItems.Remove(item);
            return true;
        }

        public List<TodoItem> GetAll()
        {
            return TodoItems;
        }

        public List<TodoItem> GetCompleted()
        {
            return TodoItems.Where(x => x.IsCompleted).ToList();
        }

        public List<TodoItem> GetUncompleted()
        {
            return TodoItems.Where(x => !x.IsCompleted).ToList();
        }

    }
}
