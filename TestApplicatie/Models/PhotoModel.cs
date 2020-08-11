using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicatie.Models
{
    public class PhotoModel
    {
        [Key]
        public int Id { get; set; }

        ApplicationUser User { get; set; }
    }
}
