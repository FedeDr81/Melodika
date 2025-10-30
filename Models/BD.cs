namespace melodika.Models;
using System;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase = Melodika_DB; Trusted_Connection = true; TrustServerCertificate = true";

     static public List<Cancion> seleccionarCancion()
    {
        List<Cancion> canciones = new List<Cancion>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "EXEC seleccionarCancion;";
            canciones = connection.Query<Cancion>(query).ToList();
        }
        return canciones;
    }

         static public List<Cancion> logIn(string correo, string contraseña)
    {
        int idUser
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "EXEC loginCuenta @CorreoElectronico = @pCorreo, @Contraseña = @pContraseña ;";
            idUser = connection.Query<Cancion>(query).ToList();
        }
        return idUser;
    }

}