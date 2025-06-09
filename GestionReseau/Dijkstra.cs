using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace GestionReseau
{
    // Représente une station du réseau
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

    // Représente un trajet entre deux stations
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

    // Représente le graphe complet (stations et trajets)
    internal class Graphe
    {
        public List<Station> Stations { get; set; } = new List<Station>();
        public List<Trajet> Trajets { get; set; } = new List<Trajet>();

        public void AjouterStation(Station station)
        {
            Stations.Add(station);
        }

        public void AjouterTrajet(Station depart, Station arrivee, int duree, List<int> lignes)
        {
            Trajets.Add(new Trajet(depart, arrivee, duree, lignes));
        }

        public List<Trajet> ObtenirTrajetsDepuis(Station station)
        {
            return Trajets.Where(t => t.Depart == station).ToList();
        }
    }

    // Implémentation de l'algorithme de Dijkstra
    internal class AlgorithmeDijkstra
    {
        public static Dictionary<Station, int> CalculerChemins(Graphe graphe, Station depart, out Dictionary<Station, Station> predecesseurs)
        {
            var distances = new Dictionary<Station, int>();
            predecesseurs = new Dictionary<Station, Station>();
            var aVisiter = new List<Station>();

            foreach (var station in graphe.Stations)
            {
                distances[station] = int.MaxValue;
                aVisiter.Add(station);
            }

            distances[depart] = 0;

            while (aVisiter.Count > 0)
            {
                var stationActuelle = aVisiter.OrderBy(s => distances[s]).First();
                aVisiter.Remove(stationActuelle);

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

        public static List<Station> TrouverChemin(Station arrivee, Dictionary<Station, Station> predecesseurs)
        {
            var chemin = new List<Station>();
            var station = arrivee;

            while (predecesseurs.ContainsKey(station))
            {
                chemin.Add(station);
                station = predecesseurs[station];
            }

            chemin.Add(station);
            chemin.Reverse();
            return chemin;
        }
    }

    // Classe pour charger le graphe depuis une base de données MySQL
    internal class ChargeurGrapheDepuisMySQL
    {
        public static Graphe Charger(Dictionary<int, Station> stations, List<(int idA, int idB, int duree, int numLigne)> segments)
        {
            var graphe = new Graphe();

            // Ajouter stations
            foreach (var station in stations.Values)
            {
                graphe.AjouterStation(station);
            }

            // Construire trajets
            var trajetsTemp = new Dictionary<(int, int), (int duree, List<int> lignes)>();

            foreach (var seg in segments)
            {
                var cle = (seg.idA, seg.idB);
                if (!trajetsTemp.ContainsKey(cle))
                    trajetsTemp[cle] = (seg.duree, new List<int>());

                trajetsTemp[cle].lignes.Add(seg.numLigne);
            }

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