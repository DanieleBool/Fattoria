using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    internal class Cavallo : Quadrupede
    {
        public Cavallo(string nome, bool pasto, DateTime entryDate, DateTime exitDate) : base(nome, pasto, entryDate, exitDate) { }

        public override void Look()
        {
            Console.WriteLine($"Sono un cavallo di nome {Nome} entrato in data {DataEntrata.ToShortDateString()} e uscito in data {DataUscita.ToShortDateString()}. {(Pasto ? "Ho già mangiato." : "Non ho ancora mangiato.")}");
        }
    }
}
