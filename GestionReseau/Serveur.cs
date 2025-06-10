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
        private static MySqlConnection? connexion;

        /// <summary>
        /// Fonction permettant l'ouverture de la base de donnée
        /// </summary>
        /// <returns>Confirmation de l'ouverture</returns>
        public static bool OuvertureConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "b3";
            string mdp = "mdp";
            string bd = "baseb3";

            string chaineConnexion = $"server={serveur};uid={login};pwd={mdp};database={bd}";  // Chaîne de connexion à la base MySQL

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

        /// <summary>
        /// Fonction permettant la fermeture de la bd
        /// </summary>
        /// <returns>Confirmation de la fermeture</returns>
        public static bool FermetureConnexion()
        {
            try
            {
                if (connexion.State == System.Data.ConnectionState.Open)
                {
                    connexion.Close();
                    Console.WriteLine("Déconnexion réussie");
                    connexion.Dispose(); // Libère les ressources associées à la connexion
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

        /// <summary>
        /// Récupère le nombre d'utilisateur
        /// </summary>
        /// <param name="email">Email de l'utilisateur</param>
        /// <param name="mdp">Mot de passe de l'utilisateur</param>
        /// <returns>True si l'utilisateur est connecté, false sinon</returns>
        public static bool UtilisateurConnexion(string email, string mdp)
        {
            string requete = $"SELECT Count(*) FROM Utilisateur WHERE Email = @Email AND Mdp = @Mdp";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                //Console.WriteLine(requete);

                try
                {
                    object result = cmd.ExecuteScalar(); // Exécute la requête et retourne la première cellule (nombre d'utilisateurs)
                    //Console.WriteLine(result);
                    int count = Convert.ToInt32(result);
                    if(count > 0)
                    {
                        StatusUtilisateur(email, mdp, 1); // Met à jour le statut en connecté
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

        /// <summary>
        /// Fonction permettant la connexion et la deconnexion d'un utilsiateur
        /// </summary>
        /// <param name="email">Email de l'utilisateur</param>
        /// <param name="mdp">Mot de passe</param>
        /// <param name="action">0 = Deconnexion / 1 = Connexion</param>
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

                    cmd.ExecuteNonQuery(); // Met à jour le statut dans la base
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

        /// <summary>
        /// Status de connexion de l'utilisateur
        /// </summary>
        /// <returns>Se connecter / Déconnexion</returns>
        public static (string, int) UtilisateurConnecte()
        {
            string connexionText = "Se connecter";
            string deconnexionText = "Déconnexion";
            int estConnecte = 0;

            string requete = "SELECT Status, Admin FROM Utilisateur";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int status = rdr.GetInt32("Status");
                    int admin = rdr.GetInt32("Admin");
                    if (status == 1){
                        estConnecte = (admin == 1) ? 1 : 0; // Si admin connecté, renvoie 1, sinon 0
                        return (deconnexionText, estConnecte);
                    }
                }
            }
            return (connexionText, estConnecte);
        }

        /// <summary>
        /// Permet la deconnexion de tout les utilisateurs
        /// </summary>
        public static void DeconnexionUtilisateurs()
        {
            List<(string email, string mdp)> utilisateurs = new List<(string, string)>();

            // Lecture de tous les utilisateurs pour récupérer leur email/mdp
            using (MySqlCommand cmd = new MySqlCommand("SELECT Email, Mdp FROM Utilisateur", connexion))
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    utilisateurs.Add((rdr.GetString("Email"), rdr.GetString("Mdp")));
                }
            }

            // Mise à jour du statut après la fermeture du reader
            foreach (var (email, mdp) in utilisateurs)
            {
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

        /// <summary>
        /// Fonction pour inscrire un utilisateur
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur</param>
        /// <param name="prenom">Prénom de l'utilisateur</param>
        /// <param name="email">Email de l'utilisateur</param>
        /// <param name="mdp">Mot de passe de l'utilisateur</param>
        /// <param name="dateInscription">Date d'inscription de l'utilisateur</param>
        /// <param name="dateNaissance">Date de naissance de l'utilisateur</param>
        /// <param name="admin">Si l'utilisateur est administrateur ou non</param>
        public static void UtilisateurInscription(string nom, string prenom, string email, string mdp, DateTime dateInscription, DateTime dateNaissance, int admin)
        {
            string requete = @"INSERT INTO Utilisateur 
                       (NomUtilisateur, PrenomUtilisateur, Email, Mdp, DateInscription, DateNaissance, Admin)
                       VALUES (@Nom, @Prenom, @Email, @Mdp, @DateInscription, @DateNaissance, @Admin)"; //  Requête SQL d'insertion paramétrée : permet d'éviter l’injection SQL

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);
                cmd.Parameters.AddWithValue("@DateInscription", dateInscription);
                cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@Admin", admin);

                //Console.WriteLine(requete);
                try
                {
                    cmd.ExecuteNonQuery();
                    StatusUtilisateur(email, mdp, 1); //Appel de la méthode enregistrant l'événement de connexion après inscription
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Récupère la liste des lignes de métro et leurs informations associées.
        /// </summary>
        /// <returns>Retourne la liste</returns>
        public static ListeLignes Lignes()
        {
            ListeLignes listeLignes = new ListeLignes();
            string requete = $"SELECT * FROM InfoLigne INNER JOIN Ligne ON InfoLigne.NumLigne = Ligne.NumLigne";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Dictionary<int, Ligne> lignesTemp = new Dictionary<int, Ligne>(); //Utilisé pour éviter de recréer plusieurs fois la même ligne(optimisation)
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

                if (!lignesTemp.ContainsKey(numLigne))// Initialise une nouvelle ligne seulement si elle n'a pas encore été ajoutée
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
                    string requete2 = $"SELECT NomStation FROM Station WHERE Station.NumStation = (SELECT NumStationA FROM Segment WHERE NumSegment = {segment});"; //Sous-requête imbriquée : on récupère la station de départ (NumStationA) associée à un segment précis
                    MySqlCommand cmd2 = new MySqlCommand(requete2, connexion);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();

                    if (rdr2.Read())
                    {
                        try
                        {
                            string nomStation = rdr2.GetString("NomStation");
                            if (!lignesTemp[numLigne].stations.Contains(nomStation)) // Évite les doublons dans la liste des stations d’une ligne
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

        /// <summary>
        /// Récupère les coordonnées GPS des stations d'une ligne donnée.
        /// </summary>
        /// <param name="stations">Liste des stations</param>
        /// <returns>Retourne les coordonnées de toutes les stations</returns>
        public static List<List<decimal>> CoordonneesStationsLigne(List<string> stations)
        {
            List<List<decimal>> toutes = new List<List<decimal>>();

            foreach (string nomStation in stations)
            {
                string nomEchappe = nomStation.Replace("'", "''"); // Échappe les apostrophes dans le nom de la station pour éviter des erreurs SQL
                string requete = $"SELECT Latitude, Longitude FROM Station WHERE NomStation = '{nomEchappe}'";
                //Console.WriteLine(requete);
                MySqlCommand cmd = new MySqlCommand(requete, connexion);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<decimal> gps = new List<decimal>(); // Structure contenant toutes les coordonnées GPS : chaque élément est une liste [latitude, longitude]

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

        /// <summary>
        /// Récupère la liste des stations d'une ligne donnée.
        /// </summary>
        /// <param name="nomLigne">Nom de la ligne</param>
        /// <returns>Retourne le nom de la ligne</returns>
        public static List<string> StationsParLigne(string nomLigne)
        {
            List<string> stations = new List<string>();

            string requete = @"
            SELECT DISTINCT st.NomStation
            FROM InfoLigne il, Ligne l, Segment seg, Station st
            WHERE il.Nom = 'NomLigne'
            AND il.NumLigne = l.NumLigne
            AND l.NumSegment = seg.NumSegment
            AND (st.NumStation = seg.NumStationA OR st.NumStation = seg.NumStationB)";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomLigne", nomLigne);

            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    stations.Add(reader.GetString(0));  // 0 = première colonne : NomStation

            return stations;
        }

        /// <summary>
        /// Calcul les horaires de passage d'une station
        /// </summary>
        /// <param name="nomStation">Nom de la station</param>
        public static List<string> CalculeHorairePassageStation(string nomStation, DateTime date)
        {
            List<string> horaireStation = new List<string>();
            TimeSpan heure = date.TimeOfDay;//On extrait uniquement l’heure actuelle (exclut la date) pour la comparaison

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

                    double multiplicateur;//Multiplie le temps de trajet si c’est un dimanche (plus de temps pour les trajets)

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
                        Console.WriteLine(horaireActuel.ToString());
                        Console.WriteLine(heure.ToString());
                        if(horaireActuel > heure)//N’ajoute que les horaires futurs (après l’heure actuelle)
                        {
                            horaireStation.Add(horaireActuel.ToString(@"hh\:mm\:ss"));
                        }
                        horaireActuel = horaireActuel.Add(TimeSpan.FromSeconds(dureeSegment * multiplicateur));
                    }
                }
            }

            return horaireStation;
        }

        public static string CalculeProchainHoraire(string nomStation, DateTime date)
        {
            string prochainHoraire = null;
            TimeSpan heure = date.TimeOfDay;

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

                    double multiplicateur = (date.DayOfWeek == DayOfWeek.Sunday) ? 1.75 : 1;

                    while (horaireActuel < horaireFin)
                    {
                        if (horaireActuel > heure)
                        {
                            // On retourne le premier horaire trouvé
                            return horaireActuel.ToString(@"hh\:mm\:ss");
                        }
                        horaireActuel = horaireActuel.Add(TimeSpan.FromSeconds(dureeSegment * multiplicateur));//Calcule l’heure suivante de passage à la station, selon la durée du segment
                    }
                }
            }

            return prochainHoraire; // Peut être null si aucun horaire trouvé
        }


        /// <summary>
        /// Supprime une information de ligne dans la base de données.
        /// </summary>
        /// <param name="numLigne">Numéro de la ligne</param>
        public static void SupprimerUneInfoLigne(int numLigne)
        {
            string requete = @"DELETE FROM InfoLigne WHERE NumLigne = @numLigne";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprime une station et ses segments associés d'une ligne spécifique dans la base de données.
        /// </summary>
        /// <param name="nomLigne">Nom de la ligne</param>
        /// <param name="nomStation">Nom de la station</param>
        public static void SupprimerUnSegment(string nomStation)
        {
            int idStation = idStationGraceNom(nomStation);

            string requeteDesactiverFK = @"SET FOREIGN_KEY_CHECKS = 0";
            MySqlCommand cmdDesactiverFK = new MySqlCommand(requeteDesactiverFK, connexion);
            cmdDesactiverFK.ExecuteNonQuery();

            string requeteSupprimerSegment = @"DELETE FROM Segment WHERE NumStationA = @idStation OR NumStationB = @idStation";
            MySqlCommand cmd = new MySqlCommand(requeteSupprimerSegment, connexion);
            cmd.Parameters.AddWithValue("@idStation", idStation);
            cmd.ExecuteNonQuery();

            string requeteActiverFK = @"SET FOREIGN_KEY_CHECKS = 1";
            MySqlCommand cmdActiverFK = new MySqlCommand(requeteActiverFK, connexion);
            cmdActiverFK.ExecuteNonQuery();
        }

        public static void SupprimerUneStation(string nomStation)
        {
            int idStation = idStationGraceNom(nomStation);

            string requeteSupprimerStation = @"DELETE FROM Station WHERE NumStation = @idStation";
            MySqlCommand cmd = new MySqlCommand(requeteSupprimerStation, connexion);
            cmd.Parameters.AddWithValue("@idStation", idStation);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute une ligne dans la base de données
        /// </summary>
        /// <param name="nomLigne">Nom de la ligne</param>
        /// <param name="couleur">Couleur de la ligne</param>
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
        /// <param name="nom">Nom de la ligne</param>
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
        /// <param name="nom">Nom de la station</param>
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

        /// <summary>
        /// Ajoute un horaire de départ et de fin pour une ligne dans la base de données.
        /// </summary>
        /// <param name="NomLigne">Numéro de la ligne</param>
        /// <param name="HoraireDepart">Horaire du premier passage de la ligne</param>
        /// <param name="HoraireFin">Horaire du dernier passage de la ligne</param>
        public static void AjoutHoraireDepartFin(int NumLigne, DateTime HoraireDepart, DateTime HoraireFin)
        {
            string requete = @"INSERT INTO Horaire (NumLigne, HoraireDepart, HoraireFin) 
                                VALUES (@NumLigne, @HoraireDepart, @HoraireFin)";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NumLigne", NumLigne);
            cmd.Parameters.AddWithValue("@HoraireDepart", HoraireDepart);
            cmd.Parameters.AddWithValue("@HoraireFin", HoraireFin);
            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Supprime les informations en rapport avec une ligne dans la table Ligne.
        /// </summary>
        /// <param name="numLigne">Numéro de la ligne</param>
        public static void SupprimerUneLigne(int numLigne)
        {
            string requete = @"DELETE FROM Ligne WHERE NumLigne = @numLigne";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprier les informations d'horaire d'une ligne dans la table Horaire
        /// </summary>
        /// <param name="numLigne">Numéro de la ligne</param>
        public static void SupprimerUnHoraire(int numLigne)
        {
            string requete = @"DELETE FROM Horaire WHERE NumLigne = @numLigne";

            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Liste des stations
        /// </summary>
        /// <returns>Liste des stations en fonction du nom</returns>
        public static List<string> ListeDesStations()
        {
            List<string> stations = new List<string>();
            string requete = "SELECT NomStation FROM Station";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    stations.Add(rdr.GetString("NomStation"));
                }
            }
            return stations;
        }

        public static void MettreAJourCouleurEtNumeroLigne(int numLigne, string couleur, string nom)
        {
            string requete = @"UPDATE InfoLigne 
                       SET Couleur = @Couleur, Nom = @Nom
                       WHERE NumLigne = @NumLigne";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Couleur", couleur);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@NumLigne", numLigne);
                cmd.ExecuteNonQuery();
            }
        }

        public static void MettreAJourNomsStations(Dictionary<string, string> stations)
        {
            foreach (var station in stations)
            {
                string ancienNom = station.Key;
                string nouveauNom = station.Value;

                if (!string.Equals(ancienNom, nouveauNom, StringComparison.Ordinal))
                {
                    string requete = @"UPDATE Station 
                               SET NomStation = @NouveauNom 
                               WHERE NomStation = @AncienNom";

                    using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
                    {
                        cmd.Parameters.AddWithValue("@NouveauNom", nouveauNom);
                        cmd.Parameters.AddWithValue("@AncienNom", ancienNom);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void UpdateDureesSegments(Dictionary<string, int> dureesChange)
        {
            using (MySqlCommand cmd = new MySqlCommand("", connexion))
            {
                foreach (var entree in dureesChange)
                {
                    string nomStation = entree.Key;
                    int nouvelleDuree = entree.Value;

                    cmd.CommandText = "SELECT NumStation FROM Station WHERE NomStation = @nomStation";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomStation", nomStation);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int numStationA))
                    {
                        cmd.CommandText = "UPDATE Segment SET DureeSegment = @duree WHERE NumStationA = @numStationA";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@duree", nouvelleDuree);
                        cmd.Parameters.AddWithValue("@numStationA", numStationA);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine($"Station non trouvée : {nomStation}");
                    }
                }
            }
        }

        public static void MettreAJourCoordonneesStations(Dictionary<string, (decimal Latitude, decimal Longitude)> coordonnees)
        {
            foreach (var station in coordonnees)
            {
                string nomStation = station.Key;
                decimal latitude = station.Value.Latitude;
                decimal longitude = station.Value.Longitude;

                string requete = "";
                if (latitude != 0 && longitude != 0)
                {
                    requete = @"UPDATE Station 
                        SET Latitude = @Latitude, Longitude = @Longitude 
                        WHERE NomStation = @NomStation";
                }
                else if (latitude != 0)
                {
                    requete = @"UPDATE Station 
                        SET Latitude = @Latitude 
                        WHERE NomStation = @NomStation";
                }
                else if (longitude != 0)
                {
                    requete = @"UPDATE Station 
                        SET Longitude = @Longitude 
                        WHERE NomStation = @NomStation";
                }
                else
                {
                    continue; // pas de mise à jour
                }

                using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
                {
                    if (latitude != 0)
                        cmd.Parameters.AddWithValue("@Latitude", latitude);
                    if (longitude != 0)
                        cmd.Parameters.AddWithValue("@Longitude", longitude);

                    cmd.Parameters.AddWithValue("@NomStation", nomStation);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModifierHoraireParLigne(int numLigne, TimeSpan horaireDebut, TimeSpan horaireFin)
        {
            string requete = "UPDATE Horaire SET HoraireDepart = @debut, HoraireFin = @fin WHERE NumLigne = @numLigne";

            using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@debut", horaireDebut);
                cmd.Parameters.AddWithValue("@fin", horaireFin);
                cmd.Parameters.AddWithValue("@numLigne", numLigne);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Aucun horaire mis à jour. Vérifiez NumLigne.");
            }
        }

        /// <summary>
        /// Récupère la durée des segments d'une ligne spécifique.
        /// </summary>
        /// <param name="numLigne">Numéro de la ligne</param>
        /// <returns>Retourne la liste de durée des segments d'une ligne</returns>
        public static List<(string stationDepart, string stationArrivee, int duree)> DureeSegmentsLigne(int numLigne)
        {
            List<(string, string, int)> segmentsLigne = new List<(string, string, int)>();

            string requete = @"
                SELECT s.NumStationA, s.NumStationB, s.DureeSegment,
                sa.NomStation AS NomStationA,
                sb.NomStation AS NomStationB
                FROM Ligne l
                JOIN Segment s ON l.NumSegment = s.NumSegment
                JOIN Station sa ON s.NumStationA = sa.NumStation
                JOIN Station sb ON s.NumStationB = sb.NumStation
                WHERE l.NumLigne = @numLigne
                ORDER BY l.Ordre
            ";

            using (var cmd = new MySqlCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@numLigne", numLigne);

                using (var lecteur = cmd.ExecuteReader())
                {
                    while (lecteur.Read())
                    {
                        string stationDepart = lecteur.GetString("NomStationA");
                        string stationArrivee = lecteur.GetString("NomStationB");
                        int duree = lecteur.GetInt32("DureeSegment");

                        segmentsLigne.Add((stationDepart, stationArrivee, duree));
                    }
                }
            }

            return segmentsLigne;
        }

        /// <summary>
        /// Récupère les données du graphe, incluant les stations et les segments.
        /// </summary>
        /// <returns>Retourne les données du graphe</returns>
        public static (Dictionary<int, Station> stations, List<(int idA, int idB, int duree, int numLigne)> segments) ObtenirDonneesGraphe()
        {
            Dictionary<int, Station> stations = new Dictionary<int, Station>();
            List<(int, int, int, int)> segments = new List<(int, int, int, int)>();

            string requeteStations = "SELECT NumStation, NomStation FROM Station";
            using (var cmdStations = new MySqlCommand(requeteStations, connexion))
            using (var lecteur = cmdStations.ExecuteReader())
            {
                while (lecteur.Read())
                {
                    int id = lecteur.GetInt32("NumStation");
                    string nom = lecteur.GetString("NomStation");
                    stations[id] = new Station(nom);
                }
            }

            string requeteSegments = @"
            SELECT s.NumStationA, s.NumStationB, s.DureeSegment, l.NumLigne
            FROM Segment s
            JOIN Ligne l ON s.NumSegment = l.NumSegment";

            using (var cmdSegments = new MySqlCommand(requeteSegments, connexion))
            using (var lecteur = cmdSegments.ExecuteReader())
            {
                while (lecteur.Read())
                {
                    int idA = lecteur.GetInt32("NumStationA");
                    int idB = lecteur.GetInt32("NumStationB");
                    int duree = lecteur.GetInt32("DureeSegment");
                    int numLigne = lecteur.GetInt32("NumLigne");

                    segments.Add((idA, idB, duree, numLigne));
                }
            }

            return (stations, segments);
        }

        public static void SupprimerUnSegment(int idStation)
        {
            string requete = @"DELETE FROM Segment WHERE NumStationA = @idStation OR NumStationB = @idStation";
            MySqlCommand cmd = new MySqlCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nomStation", idStation);
            cmd.ExecuteNonQuery();
        }
        public static (DateTime, DateTime) RecupererHorairesLigne(int idLigne)
        {
            string requeteHoraireDebut = @"SELECT HoraireDepart FROM Horaire WHERE NumLigne = @numLigne";
            MySqlCommand cmdHoraireDebut = new MySqlCommand(requeteHoraireDebut, connexion);
            cmdHoraireDebut.Parameters.AddWithValue("@numLigne", idLigne);
            TimeSpan horaireDebut = (TimeSpan)cmdHoraireDebut.ExecuteScalar();

            string requeteHoraireFin = @"SELECT HoraireFin FROM Horaire WHERE NumLigne = @numLigne";
            MySqlCommand cmdHoraireFin = new MySqlCommand(requeteHoraireFin, connexion);
            cmdHoraireFin.Parameters.AddWithValue("@numLigne", idLigne);
            TimeSpan horaireFin = (TimeSpan)cmdHoraireFin.ExecuteScalar();

            DateTime baseDate = DateTime.Today;
            DateTime resultatHoraireDebut = baseDate.Add(horaireDebut);
            DateTime resultatHoraireFin = baseDate.Add(horaireFin);

            return (resultatHoraireDebut, resultatHoraireFin);
        }
    }
}
