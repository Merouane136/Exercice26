using System;

namespace Exercice26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclarations
            int saisie, heure = 0, minute, seconde;

            //Sasisie d'un nombre de secondes
            do
            {
                Console.Write("Saisissez un nombre de secondes(entre 0 et 86400) : ");
                saisie = int.Parse(Console.ReadLine());
            } while (saisie < 0 || saisie > 86400);
            

            //Conversion
            heure = saisie / 3600;
            minute = (saisie - (heure * 3600)) / 60;
            seconde = saisie - (heure * 3600) - (minute*60);

            //Formatage de l'affcichage
            string affichage = "";
            if (heure<10)
            {
                affichage += "0";
            }
            affichage += heure + ":";

            if (minute < 10)
            {
                affichage += "0";
            }
            affichage += minute + ":";

            if (seconde < 10)
            {
                affichage += "0";
            }
            affichage += seconde ;

            //Affichage final sous forme HH:MM:SS

            Console.Write("Voici la conversion du nombre de secondes : " + affichage);
            Console.ReadLine();


        }
    }
    //Correction: Au lieu de tronquer ecrire en int directement
}
