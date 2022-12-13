
using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TP4.Models;

namespace TP4.Data;


public class UniversityContext : DbContext
{

    private static UniversityContext? _instance;
    public DbSet<Student>? Student { get; set; }
    public static UniversityContext Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Instantiate_University_Context();
            }
            return _instance;
        }
    }

    public UniversityContext(DbContextOptions o) : base(o) { }

    public static UniversityContext Instantiate_University_Context()
    {
        Debug.WriteLine("Creating a new University Context");
        var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();


        var connection = optionsBuilder.UseSqlite(@"Data Source=C:\\Users\\Admin\\source\\repos\\TP4\\tp4.db");
        return new UniversityContext(optionsBuilder.Options);
    }



}