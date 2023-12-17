using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAppCase4.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public required string UserName { get; set; }

        public required string Password { get; set; }
    }
}
