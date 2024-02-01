using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Matteo_Sirotti
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }
        public Persona(string n, int e) 
        {
            Eta = e;
            Nome = n;   
        }
        
        public override string ToString() 
        { 
            return $"{Nome}";
        }

    }
}
