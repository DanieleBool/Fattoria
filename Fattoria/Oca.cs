using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    internal class Oca : Bipede
    {
        public Oca(string nome, bool pasto, DateTime entryDate, DateTime? exitDate) : base(nome, pasto, entryDate, exitDate) { }

        public override void Look()
        {
            Console.WriteLine($"Sono un'oca di nome {Nome} entrata in data {DataEntrata.ToShortDateString()} e uscita in data {DataUscita?.ToShortDateString()}. {(Pasto ? "Ho già mangiato." : "Non ho ancora mangiato.")}");
        }
    }
}
