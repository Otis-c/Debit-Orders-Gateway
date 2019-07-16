using DebitOrdersApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Creditor> Creditors { get; set; }
        public DbSet<DebitInstruction> DebitInstructions { get; set; }
        //public DbSet<Account> Accounts { get; set; }

    }
}
