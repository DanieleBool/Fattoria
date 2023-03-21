using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
	internal class Animale
	{
		public string nome;
		public bool pasto;

        public Animale(string nome, bool pasto)
		{
			this.nome = nome;
			this.pasto = pasto;
		}

		public virtual void look()
		{
			Console.WriteLine($"L'animale è {nome}");
		}
	}
}
