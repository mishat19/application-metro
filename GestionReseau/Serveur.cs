using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GestionReseau
{
    public static class Serveur
    {
        private static MySqlConnection connexion;

        public static bool OuvertureConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "b3";
            string mdp = "mdp";
            string bd = "baseb3";

            string chaineConnexion = $"server={serveur};uid={login};pwd={mdp};database={bd}";

            connexion = new MySqlConnection(chaineConnexion);

            try
            {
                connexion.Open();
                Console.WriteLine("Connexion réussie");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                return false;
            }
        }

        public static bool FermetureConnexion()
        {
            try
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    connexion.Close();
                    Console.WriteLine("Déconnexion réussie");
                    connexion.Dispose();
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " + ex.Message);
                return false;
            }
        }

        public static bool UtilisateurConnexion(string email, string mdp)
        {
            string requete = $"SELECT Count(*) FROM utilisateur WHERE Email = @Email AND Mdp = @Mdp";
            
            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                Console.WriteLine(requete);

                try
                {
                    object result = cmd.ExecuteScalar(); // retourne la 1ère cellule de la 1ère ligne
                    Console.WriteLine(result);
                    int count = Convert.ToInt32(result);

                    return count > 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public static void UtilisateurInscription(string nom, string prenom, string email, string mdp, DateTime dateInscription, DateTime dateNaissance, int admin)
        {
            string requete = @"INSERT INTO utilisateur 
                       (NomUtilisateur, PrenomUtilisateur, Email, Mdp, DateInscription, DateNaissance, Admin)
                       VALUES (@Nom, @Prenom, @Email, @Mdp, @DateInscription, @DateNaissance, @Admin)";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);
                cmd.Parameters.AddWithValue("@DateInscription", dateInscription);
                cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@Admin", admin);

                Console.WriteLine(requete);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static ListeLignes Lignes()
        {
            ListeLignes listeLignes = new ListeLignes();
            string requete = $"SELECT * FROM InfoLigne INNER JOIN Ligne ON InfoLigne.NumLigne = Ligne.NumLigne";
            Console.WriteLine(requete);
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Dictionary<int, Ligne> lignesTemp = new Dictionary<int, Ligne>();
            int nbLignes = 0;

            while (rdr.Read())
            {
                int numLigne = rdr.GetInt32("NumLigne");
                string nom = rdr.GetString("Nom");
                string couleur = rdr.GetString("Couleur");
                int numSegment = rdr.GetInt32("NumSegment");
                List<int> segments = new List<int>();
                List<string> stations = new List<string>();
                //Console.WriteLine($"{numLigne} + {nom} {couleur} {numSegment}");

                if (!lignesTemp.ContainsKey(numLigne))
                {
                    lignesTemp[numLigne] = new Ligne(numLigne, nom, couleur, segments, stations);
                    nbLignes++;
                }

                lignesTemp[numLigne].segments.Add(numSegment);
            }

            rdr.Close();

            for (int i = 0; i<nbLignes; i++)
            {
                foreach(int segment in lignesTemp[3].segments)
                {
                    string requete2 = $"SELECT NomStation FROM Station WHERE Station.NumStation = (SELECT NumStationA FROM Segment WHERE NumSegment = {segment});";
                    Console.WriteLine(requete2);
                    MySqlCommand cmd2 = new MySqlCommand(requete2, connexion);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();

                    if (rdr2.Read())
                    {
                        try
                        {
                            string nomStation = rdr2.GetString("NomStation");
                            lignesTemp[4].stations.Add(nomStation);
                        }
                        catch (MySqlException ex) {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    rdr2.Close();
                }
            }

            foreach (var ligne in lignesTemp.Values)
            {
                listeLignes.AjoutLigne(ligne);
            }

            return listeLignes;
        }


    public static void Itineraire(string stationDep, string stationArr, TimeOnly horaireDep, TimeOnly horaireArr)
        {
            //A FAIRE QUAND ALGO DE GRAPHE
            string requete = $"SELECT * FROM Station WHERE NomStation = '{stationDep}' JOIN Segment ON '{stationDep}'.NumStation = Segment.NumSegment" +
                "";
        }
    }
}
