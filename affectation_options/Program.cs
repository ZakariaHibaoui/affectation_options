using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace affectation_options
{
    class Option
    {
        public string name;
        public int places;
    }

    class Etudiant
    {

        public string nom_prenom;
        public float note;
  

        public Etudiant(string nom_prenom_Etudiant, float note_Etudiant)
        {
            nom_prenom = nom_prenom_Etudiant;

            note = note_Etudiant;

        }

    }



    class Program
    {





        static void Main(string[] args)
        {

            Console.WriteLine("entrer le nombre des etudiants ");
            int z = int.Parse(Console.ReadLine());
            string[] tab = new string[z];


            Option administrationbasedonnee = new Option();
            administrationbasedonnee.name = "ABD";
            administrationbasedonnee.places = 20;

            Option genielogiciel = new Option();
            administrationbasedonnee.name = "GL";
            genielogiciel.places = 20;


            Option administrationsystemreseau = new Option();
            administrationbasedonnee.name = "ASR";
            administrationsystemreseau.places = 20;


            var liste = new List<Tuple<Etudiant, string, string, string>>();
           



            for (int  i= 0; i < z; i++)
            {
                Console.WriteLine("Quel est votre nom et prenom?");
                string nom_prenom_Etudiant = Console.ReadLine();
                Console.WriteLine("votre note moyenne :");
                float note_Etudiant = float.Parse(Console.ReadLine());
                Etudiant etudiant_premier = new Etudiant(nom_prenom_Etudiant, note_Etudiant);

                System.Console.WriteLine("Veuillez entrer les options que vous voulez . / premier choix : ");
                string choix_premier = Console.ReadLine();
                System.Console.WriteLine("deuxieme choix :");
                string choix_deuxieme = Console.ReadLine();
                System.Console.WriteLine("troisieme choix :");
                string choix_troisieme = Console.ReadLine();
                System.Console.WriteLine("_________________________________________");

                var tuple_premier = Tuple.Create(etudiant_premier, choix_premier, choix_deuxieme, choix_troisieme);
                liste.Add(tuple_premier);
            }

            for (int j = 0; j < z; j++)
            {
                switch (liste[j].Item2)
                {
                    case "1":
                        if (genielogiciel.places > 0)
                        {
                            tab[j] = liste[j].Item1.nom_prenom;
                            --genielogiciel.places;
                        }
                        else
                        {

                            switch (liste[j].Item3)
                            {
                                case "2":
                                    if (administrationbasedonnee.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --administrationbasedonnee.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "ASR" && administrationsystemreseau.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --administrationsystemreseau.places;
                                        }
                                    }
                                    break;

                                case "3":
                                    if (administrationsystemreseau.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --administrationsystemreseau.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "ABD" && administrationbasedonnee.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --administrationbasedonnee.places;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "4":
                        if (administrationbasedonnee.places > 0)
                        {
                            tab[j] = liste[j].Item1.nom_prenom;
                            --administrationbasedonnee.places;
                        }
                        else
                        {

                            switch (liste[j].Item3)
                            {
                                case "5":
                                    if (genielogiciel.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --genielogiciel.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "ASR" && administrationsystemreseau.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --administrationsystemreseau.places;
                                        }
                                    }
                                    break;

                                case "6":
                                    if (administrationsystemreseau.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --administrationsystemreseau.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "GL" && genielogiciel.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --genielogiciel.places;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "7":
                        if (administrationsystemreseau.places > 0)
                        {
                            tab[j] = liste[j].Item1.nom_prenom;
                            --administrationsystemreseau.places;
                        }
                        else
                        {

                            switch (liste[j].Item3)
                            {
                                case "8":
                                    if (administrationbasedonnee.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --administrationbasedonnee.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "GL" && genielogiciel.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --genielogiciel.places;
                                        }
                                    }
                                    break;

                                case "9":
                                    if (genielogiciel.places > 0)
                                    {
                                        tab[j] = liste[j].Item1.nom_prenom;
                                        --genielogiciel.places;
                                    }
                                    else
                                    {
                                        if (liste[j].Item4 == "ABD" && administrationbasedonnee.places > 0)
                                        {
                                            tab[j] = liste[j].Item1.nom_prenom;
                                            --administrationbasedonnee.places;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                }




            }
            Console.WriteLine("La liste des etudiants avec leurs filieres : ");
            Console.Write("\n");
            for (int i = 0; i < z; i++)
            {


                Console.Write(tab[i] + "\t");

                Console.Write("\n");
                Console.Write("----------------------------------");
                Console.Write("\n");
            }
        }
    }
}
