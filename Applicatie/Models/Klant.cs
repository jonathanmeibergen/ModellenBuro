using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ModellenBuro.Models;

namespace ModellenBuro
{
    public class Klant
    {
        [Key]
        public int Id { get; set; }

        //add user information
        PhotoModel User { get; set; }
    }
}
