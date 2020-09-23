using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudFinalASP.NET.Models
{
    public class CrudContext: DbContext 
     {
    public CrudContext () : base ("CrudContextD")
    {
     
     }
public DbSet <Employee> Employees { get; set;  }
     }
}

