// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using Fattoria;

Console.WriteLine("Hello, World!");


var animali = new List<Animale>
{
	new Gallina("ovaia", false),
	new Gallina("lina", false),
	new Gallina("rosita", false),
	new Cavallo("millo", false),
	new Cavallo("rocco", false),
	new Maiale("dino", false),
	new Maiale("ciccio", false),
	new Oca("loca", false),
	new Oca("miseria", false),
	new Maiale("peppa", false),
};

foreach (Animale animale in animali)
{
	animale.look();
};

//Console.WriteLine("Enter category:");
//string newCat;
//newCat = Console.ReadLine();
//const categorie = new string[] {"Oca","Maiale","Cavallo","Gallina"};
////if (list.Contains(answer))
//    if (categorie.Any(newCat.Equals))
//{
//	Console.WriteLine("non è la categoria giusta");
//}
////else {
////    string? Value = null;
////    newCat = Value;
////}

//Console.WriteLine("Enter name:");
//string newPet;
//newPet = Console.ReadLine();

//if (newPet == null) 
//{ 
//	Console.WriteLine("non hai scritto");
//}
//else 
//{
//	animali.Add(newPet);
//	animali.pasto;
//};

//Console.WriteLine("Hai scritto: " + newPet);


Console.WriteLine("Enter category:");
string newCat;
newCat = Console.ReadLine();

Console.WriteLine("Enter name:");
string input;
input = Console.ReadLine();
Animale newPet = null;

bool feed;
string cibo;
Console.WriteLine("hai dato cibo?");
cibo = Console.ReadLine();

if(cibo == "si")
{
	feed = true;
}
else
{
	feed = false;
}

switch(newCat)
{
	case "Maiale":
		newPet = new Maiale(input, feed);
		break;
	case "Oca":
		newPet = new Oca(input, feed);
		break;
	case "Gallina":
        newPet = new Gallina(input, feed);
        break;
	case "Cavallo":
        newPet = new Cavallo(input, feed);
        break;
	default:
		Console.WriteLine("La categoria non è presente");
		break;
}

animali.Add(newPet);
