using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Code_First_Student_dB
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}





    

