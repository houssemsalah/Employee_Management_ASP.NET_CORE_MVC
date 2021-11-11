using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP1_ASPNETCORE.Models
{
    public enum Dept
    {
        None,
        HR,
        Finance,
        IT
    }

    public class Emp
    {
        public int Id { get; set; }     
        public string Name { get; set; }  
        public string Email { get; set; }
        public Dept Department { get; set; }

    }
}
