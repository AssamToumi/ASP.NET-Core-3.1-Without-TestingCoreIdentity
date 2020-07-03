using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestingCoreIdentity.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Choose Name")]        
        public string Name { get; set; }
        
        [StringLength(50)]
        public string Description { get; set; }

    }
}
