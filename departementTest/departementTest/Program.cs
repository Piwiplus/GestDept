using System;
using ClassDepartement;

namespace departementTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Departement d1 = new Departement("38", "ISERE", 7431, 1094, "Rhône-Aples");
            Departement d2 = new Departement("75", "PARIS", 105, 2125, "Ile-De-France");
            Console.Write("entré un numéro de département");
            string num1 = Console.ReadLine();
            Console.Write("entré un nom de département");
            string nom1 = Console.ReadLine();
            Console.Write("entré la superficie du département");
            double sup1 = double.Parse(Console.ReadLine());
            Console.Write("entré un nombre de la population du département");
            double pop1 = double.Parse(Console.ReadLine());
            Console.Write("entré le nom de la région");
            string reg1 = Console.ReadLine();
            Departement d3 = new Departement(num1,nom1,sup1,pop1, reg1);

            d1.Afficher();
            d2.Afficher();
            d3.Afficher();
            Console.WriteLine(d1.GetNom() + " = " + d1.CalculerDensite());
            Console.WriteLine(d2.GetNom() + " = " + d2.CalculerDensite());
            d1.SetRegion("Auvergne-Rhône-Alpes");
            d1.Afficher();
            DensitePlus(d1,d2);
        }
        static string DensitePlus(Departement dep1, Departement dep2)
        {
            if (dep1.CalculerDensite() > dep2.CalculerDensite())
            {
                return dep1.GetNom();
            }
            else
            {
                return dep2.GetNom();
            }
        }
    }
}
