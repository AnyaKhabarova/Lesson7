using System;

namespace Practice_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new HybridCar();
            car.Move();
        }
    }

    class Car
    {
        public double Fuel;

        public int Milage;

        public Car()
        {
            Fuel = 50;
            Milage = 0;
        }

        public void Move()
        {
            Milage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }

    }

    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar: Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }   

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager: Employee
    {
        public string ProjectName;
    }

    class Developer: Employee
    {
        public string ProgrammingLanguage;
    }
}

