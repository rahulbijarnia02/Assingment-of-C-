using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYAPP.Models;
using System.ComponentModel.DataAnnotations;


namespace myapp.Models
{
    public class EmployeeDetailsModel
    {
        public int EmpId {get;set;}
        [Required]
        [MaxLength(100)]
        public string ?Name {get; set;}
         [Required]
        [Range(1,100, ErrorMessage ="Age must be between 1-100 in years.")]
        public int ?Age {get;set;}
           [Required]
         [Range(1,100000, ErrorMessage ="Salary must be between 1-100000.")]
        public string ?salary{get;set;}
             [Required]
        [MaxLength(10)]
        public string ?Designation{get;set;}
    }
}