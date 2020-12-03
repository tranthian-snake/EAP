using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
    }
}
