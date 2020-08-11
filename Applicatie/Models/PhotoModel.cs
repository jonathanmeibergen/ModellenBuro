using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBuro.Models
{
    public class PhotoModel : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Waist { get; set; }
        public float LegLength { get; set; }
        public float Chest { get; set; }

    }
}
