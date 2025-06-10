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
        public string Nom { get; set; }

        public Station(string nom)
        {
            Nom = nom;
        }

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
        public Station Depart { get; set; }
        public Station Arrivee { get; set; }
        public int DureeEnSecondes { get; set; }
        public List<int> Lignes { get; set; }

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
        public List<Station> Stations { get; set; } = new List<Station>();
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

            // Initialisation : toutes distances à l’infini sauf départ à 0
            foreach (var station in graphe.Stations)
            {
                distances[station] = int.MaxValue;
                aVisiter.Add(station);
            }

            distances[depart] = 0;

            // Tant qu’il reste des stations à visiter
            while (aVisiter.Count > 0)
            {
                // Station non visitée avec distance minimale
                var stationActuelle = aVisiter.OrderBy(s => distances[s]).First();
                aVisiter.Remove(stationActuelle);


                // Mise à jour des distances des voisins via la station actuelle
                foreach (var trajet in graphe.ObtenirTrajetsDepuis(stationActuelle))
                {
                    int nouvelleDistance = distances[stationActuelle] + trajet.DureeEnSecondes;

                    if (nouvelleDistance < distances[trajet.Arrivee])
                    {
                        distances[trajet.Arrivee] = nouvelleDistance;
                        predecesseurs[trajet.Arrivee] = stationActuelle;
                    }
                }
            }

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

            while (predecesseurs.ContainsKey(station))
            {
                chemin.Add(station);
                station = predecesseurs[station];
            }

            chemin.Add(station); // Ajouter la station de départ
            chemin.Reverse();
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

            // Ajouter toutes les stations au graphe
            foreach (var station in stations.Values)
            {
                graphe.AjouterStation(station);
            }

            // Construire les trajets en combinant les segments pour gérer plusieurs lignes par trajet
            var trajetsTemp = new Dictionary<(int, int), (int duree, List<int> lignes)>();

            foreach (var seg in segments)
            {
                var cle = (seg.idA, seg.idB);
                if (!trajetsTemp.ContainsKey(cle))
                    trajetsTemp[cle] = (seg.duree, new List<int>());

                trajetsTemp[cle].lignes.Add(seg.numLigne);
            }

            // Ajouter les trajets au graphe
            foreach (var kvp in trajetsTemp)
            {
                var (idA, idB) = kvp.Key;
                var (duree, lignes) = kvp.Value;

                if (stations.ContainsKey(idA) && stations.ContainsKey(idB))
                {
                    graphe.AjouterTrajet(stations[idA], stations[idB], duree, lignes);
                }
            }

            return graphe;
        }

    }
}