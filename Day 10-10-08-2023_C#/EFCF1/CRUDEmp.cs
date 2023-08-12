using EFCF1.Context;
using EFCF1.Model;
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
            using (var context = new EmployeeManagement())
            {
                var emp = new Emp()
                {

                  Ename="Nandhini" , 
                  Addr="erode",
                  Deptno=1
                  

                };
                context.Emps.Add(emp);
                context.SaveChanges();
            }
        }
        public void UpdateEmp()
        {
            var context = new EmployeeManagement();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 10436);
            selemp.Addr = "Dpm";
            context.SaveChanges();


        }
        public void DeleteEmp()
        {

            var context = new EmployeeManagement();
            var selemp = context.Emps.FirstOrDefault(d => d.Empno == 10436);
            context.Emps.Remove(selemp);
            context.SaveChanges();
        }
    }


}

