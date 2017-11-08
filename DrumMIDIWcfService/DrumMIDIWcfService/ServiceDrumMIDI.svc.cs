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

        public List<Preset> PresetSelect(string _PresetName)
        {
            List<Preset> selectedPreset = new List<Preset>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [presetName], [idPart1], [idPart2], [idPart3], [idPart4], [idPart5], [idUser] FROM tbPreset WHERE presetName = '" + _PresetName + "'", newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    try
                    {
                        if (!newReader.HasRows)
                        {
                            return null;
                        }

                        while (newReader.Read())
                        {
                            selectedPreset.Add(new Preset()
                            {
                                Name = newReader["presetName"].ToString(),
                                IdDrumPart1 = int.Parse(newReader["idPart1"].ToString()),
                                IdDrumPart2 = int.Parse(newReader["idPart2"].ToString()),
                                IdDrumPart3 = int.Parse(newReader["idPart3"].ToString()),
                                IdDrumPart4 = int.Parse(newReader["idPart4"].ToString()),
                                IdDrumPart5 = int.Parse(newReader["idPart5"].ToString()),
                                IdUser = int.Parse(newReader["idUser"].ToString()),
                            });
                        }
                    }

                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return selectedPreset;
        }

        public List<DrumPart> DrumPartSelect(string _idPart)
        {
            List<DrumPart> selectedDrumPart = new List<DrumPart>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [id], [intensity], [analogPort], [idNote] FROM tbDrumPart WHERE id = '" + _idPart + "'", newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    try
                    {
                        if (!newReader.HasRows)
                        {
                            return null;
                        }

                        while (newReader.Read())
                        {
                            selectedDrumPart.Add(new DrumPart()
                            {
                                Id = int.Parse(newReader["id"].ToString()),
                                Intensity = int.Parse(newReader["intensity"].ToString()),
                                AnalogPort = int.Parse(newReader["analogPort"].ToString()),
                                IdNote = int.Parse(newReader["idNote"].ToString()),
                            });
                        }
                    }

                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return selectedDrumPart;
        }

        public List<Note> MIDINoteSelect(string _idNote)
        {
            List<Note> selectedMidiNote = new List<Note>();
            DbConnection webServiceDB = new DbConnection();
            using (SqlConnection newSqlConnection = new SqlConnection(webServiceDB.ConnectionString))
            {
                newSqlConnection.Open();
                using (SqlCommand newCommand = new SqlCommand("SELECT [id], [codeMIDI], [name] FROM tbNote WHERE id = '" + _idNote + "'", newSqlConnection))
                using (SqlDataReader newReader = newCommand.ExecuteReader())
                {
                    try
                    {
                        if (!newReader.HasRows)
                        {
                            return null;
                        }

                        while (newReader.Read())
                        {
                            selectedMidiNote.Add(new Note()
                            {
                                Id = int.Parse(newReader["id"].ToString()),
                                CodeMIDI = int.Parse(newReader["codeMIDI"].ToString()),
                                Name = newReader["name"].ToString(),
                            });
                        }
                    }

                    catch
                    {

                    }
                }
            }
            webServiceDB = null;
            return selectedMidiNote;
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
