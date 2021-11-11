using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP1_ASPNETCORE.Models
{
    
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Taille max 50 characters")]
        public string  Name { get; set; }

        [Required]
        public string Departement { get; set; }

        [Range(200,5000)]
        public int Salary { get; set; }
    }
}
