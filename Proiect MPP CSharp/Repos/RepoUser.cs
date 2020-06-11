using Proiect_MPP_CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect_MPP_CSharp.Repos
{
    class RepoUser : RepositoryUser
    {
        private string numeTabela;
        public RepoUser(string numeTabela) {
            this.numeTabela = numeTabela;
        }

        public ICollection<User> findAll()
        {
            throw new NotImplementedException();
        }

        public User findByUserAndPass(string username, string password)
        {   
            using (SqlConnection connection = DatabaseUtils.connect()) {
                connection.Open();
                SqlCommand cautare = new SqlCommand($"select * from " + numeTabela + " where username = @username and password = @password", connection);
                cautare.Parameters.Add("@username", username);
                cautare.Parameters.Add("@password", password);
                using (SqlDataReader reader = cautare.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }
                    else {
                        return null;
                    }
                }
            }
        }

        public User findOne(string id)
        {
            throw new NotImplementedException();
        }

        public void save(User entity)
        {
            throw new NotImplementedException();
        }

        public void update(string id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}
