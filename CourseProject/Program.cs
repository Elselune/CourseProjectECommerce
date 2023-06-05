using System;
using Microsoft.EntityFrameworkCore;

namespace CourseProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }

    public class ApplicationContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }

}