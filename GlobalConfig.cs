using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        // making private set, allows only methods in globalconfig can change value of connections
        // but everyone can look at the connections
        public static IDataConnection Connection { get; private set; }

        public static void InitialiseConnections(DatabaseType db)
        {
            
            // whenever you already have a bool value you dont have to do a comparison 
            // because there already is a bool value
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection= text;
            }
        } 

        // Gets the connection string from App.config by looking up a name and return the value of the string
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
