using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria;

internal class Bipede : Animale
{
    public const string Zampe = "2";

    public Bipede(string nome, bool pasto, DateTime entryDate, DateTime exitDate) : base(nome, pasto, entryDate, exitDate) { }
}
//internal class Bipede : Animale
//{
//    //public string Zampe { get; set; }
//    //public Bipede(string nome, bool pasto) : base(nome, pasto)
//    //{
//    //    Zampe = "2";
//    //}

//    //public override void look()
//    //{
//    //    Console.WriteLine($"Sono un bipede di nome {nome}, ho {zampe} zampe e {(pasto ? "ho mangiato" : "non ho mangiato")}");
//    //}
//    //public static string Zampe { get => zampe; set => zampe = value; }
//}