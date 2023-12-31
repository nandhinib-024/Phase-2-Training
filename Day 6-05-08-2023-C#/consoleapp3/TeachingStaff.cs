﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp3
{
     class TeachingStaff:StaffDetails
    {
        private string? dept;
        private double basicsalary;
        private readonly int _da, _hra, _cca, _pf;

        public TeachingStaff(int eno, string? name, string? address,
            string? collegeName, string? collegeaddress,
            string? dept, double basicsalary, int da, int hra, int cca, int pf)
            : base(eno, name, address, collegeName, collegeaddress)
        {
            this.dept = dept;
            this.basicsalary = basicsalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }


      


        public string? Dept { get => dept; set => dept = value; }
        public double Basicsalary { get => basicsalary; set => basicsalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float netsalary = (float)(Basicsalary+
                ((Basicsalary*((float)Da/100))
                +(Basicsalary*((float)Hra /100))+
                (Basicsalary*((float)Cca /100))-
                (Basicsalary*((float)Pf /100))
                ));
            return netsalary;
        }


    }
}
