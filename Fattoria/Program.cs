// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using Fattoria;

namespace Fattoria
{
    namespace Animali
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Animale> animali = new List<Animale>
            {
                new Gallina("ovaia", false, DateTime.Now, DateTime.Now),
                new Gallina("lina", false, DateTime.Now, DateTime.Now),
                new Gallina("rosita", false, DateTime.Now, DateTime.Now),
                new Cavallo("millo", false, DateTime.Now, DateTime.Now),
                new Cavallo("rocco", false, DateTime.Now, DateTime.Now),
                new Maiale("dino", false, DateTime.Now, DateTime.Now),
                new Maiale("ciccio", false, DateTime.Now, DateTime.Now),
                new Oca("loca", false, DateTime.Now, DateTime.Now),
                new Oca("miseria", false, DateTime.Now, DateTime.Now),
                new Maiale("peppa", false, DateTime.Now, DateTime.Now),
            };

                foreach (Animale animale in animali)
                {
                    animale.Look();
                }

                Console.WriteLine("Enter category:");
                string newCat = Console.ReadLine();

                Console.WriteLine("Enter name:");
                string input = Console.ReadLine();

                bool feed;
                string cibo;
                Console.WriteLine("Hai nutrito l'animale? Rispondi \"si\" o \"no\"");
                cibo = Console.ReadLine();

                while (true)
                {
                    if (cibo == "si")
                    {
                        feed = true;
                        break;
                    }
                    else if (cibo == "no")
                    {
                        feed = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Non hai inserito il giusto input. Riprova.");
                        cibo = Console.ReadLine();
                    }
                }

                Console.WriteLine("Enter entry date:");
                DateTime entryDate;
                while (!DateTime.TryParse(Console.ReadLine(), out entryDate))
                {
                    Console.WriteLine("Non hai inserito una data valida. Riprova.");
                }

                Console.WriteLine("Enter exit date:");
                DateTime exitDate;
                while (!DateTime.TryParse(Console.ReadLine(), out exitDate))
                {
                    Console.WriteLine("Non hai inserito una data valida. Riprova.");
                }

                Animale newPet;
                switch (newCat)
                {
                    case "Maiale":
                        newPet = new Maiale(input, feed, entryDate, exitDate);
                        break;
                    case "Oca":
                        newPet = new Oca(input, feed, entryDate, exitDate);
                        break;
                    case "Gallina":
                        newPet = new Gallina(input, feed, entryDate, exitDate);
                        break;
                    case "Cavallo":
                        newPet = new Cavallo(input, feed, entryDate, exitDate);
                        break;
                    default:
                        Console.WriteLine("La categoria non è presente");
                        return;
                }

                animali.Add(newPet);

                Console.WriteLine("\nSituazione animali:");
                foreach (Animale animale in animali)
                {
                    string statoPasto = animale.Pasto ? "nutrito" : "non nutrito";
                    Console.WriteLine($"{animale.Nome} ({animale.GetType().Name}), {statoPasto}, entrata il {animale.DataEntrata.ToShortDateString()}, uscita il {animale.DataUscita.ToShortDateString()});
                }
            }
        }
    }
}
//Console.WriteLine("Hello, World!");



//var animali = new List<Animale>
//{
//	new Gallina("ovaia", false),
//	new Gallina("lina", false),
//	new Gallina("rosita", false),
//	new Cavallo("millo", false),
//	new Cavallo("rocco", false),
//	new Maiale("dino", false),
//	new Maiale("ciccio", false),
//	new Oca("loca", false),
//	new Oca("miseria", false),
//	new Maiale("peppa", false),
//};

//foreach (Animale animale in animali)
//{
//	animale.look();
//};

//// string choose;
//// Console.WriteLine("Se vuoi inserire i dati di un nuovo animale premi \"y\", se vuoi modificare i dati di un animale premi \"x\"");
//// choose = Console.ReadLine();
//// Button button1 = new Button();
//// Button button2 = new Button();
//// if (
////Console.WriteLine("Enter category:");
////string newCat;
////newCat = Console.ReadLine();
////const categorie = new string[] {"Oca","Maiale","Cavallo","Gallina"};
//////if (list.Contains(answer))
////    if (categorie.Any(newCat.Equals))
////{
////	Console.WriteLine("non è la categoria giusta");
////}
//////else {
//////    string? Value = null;
//////    newCat = Value;
//////}

////Console.WriteLine("Enter name:");
////string newPet;
////newPet = Console.ReadLine();

////if (newPet == null) 
////{ 
////	Console.WriteLine("non hai scritto");
////}
////else 
////{
////	animali.Add(newPet);
////	animali.pasto;
////};

////Console.WriteLine("Hai scritto: " + newPet);

////INPUT UTENTE e DICHIARAZIONE VARIABILI ////////////////////////////////////

//Console.WriteLine("Enter category:");
//string newCat;
//newCat = Console.ReadLine();

//Console.WriteLine("Enter name:");
//string input;
//input = Console.ReadLine();
//Animale newPet = null;

//bool feed;
//string cibo;
//Console.WriteLine("Hai nutrito l'animale? Rispondi \"si\" o \"no\"");
//cibo = Console.ReadLine();

//do
//{


//if(cibo == "si")
//{
//	feed = true;
//}
//else if( cibo == "no")
//{
//	feed = false;
//}
//else
//{
//	feed = false;
//	Console.WriteLine("Non hai inserito il giusto input");
//}
//}


//switch(newCat)
//{
//	case "Maiale":
//		newPet = new Maiale(input, feed);
//		break;
//	case "Oca":
//		newPet = new Oca(input, feed);
//		break;
//	case "Gallina":
//        newPet = new Gallina(input, feed);
//        break;
//	case "Cavallo":
//        newPet = new Cavallo(input, feed);
//        break;
//	default:
//		Console.WriteLine("La categoria non è presente");
//		break;
//}

//animali.Add(newPet);
