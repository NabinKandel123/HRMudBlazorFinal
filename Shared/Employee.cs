using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppMudBlazorProject.Shared;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string ContactNumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }    
    public Gender Sex { get; set; }
    public DateTime? JoinDate { get; set; }


    public int DepartmentID { get; set; }
    public Department? Department { get; set; }


    public int DesignationID { get; set; }
    public Designation? Desgination { get; set; }
}

public enum Gender
{
    Male,
    Female,
    Others,
}
