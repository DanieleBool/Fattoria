using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    internal class Quadrupede : Animale
    {
        public const string Zampe = "4";

        public Quadrupede(string nome, bool pasto, DateTime entryDate, DateTime? exitDate) : base(nome, pasto, entryDate, exitDate) { }
    }

    //internal class Quadrupede : Animale
    //{
    //    public string Zampe { get; set; }
    //    public Quadrupede(string nome, bool pasto) : base(nome, pasto)
    //    {
    //        Zampe = "4";
    //    }

    //    public override void look()
    //    {
    //        Console.WriteLine($"Sono un quadrupede di nome {nome}, ho {zampe} zampe e {(pasto ? "ho mangiato" : "non ho mangiato")}");
    //    }
    //    //public static string Zampe { get => zampe; set => zampe = value; }

}

