using System;

namespace ClassDepartement
{
    /// <summary>
    /// Classe Département
    /// </summary>
    public class Departement
    {
        //Attributs privés
        private string numero;
        private string nom;
        private double superficie; // en Km²
        private double population; // en miliers d'habitants
        private string region;
        public Departement(string unNumero, string unNom, double uneSuperficie, double unePopulation, string uneRegion)
        {
            #region attribut
            this.numero = unNumero;
            this.nom = unNom;
            this.superficie = uneSuperficie;
            this.population = unePopulation;
            this.region = uneRegion;
            #endregion
        }
        public void Afficher()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", this.numero, this.nom, this.superficie, this.population, this.region);
        }
        public double CalculerDensite()
        {
            double densite;
            densite = this.population * 1000 / this.superficie;
            return densite;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public string GetSuperficie()
        {
            return this.superficie;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public void SetNom(string unNom)
        {
            this.nom = unNom;
        }
        public void SetRegion(string uneRegion)
        {
            this.region = uneRegion;
        }
        public void SetPopulation(double Population)
        {
            this.population = Population;
        }

    }
}
