using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Motorbike : vehicle
    {

        private Boolean fuel =true; // true = Benzin, false = Diesel
        private String color; 
        private int tank;

        public const decimal super = 1.5M;

        public Motorbike (String color, int tank)
        {
            Color = color;
            Tank = tank;

        }

        public Boolean Fuel { get; }
       

        public String Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public int Tank
        {

            get
            {
                return this.tank;
            }
            set
            {
                if (value <= 0) throw new Exception(" Tankgröße kann nicht negativ sein");

                this.tank = value;
            }

        }

        public string Look => Color;


        public void ChangeTank(int tank)
        {
            if ((tank <= 0) || (tank > 50))
            {
                throw new ArgumentException("Tankgrösse muss zwischen 0 und 50 liegen");
            }
            else
            {
                this.tank = tank;
            }
        }
    }
}
