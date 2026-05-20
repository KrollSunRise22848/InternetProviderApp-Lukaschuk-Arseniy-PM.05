using Microsoft.Data.Sqlite;
using InternetProviderApp.Models;
using System.Collections.Generic;

namespace InternetProviderApp.Data
{
    public class TariffRepository
    {
        public List<Tariff> GetAll()
        {
            var list = new List<Tariff>();
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Price, Speed FROM Tariffs ORDER BY Name";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Tariff
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Speed = reader.GetInt32(3)
                });
            }
            return list;
        }

        public Tariff? GetById(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Price, Speed FROM Tariffs WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Tariff
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Speed = reader.GetInt32(3)
                };
            }
            return null;
        }

        public void Add(Tariff tariff)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Tariffs (Name, Price, Speed) VALUES ($name, $price, $speed)";
            cmd.Parameters.AddWithValue("$name", tariff.Name);
            cmd.Parameters.AddWithValue("$price", tariff.Price);
            cmd.Parameters.AddWithValue("$speed", tariff.Speed);
            cmd.ExecuteNonQuery();
        }

        public void Update(Tariff tariff)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Tariffs SET Name=$name, Price=$price, Speed=$speed WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", tariff.Id);
            cmd.Parameters.AddWithValue("$name", tariff.Name);
            cmd.Parameters.AddWithValue("$price", tariff.Price);
            cmd.Parameters.AddWithValue("$speed", tariff.Speed);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Tariffs WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }
    }
}