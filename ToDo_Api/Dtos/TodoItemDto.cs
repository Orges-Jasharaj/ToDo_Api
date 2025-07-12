using System.ComponentModel.DataAnnotations;

namespace ToDo_Api.Dtos
{
    public class TodoItemDto
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
