﻿using MyLittleBluRayThequeProject.DTOs;
using Npgsql;

namespace MyLittleBluRayThequeProject.Repositories
{
    public class PersonneRepository
    {
        public List<Personne> GetListPersonnes()
        {
            NpgsqlConnection conn = null;
            List<Personne> result = new List<Personne>();
            try
            {
                // Connect to a PostgreSQL database
                conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=network;Database=postgres;");
                conn.Open();

                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"p\".\"Id\", \"p\".\"Nom\", \"p\".\"Prenom\", \"p\".\"DateNaissance\", \"p\".\"Nationalite\" FROM \"BluRayTheque\".\"Personne\" AS p ", conn);

                // Execute the query and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows
                while (dr.Read())
                    result.Add(new Personne
                    {
                        Id = long.Parse(dr[0].ToString()),
                        Nom = dr[1].ToString(),
                        Prenom = dr[2].ToString(),
                        DateNaissance = DateTime.Parse(dr[3].ToString()),
                        Nationalite = dr[5].ToString()
                    });
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }


        public List<Personne> GetListActeursOfBluRay(long idBr)
        {
            NpgsqlConnection conn = null;
            List<Personne> result = new List<Personne>();
            try
            {
                // Connect to a PostgreSQL database
                conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=network;Database=postgres;");
                conn.Open();

                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"p\".\"Id\", \"p\".\"Nom\", \"p\".\"Prenom\", \"p\".\"DateNaissance\", \"p\".\"Nationalite\" FROM \"BluRayTheque\".\"Personne\" AS p JOIN \"BluRayTheque\".\"Acteur\" AS a ON \"a\".\"IdActeur\" = \"p\".\"Id\" JOIN \"BluRayTheque\".\"BluRay\" AS b ON \"a\".\"IdBluRay\" = \"b\".\"Id\" ", conn);

                // Execute the query and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows
                while (dr.Read())
                    result.Add(new Personne
                    {
                        Id = long.Parse(dr[0].ToString()),
                        Nom = dr[1].ToString(),
                        Prenom = dr[2].ToString(),
                        DateNaissance = DateTime.Parse(dr[3].ToString()),
                        Nationalite = dr[5].ToString()
                    });
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }


        public List<Personne> GetListRealisateurs()
        {
            NpgsqlConnection conn = null;
            List<Personne> result = new List<Personne>();
            try
            {
                // Connect to a PostgreSQL database
                conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=network;Database=postgres;");
                conn.Open();

                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"p\".\"Id\", \"p\".\"Nom\", \"p\".\"Prenom\", \"p\".\"DateNaissance\", \"p\".\"Nationalite\" FROM \"BluRayTheque\".\"Personne\" AS p JOIN \"BluRayTheque\".\"Realisateur\" AS r ON \"r\".\"IdRealisateur\" = \"r\".\"Id\"", conn);

                // Execute the query and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows
                while (dr.Read())
                    result.Add(new Personne
                    {
                        Id = long.Parse(dr["Id"].ToString()),
                        Nom = dr["Nom"].ToString(),
                        Prenom = dr["Prenom"].ToString(),
                        DateNaissance = DateTime.Parse(dr["DateNaissance"].ToString()),
                        Nationalite = dr["Nationalite"].ToString()
                    });
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public List<Personne> GetListScenaristes()
        {
            NpgsqlConnection conn = null;
            List<Personne> result = new List<Personne>();
            try
            {
                // Connect to a PostgreSQL database
                conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=network;Database=postgres;");
                conn.Open();

                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"p\".\"Id\", \"p\".\"Nom\", \"p\".\"Prenom\", \"p\".\"DateNaissance\", \"p\".\"Nationalite\" FROM \"BluRayTheque\".\"Personne\" AS p JOIN \"BluRayTheque\".\"Scenariste\" AS s ON \"s\".\"IdScenariste\" = \"p\".\"Id\"", conn);

                // Execute the query and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows
                while (dr.Read())
                    result.Add(new Personne
                    {
                        Id = long.Parse(dr["Id"].ToString()),
                        Nom = dr["Nom"].ToString(),
                        Prenom = dr["Prenom"].ToString(),
                        DateNaissance = DateTime.Parse(dr["DateNaissance"].ToString()),
                        Nationalite = dr["Nationalite"].ToString()
                    });
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return result;
        }


    }
}
