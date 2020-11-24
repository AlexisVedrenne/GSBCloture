using Classe.Technique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Clôture
{
    class Program
    {
        static void Main()
        {
            //BddMySql.GetInstance();
            //int nb = BddMySql.ClotureFraisDuMois("202011");
            //Console.WriteLine(nb);
            DateTime d1 = new DateTime(1991, 10, 12);
            DateTime d2 = new DateTime(1991, 11, 9);
            DateTime d3 = new DateTime(2001, 1, 5);
            Console.WriteLine("Mois precedent : "+GestionDate.getMoisPrecedent());
            Console.WriteLine("Mois suivant : "+GestionDate.getMoisSuivant());
            Console.WriteLine("Mois precedent param : "+GestionDate.getMoisPrecedent(d1));
            Console.WriteLine("Mois suivant param : " + GestionDate.getMoisSuivant(d2));
            Console.WriteLine("Entre vrai : "+GestionDate.Entre(25,20));
            Console.WriteLine("Entre faux : "+GestionDate.Entre(2,10));
            Console.WriteLine("Entre param vrai : " + GestionDate.Entre(1,6 ,d3));
            Console.WriteLine("Entre param faux : " + GestionDate.Entre(20, 30,d3));
            Console.ReadLine();
        }
    }
}
