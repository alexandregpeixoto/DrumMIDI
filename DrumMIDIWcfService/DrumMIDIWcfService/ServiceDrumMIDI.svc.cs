﻿using System;
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
                    try
                    {
                        if (newCommand.ExecuteNonQuery() != 0)
                        {
                            fResult = true;
                        }
                    }

                    //If there's some error, just ignore the command and return false...
                    catch
                    {

                    }
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
                    try
                    {
                        while (newReader.Read())
                        {
                            fResult.Add(newReader.GetString(0));
                        }
                    }

                    catch
                    {

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
                    try
                    {
                        while (newReader.Read())
                        {
                            if (newReader.GetString(0) == _Password) { fResult = true; };
                        }
                    }

                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public bool PresetCreate(string _PresetName, Int32 _idPart1, Int32 _idPart2, Int32 _idPart3, Int32 _idPart4, Int32 _idPart5, Int32 _idUser)
        {
            bool fResult = false;
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("INSERT INTO tbPreset([presetName], [idPart1], [idPart2], [idPart3], [idPart4], [idPart5], [idUser]) VALUES ('" + _PresetName + "','" + _idPart1 + "','" + _idPart2 + "','" + _idPart3 + "','" + _idPart4 + "','" + _idPart5 + "','" + _idUser + "')", newSqlConnection))
                {
                    try
                    {
                        if (newCommand.ExecuteNonQuery() != 0)
                        {
                            fResult = true;
                        }
                    }

                    //If there's some error, just ignore the command and return false...
                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public List<string> PresetList()
        {
            List<String> fResult = new List<string>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [presetName] FROM tbPreset", newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    try
                    {
                        while (newReader.Read())
                        {
                            fResult.Add(newReader.GetString(0));
                        }
                    }

                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public List<string> PresetSelect(string _PresetName)
        {
            List<String> fResult = new List<string>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [presetName], [idPart1], [idPart2], [idPart3], [idPart4], [idPart5], [idUser] FROM tbPreset WHERE presetName = '" + _PresetName + "'"))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    try
                    {
                        while (newReader.Read())
                        {
                            fResult.Add(newReader.GetString(0));
                        }
                    }

                    catch
                    {

                    }
                }
        }
            webServiceDB = null;
            return fResult;
        }

    public bool NoteCreate(Int32 _codeMIDI, string _name)
        {
            bool fResult = false;
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("INSERT INTO tbNote([codeMIDI], [name]) VALUES ('" + _codeMIDI + "','" + _name + "')", newSqlConnection))
                {
                    try
                    {
                        if (newCommand.ExecuteNonQuery() != 0)
                        {
                            fResult = true;
                        }
                    }

                    //If there's some error, just ignore the command and return false...
                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }

        public bool DrumPartCreate(Int32 _intensity, Int32 _analogPort, Int32 _idNote)
        {
            bool fResult = false;
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("INSERT INTO tbDrumPart([intensity], [analogPort], [idNote]) VALUES ('" + _intensity + "','" + _analogPort + "','" + _idNote + "')", newSqlConnection))
                {
                    try
                    {
                        if (newCommand.ExecuteNonQuery() != 0)
                        {
                            fResult = true;
                        }
                    }

                    //If there's some error, just ignore the command and return false...
                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return fResult;
        }
    }
}
