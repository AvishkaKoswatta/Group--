using Microsoft.EntityFrameworkCore;
using Student_Reg_Group.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Reg_Group
{
    public class PersonContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        private readonly string path = @"C:\Users\Avishka Koswaththa\Downloads\Student_Reg_GroupNEW\Student_Reg_Group\Student_Reg_Group\Persons.db";

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data source={path}");

    }
}
