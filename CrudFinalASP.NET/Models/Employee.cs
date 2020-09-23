using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudFinalASP.NET.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string  Adress{ get; set; }

        public string Phone { get; set; }

    }
}