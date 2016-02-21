using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        private Boolean fuel; // true = Benzin, false = Diesel
        private String color; // Farbe des Autos
        private int tank; //Größe des Tanks

        public const decimal diesel = 1.1M;
        public const decimal super = 1.5M;


        public Car(Boolean fuel, String color,int tank)
        {
            this.Fuel = fuel;
            this.Color = color;
            this.Tank = tank;  
        }

        public Boolean Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }

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

        public void ChangeTank(int tank)
        {
            if ((tank <=0)|| (tank>100))
                {
                throw new ArgumentException("Tankgrösse muss zwischen 0 und 100 liegen");
                }
            else
            {
                this.tank = tank;
            }
                 

        }

        public decimal FillUp(Boolean fuel,int tank)
        {
            decimal sum;

            if (fuel ==true)
            {
              sum=  super * tank;
                return sum;

            }
            else
            {
                sum = diesel * tank;
                return sum;
            }
        }
    }
}
