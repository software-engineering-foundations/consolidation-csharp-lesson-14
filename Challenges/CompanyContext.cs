namespace Challenges;

using Microsoft.EntityFrameworkCore;

public class CompanyContext: DbContext
{
    public DbSet<Employee> Employees { get; set; }

    private static string DatabasePath => Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent + @"\Challenges\Data\company.db";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DatabasePath}");
}