using System;
using System.Collections.Generic;
using System.Text;

namespace pdf1
{
    public class Person
    {
        public int Age;
        public string Name;
        public Person()
        {
            Age = 1;
            Name = "Test";
        }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }

    public class Car
    {
        private double Fuel = 0;
        public Car()
        {
            Fuel = 40;
        }
        public Car(double fuel) {
            Fuel = fuel;
        }
        public void Move(double km)
        {
            double koef = 8.4; //литров на километр
            Fuel -= km / koef; //a += b  <==> a = a + b; -=; *=; /=; %

            if (Fuel < 0.0) {
                Fuel = 0;
            }
        }
        public bool CanMove()
        {
            if (Fuel >= 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetFuilLiters()
        {
            return Fuel;
        }
        public string Name { get; set; }
        public string Color { get; set; }

        public static string GetName(int index)
        {
            if (index == 0) return "Lada";
            if (index == 1) return "Volga";
            return "BMW";
        }
    }


    public class MathUtils
    {
        public static int Add(int a, int b) { return a + b; }
    }
}
