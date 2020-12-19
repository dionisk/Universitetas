using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Models
{
    public enum ToDoItemStatus
    {
        Backlog,
        Wip,
        Done,
        Archived
    }
    public class ToDoItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime DeadLineDate { get; set; }
        [Required]
        [Range(1, 5)]
        [DefaultValue(3)]
        public int Priority { get; set; }
        [DefaultValue(1)]
        public ToDoItemStatus Status { get; set; }

    }
}
