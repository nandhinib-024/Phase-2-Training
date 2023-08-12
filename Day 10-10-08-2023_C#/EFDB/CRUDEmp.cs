
using EFDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1
{
    internal class CRUDEmp
    {
        public void AddNewEmp()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var emp = new Emp()
                {
                    Empno = 1,
                    Empname="Nandhini",
                    Addr="Erode",
                    Deptno=1

                };
                context.Emps.Add(emp);
                context.SaveChanges();
            }
        }
        public void UpdateEmp()
        {
            var context = new EmployeeMgmtContext();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 10436);
            selemp.Addr = "Dpm";
            context.SaveChanges();


        }
        public void DeleteEmp()
        {

            var context = new EmployeeMgmtContext();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 10436);
            context.Emps.Remove(selemp);
            context.SaveChanges();
        }
    }


}

