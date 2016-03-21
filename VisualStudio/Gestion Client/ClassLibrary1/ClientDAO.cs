using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class ClientDAO
    {
            SqlConnection _connect;
            public ClientDAO(string chaine)
            {
                _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            }
            public void Insert(Client cli/*, string Nom , string IDContactClient, string CoefClient*/)
            {
                SqlConnection _connect;
                _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
                SqlCommand requete = new SqlCommand("insert into Client(NomClient, CoefClient, IDContactClient) values(@NomClient, @CoefClient, @IDContactClient)", _connect);
                _connect.Open();
                requete.Parameters.AddWithValue("@NomClient", cli.NomClient);
                requete.Parameters.AddWithValue("@CoefClient", cli.CoefClient);
                requete.Parameters.AddWithValue("@IDContactClient", cli.IDContactClient);
                requete.ExecuteNonQuery();
                SqlCommand requete2 = new SqlCommand("select max(IDClient) from Client", _connect);
                int ID_Client = (int)requete2.ExecuteScalar();
                cli.IDClient = ID_Client;
                _connect.Close();

            }
            public void Update(Client cli, string TB1, decimal TB2, string TB3, int TB4)
            {
                SqlConnection _connect;
                _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
                _connect.Open();

                SqlCommand requete = new SqlCommand("update Client set NomClient = @NomClient, CoefClient = @CoefClient, IDContactClient = @IDContactClient WHERE IDClient = @IDClient", _connect);
                requete.Parameters.AddWithValue("@NomClient", TB1);
                requete.Parameters.AddWithValue("@CoefClient", TB2);
                requete.Parameters.AddWithValue("@IDContactClient", TB3);
                requete.Parameters.AddWithValue("@IDClient", TB4);
                requete.ExecuteNonQuery();
                _connect.Close();
            }
            public void Delete(Client cli, int TB4)
            {
                SqlConnection _connect;
                _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
                _connect.Open();
                SqlCommand requete = new SqlCommand("delete from Client WHERE IDClient = @IDClient", _connect);
                requete.Parameters.AddWithValue("@IDClient", TB4);
                requete.ExecuteNonQuery();

                _connect.Close();
            }
            // public Find<Client> Client Find(int IDClient)
            // {
            //     SqlConnection _connect;
            //     _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            //     _connect.Open();
            //    Find<Client> resultat = new Find<Client>();
            //    SqlCommand requete = new SqlCommand("select * from Client", _connect);

            //    SqlDataReader lecture = requete.ExecuteReader();
            //    while (lecture.Read())
            //    {
            //        Client c = new Client();
            //        c.IDClient = Convert.ToInt32(lecture["IDClient"]);
            //        c.NomClient = Convert.ToString(lecture["NomClient"]);
            //        c.CoefClient = Convert.ToDecimal(lecture["CoefClient"]);
            //        c.IDContactClient = Convert.ToInt32(lecture["IDContactClient"]);
            //        resultat.Add(c);

            //    }
            //    //Form1.listBox1.DataSource = Form1.repo.Liste();
            //    _connect.Close();
            //    return resultat;
            //}
            public List<Client> Liste()
            {
                SqlConnection _connect;
                _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
                _connect.Open();
                List<Client> resultat = new List<Client>();
                SqlCommand requete = new SqlCommand("select * from Client", _connect);

                SqlDataReader lecture = requete.ExecuteReader();
                while (lecture.Read())
                {
                    Client c = new Client();
                    c.IDClient = Convert.ToInt32(lecture["IDClient"]);
                    c.NomClient = Convert.ToString(lecture["NomClient"]);
                    c.CoefClient = Convert.ToDecimal(lecture["CoefClient"]);
                    c.IDContactClient = Convert.ToInt32(lecture["IDContactClient"]);
                    resultat.Add(c);

                }
                //Form1.listBox1.DataSource = Form1.repo.Liste();
                _connect.Close();
                return resultat;
            }
        }
    }

