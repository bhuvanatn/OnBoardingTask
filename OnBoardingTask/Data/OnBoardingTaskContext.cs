using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnBoardingTask.Models;

namespace OnBoardingTask.Models
{
    public class OnBoardingTaskContext : DbContext
    {
        public OnBoardingTaskContext (DbContextOptions<OnBoardingTaskContext> options)
            : base(options)
        {
        }

        public DbSet<OnBoardingTask.Models.Customer> Customer { get; set; }

        public DbSet<OnBoardingTask.Models.Sales> Sales { get; set; }

        public DbSet<OnBoardingTask.Models.Store> Store { get; set; }
    }
}
