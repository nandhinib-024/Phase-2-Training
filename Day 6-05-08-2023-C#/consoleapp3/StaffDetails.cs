using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
     class StaffDetails:College
    {
        private int  eno;
        private string? name,address;

        public StaffDetails(int eno, string? name, string? address, string? collegeName, string? collegeaddress):base(collegeName, collegeaddress)
        {
            Eno = eno;
            Name = name;
            Address = address;
        }

        public int Eno { get => eno; set => eno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
    }
}
