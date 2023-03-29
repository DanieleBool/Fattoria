using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    internal class Gallina : Bipede
    {
        public Gallina(string nome, bool pasto, DateTime entryDate, DateTime? exitDate) : base(nome, pasto, entryDate, exitDate) { }

        public override void Look()
        {
            Console.WriteLine($"Sono una gallina di nome {Nome} entrata in data {DataEntrata.ToShortDateString()} e uscita in data {DataUscita?.ToShortDateString()}. {(Pasto ? "Ho già mangiato." : "Non ho ancora mangiato.")}");
        }
        //public override void Look()
        //{
        //    Console.WriteLine($"Sono una gallina di nome {Nome} entrata in data {DataEntrata.ToShortDateString()} e uscita in data {DataUscita.ToShortDateString()}. {(Pasto ? "Ho già mangiato." : "Non ho ancora mangiato.")}");
        //}
    }
}
