// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
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

Console.WriteLine("Enter category:");
string newCat;
newCat = Console.ReadLine();
var categorie = new string[] {"Oca","Maiale","Cavallo","Gallina"};
//if (list.Contains(answer))
    if (categorie.Any(newCat.Equals))
{
	Console.WriteLine("non è la categoria giusta");
}
//else {
//    string? Value = null;
//    newCat = Value;
//}

Console.WriteLine("Enter name:");
string newPet;
newPet = Console.ReadLine();

if (newPet == null) 
{ 
	Console.WriteLine("non hai scritto");
}
else 
{
	animali.Add(newPet);
	animali.pasto;
};

Console.WriteLine("Hai scritto: " + newPet);



//Animale animale2 = new Gallina("ovaia", false);
//Animale animale3 = new Gallina("lina", false);
//Animale animale4 = new Gallina("rosita", false);
//Animale animale5 = new Cavallo("millo", false);
//Animale animale6 = new Cavallo("rocco", false);
//Animale animale7 = new Maiale("dino", false);
//Animale animale8 = new Maiale("ciccio", false);
//Animale animale9 = new Oca("loca", false);
//Animale animale10 = new Oca("miseria", false);
//Animale animale1 = new Maiale("peppa",false);

//Animale.look();
//devo fare riferimento ad un oggetto