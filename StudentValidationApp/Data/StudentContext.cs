using StudentValidationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StudentValidationApp.Data
{
    public class StudentContext : DbContext
    {



        public DbSet <Student> Students {get;set;}

    }
}
