using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uczelnia UWM = new Uczelnia("11-06-2017");
            //Uczelnia Stanford = new Uczelnia("01-12-2017");

            /*Już nie działa tworzenie nowych obiektów bo w Singeltonie konstruktor jest z założenia prywatny*/

            Uczelnia UWM = Uczelnia.Instance;
            Uczelnia Stanford = Uczelnia.Instance;

            UWM.RekrutujStudentow();
            Stanford.RekrutujStudentow();

            Console.ReadLine();
        }
    }
}
