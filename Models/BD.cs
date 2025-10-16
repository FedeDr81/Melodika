namespace melodika.Models;
using System;
using Microsoft.Data.SqlClient;
using Dapper;
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase = Melodika_DB; Trusted_Connection = true; TrustServerCertificate = true";

}