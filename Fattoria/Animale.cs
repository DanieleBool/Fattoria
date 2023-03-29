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
        public string Nome { get; set; }
        public bool Pasto { get; set; }
        public DateTime DataEntrata { get; set; }
        public DateTime? DataUscita { get; set; }

        public Animale(string nome, bool pasto, DateTime entryDate, DateTime? exitDate)
        {
            Nome = nome;
            Pasto = pasto;
            DataEntrata = entryDate;
            DataUscita = exitDate;
        }

        public virtual void Look()
        {
            Console.WriteLine($"Sono un animale di nome {Nome} entrato in data {DataEntrata.ToShortDateString()} e uscito in data {DataUscita?.ToShortDateString()}. {(Pasto ? "Ho già mangiato." : "Non ho ancora mangiato.")}");
        }

    }
}
        //internal class Animale
        //{
        //       public string Nome { get; set; }
        //       public bool Pasto { get; set; }

        //       public Animale(string nome, bool pasto)
        //	{
        //           Nome = nome;
        //           Pasto = pasto;
        //       }

        //       public void Look()
        //       {
        //           Console.WriteLine($"Sono un animale di nome {Nome} e {(Pasto ? "ho" : "non ho")} già mangiato.");
        //       }


        //       public void feedQuest() 
        //	{
        //           bool feed;
        //           string cibo;
        //           Console.WriteLine("Hai nutrito l'animale? Rispondi \"si\" o \"no\"");
        //           cibo = Console.ReadLine();


        //           if (cibo == "si")
        //           {
        //               feed = true;
        //           }
        //           else if (cibo == "no")
        //           {
        //               feed = false;
        //           }
        //           else
        //           {
        //               feed = false;
        //               Console.WriteLine("Non hai inserito il giusto input");
        //           }
        //       }
        //   }
    
