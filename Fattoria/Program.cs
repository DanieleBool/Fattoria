// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using Fattoria;

namespace Fattoria
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



            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSeleziona un'opzione:");
                Console.WriteLine("1. Aggiungi animale");
                Console.WriteLine("2. Modifica animale");
                Console.WriteLine("3. Visualizza animali");
                Console.WriteLine("4. Esci");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddAnimal(animali);
                        break;
                    case "2":
                        ModifyAnimal(animali);
                        break;
                    case "3":
                        DisplayAnimals(animali);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida.");
                        break;
                }
            }
        }

        static void AddAnimal(List<Animale> animali)
        {
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

            Console.WriteLine("Enter exit date (leave blank if unknown):");
            DateTime? exitDate = null;
            string exitDateString = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(exitDateString))
            {
                DateTime parsedExitDate;
                while (!DateTime.TryParse(exitDateString, out parsedExitDate))
                {
                    Console.WriteLine("Non hai inserito una data valida. Riprova.");
                    exitDateString = Console.ReadLine();
                }
                exitDate = parsedExitDate;
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
            
        }

        static void ModifyAnimal(List<Animale> animali)
        {
            Console.WriteLine("Inserisci il nome dell'animale da modificare:");
            string name = Console.ReadLine();

            Animale animale = animali.FirstOrDefault(a => a.Nome == name);
            if (animale != null)
            {
                Console.WriteLine("Seleziona l'opzione da modificare:");
                Console.WriteLine("1. Nome");
                Console.WriteLine("2. Stato nutrizione");
                Console.WriteLine("3. Data d'entrata");
                Console.WriteLine("4. Data d'uscita");

                int option;
                while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
                {
                    Console.WriteLine("Inserisci un numero valido tra 1 e 4:");
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Inserisci il nuovo nome:");
                        animale.Nome = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("L'animale è stato nutrito? Rispondi \"si\" o \"no\"");
                        string cibo = Console.ReadLine();
                        while (true)
                        {
                            if (cibo == "si")
                            {
                                animale.Pasto = true;
                                break;
                            }
                            else if (cibo == "no")
                            {
                                animale.Pasto = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Non hai inserito il giusto input. Riprova.");
                                cibo = Console.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserisci la nuova data d'entrata:");
                        DateTime entryDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out entryDate))
                        {
                            Console.WriteLine("Non hai inserito una data valida. Riprova.");
                        }
                        animale.DataEntrata = entryDate;
                        break;
                    case 4:
                        Console.WriteLine("Inserisci la nuova data d'uscita o lascia vuoto per rimuovere la data d'uscita:");
                        string exitDateString = Console.ReadLine();
                        if (DateTime.TryParse(exitDateString, out DateTime exitDate))
                        {
                            animale.DataUscita = exitDate;
                        }
                        else
                        {
                            animale.DataUscita = null;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Animale non trovato.");
            }
        }

            

        static void DisplayAnimals(List<Animale> animali)
        {
            //foreach (Animale animale in animali)
            //{
            //    animale.Look();
            //}
            // Qui il codice per visualizzare la lista degli animali.
            Console.WriteLine("\nSituazione animali:");
            foreach (Animale animale in animali)
            {
                string statoPasto = animale.Pasto ? "nutrito" : "non nutrito";
                //Console.WriteLine($"{animale.Nome} ({animale.GetType().Name}), {statoPasto}, entrata il {animale.DataEntrata.ToShortDateString()}, uscita il {animale.DataUscita.ToShortDateString()})");
                Console.WriteLine($"{animale.Nome} ({animale.GetType().Name}), {statoPasto}, entrata il {animale.DataEntrata.ToShortDateString()}, uscita il {(animale.DataUscita.HasValue ? animale.DataUscita.Value.ToShortDateString() : "N/A")}");
            }
        }
    }
  
}


            //Console.WriteLine("Enter category:");
            //string newCat = Console.ReadLine();

            //Console.WriteLine("Enter name:");
            //string input = Console.ReadLine();

            //bool feed;
            //string cibo;
            //Console.WriteLine("Hai nutrito l'animale? Rispondi \"si\" o \"no\"");
            //cibo = Console.ReadLine();

            //while (true)
            //{
            //    if (cibo == "si")
            //    {
            //        feed = true;
            //        break;
            //    }
            //    else if (cibo == "no")
            //    {
            //        feed = false;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Non hai inserito il giusto input. Riprova.");
            //        cibo = Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("Enter entry date:");
            //DateTime entryDate;
            //while (!DateTime.TryParse(Console.ReadLine(), out entryDate))
            //{
            //    Console.WriteLine("Non hai inserito una data valida. Riprova.");
            //}

            //Console.WriteLine("Enter exit date:");
            //DateTime exitDate;
            //while (!DateTime.TryParse(Console.ReadLine(), out exitDate))
            //{
            //    Console.WriteLine("Non hai inserito una data valida. Riprova.");
            //}

            //Animale newPet;
            //switch (newCat)
            //{
            //    case "Maiale":
            //        newPet = new Maiale(input, feed, entryDate, exitDate);
            //        break;
            //    case "Oca":
            //        newPet = new Oca(input, feed, entryDate, exitDate);
            //        break;
            //    case "Gallina":
            //        newPet = new Gallina(input, feed, entryDate, exitDate);
            //        break;
            //    case "Cavallo":
            //        newPet = new Cavallo(input, feed, entryDate, exitDate);
            //        break;
            //    default:
            //        Console.WriteLine("La categoria non è presente");
            //        return;
            //}

            //animali.Add(newPet);

            //Console.WriteLine("\nSituazione animali:");
            //foreach (Animale animale in animali)
            //{
            //    string statoPasto = animale.Pasto ? "nutrito" : "non nutrito";
            //    Console.WriteLine($"{animale.Nome} ({animale.GetType().Name}), {statoPasto}, entrata il {animale.DataEntrata.ToShortDateString()}, uscita il {animale.DataUscita.ToShortDateString()});
            //}


