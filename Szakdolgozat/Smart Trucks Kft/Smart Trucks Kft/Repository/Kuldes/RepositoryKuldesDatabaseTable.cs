﻿using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using Smart_Trucks_Kft.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{
    partial class RepositoryKuldesDatabaseTable

    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryKuldesDatabaseTable()
        {

            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();

        }

        public void createTableKuldes()
        {
            string queryUSE = "USE kamion;";
            string queryCreateTable =
                "Create TABLE `kuldes` (" +
                "   `sid` int(60) NOT NULL DEFAULT '0', " +
                  "   `kid` int(60) NOT NULL DEFAULT '0', " +
                    "   `heid` int(60) NOT NULL DEFAULT '0', " +
                      "   `teid` int(60) NOT NULL DEFAULT '0', " +
                        "   `did` int(60) NOT NULL DEFAULT '0', " +
                   "   `Kikuldes` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +                
                       "   `Viszaerkezes` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '') " +
                        " ENGINE = InnoDB;";
            string queryPrimaryKey =
                "ALTER TABLE `kuldes`  ADD PRIMARY KEY(`sid`); ";

            MySqlConnection connection =
               new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla lérehozása sikertelen.");
            }

        }



        public void deleteTableKuldes()
        {
            string query =
                "USE kamion; " +
                "DROP TABLE kuldes;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla törlése nem sikerült.");
            }
        }

        public void deleteDataFromTermekTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Kuldes.getSQLCommandDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok törlése sikertelen.");
            }
        }
    }
    }