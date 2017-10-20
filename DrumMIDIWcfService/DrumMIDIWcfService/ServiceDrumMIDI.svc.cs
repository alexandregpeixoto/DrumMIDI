using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DrumMIDIWcfService.Classes;
using System.Data.SqlClient;

namespace DrumMIDIWcfService
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceDrumMIDI : IServiceDrumMIDI
    {
        public bool UserCreate(string _UserName, string _Password)
        {
            bool fResult = false;
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("INSERT INTO tbUser([Name], [Password]) VALUES ('" + _UserName + "','" + _Password + "')", newSqlConnection))
                {
                    try { if (newCommand.ExecuteNonQuery() != 0) { fResult = true; }; }

                    //If there's some error, just ignore the command and return false...
                    catch { }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public List<string> UserList()
        {
            List<String> fResult = new List<string>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [Name] FROM tbUser", newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    while (newReader.Read())
                    {
                        fResult.Add(newReader.GetString(0));
                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public bool UserLogin(string _UserName, string _Password)
        {
            bool fResult = false;
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [Password] FROM tbUser WHERE [UserName] = " + _UserName, newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    while (newReader.Read())
                    {
                        if (newReader.GetString(0) == _Password) { fResult = true; };
                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }
    }
}
