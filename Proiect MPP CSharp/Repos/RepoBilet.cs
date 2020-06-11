using Proiect_MPP_CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect_MPP_CSharp.Repos
{
    class RepoBilet : RepositoryBilet
    {
        private string numeTabela;

        public RepoBilet(string numeTabela) {
            this.numeTabela = numeTabela;
        }

        public ICollection<Bilet> findAll()
        {
            throw new NotImplementedException();
        }

        public Bilet findOne(string id)
        {
            throw new NotImplementedException();
        }

        public void save(Bilet entity)
        {
            using (SqlConnection connection = DatabaseUtils.connect())
            {
                connection.Open();
                SqlCommand cautare = new SqlCommand($"insert into " + numeTabela + " values (@id, @idExcursie, @client, @nrTel, @nrLocuri)", connection);
                cautare.Parameters.Add("@id", entity.id);
                cautare.Parameters.Add("@idExcursie", entity.idExcursie);
                cautare.Parameters.Add("@client", entity.client);
                cautare.Parameters.Add("@nrTel", entity.nrTelefon);
                cautare.Parameters.Add("@nrLocuri", entity.nrLocuri);
                try
                {
                    cautare.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void update(string id, Bilet entity)
        {
            throw new NotImplementedException();
        }
    }
}
