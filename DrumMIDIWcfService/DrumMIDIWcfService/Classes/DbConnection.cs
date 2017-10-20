using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrumMIDIWcfService.Classes
{
    public class DbConnection
    {
        String strServerName = "localhost";
        String strInstanceName = "SQLEXPRESS";
        String strDatabaseName = "DrumMidiDatabase";
        String strUserName = "sa";
        String strUserPassword = "sa";
        bool boolWindowsAuthentication = false;

        public String ServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }

        public String InstanceName
        {
            get { return strInstanceName; }
            set { strInstanceName = value; }
        }

        public String DatabaseName
        {
            get { return strDatabaseName; }
            set { strDatabaseName = value; }
        }

        public String UserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public String UserPassword
        {
            get { return strUserPassword; }
            set { strUserPassword = value; }
        }

        public bool WindowsAuthentication
        {
            get { return boolWindowsAuthentication; }
            set { boolWindowsAuthentication = value; }
        }

        public DbConnection()
        {
        }

        public DbConnection(String _ServerName, String _InstanceName, String _DatabaseName, String _UserName, String _UserPassword, bool _WindowsAuthentication)
        {
            ServerName = _ServerName;
            InstanceName = _InstanceName;
            DatabaseName = _DatabaseName;
            UserName = _UserName;
            UserPassword = _UserPassword;
            WindowsAuthentication = _WindowsAuthentication;
        }

        public String ConnectionString
        {
            get
            {
                String conStr = "";
                if (WindowsAuthentication)
                {
                    if (InstanceName != String.Empty)
                    {
                        conStr = "Data Source=" + ServerName + "\\" + InstanceName +  ";Initial Catalog=" + DatabaseName + ";Integrated Security = SSPI;";
                    }
                    else
                    {
                        conStr = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";Integrated Security = SSPI;";
                    }
                    
                }
                else
                {
                    if (InstanceName != String.Empty)
                    {
                        conStr = "Data Source=" + ServerName + "\\" + InstanceName + ";Initial Catalog=" + DatabaseName + ";User id=" + UserName + ";Password=" + UserPassword + ";";
                    }
                    else
                    {
                        conStr = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User id=" + UserName + ";Password=" + UserPassword + ";";
                    }
                }
                return conStr;
            }
        }

    }
}