using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace GestionReseau
{
    public static class Serveur
    {
        private static SqliteConnection? connexion;

        /// <summary>
        /// Fonction permettant l'ouverture de la base de donnée
        /// </summary>
        /// <returns>Confirmation de l'ouverture</returns>
        public static bool OuvertureConnexion()
        {
            // Fichier de base de données local
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "metro.db");
            string chaineConnexion = $"Data Source={dbPath}";

            connexion = new SqliteConnection(chaineConnexion);

            try
            {
                connexion.Open();
                InitialiserBaseDeDonnees(); // Génère les tables si la BDD est vierge
                Console.WriteLine("Connexion réussie");
                return true;
            }
            catch (SqliteException ex)
            {
                Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                return false;
            }
        }

        private static void InitialiserBaseDeDonnees()
        {
            string requeteCreation = @"
                CREATE TABLE IF NOT EXISTS Utilisateur (
                    Email TEXT PRIMARY KEY,
                    Mdp TEXT,
                    NomUtilisateur TEXT,
                    PrenomUtilisateur TEXT,
                    DateInscription TEXT,
                    DateNaissance TEXT,
                    Admin INTEGER,
                    Status INTEGER
                );
                CREATE TABLE IF NOT EXISTS InfoLigne (
                    NumLigne INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nom TEXT,
                    Couleur TEXT
                );
                CREATE TABLE IF NOT EXISTS Station (
                    NumStation INTEGER PRIMARY KEY AUTOINCREMENT,
                    NomStation TEXT,
                    Latitude REAL,
                    Longitude REAL
                );
                CREATE TABLE IF NOT EXISTS Segment (
                    NumSegment INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumStationA INTEGER,
                    NumStationB INTEGER,
                    DureeSegment INTEGER
                );
                CREATE TABLE IF NOT EXISTS Ligne (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumLigne INTEGER,
                    NumSegment INTEGER,
                    Ordre INTEGER
                );
                CREATE TABLE IF NOT EXISTS Horaire (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumLigne INTEGER,
                    HoraireDepart TEXT,
                    HoraireFin TEXT
                );

                -- Compte Administrateur
                INSERT OR IGNORE INTO Utilisateur (Email, Mdp, Admin, Status) 
                VALUES ('admin@metro.fr', 'admin', 1, 0);

                -- Lignes de métro
                INSERT OR IGNORE INTO InfoLigne (NumLigne, Nom, Couleur) VALUES 
                (1, 'Ligne A', 'Rouge'), 
                (2, 'Ligne B', 'Bleu');
        
                -- Stations
                INSERT OR IGNORE INTO Station (NumStation, NomStation, Latitude, Longitude) VALUES 
                (1, 'Mairie', 49.8940, 2.2950),
                (2, 'Gare Centrale', 49.8900, 2.3010),
                (3, 'Université', 49.8800, 2.2800),
                (4, 'Hôpital', 49.8700, 2.2900),
                (5, 'Stade', 49.8950, 2.3100);
        
                -- Segments (Connexions entre les stations avec durée en secondes)
                INSERT OR IGNORE INTO Segment (NumSegment, NumStationA, NumStationB, DureeSegment) VALUES 
                (1, 1, 2, 120),
                (2, 2, 3, 180),
                (3, 2, 4, 150),
                (4, 4, 5, 200);
        
                -- Association des segments aux lignes avec ordre de passage
                INSERT OR IGNORE INTO Ligne (Id, NumLigne, NumSegment, Ordre) VALUES 
                (1, 1, 1, 1),
                (2, 1, 2, 2),
                (3, 2, 3, 1),
                (4, 2, 4, 2);
        
                -- Horaires de fonctionnement des lignes
                INSERT OR IGNORE INTO Horaire (Id, NumLigne, HoraireDepart, HoraireFin) VALUES 
                (1, 1, '06:00:00', '23:30:00'),
                (2, 2, '05:45:00', '22:00:00');
            ";

            using (SqliteCommand cmd = new SqliteCommand(requeteCreation, connexion))
            {
                cmd.ExecuteNonQuery();
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
                if (connexion != null && connexion.State == System.Data.ConnectionState.Open)
                {
                    connexion.Close();
                    Console.WriteLine("Déconnexion réussie");
                    connexion.Dispose(); // Libère les ressources associées à la connexion
                    return true;
                }
                return false;
            }
            catch (SqliteException ex)
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

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                try
                {
                    object result = cmd.ExecuteScalar(); // Exécute la requête et retourne la première cellule (nombre d'utilisateurs)
                    int count = Convert.ToInt32(result);
                    if (count > 0)
                    {
                        StatusUtilisateur(email, mdp, 1); // Met à jour le statut en connecté
                        return true;
                    }
                    return false;
                }
                catch (SqliteException ex)
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
            string requete = $"UPDATE Utilisateur SET Status = @Action WHERE Email = @Email AND Mdp = @Mdp";

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);

                cmd.ExecuteNonQuery(); // Met à jour le statut dans la base
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

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            using (SqliteDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int status = rdr.GetInt32(rdr.GetOrdinal("Status"));
                    int admin = rdr.GetInt32(rdr.GetOrdinal("Admin"));
                    if (status == 1)
                    {
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
            using (SqliteCommand cmd = new SqliteCommand("SELECT Email, Mdp FROM Utilisateur", connexion))
            using (SqliteDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    utilisateurs.Add((rdr.GetString(rdr.GetOrdinal("Email")), rdr.GetString(rdr.GetOrdinal("Mdp"))));
                }
            }

            // Mise à jour du statut après la fermeture du reader
            foreach (var (email, mdp) in utilisateurs)
            {
                string requete = "UPDATE Utilisateur SET Status = @Status WHERE Email = @Email AND Mdp = @Mdp";

                using (SqliteCommand cmd2 = new SqliteCommand(requete, connexion))
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
        public static void UtilisateurInscription(string nom, string prenom, string email, string mdp, DateTime dateInscription, DateTime dateNaissance, int admin, int status)
        {
            string requete = @"INSERT INTO Utilisateur 
                               (NomUtilisateur, PrenomUtilisateur, Email, Mdp, DateInscription, DateNaissance, Admin, Status)
                               VALUES (@Nom, @Prenom, @Email, @Mdp, @DateInscription, @DateNaissance, @Admin, @Status)";

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenom", prenom);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", mdp);
                cmd.Parameters.AddWithValue("@DateInscription", dateInscription.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Admin", admin);
                cmd.Parameters.AddWithValue("@Status", status);

                try
                {
                    cmd.ExecuteNonQuery();
                    StatusUtilisateur(email, mdp, 1);
                }
                catch (SqliteException ex)
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
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            SqliteDataReader rdr = cmd.ExecuteReader();

            Dictionary<int, Ligne> lignesTemp = new Dictionary<int, Ligne>();
            int nbLignes = 0;

            while (rdr.Read())
            {
                int numLigne = rdr.GetInt32(rdr.GetOrdinal("NumLigne"));
                string nom = rdr.GetString(rdr.GetOrdinal("Nom"));
                string couleur = rdr.GetString(rdr.GetOrdinal("Couleur"));
                int numSegment = rdr.GetInt32(rdr.GetOrdinal("NumSegment"));
                List<int> segments = new List<int>();
                List<string> stations = new List<string>();

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
                    SqliteCommand cmd2 = new SqliteCommand(requete2, connexion);
                    SqliteDataReader rdr2 = cmd2.ExecuteReader();

                    if (rdr2.Read())
                    {
                        try
                        {
                            string nomStation = rdr2.GetString(rdr2.GetOrdinal("NomStation"));
                            if (!lignesTemp[numLigne].stations.Contains(nomStation))
                            {
                                lignesTemp[numLigne].stations.Add(nomStation);
                            }
                        }
                        catch (SqliteException ex)
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
        public static List<List<decimal>> CoordonneesStationsLigne(List<string> stations)
        {
            List<List<decimal>> toutes = new List<List<decimal>>();

            foreach (string nomStation in stations)
            {
                string nomEchappe = nomStation.Replace("'", "''");
                string requete = $"SELECT Latitude, Longitude FROM Station WHERE NomStation = '{nomEchappe}'";
                SqliteCommand cmd = new SqliteCommand(requete, connexion);
                SqliteDataReader rdr = cmd.ExecuteReader();

                List<decimal> gps = new List<decimal>();

                if (rdr.Read())
                {
                    gps.Add((decimal)rdr.GetDouble(rdr.GetOrdinal("Latitude")));
                    gps.Add((decimal)rdr.GetDouble(rdr.GetOrdinal("Longitude")));
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

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    lignes.Add(rdr.GetString(rdr.GetOrdinal("Nom")));
                }
            }

            return lignes;
        }

        /// <summary>
        /// Récupère la liste des stations d'une ligne donnée.
        /// </summary>
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

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomLigne", nomLigne);

            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    stations.Add(rdr.GetString(rdr.GetOrdinal("NomStation")));
                }
            }
            return stations;
        }

        /// <summary>
        /// Calcul les horaires de passage d'une station
        /// </summary>
        public static List<string> CalculeHorairePassageStation(string nomStation, DateTime date)
        {
            List<string> horaireStation = new List<string>();
            TimeSpan heure = date.TimeOfDay;

            string requete = @"
            SELECT DISTINCT h.HoraireDepart, seg.DureeSegment, h.HoraireFin
            FROM Station st, Segment seg, Ligne l, Horaire h
            WHERE st.NomStation = @NomStation
            AND st.NumStation = seg.NumStationB
            AND seg.NumSegment = l.NumSegment
            AND l.NumLigne = h.NumLigne";

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomStation", nomStation);

            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    TimeSpan horaireDepart = TimeSpan.Parse(rdr.GetString(rdr.GetOrdinal("HoraireDepart")));
                    int dureeSegment = rdr.GetInt32(rdr.GetOrdinal("DureeSegment"));
                    TimeSpan horaireFin = TimeSpan.Parse(rdr.GetString(rdr.GetOrdinal("HoraireFin")));
                    TimeSpan horaireActuel = horaireDepart;

                    double multiplicateur = (date.DayOfWeek == DayOfWeek.Sunday) ? 1.75 : 1;

                    while (horaireActuel < horaireFin)
                    {
                        if (horaireActuel > heure)
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

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NomStation", nomStation);

            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    TimeSpan horaireDepart = TimeSpan.Parse(rdr.GetString(rdr.GetOrdinal("HoraireDepart")));
                    int dureeSegment = rdr.GetInt32(rdr.GetOrdinal("DureeSegment"));
                    TimeSpan horaireFin = TimeSpan.Parse(rdr.GetString(rdr.GetOrdinal("HoraireFin")));
                    TimeSpan horaireActuel = horaireDepart;

                    double multiplicateur = (date.DayOfWeek == DayOfWeek.Sunday) ? 1.75 : 1;

                    while (horaireActuel < horaireFin)
                    {
                        if (horaireActuel > heure)
                        {
                            return horaireActuel.ToString(@"hh\:mm\:ss");
                        }
                        horaireActuel = horaireActuel.Add(TimeSpan.FromSeconds(dureeSegment * multiplicateur));
                    }
                }
            }

            return prochainHoraire;
        }

        /// <summary>
        /// Supprime une information de ligne dans la base de données.
        /// </summary>
        public static void SupprimerUneInfoLigne(int numLigne)
        {
            string requete = @"DELETE FROM InfoLigne WHERE NumLigne = @numLigne";

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprime une station et ses segments associés d'une ligne spécifique dans la base de données.
        /// </summary>
        public static void SupprimerUnSegment(string nomStation)
        {
            int idStation = idStationGraceNom(nomStation);

            string requeteDesactiverFK = @"PRAGMA foreign_keys = OFF;";
            SqliteCommand cmdDesactiverFK = new SqliteCommand(requeteDesactiverFK, connexion);
            cmdDesactiverFK.ExecuteNonQuery();

            string requeteSupprimerSegment = @"DELETE FROM Segment WHERE NumStationA = @idStation OR NumStationB = @idStation";
            SqliteCommand cmd = new SqliteCommand(requeteSupprimerSegment, connexion);
            cmd.Parameters.AddWithValue("@idStation", idStation);
            cmd.ExecuteNonQuery();

            string requeteActiverFK = @"PRAGMA foreign_keys = ON;";
            SqliteCommand cmdActiverFK = new SqliteCommand(requeteActiverFK, connexion);
            cmdActiverFK.ExecuteNonQuery();
        }

        public static void SupprimerUneStation(string nomStation)
        {
            int idStation = idStationGraceNom(nomStation);

            string requeteSupprimerStation = @"DELETE FROM Station WHERE NumStation = @idStation";
            SqliteCommand cmd = new SqliteCommand(requeteSupprimerStation, connexion);
            cmd.Parameters.AddWithValue("@idStation", idStation);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute une ligne dans la base de données
        /// </summary>
        public static void AjoutLigne(string nomLigne, string couleur)
        {
            string requeteAjoutLigne = @"INSERT INTO InfoLigne (Nom, Couleur)
                                        VALUES (@nomLigne, @couleur)";

            SqliteCommand cmdAjoutLigne = new SqliteCommand(requeteAjoutLigne, connexion);
            cmdAjoutLigne.Parameters.AddWithValue("@nomLigne", nomLigne);
            cmdAjoutLigne.Parameters.AddWithValue("@couleur", couleur);
            cmdAjoutLigne.ExecuteNonQuery();
        }

        /// <summary>
        /// Ajoute une station dans la base de données
        /// </summary>
        public static void AjoutStation(string nomStation, double latitude, double longitude)
        {
            string requeteAjoutStation = @"INSERT INTO Station (NomStation, Latitude, Longitude)
                                           VALUES (@nomStation, @latitude, @longitude)";

            SqliteCommand cmdAjoutStation = new SqliteCommand(requeteAjoutStation, connexion);
            cmdAjoutStation.Parameters.AddWithValue("@nomStation", nomStation);
            cmdAjoutStation.Parameters.AddWithValue("@latitude", latitude);
            cmdAjoutStation.Parameters.AddWithValue("@longitude", longitude);
            cmdAjoutStation.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de modifier InfoLigne
        /// </summary>
        public static void ModifInfosLigne(int numLigne, string nom, string couleur)
        {
            string requete = @"UPDATE InfoLigne SET Nom = @nom, Couleur = @couleur WHERE NumLigne = @numLigne";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@couleur", couleur);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de modifier le nom des stations
        /// </summary>
        public static void ModifNomStations(Dictionary<string, string> stationsChange)
        {
            foreach (KeyValuePair<string, string> station in stationsChange)
            {
                string ancienNom = station.Key;
                string nouveauNom = station.Value;

                string requete = "UPDATE Station SET NomStation = @nouveauNom WHERE NomStation = @ancienNom";
                SqliteCommand cmd = new SqliteCommand(requete, connexion);
                cmd.Parameters.AddWithValue("@nouveauNom", nouveauNom);
                cmd.Parameters.AddWithValue("@ancienNom", ancienNom);

                cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// Permet de modifier les coordonnées d'une station
        /// </summary>
        public static void ModifCoordonneesStations(Dictionary<string, (decimal lat, decimal lon)> coordonneesChange)
        {
            foreach (KeyValuePair<string, (decimal lat, decimal lon)> station in coordonneesChange)
            {
                string nomStation = station.Key;
                decimal latitude = station.Value.lat;
                decimal longitude = station.Value.lon;

                if (latitude != 0 && longitude != 0)
                {
                    string requete = @"UPDATE Station SET Latitude = @lat, Longitude = @lon WHERE NomStation = @nom";
                    SqliteCommand cmd = new SqliteCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lat", latitude);
                    cmd.Parameters.AddWithValue("@lon", longitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
                else if (latitude != 0)
                {
                    string requete = @"UPDATE Station SET Latitude = @lat WHERE NomStation = @nom";
                    SqliteCommand cmd = new SqliteCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lat", latitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
                else if (longitude != 0)
                {
                    string requete = @"UPDATE Station SET Longitude = @lon WHERE NomStation = @nom";
                    SqliteCommand cmd = new SqliteCommand(requete, connexion);
                    cmd.Parameters.AddWithValue("@lon", longitude);
                    cmd.Parameters.AddWithValue("@nom", nomStation);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Ajoute un segment entre deux stations dans la base de données.
        /// </summary>
        public static void AjoutSegment(int dureeSegment, int numStationA, int numStationB)
        {
            string requete = @"INSERT INTO Segment (DureeSegment, NumStationA, NumStationB) 
                                VALUES (@dureeSegment, @numStationA, @numStationB)";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@dureeSegment", dureeSegment);
            cmd.Parameters.AddWithValue("@numStationA", numStationA);
            cmd.Parameters.AddWithValue("@numStationB", numStationB);
            cmd.ExecuteNonQuery();
        }

        public static void AjoutSegmentDansLigne(int numLigne, int numSegment, int ordre)
        {
            string requete = @"INSERT INTO Ligne (NumLigne, NumSegment, Ordre) 
                                VALUES (@numLigne, @numSegment, @ordre)";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.Parameters.AddWithValue("@numSegment", numSegment);
            cmd.Parameters.AddWithValue("@ordre", ordre);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Récupère l'ID d'une ligne à partir de son nom.
        /// </summary>
        public static int idLigneGraceNom(string nom)
        {
            string requete = @"SELECT NumLigne FROM InfoLigne WHERE Nom = @nom";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Récupère l'ID d'une station à partir de son nom.
        /// </summary>
        public static int idStationGraceNom(string nom)
        {
            string requete = @"SELECT NumStation FROM Station WHERE NomStation = @nom";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Récupère l'ID du dernier objet inséré dans la base de données.
        /// </summary>
        public static int RecupereIdDernierObjet()
        {
            string requete = @"SELECT last_insert_rowid()";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Ajoute un horaire de départ et de fin pour une ligne dans la base de données.
        /// </summary>
        public static void AjoutHoraireDepartFin(int NumLigne, DateTime HoraireDepart, DateTime HoraireFin)
        {
            string requete = @"INSERT INTO Horaire (NumLigne, HoraireDepart, HoraireFin) 
                                VALUES (@NumLigne, @HoraireDepart, @HoraireFin)";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@NumLigne", NumLigne);
            cmd.Parameters.AddWithValue("@HoraireDepart", HoraireDepart.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@HoraireFin", HoraireFin.ToString("HH:mm:ss"));
            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Supprime les informations en rapport avec une ligne dans la table Ligne.
        /// </summary>
        public static void SupprimerUneLigne(int numLigne)
        {
            string requete = @"DELETE FROM Ligne WHERE NumLigne = @numLigne";

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprier les informations d'horaire d'une ligne dans la table Horaire
        /// </summary>
        public static void SupprimerUnHoraire(int numLigne)
        {
            string requete = @"DELETE FROM Horaire WHERE NumLigne = @numLigne";

            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@numLigne", numLigne);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Liste des stations
        /// </summary>
        public static List<string> ListeDesStations()
        {
            List<string> stations = new List<string>();
            string requete = "SELECT NomStation FROM Station";

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    stations.Add(rdr.GetString(rdr.GetOrdinal("NomStation")));
                }
            }
            return stations;
        }

        /// <summary>
        /// Met à jour la couleur, et le nom de la ligne.
        /// </summary>
        public static bool MettreAJourCouleurEtNumeroLigne(int numLigne, string couleur, string nom)
        {
            string verifRequete = @"SELECT COUNT(*) FROM InfoLigne 
                            WHERE Nom = @Nom AND NumLigne != @NumLigne";

            using (SqliteCommand verifCmd = new SqliteCommand(verifRequete, connexion))
            {
                verifCmd.Parameters.AddWithValue("@Nom", nom);
                verifCmd.Parameters.AddWithValue("@NumLigne", numLigne);

                long count = (long)verifCmd.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
            }

            string requete = @"UPDATE InfoLigne 
                       SET Couleur = @Couleur, Nom = @Nom
                       WHERE NumLigne = @NumLigne";

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@Couleur", couleur);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@NumLigne", numLigne);
                cmd.ExecuteNonQuery();
            }
            return false;
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

                    using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
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
            using (SqliteCommand cmd = new SqliteCommand("", connexion))
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
                    continue;
                }

                using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
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

            using (SqliteCommand cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@debut", horaireDebut.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@fin", horaireFin.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@numLigne", numLigne);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Aucun horaire mis à jour. Vérifiez NumLigne.");
            }
        }

        /// <summary>
        /// Récupère la durée des segments d'une ligne spécifique.
        /// </summary>
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

            using (var cmd = new SqliteCommand(requete, connexion))
            {
                cmd.Parameters.AddWithValue("@numLigne", numLigne);

                using (var lecteur = cmd.ExecuteReader())
                {
                    while (lecteur.Read())
                    {
                        string stationDepart = lecteur.GetString(lecteur.GetOrdinal("NomStationA"));
                        string stationArrivee = lecteur.GetString(lecteur.GetOrdinal("NomStationB"));
                        int duree = lecteur.GetInt32(lecteur.GetOrdinal("DureeSegment"));

                        segmentsLigne.Add((stationDepart, stationArrivee, duree));
                    }
                }
            }

            return segmentsLigne;
        }

        /// <summary>
        /// Récupère les données du graphe, incluant les stations et les segments.
        /// </summary>
        public static (Dictionary<int, Station> stations, List<(int idA, int idB, int duree, int numLigne)> segments) ObtenirDonneesGraphe()
        {
            Dictionary<int, Station> stations = new Dictionary<int, Station>();
            List<(int, int, int, int)> segments = new List<(int, int, int, int)>();

            string requeteStations = "SELECT NumStation, NomStation FROM Station";
            using (var cmdStations = new SqliteCommand(requeteStations, connexion))
            using (var lecteur = cmdStations.ExecuteReader())
            {
                while (lecteur.Read())
                {
                    int id = lecteur.GetInt32(lecteur.GetOrdinal("NumStation"));
                    string nom = lecteur.GetString(lecteur.GetOrdinal("NomStation"));
                    stations[id] = new Station(nom); // Assure-toi que la classe Station est bien dans ton namespace
                }
            }

            string requeteSegments = @"
            SELECT s.NumStationA, s.NumStationB, s.DureeSegment, l.NumLigne
            FROM Segment s
            JOIN Ligne l ON s.NumSegment = l.NumSegment";

            using (var cmdSegments = new SqliteCommand(requeteSegments, connexion))
            using (var lecteur = cmdSegments.ExecuteReader())
            {
                while (lecteur.Read())
                {
                    int idA = lecteur.GetInt32(lecteur.GetOrdinal("NumStationA"));
                    int idB = lecteur.GetInt32(lecteur.GetOrdinal("NumStationB"));
                    int duree = lecteur.GetInt32(lecteur.GetOrdinal("DureeSegment"));
                    int numLigne = lecteur.GetInt32(lecteur.GetOrdinal("NumLigne"));

                    segments.Add((idA, idB, duree, numLigne));
                }
            }

            return (stations, segments);
        }

        public static void SupprimerUnSegment(int idStation)
        {
            string requete = @"DELETE FROM Segment WHERE NumStationA = @idStation OR NumStationB = @idStation";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@idStation", idStation);
            cmd.ExecuteNonQuery();
        }

        public static (DateTime, DateTime) RecupererHorairesLigne(int idLigne)
        {
            string requeteHoraireDebut = @"SELECT HoraireDepart FROM Horaire WHERE NumLigne = @numLigne";
            SqliteCommand cmdHoraireDebut = new SqliteCommand(requeteHoraireDebut, connexion);
            cmdHoraireDebut.Parameters.AddWithValue("@numLigne", idLigne);
            TimeSpan horaireDebut = TimeSpan.Parse(cmdHoraireDebut.ExecuteScalar().ToString());

            string requeteHoraireFin = @"SELECT HoraireFin FROM Horaire WHERE NumLigne = @numLigne";
            SqliteCommand cmdHoraireFin = new SqliteCommand(requeteHoraireFin, connexion);
            cmdHoraireFin.Parameters.AddWithValue("@numLigne", idLigne);
            TimeSpan horaireFin = TimeSpan.Parse(cmdHoraireFin.ExecuteScalar().ToString());

            DateTime baseDate = DateTime.Today;
            DateTime resultatHoraireDebut = baseDate.Add(horaireDebut);
            DateTime resultatHoraireFin = baseDate.Add(horaireFin);

            return (resultatHoraireDebut, resultatHoraireFin);
        }

        public static int MemeNom(string nomStation, int numStation)
        {
            string concat = nomStation + numStation.ToString();

            string requete = "SELECT COUNT(*) FROM Station WHERE NomStation = @nomStation";
            SqliteCommand cmd = new SqliteCommand(requete, connexion);
            cmd.Parameters.AddWithValue("@nomStation", concat);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }
    }
}