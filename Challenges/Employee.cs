namespace Challenges;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("employees")]
public class Employee
{
    [Key]
    public required long Id { get; init; }
    
    [Column("name")]
    public required string Name { get; set; }
    
    [Column("age")]
    public required long Age { get; set; }
    
    [Column("job_title")]
    public required string JobTitle { get; set; }
    
    [Column("department")]
    public string? Department { get; set; }
    
    [Column("manager_id")]
    public long? ManagerId { get; set; }
    
    [Column("years_of_service")]
    public required long YearsOfService { get; set; }
    
    [Column("pay_band")]
    public required long PayBand { get; set; }
    
    [Column("on_leave")]
    public required long OnLeave { get; set; }

    public override string ToString()
    {
        return $"Employee(Id={Id}, Name=\"{Name}\", Age={Age}, JobTitle=\"{JobTitle}\", Department=\"{Department}\", " +
               $"ManagerId={ManagerId}, YearsOfService={YearsOfService}, PayBand={PayBand}, OnLeave={OnLeave})";
    }

    public override bool Equals(object? obj)
    {
        return obj is Employee employee && employee.GetHashCode() == GetHashCode();
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}