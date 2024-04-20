using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategoriaRepository : BaseRepository, ICategoriaRepository
    {

        public CategoriaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoriaModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO CatMode VALUES (@name,@observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value =
            categoriaModel.Observation;
                command.ExecuteNonQuery();
            }

        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM CatMode WHERE Cat_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }

        }

        public void Edit(CategoriaModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE CatMode 
                            SET Cat_Mode_Name = @name, 
                            Cat_Mode_Observation = @observation 
                            WHERE Cat_Mode_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value =
            categoriaModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value =
            categoriaModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriaModel.Id;
                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<CategoriaModel> GetAll()
        {
            var categoriaList = new List<CategoriaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM CatMode ORDER BY Cat_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaModel = new CategoriaModel();
                        categoriaModel.Id = (int)reader["Cat_Mode_Id"];
                        categoriaModel.Name = reader["Cat_Mode_Name"].ToString();
                        categoriaModel.Observation = reader["Cat_Mode_Observation"].ToString();
                        categoriaList.Add(categoriaModel);
                    }
                }
            }
            return categoriaList;
        }

        public IEnumerable<CategoriaModel> GetByValue(string value)
        {
            var categoriaList = new List<CategoriaModel>();
            int categoriaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriaName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Cat_Mode 
                                    WHERE Cat_Mode_Id=@id or Cat_Mode_Name LIKE @name+ '%'
                                    ORDER BY Cat_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriaId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaModel = new CategoriaModel();
                        categoriaModel.Id = (int)reader["Cat_Mode_Id"];
                        categoriaModel.Name = reader["Cat_Mode_Name"].ToString();
                        categoriaModel.Observation = reader["Cat_Mode_Observation"].ToString();
                        categoriaList.Add(categoriaModel);
                    }
                }
            }

            return categoriaList;
        }
    }
}

