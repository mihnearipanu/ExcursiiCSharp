using Proiect_MPP_CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect_MPP_CSharp.Repos
{
    class RepoExcursie : RepositoryExcursie
    {
        private string numeTabela;

        public RepoExcursie(string numeTabela) {
            this.numeTabela = numeTabela;
        }
        public ICollection<Excursie> filtrare1(string obiectiv, string ora1, string ora2)
        {
            using (SqlConnection connection = DatabaseUtils.connect())
            {
                connection.Open();
                SqlCommand select = new SqlCommand("select * from " + numeTabela + " where obiectiv=@obiectiv", connection);
                select.Parameters.Add("@obiectiv", obiectiv);
                using (SqlDataReader reader = select.ExecuteReader())
                {
                    List<Excursie> excursii = new List<Excursie>();
                    while (reader.Read())
                    {
                        excursii.Add(new Excursie(reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetDouble(4),
                            reader.GetInt32(5)));
                    }
                    List<Excursie> excursiiFinal = new List<Excursie>();
                    foreach (Excursie e in excursii) {
                        int ora = int.Parse(e.oraPlecarii.Split(':')[0] + e.oraPlecarii.Split(':')[1]);
                        int oraPlecare1 = int.Parse(ora1.Split(':')[0] + ora1.Split(':')[1]);
                        int oraPlecare2 = int.Parse(ora2.Split(':')[0] + ora2.Split(':')[1]);
                        if (oraPlecare1 <= ora && ora <= oraPlecare2) {
                            excursiiFinal.Add(e);
                        }
                    }
                    return excursiiFinal;
                }
            }
        }

        public ICollection<Excursie> findAll()
        {
            using (SqlConnection connection = DatabaseUtils.connect()) {
                connection.Open();
                SqlCommand select = new SqlCommand("select * from " + numeTabela, connection);
                using (SqlDataReader reader = select.ExecuteReader()) {
                    List<Excursie> excursii = new List<Excursie>();
                    while (reader.Read()) {
                        Excursie excursie = new Excursie(reader.GetString(0), 
                            reader.GetString(1), 
                            reader.GetString(2), 
                            reader.GetString(3), 
                            reader.GetDouble(4), 
                            reader.GetInt32(5));
                        excursii.Add(excursie);
                    }
                    return excursii;
                }
            }
        }

        public Excursie findOne(string id)
        {
            using (SqlConnection connection = DatabaseUtils.connect())
            {
                connection.Open();
                SqlCommand cautare = new SqlCommand($"select * from " + numeTabela + " where id = @id", connection);
                cautare.Parameters.Add("@id", id);
                using (SqlDataReader reader = cautare.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Excursie(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetInt32(5));
                    }
                    else {
                        return null;
                    }
                }
            }
        }

        public void save(Excursie entity)
        {
            using (SqlConnection connection = DatabaseUtils.connect())
            {
                connection.Open();
                SqlCommand cautare = new SqlCommand($"insert into " + numeTabela + " values (@id, @numeCompTrans, @obiectiv, @oraPlecarii, @pret, @nrLocuri)", connection);
                cautare.Parameters.Add("@id", entity.id);
                cautare.Parameters.Add("@numeCompTrans", entity.numeCompTrans);
                cautare.Parameters.Add("@obiectiv", entity.obiectiv);
                cautare.Parameters.Add("@oraPlecarii", entity.oraPlecarii);
                cautare.Parameters.Add("@pret", entity.pret);
                cautare.Parameters.Add("@nrLocuri", entity.nrLocuri);
                try
                {
                    cautare.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void update(string id, Excursie entity)
        {
            using (SqlConnection connection = DatabaseUtils.connect()) {
                connection.Open();
                SqlCommand update = new SqlCommand("update " + numeTabela + " set nrLocuri=@nrLocuri where id=@id", connection);
                update.Parameters.Add("@nrLocuri", entity.nrLocuri);
                update.Parameters.Add("@id", id);
                try
                {
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
