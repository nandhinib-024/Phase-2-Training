using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    class ElectricReading
    {
        private int consumernumber, prevreading, curreading;
        private string consumername, consumertype;
        private readonly int _subsidy;

        public ElectricReading(int consumernumber, string consumername, int prevreading, int curreading, string consumertype)
        {
            Consumernumber = consumernumber;
            Prevreading = prevreading;
            Curreading = curreading;
            Consumername = consumername;
            Consumertype = consumertype;
            _subsidy = 50;
        }

        public int Consumernumber
        {
            get => consumernumber;
            set => consumernumber = value;
        }
        public int Curreading { get => curreading; set => curreading = value; }

        public int Prevreading { get => prevreading; set => prevreading = value; }
        public string Consumername { get => consumername; set => consumername = value; }
        public string Consumertype { get => consumertype; set => consumertype = value; }

        public int Subsidy => _subsidy;

        public int CalculateBill()
        {

            int billamt = 0;
            int consumption = Curreading - Prevreading;

            if (Consumertype.Equals("Domestic"))
            {
                if (consumption <= 100)
                {
                    billamt = 0;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption - 100) * 10;
                }

            }
            else if (Consumertype.Equals("Commercial"))
            {
                if (consumption <= 100)
                {
                    billamt = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption) * 50;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption) * 100;
                }

            }
            return billamt;
        }


    }
    
}
