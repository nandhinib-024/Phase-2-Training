﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
    class StudentMarks : StudentDetails
    {
        private int m1, m2, m3;

        public StudentMarks(int rolno, string name, string address,int m1, int m2, int m3, string? collegeName, string? collegeaddress) :base(rolno,name,address, collegeName, collegeaddress)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }

        public int CalculateTotal()
        {
            int total;
            total = m1+m2+m3;
            return total;
        }
        public double CalculateAverage()
        {
           return (m1+m2+m3)/3;
        }
    }
}