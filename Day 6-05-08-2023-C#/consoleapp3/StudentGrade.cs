using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
     class StudentGrade : StudentMarks
    {
        public StudentGrade(int rolno, string name, string address, int m1, int m2, int m3, string? collegeName, string? collegeaddress) : base(rolno, name, address, m1, m2, m3,collegeName, collegeaddress)
        {

        }
        public char CalculateGrade()
        {
            double average=CalculateAverage();
            if(average>90)
            {
                return 'A';
            }
            else if(average<50)
            {
                return 'B';
                
            }
            else
            {
                return 'C';
            }
           
        }
    }
}
