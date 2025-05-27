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
            string requete = $"SELECT Count(*) FROM Utilisateur WHERE Email = @Email AND Mdp = @Mdp";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                Console.WriteLine(requete);

                try
                {
                    object result = cmd.ExecuteScalar(); // retourne la 1ère cellule de la 1ère ligne
                    //Console.WriteLine(result);
                    int count = Convert.ToInt32(result);
                    if(count > 0)
                    {
                        StatusUtilisateur(email, mdp, 1); //1 pour Connexion de l'utilisateur
                        return true;
                    }
                    return false;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public static void StatusUtilisateur(string email, string mdp, int action)
        {
            if (action == 0)
            { //Déconnexion de l'utilisateur ou fermeture de l'application
                string requete = $"UPDATE Utilisateur SET Status = @Action WHERE Email = @Email AND Mdp = @Mdp";

                using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mdp", mdp);

                    cmd.ExecuteNonQuery();
                }

            }
            else if (action == 1) { //Connexion de l'utilisateur
                string requete = $"UPDATE Utilisateur SET Status = @action WHERE Email = @Email AND Mdp = @Mdp";

                using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mdp", mdp);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string UtilisateurConnecte()
        {
            string requete = "SELECT Status FROM Utilisateur";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int status = rdr.GetInt32("Status");
                    if (status == 1)
                        return "Déconnexion";
                }
            }
            return "Se connecter";
        }

        //Fonction de test
        public static void DeconnexionUtilisateurs()
        {
            List<(string email, string mdp)> utilisateurs = new List<(string, string)>();

            //Lecture de tous les utilisateurs
            using (MySqlCommand cmd = new MySqlCommand("SELECT Email, Mdp FROM Utilisateur", connexion))
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    utilisateurs.Add((rdr.GetString("Email"), rdr.GetString("Mdp")));
                }
            }
            Console.WriteLine($"Déconnexion de {utilisateurs.Count} utilisateurs.");

            //Maj après fermeture reader
            foreach (var (email, mdp) in utilisateurs)
            {
                Console.WriteLine($"Déconnexion : {email}, {mdp}");
                string requete = "UPDATE Utilisateur SET Status = @Status WHERE Email = @Email AND Mdp = @Mdp";

                using (MySqlCommand cmd2 = new MySqlCommand(requete, connexion))
                {
                    cmd2.Parameters.AddWithValue("@Status", 0);
                    cmd2.Parameters.AddWithValue("@Email", email);
                    cmd2.Parameters.AddWithValue("@Mdp", mdp);

                    cmd2.ExecuteNonQuery();
                }
            }
        }


        public static void UtilisateurInscription(string nom, string prenom, string email, string mdp, DateTime dateInscription, DateTime dateNaissance, int admin)
        {
            string requete = @"INSERT INTO Utilisateur 
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
                    StatusUtilisateur(email, mdp, 1); //1 pour Connexion de l'utilisateur
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

            foreach (var numLigne in lignesTemp.Keys)
            {
                foreach (int segment in lignesTemp[numLigne].segments)
                {
                    string requete2 = $"SELECT NomStation FROM Station WHERE Station.NumStation = (SELECT NumStationA FROM Segment WHERE NumSegment = {segment});";
                    MySqlCommand cmd2 = new MySqlCommand(requete2, connexion);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();

                    if (rdr2.Read())
                    {
                        try
                        {
                            string nomStation = rdr2.GetString("NomStation");
                            if (!lignesTemp[numLigne].stations.Contains(nomStation))
                            {
                                lignesTemp[numLigne].stations.Add(nomStation);
                            }
                        }
                        catch (MySqlException ex)
                        {
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

            foreach (string nomStation in stations)
            {
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
            SELECT DISTINCT h.HoraireDepart, seg.DureeSegment, h.HoraireFin
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

                    TimeSpan horaireFin = rdr.GetTimeSpan("HoraireFin");
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

                    while (horaireActuel < horaireFin)
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
            cmd1.Parameters.AddWithValue("@nomStation", nomStation);

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

        /// <summary>
        /// Supprime les données d'une ligne présente dans les tables InfoLigne et Ligne
        /// </summary>
        /// <param name="nomLigne"></param>
        public static void SupprimeUneLigne(string nomLigne)
        {
            string requeteLigne = @"DELETE FROM Ligne
                                    WHERE numLigne = (SELECT numLigne
                                                      FROM InfoLigne
                                                      WHERE Nom = @nomLigne)";

            MySqlCommand cmdLigne = new MySqlCommand(requeteLigne, connexion);
            cmdLigne.Parameters.AddWithValue("@nomLigne", nomLigne);
            cmdLigne.ExecuteNonQuery();

            string requeteInfoLigne = @"DELETE FROM InfoLigne WHERE Nom = @nomLigne";

            MySqlCommand cmdInfoLigne = new MySqlCommand(requeteInfoLigne, connexion);
            cmdInfoLigne.Parameters.AddWithValue("@nomLigne", nomLigne);
            cmdInfoLigne.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute une ligne dans la base de données
        /// </summary>
        /// <param name="nomLigne"></param>
        /// <param name="couleur"></param>
        public static void AjoutLigne(string nomLigne, string couleur)
        {
            string requeteAjoutLigne = @"INSERT INTO InfoLigne (Nom, Couleur)
                                        VALUES (@nomLigne, @couleur)";

            MySqlCommand cmdAjoutLigne = new MySqlCommand(requeteAjoutLigne, connexion);
            cmdAjoutLigne.Parameters.AddWithValue("@nomLigne", nomLigne);
            cmdAjoutLigne.Parameters.AddWithValue("@couleur", couleur);
            cmdAjoutLigne.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute une station dans la base de données
        /// </summary>
        /// <param name="nomStation"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public static void AjoutStation(string nomStation, double latitude, double longitude)
        {
            string requeteAjoutStation = @"INSERT INTO Station (NomStation, Latitude, Longitude)
                                           VALUES (@nomStation, @latitude, @longitude)";

            MySqlCommand cmdAjoutStation = new MySqlCommand(requeteAjoutStation, connexion);
            cmdAjoutStation.Parameters.AddWithValue("@nomStation", nomStation);
            cmdAjoutStation.Parameters.AddWithValue("@latitude", latitude);
            cmdAjoutStation.Parameters.AddWithValue("@longitude", longitude);
            cmdAjoutStation.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute un un horaire depart pour une ligne dans la base de donnée
        /// </summary>
        /// <param name="nomStation"></param>
        /// <param name="horaire"></param>
        public static void AjoutHoraireLigne(string nomStation, DateTime horaire)
        {
            string requeteAjoutHoraire = @"INSERT INTO Horaire (HoraireDepart, NumLigne)
                                           VALUES (@horaireDepart, @numLigne)";

            MySqlCommand cmdAjoutHoraire = new MySqlCommand(requeteAjoutHoraire, connexion);
            cmdAjoutHoraire.Parameters.AddWithValue("@numLigne", nomStation);
            cmdAjoutHoraire.Parameters.AddWithValue("@horaireDepart", horaire);
            cmdAjoutHoraire.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de modifier InfoLigne
        /// </summary>
        /// <param name="numLigne"></param>
        /// <param name="nom"></param>
        /// <param name="couleur"></param>
        public static void ModifInfosLigne(int numLigne, string nom, string couleur)
        {
            string requete = @"UPDATE InfoLigne SET Nom = @nom, Couleur = @couleur WHERE NumLigne = @numLigne";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@couleur", couleur);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de modifier le nom des stations
        /// </summary>
        /// <param name="stationsChange"></param>
        public static void ModifNomStations(Dictionary<string, string> stationsChange)
        {
            foreach (KeyValuePair<string, string> station in stationsChange)
            {
                string ancienNom = station.Key;    //Clé = nom d'origine
                string nouveauNom = station.Value; //Valeur = nouveau nom

                string requete = "UPDATE Station SET NomStation = @nouveauNom WHERE NomStation = @ancienNom";
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nouveauNom", nouveauNom);
                cmd.Parameters.AddWithValue("@ancienNom", ancienNom);

                cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// Permet de modifier les coordonnées d'une station
        /// </summary>
        /// <param name="coordonneesChange"></param>
        public static void ModifCoordonneesStations(Dictionary<string, (decimal lat, decimal lon)> coordonneesChange)
        {
            foreach (KeyValuePair<string, (decimal lat, decimal lon)> station in coordonneesChange)
            {
                string nomStation = station.Key;
                decimal latitude = station.Value.lat;
                decimal longitude = station.Value.lon;

                if (latitude != 0 && longitude != 0)
                {
                    //Latitude & Longitude
                    string requete = @"UPDATE Station SET Latitude = @lat, Longitude = @lon WHERE NomStation = @nom";
                    MySqlCommand cmd = new MySqlCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lat", latitude);
                    cmd.Parameters.AddWithValue("@lon", longitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
                else if (latitude != 0)
                {
                    //Latitude seulement
                    string requete = @"UPDATE Station SET Latitude = @lat WHERE NomStation = @nom";
                    MySqlCommand cmd = new MySqlCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lat", latitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
                else if (longitude != 0)
                {
                    //Longitude seulement
                    string requete = @"UPDATE Station SET Longitude = @lon WHERE NomStation = @nom";
                    MySqlCommand cmd = new MySqlCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lon", longitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Ajoute un segment entre deux stations dans la base de données.
        /// </summary>
        /// <param name="dureeSegment">Temps en seconde pour aller de la station A à la station B</param>
        /// <param name="numStationA">Station de départ du segment</param>
        /// <param name="numStationB">Station d'arriver du segment</param>
        public static void AjoutSegment(int dureeSegment, int numStationA, int numStationB)
        {
            // Ajoute un segment entre deux stations
            string requete = @"INSERT INTO Segment (DureeSegment, NumStationA, NumStationB) 
                                VALUES (@dureeSegment, @numStationA, @numStationB)";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@dureeSegment", dureeSegment);
            cmd.Parameters.AddWithValue("@numStationA", numStationA);
            cmd.Parameters.AddWithValue("@numStationB", numStationB);
            cmd.ExecuteNonQuery();
        }

        public static void AjoutSegmentDansLigne(int numLigne, int numSegment, int ordre)
        {
            // Ajoute un segment à une ligne
            string requete = @"INSERT INTO Ligne (NumLigne, NumSegment, Ordre) 
                                VALUES (@numLigne, @numSegment, @ordre)";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.Parameters.AddWithValue("@numSegment", numSegment);
            cmd.Parameters.AddWithValue("@ordre", ordre);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Récupère l'ID d'une ligne à partir de son nom.
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>Retourne l'ID </returns>
        public static int idLigneGraceNom(string nom)
        {
            string requete = @"SELECT NumLigne FROM InfoLigne WHERE Nom = @nom";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Récupère l'ID d'une station à partir de son nom.
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>Retourne l'ID de la station</returns>
        public static int idStationGraceNom(string nom)
        {
            string requete = @"SELECT NumStation FROM Station WHERE NomStation = @nom";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Récupère l'ID du dernier objet inséré dans la base de données.
        /// </summary>
        /// <returns>Retourne l'ID récupérer</returns>
        public static int RecupereIdDernierObjet()
        {
            string requete = @"SELECT LAST_INSERT_ID()";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
