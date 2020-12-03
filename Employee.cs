using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadry
{   
    public class Employee : Person
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DateOfHire { get; set; }


        public override string GetInfo()
        {
            return $"Pracownik: {FirstName} {LastName}";
        }
    }
}
