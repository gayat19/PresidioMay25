using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeApplication.Models
{
    public class ValidEmployee : Employee
    {
        public string GovermentIdNumber { get; set; } = string.Empty;
        public override void TakeEmployeeDetailsFromUser()
        {
            base.TakeEmployeeDetailsFromUser();
            Console.WriteLine("Please enter the employee government id number");
            GovermentIdNumber = Console.ReadLine() ?? "";
        }
        public override string ToString()
        {
            return base.ToString() + "\nGoverment Id Number : " + GovermentIdNumber;
        }
    }
}
