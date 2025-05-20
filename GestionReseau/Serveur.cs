using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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

            for (int i = 1; i<=nbLignes; i++)
            {
                foreach(int segment in lignesTemp[i].segments)
                {
                    string requete2 = $"SELECT NomStation FROM Station WHERE Station.NumStation = (SELECT NumStationA FROM Segment WHERE NumSegment = {segment});";
                    //Console.WriteLine(requete2);
                    MySqlCommand cmd2 = new MySqlCommand(requete2, connexion);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();

                    if (rdr2.Read())
                    {
                        try
                        {
                            string nomStation = rdr2.GetString("NomStation");
                            if(!lignesTemp[i].stations.Contains(nomStation))
                            {
                                lignesTemp[i].stations.Add(nomStation);
                            }
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

        public static double HoraireSegment(string numStationA, string numStationB)
        {
            string stationA = numStationA;
            string stationB = numStationB;
            double resultat = 0;

            string requete = $"SELECT DureeSegment FROM Segment WHERE NumStationA = {numStationA} AND NumStationB = {numStationB}";
            Console.WriteLine(requete);
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) {
                resultat = (double)rdr.GetInt32("DureeSegment");
            }
            rdr.Close();
            return resultat;
        }

        public static string TotalHoraire(int numLigne, double tempsTrajet)
        {
            string requete = $"SELECT HoraireDepart FROM Horaire WHERE NumLigne = {numLigne}";
            Console.WriteLine(requete);

            TimeSpan mysqlTime = TimeSpan.Zero;
            TimeOnly horaireDepart;
            TimeOnly horaireFinal;
            string resultat = "";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                mysqlTime = rdr.GetTimeSpan("HoraireDepart");
            }

            rdr.Close();

            horaireDepart = TimeOnly.FromTimeSpan(mysqlTime);
            horaireFinal = horaireDepart.AddMinutes(tempsTrajet);

            resultat = horaireFinal.ToString("HH:mm");

            return resultat;
        }

        public static List<string> HorairesParStationEtLigne(string nomLigne, string nomStation)
        {
            List<string> horaires = new List<string>();

            // Récupérer le NumLigne
            string requeteNumLigne = $"SELECT NumLigne FROM InfoLigne WHERE Nom = @NomLigne";
            MySqlCommand cmd1 = new MySqlCommand(requeteNumLigne, connexion);
            cmd1.Parameters.AddWithValue("@NomLigne", nomLigne);
            int numLigne = -1;

            using (var rdr = cmd1.ExecuteReader())
            {
                if (rdr.Read())
                    numLigne = rdr.GetInt32("NumLigne");
            }

            if (numLigne == -1) return horaires;

            // Vérifier si la station est utilisée dans un segment de cette ligne
            string requete = @"
            SELECT DISTINCT Horaire.HoraireDepart
            FROM Horaire
            JOIN Ligne ON Horaire.NumLigne = Ligne.NumLigne
            JOIN Segment ON Ligne.NumSegment = Segment.NumSegment
            JOIN Station ON Station.NumStation = Segment.NumStationA OR Station.NumStation = Segment.NumStationB
            WHERE Horaire.NumLigne = @NumLigne AND Station.NomStation = @NomStation";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NumLigne", numLigne);
            cmd.Parameters.AddWithValue("@NomStation", nomStation);

            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    TimeSpan horaire = rdr.GetTimeSpan("HoraireDepart");
                    horaires.Add(horaire.ToString(@"hh\:mm"));
                }
            }

            return horaires;
        }

        public static void SupprimerDonnees(string nomLigne, string nomStation = null, string horaire = null)
        {
            if (!string.IsNullOrWhiteSpace(nomStation) && !string.IsNullOrWhiteSpace(horaire))
            {
                Console.WriteLine($"Suppression des données pour la ligne '{nomLigne}', station '{nomStation}' à l'horaire '{horaire}'.");
                // TODO : supprimer à ce niveau de précision (ligne + station + horaire)
                string requete = $"DELETE FROM Horaire";
            }
            else if (!string.IsNullOrWhiteSpace(nomStation))
            {
                Console.WriteLine($"Suppression des données pour la ligne '{nomLigne}', station '{nomStation}'.");
                // TODO : supprimer la station pour la ligne donnée
            }
            else
            {
                Console.WriteLine($"Suppression de toutes les données pour la ligne '{nomLigne}'.");
                // TODO : supprimer toute la ligne
            }
        }

        public static List<string> ListeDesLignes()
        {
            List<string> lignes = new List<string>();
            string requete = "SELECT Nom FROM InfoLigne";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString("Nom"));
                }
            }

            return lignes;
        }

        public static List<string> StationsParLigne(string nomLigne)
        {
            List<string> stations = new List<string>();
            string requete = @"
            SELECT DISTINCT st.NomStation
            FROM InfoLigne il, Ligne l, Segment seg, Station st 
            WHERE il.Nom = @NomLigne
            AND il.NumLigne = l.NumLigne
            AND l.NumSegment = seg.NumSegment
            AND (st.NumStation = seg.NumStationA OR st.NumStation = seg.NumStationB)";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomLigne", nomLigne);

            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    stations.Add(rdr.GetString("NomStation"));
                }
            }
            return stations;
        }

        public static void Itineraire(string stationDep, string stationArr, TimeOnly horaireDep, TimeOnly horaireArr)
        {
            //A FAIRE QUAND ALGO DE GRAPHE
            string requete = $"SELECT * FROM Station WHERE NomStation = '{stationDep}' JOIN Segment ON '{stationDep}'.NumStation = Segment.NumSegment" +
                "";
        }
    }
}
