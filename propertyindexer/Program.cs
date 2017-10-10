using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyindexer
{
    class Engine
    {
        string name;
        int size;

        public Engine(string n, int s)
        {
            name = n;
            size = s;
        }

        public  int Size
        {
            get
            {
                return size;
            }
        }
    }
    class Car
    {
        string name;
        Engine engine;
        public Car(string n, Engine e)
        {
            name = n;
            engine = e;
        }

        public void printInfo()
        {
            Console.WriteLine(name + "(" + engine.Size + ")");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine blf = new Engine("BLF", 1597);
            Engine bvy = new Engine("BVY", 1984);
            Engine blg = new Engine("BLG", 1389);

            Car[] cars = new Car[4];
            cars[0] = new Car("GOLF E", blf);
            cars[1] = new Car("GOLF GLI", bvy);
            cars[2] = new Car("GOLF GT TSI", blg);
            cars[3] = new Car("GOLF Octava", blf);

            foreach (Car car in cars)
                car.printInfo();
        }
    }
}
