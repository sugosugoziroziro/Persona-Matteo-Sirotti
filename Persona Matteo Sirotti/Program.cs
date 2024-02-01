using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Matteo_Sirotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();
            for(int i = 0;i<5;i++)
            {
                persone.Add(new Persona(Console.ReadLine(), int.Parse(Console.ReadLine())));
               Text
            }
            for (int i = 0; i < persone.Count; i++)
            {
                if (persone[i].Eta>=18)
                {
                    Console.WriteLine(persone[i].ToString());
                }
            }
            

        }


    }
}
