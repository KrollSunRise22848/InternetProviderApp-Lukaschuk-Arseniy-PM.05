using Microsoft.Data.Sqlite;
using InternetProviderApp.Models;
using System.Collections.Generic;
using System;

namespace InternetProviderApp.Data
{
    public class SubscriberRepository
    {
        public List<Subscriber> GetAll(string search = "")
        {
            var list = new List<Subscriber>();
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT s.Id, s.FullName, s.Phone, s.Address, s.ContractNumber, s.TariffId, s.IsActive, t.Name AS TariffName
                FROM Subscribers s
                JOIN Tariffs t ON t.Id = s.TariffId
                WHERE ($search = '' OR s.FullName LIKE '%' || $search || '%' OR s.Phone LIKE '%' || $search || '%' OR s.ContractNumber LIKE '%' || $search || '%')
                ORDER BY s.FullName
            ";
            cmd.Parameters.AddWithValue("$search", search);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Subscriber
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Phone = reader.GetString(2),
                    Address = reader.GetString(3),
                    ContractNumber = reader.GetString(4),
                    TariffId = reader.GetInt32(5),
                    IsActive = reader.GetInt32(6) == 1,
                    TariffName = reader.GetString(7)
                });
            }
            return list;
        }

        public bool ContractNumberExists(string contractNumber, int excludeId = 0)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Subscribers WHERE ContractNumber = $contract AND Id != $excludeId";
            cmd.Parameters.AddWithValue("$contract", contractNumber);
            cmd.Parameters.AddWithValue("$excludeId", excludeId);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public void Add(Subscriber sub)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Subscribers (FullName, Phone, Address, ContractNumber, TariffId, IsActive)
                VALUES ($fullName, $phone, $address, $contract, $tariffId, $isActive)
            ";
            FillParameters(cmd, sub);
            cmd.ExecuteNonQuery();
        }

        public void Update(Subscriber sub)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Subscribers SET FullName=$fullName, Phone=$phone, Address=$address, ContractNumber=$contract, TariffId=$tariffId, IsActive=$isActive
                WHERE Id=$id
            ";
            cmd.Parameters.AddWithValue("$id", sub.Id);
            FillParameters(cmd, sub);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Subscribers WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }

        private void FillParameters(SqliteCommand cmd, Subscriber sub)
        {
            cmd.Parameters.AddWithValue("$fullName", sub.FullName);
            cmd.Parameters.AddWithValue("$phone", sub.Phone);
            cmd.Parameters.AddWithValue("$address", sub.Address);
            cmd.Parameters.AddWithValue("$contract", sub.ContractNumber);
            cmd.Parameters.AddWithValue("$tariffId", sub.TariffId);
            cmd.Parameters.AddWithValue("$isActive", sub.IsActive ? 1 : 0);
        }
    }
}