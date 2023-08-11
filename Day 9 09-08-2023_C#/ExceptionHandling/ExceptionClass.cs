using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
     class ExceptionClass
    {
        private int num1, num2, res;
        private int age;
        //private int[] numbers;

        public ExceptionClass(int num1, int num2, int res, int age)
        {
            this.Num2 = num2;
            this.Res = re;
            this.Age = age;
            //  this.Numbers = numbers;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Res { get => res; set => res = value; }
        public int Age { get => age; set => age = value; }

        // public int[] Numbers { get => numbers; set => numbers = value; }

        public int Add()
        {
            Res=Num2+Num1;
            return Res;
        }

        public int Div()
        {
            if(Num2!=0)
            {
                Res = Num1 / Num2;
            }
            else
            {
                
                throw new DivException("customized");
            }
            //Res = Num1 / Num2;
            return Res;
            /*
          try
          {
              //Res = Num1 / Num2;
            //  foreach (int i in Numbers) 

            for(int i=0;i<6;i++)
              {
                  int quo = Numbers[i] / Num2;
                  Console.WriteLine(quo);
              }
              
        }
            catch ( ArithmeticException ex)
            {
                //Res = 0;
                Console.WriteLine(ex.TargetSite);
            }
           catch(Exception)
            {
                Console.WriteLine("Index is out");
            }
            finally
            {
                Console.WriteLine("Done");
            }
           */


        }

        public void Checkgae()
        {
            if(Age<18)
            {
                throw new AgeException();
            }
            else 
            {
                Console.WriteLine("Eligible");
            }
        }
    }
}
