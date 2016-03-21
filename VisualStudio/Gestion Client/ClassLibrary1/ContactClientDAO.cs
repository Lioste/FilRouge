using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    class ContactClientDAO
    {
        SqlConnection _connect;
        public ContactClientDAO(string chaine)
        {
            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
        }
        public List<ContactClient> Liste()
        {
            SqlConnection _connect;
            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            _connect.Open();
            List<ContactClient> resultat = new List<ContactClient>();
            SqlCommand requete = new SqlCommand("select * from ContactClient", _connect);

            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                ContactClient cc = new ContactClient();
                cc.IDContactClient = Convert.ToInt32(lecture["IDContactClient"]);
                cc.NomContactClient = Convert.ToString(lecture["NomContactClient"]);
                cc.ParticulierContactClient = Convert.ToBoolean(lecture["ParticulierContactClient"]);
                resultat.Add(cc);

            }
            _connect.Close();
            return resultat;
        }
    }
}
