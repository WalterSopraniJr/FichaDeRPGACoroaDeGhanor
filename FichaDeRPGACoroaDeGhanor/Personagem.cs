using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDeRPGACoroaDeGhanor
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Forca { get; set; }
        public int Habilidade { get; set; }
        public int PV { get; set; }
        public int PM { get; set; }
        public List<string> Pericias { get; set; } = new();
        public List<string> Poderes { get; set; } = new();
        public decimal Dinheiro { get; set; }
        public string Equipamento { get; set; }
    }
}
