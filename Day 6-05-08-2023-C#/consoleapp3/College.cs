using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
     class College
    {
        private string? collegeName, collegeaddress;

        public College(string? collegeName, string? collegeaddress)
        {
            this.CollegeName = collegeName;
            this.Collegeaddress = collegeaddress;
        }

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? Collegeaddress { get => collegeaddress; set => collegeaddress = value; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{CollegeName} {Collegeaddress}");
        }
    }
}
