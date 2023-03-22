using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    internal class Quadrupede : Animale
    {
		public const string zampe = "4";

        public Quadrupede(string nome, bool pasto) : base(nome, pasto)
        {
        }

        //public static string Zampe { get => zampe; set => zampe = value; }

	}
}
