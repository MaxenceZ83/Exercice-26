using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration

            int secondes;
            string heure;

            // Saisie du nombre de secondes 

            do
            {
                Console.Write("Entrez le nombre de secondes (entre 0 et 86400) = ");
                secondes = int.Parse(Console.ReadLine());

            } while (secondes < 0 || secondes > 86400);

            // Calcul des heures, minutes et secondes correspondantes 

            int h = secondes / 3600;
            int m = (secondes - (h * 3600));
            int s = secondes - (h * 3600) - (m * 60);

            // formatage de la chaîne à afficher (avec ajout de "0" si nécessaire
            heure = "";
            if (h < 10)
            {
                heure += "O";
            }
            heure += h + ":";
            if (m < 10)
            {
                heure += "O";
            }
            heure += m + ":";
            if (s < 10)
            {
                heure += "O";
            }
            heure += s;

            // affichage final de l'heure
            Console.WriteLine(heure);
            Console.ReadLine();
        }
    }
   
  
}
