using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria;

internal class Bipede : Animale
{
    private static string zampe = "2";

    public Bipede(string nome, bool pasto) : base(nome, pasto)
    {
    }

    //public static string Zampe { get => zampe; set => zampe = value; }
}