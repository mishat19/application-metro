using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Ocsp;

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
        public static List<List<decimal>> CoordonneesStationsLigne(List<string> stations)
        {
            List<List<decimal>> toutes = new List<List<decimal>>();

            foreach (string nomStation in stations) {
                string nomEchappe = nomStation.Replace("'", "''");
                string requete = $"SELECT Latitude, Longitude FROM Station WHERE NomStation = '{nomEchappe}'";
                Console.WriteLine(requete);
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<decimal> gps = new List<decimal>();

                if (rdr.Read())
                {
                    gps.Add(rdr.GetDecimal("Latitude"));
                    gps.Add(rdr.GetDecimal("Longitude"));
                }
                rdr.Close();
                toutes.Add(gps);
            }
            return toutes;
        }

        public static void SupprimerDonnees(string nomLigne, string nomStation = null)
        {
            if (!string.IsNullOrWhiteSpace(nomStation))
            {
                Console.WriteLine($"Suppression des données pour la ligne '{nomLigne}', station '{nomStation}'.");
                // Récupérer le numLigne dans InfoLigne, modifier les stations A et B dans Segment puis supprimer station dans Station
            }
            else
            {
                Console.WriteLine($"Suppression de toutes les données pour la ligne '{nomLigne}'.");
                // Tout supprimer à la main chaque dépendance avant la Ligne ou bien UPDATE pour mettre un ON DELETE CASCADE ou changer le NumLigne de chaque Segment en "0" pour signifier "pas rattaché"
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
        /// <summary>
        /// Calcul les horaires de passage d'une station
        /// </summary>
        /// <param name="nomStation"></param>
        public static List<string> CalculeHorairePassageStation(string nomStation, DateTime date)
        {
            List<string> horaireStation = new List<string>();

            string requete = @"
            SELECT DISTINCT h.HoraireDepart, seg.DureeSegment
            FROM Station st, Segment seg, Ligne l, Horaire h
            WHERE st.NomStation = @NomStation
            AND st.NumStation = seg.NumStationB
            AND seg.NumSegment = l.NumSegment
            AND l.NumLigne = h.NumLigne";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomStation", nomStation);

            using (var rdr = cmd.ExecuteReader())
            {
                
                while (rdr.Read())
                {
                    TimeSpan horaireDepart = rdr.GetTimeSpan("HoraireDepart");
                    int dureeSegment = rdr.GetInt32("DureeSegment");

                    TimeSpan horaireLimite = new TimeSpan(22, 0, 0);
                    TimeSpan horaireActuel = horaireDepart;

                    double multiplicateur;

                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        multiplicateur = 1.75;
                    }
                    else
                    {
                        multiplicateur = 1;
                    }

                    while (horaireActuel < horaireLimite)
                    {
                        horaireStation.Add(horaireActuel.ToString(@"hh\:mm\:ss"));
                        horaireActuel = horaireActuel.Add(TimeSpan.FromSeconds(dureeSegment * multiplicateur));
                    }
                }
            }

            return horaireStation;
        }

        /// <summary>
        /// Permet de supprimer une station a partir du numero de la ligne et du nom de la station
        /// </summary>
        /// <param name="nomLigne"></param>
        /// <param name="nomStation"></param>
        public static void SupprimerUneStation(string nomLigne, string nomStation)
        {
            string requeteIdStation =
            @"SELECT s.NumStation
            FROM Station st
            JOIN Segment seg ON st.NumStation = seg.NumStationA OR st.NumStation = seg.NumStationB
            JOIN Ligne l ON seg.NumSegment = l.NumSegment
            JOIN InfoLigne il ON seg.NumSegment = l.NumSegment
            WHERE s.NomStation = @nomStation AND i.Nom = @nomLigne
            LIMIT 1"
            ;

            MySqlCommand cmd1 = new MySqlCommand(requeteIdStation, connexion);
            cmd1.Parameters.AddWithValue("@nomLigne", nomLigne);
            cmd1.Parameters.AddWithValue("@NomStation", nomStation);

            object resultat = cmd1.ExecuteScalar();
            int idStation = Convert.ToInt32(resultat);

            string requeteSupprimerSegment = @"DELETE FROM Segment WHERE NumStationA = @idStation OR NumStationB = @idStation";

            MySqlCommand cmd2 = new MySqlCommand(requeteSupprimerSegment, connexion);
            cmd2.Parameters.AddWithValue("@idStation", idStation);

            string requeteSupprimerStation = @"DELETE FROM Station WHERE NumStation = @idStation";

            MySqlCommand cmd3 = new MySqlCommand(requeteSupprimerStation, connexion);
            cmd3.Parameters.AddWithValue("@idStation", idStation);
            cmd3.ExecuteNonQuery();
        }

        public static void Itineraire(string stationDep, string stationArr, TimeOnly horaireDep, TimeOnly horaireArr)
        {
            //A FAIRE QUAND ALGO DE GRAPHE
            string requete = $"SELECT * FROM Station WHERE NomStation = '{stationDep}' JOIN Segment ON '{stationDep}'.NumStation = Segment.NumSegment" +
                "";
        }
    }
}
