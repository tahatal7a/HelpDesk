using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    internal class Classtech
    {
        public static int ID;
        public static string Nom;
        public static string Prenom;
        public static string Departement;
        public static string Service;
        public static string Nbureau;
        public static string Ntel;
        public static string Specialité;

        //rendre les informations des techniciens
    public static DataTable technicienInformation() { 
        
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select Nom,Prenom,Specialite from Technicien",Form1.cnx);
            adapter.Fill(dataTable);
           



            return dataTable;
        
        
        }
   
    }
}
