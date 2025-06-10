using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace GestionReseau
{
    /// <summary>
    /// Représente une station du réseau.
    /// </summary>
    public class Station
    {
        // Nom de la station
        public string Nom { get; set; }

        // Constructeur initialisant le nom de la station
        public Station(string nom)
        {
            Nom = nom;
        }

        // Retourne le nom de la station
        public override string ToString()
        {
            return Nom;
        }
    }

    /// <summary>
    /// Représente un trajet entre deux stations, avec durée et lignes concernées.
    /// </summary>
    internal class Trajet
    {
        // Station de départ
        public Station Depart { get; set; }
        // Station d'arrivée
        public Station Arrivee { get; set; }
        // Durée du trajet en secondes
        public int DureeEnSecondes { get; set; }
        // Liste des numéros de lignes
        public List<int> Lignes { get; set; }

        // Constructeur
        public Trajet(Station depart, Station arrivee, int duree, List<int> lignes)
        {
            Depart = depart;
            Arrivee = arrivee;
            DureeEnSecondes = duree;
            Lignes = lignes;
        }
    }

    /// <summary>
    /// Représente le graphe complet du réseau : stations et trajets.
    /// </summary>
    internal class Graphe
    {
        // Liste des stations du réseau
        public List<Station> Stations { get; set; } = new List<Station>();
        // Liste des trajets entre stations
        public List<Trajet> Trajets { get; set; } = new List<Trajet>();

        /// <summary>
        /// Ajoute une station au graphe.
        /// </summary>
        public void AjouterStation(Station station)
        {
            Stations.Add(station);
        }

        /// <summary>
        /// Ajoute un trajet entre deux stations au graphe.
        /// </summary>
        public void AjouterTrajet(Station depart, Station arrivee, int duree, List<int> lignes)
        {
            Trajets.Add(new Trajet(depart, arrivee, duree, lignes));
        }

        /// <summary>
        /// Retourne la liste des trajets partant d’une station donnée.
        /// </summary>
        public List<Trajet> ObtenirTrajetsDepuis(Station station)
        {
            // Filtre la liste des trajets pour ceux dont la station de départ est celle passée en paramètre
            return Trajets.Where(t => t.Depart == station).ToList();
        }
    }

    /// <summary>
    /// Implémentation de l’algorithme de Dijkstra pour trouver les plus courts chemins.
    /// </summary>
    internal class AlgorithmeDijkstra
    {
        /// <summary>
        /// Calcule la distance minimale depuis la station de départ vers toutes les autres.
        /// </summary>
        /// <param name="graphe">Le graphe du réseau</param>
        /// <param name="depart">Station de départ</param>
        /// <param name="predecesseurs">Dictionnaire des prédécesseurs sur les chemins trouvés</param>
        /// <returns>Dictionnaire des distances minimales</returns>
        public static Dictionary<Station, int> CalculerChemins(Graphe graphe, Station depart, out Dictionary<Station, Station> predecesseurs)
        {
            var distances = new Dictionary<Station, int>();
            predecesseurs = new Dictionary<Station, Station>();
            var aVisiter = new List<Station>();

            // Initialisation : toutes distances sont infinies sauf celle de départ qui vaut 0
            foreach (var station in graphe.Stations)
            {
                distances[station] = int.MaxValue;
                aVisiter.Add(station);
            }

            distances[depart] = 0;

            // Tant qu’il reste des stations à visiter
            while (aVisiter.Count > 0)
            {
                // Sélection de la station non visitée ayant la distance minimale
                var stationActuelle = aVisiter.OrderBy(s => distances[s]).First();
                aVisiter.Remove(stationActuelle);

                // Mise à jour des distances des stations voisines via la station actuelle
                foreach (var trajet in graphe.ObtenirTrajetsDepuis(stationActuelle))
                {
                    int nouvelleDistance = distances[stationActuelle] + trajet.DureeEnSecondes;

                    // Si on trouve un chemin plus court vers la station d'arrivée du trajet
                    if (nouvelleDistance < distances[trajet.Arrivee])
                    {
                        distances[trajet.Arrivee] = nouvelleDistance;
                        predecesseurs[trajet.Arrivee] = stationActuelle; // Mise à jour du prédécesseur
                    }
                }
            }

            // Renvoie les distances minimales vers chaque station depuis le départ
            return distances;
        }

        /// <summary>
        /// Reconstruit le chemin le plus court à partir de la station d’arrivée.
        /// </summary>
        /// <param name="arrivee">Station d’arrivée</param>
        /// <param name="predecesseurs">Dictionnaire des prédécesseurs obtenu par CalculerChemins</param>
        /// <returns>Liste des stations du chemin dans l’ordre</returns>
        public static List<Station> TrouverChemin(Station arrivee, Dictionary<Station, Station> predecesseurs)
        {
            var chemin = new List<Station>();
            var station = arrivee;

            // Remonte la chaîne des prédécesseurs jusqu'à la station de départ
            while (predecesseurs.ContainsKey(station))
            {
                chemin.Add(station);
                station = predecesseurs[station];
            }

            chemin.Add(station); // Ajoute la station de départ
            chemin.Reverse(); // Inverse pour obtenir l'ordre du chemin du départ vers l'arrivée
            return chemin;
        }
    }

    /// <summary>
    /// Charge le graphe à partir de données extraites d’une base MySQL.
    /// </summary>
    internal class ChargeurGrapheDepuisMySQL
    {
        /// <summary>
        /// Construit le graphe à partir de dictionnaires de stations et segments.
        /// </summary>
        /// <param name="stations">Dictionnaire id -> Station</param>
        /// <param name="segments">Liste des segments (idA, idB, durée, numéro ligne)</param>
        /// <returns>Graphe complet</returns>
        public static Graphe Charger(Dictionary<int, Station> stations, List<(int idA, int idB, int duree, int numLigne)> segments)
        {
            var graphe = new Graphe();

            // Ajout de toutes les stations dans le graphe
            foreach (var station in stations.Values)
            {
                graphe.AjouterStation(station);
            }

            // Dictionnaire temporaire pour combiner segments similaires (même départ/arrivée) en un trajet avec plusieurs lignes
            var trajetsTemp = new Dictionary<(int, int), (int duree, List<int> lignes)>();

            foreach (var seg in segments)
            {
                var cle = (seg.idA, seg.idB);
                // Si le trajet n'existe pas encore, on l'ajoute avec la durée et une liste vide pour les lignes
                if (!trajetsTemp.ContainsKey(cle))
                    trajetsTemp[cle] = (seg.duree, new List<int>());

                // On ajoute le numéro de ligne correspondant à ce segment dans la liste
                trajetsTemp[cle].lignes.Add(seg.numLigne);
            }

            // Ajout des trajets au graphe à partir du dictionnaire temporaire
            foreach (var kvp in trajetsTemp)
            {
                var (idA, idB) = kvp.Key;
                var (duree, lignes) = kvp.Value;

                // Vérifie que les stations existent avant d'ajouter le trajet
                if (stations.ContainsKey(idA) && stations.ContainsKey(idB))
                {
                    graphe.AjouterTrajet(stations[idA], stations[idB], duree, lignes);
                }
            }

            return graphe;
        }

    }
}