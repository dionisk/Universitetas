using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime? CreationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DeadLineDate { get; set; }
        [Required]
        [Range(1, 5)]
        [DefaultValue(3)]
        public int Priority { get; set; }
        [DefaultValue(ToDoItemStatus.Backlog)]
        public ToDoItemStatus Status { get; set; }       
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [DisplayName("Category")]
        public virtual Category Category { get; set; }

    }
}
