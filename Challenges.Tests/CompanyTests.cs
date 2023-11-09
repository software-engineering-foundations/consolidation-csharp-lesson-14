namespace Challenges.Tests;

using System.Collections;
using System.Globalization;
using NUnit.Framework;

[TestFixture]
public class CompanyTests
{
    private Challenges Challenges = new();

    private IComparer EmployeeComparer = new Comparer(CultureInfo.InvariantCulture); 
        
    [Test]
    public void TestSelectAllEmployeesUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployees);

        // Act
        var employees = Challenges.SelectAllEmployeesUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }

    [Test]
    public void TestSelectAllEmployeesUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployees;

        // Act
        var employees = Challenges.SelectAllEmployeesUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }
    
    [Test]
    public void TestSelectEmployeeWithId51708UsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployee = EmployeeHelper.ConvertEmployeeToDictionary(EmployeeHelper.EmployeeWithId51708);

        // Act
        var employee = Challenges.SelectEmployeeWithId51708UsingSqlLiteCore();
        
        // Assert
        Assert.AreEqual(expectedEmployee, employee);
    }

    [Test]
    public void TestSelectEmployeeWithId51708UsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployee = EmployeeHelper.EmployeeWithId51708;

        // Act
        var employee = Challenges.SelectEmployeeWithId51708UsingEntityFrameworkCore();
        
        // Assert
        Assert.AreEqual(expectedEmployee, employee);
    }

    [Test]
    public void TestSelectFirst10EmployeesUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.First10Employees);

        // Act
        var employees = Challenges.SelectFirst10EmployeesUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }
    
    [Test]
    public void TestSelectFirst10EmployeesUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.First10Employees;

        // Act
        var employees = Challenges.SelectFirst10EmployeesUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }
    
    [Test]
    public void TestSelectAllEmployeesInAscendingNameOrderUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees =
            EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployeesInAscendingNameOrder);

        // Act
        var employees = Challenges.SelectAllEmployeesInAscendingNameOrderUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);

    }
    
    [Test]
    public void TestSelectAllEmployeesInAscendingNameOrderUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesInAscendingNameOrder;

        // Act
        var employees = Challenges.SelectAllEmployeesInAscendingNameOrderUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [Test]
    public void TestSelectAllEmployeesInDescendingNameOrderUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees =
            EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployeesInDescendingNameOrder);

        // Act
        var employees = Challenges.SelectAllEmployeesInDescendingNameOrderUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }
    
    [Test]
    public void TestSelectAllEmployeesInDescendingNameOrderUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesInDescendingNameOrder;

        // Act
        var employees = Challenges.SelectAllEmployeesInDescendingNameOrderUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [Test]
    public void TestSelectEmployeesInConsultingDepartmentUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees =
            EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployeesInConsultingDeparment);

        // Act
        var employees = Challenges.SelectEmployeesInConsultingDepartmentUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }
    
    [Test]
    public void TestSelectEmployeesInConsultingDepartmentUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesInConsultingDeparment;

        // Act
        var employees = Challenges.SelectEmployeesInConsultingDepartmentUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }
    
    [Test]
    public void TestSelectEmployeesBelowPayBand5UsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployeesBelowPayBand5);

        // Act
        var employees = Challenges.SelectEmployeesBelowPayBand5UsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }

    [Test]
    public void TestSelectEmployeesBelowPayBand5UsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesBelowPayBand5;

        // Act
        var employees = Challenges.SelectEmployeesBelowPayBand5UsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [Test]
    public void TestSelectEmployeesBelowPayBand5AndWithLessThan3YearsOfServiceUsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees =
            EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper
                .AllEmployeesBelowPayBand5AndWithLessThan3YearsOfService);

        // Act
        var employees = Challenges.SelectEmployeesBelowPayBand5AndWithLessThan3YearsOfServiceUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }

    [Test]
    public void TestSelectEmployeesBelowPayBand5AndWithLessThan3YearsOfServiceUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesBelowPayBand5AndWithLessThan3YearsOfService;

        // Act
        var employees = Challenges.SelectEmployeesBelowPayBand5AndWithLessThan3YearsOfServiceUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [Test]
    public void TestSelectEmployeesWithId51708OrManagerId51708UsingSqlLiteCore()
    {
        // Arrange
        var expectedEmployees =
            EmployeeHelper.ConvertEmployeesToDictionaries(EmployeeHelper.AllEmployeesWithIdOrManagerId51708);

        // Act
        var employees = Challenges.SelectEmployeesWithId51708OrManagerId51708UsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees, EmployeeComparer);
    }
    
    [Test]
    public void TestSelectEmployeesWithId51708OrManagerId51708UsingEntityFrameworkCore()
    {
        // Arrange
        var expectedEmployees = EmployeeHelper.AllEmployeesWithIdOrManagerId51708;

        // Act
        var employees = Challenges.SelectEmployeesWithId51708OrManagerId51708UsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [Test]
    public void TestSelectDistinctNonNullDepartmentsUsingSqlLiteCore()
    {
        // Arrange
        var expectedDepartments = EmployeeHelper.AllDistinctNonNullDepartments;

        // Act
        var departments = Challenges.SelectDistinctNonNullDepartmentsUsingSqlLiteCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedDepartments, departments);
    }

    [Test]
    public void TestSelectDistinctNonNullDepartmentsUsingEntityFrameworkCore()
    {
        // Arrange
        var expectedDepartments = EmployeeHelper.AllDistinctNonNullDepartments;

        // Act
        var departments = Challenges.SelectDistinctNonNullDepartmentsUsingEntityFrameworkCore();
        
        // Assert
        CollectionAssert.AreEqual(expectedDepartments, departments);
    }
}