using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAppCase4.Entites
{
    public class Task
    {
        
        [Key]
        public int TaskId { get; set; }

        public required string Title { get; set; }
        public required string Description { get; set; }
        //public DateOnly DueDate { get; set; }
    }
}
