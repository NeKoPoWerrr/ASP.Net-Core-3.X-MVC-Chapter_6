using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_6.Models
{
    public class Employee
    {
        [Display(Name="員工編號")]
        public int Id { get; set; }
        [Display(Name = "員工名稱")]
        public string Name { get; set; }
        [Display(Name = "員工手機")]
        public string Mobile { get; set; }
        [Display(Name = "員工信箱")]
        public string Email { get; set; }
        [Display(Name = "員工部門")]
        public string Department { get; set; }
        [Display(Name = "員工職稱")]
        public string Title { get; set; }
       
    }
}
