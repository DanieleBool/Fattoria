using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
	internal class Animale
	{
		//public string nome
		public string nome { get; set; }
		public bool pasto;

        public Animale(string nome, bool pasto)
		{
			this.nome = nome;
			this.pasto = pasto;
		}

		public virtual void look()
		{
			Console.WriteLine($"L'animale è {nome} ed ha mangiato {pasto}");
		}

		public void feed() 
		{ 
			 
		}
	}
}
