using System;
using ClassDepartement;

namespace AppliGestDept
{
    class Program
    {
        static void Main(string[] args)
        {
            Departement d = new Departement("40", "landes", 9243, 327, "Aquitaine");
            d.Afficher();
        }
    }
}
