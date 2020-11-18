using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Class
    {
        [Key]
        public int MyProperty { get; set; }
        public string Text { get; set; }
    }
}
