using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verif_Mail
{
   public class Lib
    {
        /// <summary>
        /// Verifie chaque caractere de la chaine Domaine [AZaz09-_.]
        /// </summary>
        /// <param name="Domaine"></param>
        /// <returns></returns>
        public static string VerificationChaineDomaine(char[] Domaine)
        {
            int Compteur = 0;
            int PlaceDuDernierPoint = 0;
            if (Domaine.Length > 256) //D'apres  http://en.wikipedia.org/wiki/E-mail_address#RFC_specification 
                return ("Partie Domaine trop longue.");
            while (Compteur < Domaine.Length)
            {

                if (Domaine[Compteur] > 64 && Domaine[Compteur] < 91/*Majuscule*/ || Domaine[Compteur] > 96 && Domaine[Compteur] < 123/*Minuscule*/ || Domaine[Compteur] == 46/*.*/ || Domaine[Compteur] == 45/*-*/ || Domaine[Compteur] > 47 && Domaine[Compteur] < 58/*Chiffre*/)
                {
                    if (Domaine[Compteur] == 46/*.*/ || Domaine[Compteur] == 45/*-*/ )
                    {
                            if (Compteur == 0)
                                return ("Caractere illicite suivant le arobase.");


                        if (PlaceDuDernierPoint != 0 && (Compteur - 1) == PlaceDuDernierPoint && Domaine[Compteur] == 46)
                        {
                            return ("Deux point se suive dans la zone domaine.");
                        }
                        if (Domaine[Compteur - 1] == '-' && Domaine[Compteur] == '-')
                        {
                            return ("Deux tiret se suive dans la zone domaine.");
                        }
                        if (Domaine[Compteur] == '.' && Domaine[Compteur - 1] == '-'|| Domaine[Compteur] == '-' && Domaine[Compteur - 1] == '.')
                            return ("Deux Caractere speciaux se suive dans la zone domaine.");
                        if (Domaine[Compteur] == 46)
                            PlaceDuDernierPoint = Compteur;

                    }
                    Compteur++;
                }
                
                else //si caractere != de AZaz09-_. alors erreur
                {
              
                    return ("Caractere illicite apres arobase.");
                }
    
            }
            if (Domaine.Length - PlaceDuDernierPoint < 3)// .net .org.com.fr
                return ("Partie Lang trop courte.");
            if(PlaceDuDernierPoint == 0)
                return ("Aucun point dans la zone domaine.");
            return ("");
        }
        /// <summary>
        /// Verifie chaque caractere de la chaine local [AZaz09-_.]
        /// </summary>
        /// <param name="Chaine"></param>
        /// <returns></returns>
        public static string VerificationChaineLocale(char[] Local)
        {
            int Compteur = 0;
            if (Local.Length > 65) //D'apres  http://en.wikipedia.org/wiki/E-mail_address#RFC_specification 
                return ("Partie Locale trop longue.");
            while (Compteur < Local.Length)
            {
                if (Local[Compteur] > 64 && Local[Compteur] < 91/*Majuscule*/ || Local[Compteur] > 96 && Local[Compteur] < 123/*Minuscule*/ || Local[Compteur] == 46/*.*/ || Local[Compteur] == 45/*-*/ || Local[Compteur] == 95 /*_*/|| Local[Compteur] > 49 && Local[Compteur] < 58/*Chiffre*/)
                {
                    if (Local[Compteur] == 46/*.*/ || Local[Compteur] == 45/*-*/ || Local[Compteur] == 95 /*_*/)
                    {
                        if(Compteur == 0)
                            return ("caractere special interdit comme 1er caractere");
                        if (Local[Compteur - 1] == 46/*.*/ || Local[Compteur - 1] == 45/*-*/ || Local[Compteur - 1] == 95 /*_*/)
                            return ("Deux caractere speciaux a la suite .");
                    }
                        Compteur++;
                }
                else
                {//si caractere != de AZaz09-_. alors erreur
                    return ("Caractere illicite avant arobase.");
                }
            }
            return ("");
        }

        /// <summary>
        /// Copie une partie du textbox dans une chaine de caractere 
        /// </summary>
        /// <param name="TexBox"></param>
        /// <param name="TextBoxACopier"></param>
        /// <param name="Debut"></param>
        /// <param name="Fin"></param>
        /// <returns></returns>
        public static char[] InitialiseChaine(char[] TextBox, string TextBoxACopier, int Debut, int Fin)
        {

            int Compteur = 0;
            while (Debut < Fin && Compteur < TextBox.Length)
            {

                TextBox[Compteur] = TextBoxACopier[Debut];
                Debut++;
                Compteur++;
            }
            return (TextBox);
        }

        /// <summary>
        /// Fonction qui renvoie la position de '@' dans la chaine TextBox, renvoie 0 si elle ne la pas trouvée.
        /// </summary>
        /// <param name="TextBox"></param>
        /// <returns></returns>
        public static int PlaceArobase(string TextBox)
        {
            int Compteur = 0;
            while (Compteur < TextBox.Length)
            {
                if (TextBox[Compteur] == '@')
                    return (Compteur);
                Compteur++;
            }
            return (0);
        }

        /// <summary>
        /// Verification de la saisie utilisateur,prend en parametre un string.
        /// </summary>
        /// <param name="TextBox"></param>
        /// <returns></returns>
        public static string Verification_Email(string TextBox)
        {
            //string retour = "";
            int LongueurStringTextBox = TextBox.Length;
            if (LongueurStringTextBox > 5)//Verification de la taille minimal pour une adresse mail
            {
                if (PlaceArobase(TextBox) > 0)//Verification place de l'arobase
                {
                    int Int_PlaceArobase = PlaceArobase(TextBox);
                    char[] Local = new char[Int_PlaceArobase];//Initialise une chaine de longueur 
                    char[] Domaine = new char[LongueurStringTextBox - (Int_PlaceArobase + 1)];
                    Local = InitialiseChaine(Local, TextBox, 0, Int_PlaceArobase);
                    Domaine = InitialiseChaine(Domaine, TextBox, Int_PlaceArobase + 1, TextBox.Length);
                    if (VerificationChaineDomaine(Domaine) == "" && VerificationChaineLocale(Local) == "")
                    {
                        return ("");
                    }
                    else
                    {
                        return (VerificationChaineDomaine(Domaine)+ VerificationChaineLocale(Local));
                    }
                }
                else
                {

                    return "Manque caractere '@'.\n";
                }
            }
            else
            {
          
          
                return "Saisie longueur trop petite.\n";
            }

            return "";
        }
    }
}
