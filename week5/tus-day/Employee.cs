using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDbManager
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Range(18,50)]
        public int? Age { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        public string Address { get; set; }
    }
}
