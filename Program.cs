using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_technique_moDmoB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Premier exercice



            // initialisation d'une premiere variable
            int sum = 0;
            //itération de la valeur jusqu'a 90000.
            for (int index = 0; index < 90000; index++)
            {
                // prendre seulement les multiples de 3
                if (index % 3 == 0)
                {
                    //Additionner les valeurs ensemble
                    sum += index;
                }
            }
            //retourne la somme
            Console.WriteLine("S = " + sum);



            // deuxieme exercice




            //Convertir la somme en chaine de caractère
            string sumToString = sum.ToString();
            // mettre la chaine de caractère dans un tableau
            char[] listChar = sumToString.ToCharArray();

            Console.Write("L = ");
            //itération du tableau pour récupérer le chiffre converti
            foreach (char numberConvertedToChar in listChar)
            {
                Console.Write(numberConvertedToChar + " ");
            }




            // troisieme exercice




            //Suppression les valeurs en doublons et creation d'un nouveau tableau apres suppresion avec nouvelle valeur
            char[] ListCharAfterRemoveDuplicate= listChar.Distinct().ToArray();
            Console.Write("\n"+"L' = ");
            //affichage du nouveau tableau
            foreach (char charToNumber in ListCharAfterRemoveDuplicate)
            {
                Console.Write(charToNumber + " ");
            }



            // quatrieme exercice


            //conversion du tableau de caractère en nouveau tableau d'entier
            int[] NumberArray = Array.ConvertAll(ListCharAfterRemoveDuplicate, charToNumber => (int)Char.GetNumericValue(charToNumber));
            //affichage du tableau avec la somme 
            Console.WriteLine("\n"+ "S' = " + NumberArray.Sum()); 
        }
    }
}
