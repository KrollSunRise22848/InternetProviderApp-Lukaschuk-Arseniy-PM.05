using Microsoft.Data.Sqlite;
using InternetProviderApp.Models;
using System;
using System.Collections.Generic;

namespace InternetProviderApp.Data
{
    public class RequestRepository
    {
        public List<Request> GetAll()
        {
            var list = new List<Request>();
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT r.Id, r.SubscriberId, r.TariffId, r.Date, r.Status,
                       s.FullName, t.Name
                FROM Requests r
                JOIN Subscribers s ON s.Id = r.SubscriberId
                JOIN Tariffs t ON t.Id = r.TariffId
                ORDER BY r.Date DESC
            ";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Request
                {
                    Id = reader.GetInt32(0),
                    SubscriberId = reader.GetInt32(1),
                    TariffId = reader.GetInt32(2),
                    Date = DateTime.Parse(reader.GetString(3)),
                    Status = reader.GetString(4),
                    SubscriberName = reader.GetString(5),
                    TariffName = reader.GetString(6)
                });
            }
            return list;
        }

        public void Add(Request request)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Requests (SubscriberId, TariffId, Date, Status)
                VALUES ($subId, $tariffId, $date, $status)
            ";
            cmd.Parameters.AddWithValue("$subId", request.SubscriberId);
            cmd.Parameters.AddWithValue("$tariffId", request.TariffId);
            cmd.Parameters.AddWithValue("$date", request.Date.ToString("s"));
            cmd.Parameters.AddWithValue("$status", request.Status);
            cmd.ExecuteNonQuery();
        }

        public void Update(Request request)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Requests SET Status=$status WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", request.Id);
            cmd.Parameters.AddWithValue("$status", request.Status);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Requests WHERE Id=$id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }
    }
}