using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4.Entity
{
    public class Emp
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int? Bonus { get; set; }
        public int? ManagerId { get; set; }
        public int? DeptId { get; set; }
        public Dept Dept { get; set; }
    }
}
