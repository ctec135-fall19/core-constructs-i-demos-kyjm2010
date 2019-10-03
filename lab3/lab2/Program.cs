using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar myCar = new SportsCar();
            myCar.PetName = "my beatup sienna";
            Console.WriteLine("My car: \"{0}\",\t{1}", myCar.getPetName(), myCar.PetName);
        }
    }
}
