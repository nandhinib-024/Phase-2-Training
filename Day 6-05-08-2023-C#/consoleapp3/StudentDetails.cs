using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
    class StudentDetails:College
    {
        private int rolno;
        private string? name;   
        private string? address;

        public StudentDetails(int rolno, string? name, string? address, string? collegeName, string? collegeaddress) : base(collegeName, collegeaddress)

        {
            Rolno = rolno;
            Name = name;
            Address = address;
        }

        public int Rolno { get => rolno; set => rolno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }



    }
}
