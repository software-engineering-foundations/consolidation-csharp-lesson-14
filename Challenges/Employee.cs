namespace Challenges;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("employees")]
public class Employee
{
    [Key]
    public long Id { get; init; }

    [Column("name")]
    public string Name { get; set; }

    [Column("age")]
    public long Age { get; set; }

    [Column("job_title")]
    public string JobTitle { get; set; }

    [Column("department")]
    public string? Department { get; set; }

    [Column("manager_id")]
    public long? ManagerId { get; set; }

    [Column("years_of_service")]
    public long YearsOfService { get; set; }

    [Column("pay_band")]
    public long PayBand { get; set; }

    [Column("on_leave")]
    public long OnLeave { get; set; }

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