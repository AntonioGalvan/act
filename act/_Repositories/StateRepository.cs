using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.States;

namespace act._Repositories
{
    internal class StateRepository : BaseRepository, IStateRepository
    {
        private object sqlDbType;
        private int projectId;

        public StateRepository(string connectionString, int pProjectId)
        {
            this.connectionString = connectionString;
            this.projectId = pProjectId;
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete from ObjectStates where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IStateRepository.Add(ObjectStateModel stateModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into ObjectStates values (@key, @projectId, @name, @purpose)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = stateModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = stateModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = stateModel.Purpose;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IStateRepository.Edit(ObjectStateModel stateModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update ObjectStates set name=@name, [Key]=@key, purpose=@purpose where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = stateModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = stateModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = stateModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = stateModel.Purpose;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<ObjectStateModel> IStateRepository.GetAll()
        {
            var stateList = new List<ObjectStateModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select id, name, [key], purpose from ObjectStates where projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var stateModel = new ObjectStateModel();
                        stateModel.Id = (int)reader[0];
                        stateModel.Name = reader[1].ToString();
                        stateModel.Key = "ES-" + reader[2].ToString();
                        stateModel.Purpose = reader[3].ToString();
                        stateList.Add(stateModel);
                    }
                }
            }
            return stateList;
        }

        IEnumerable<ObjectStateModel> IStateRepository.GetByValue(string value)
        {
            var stateList = new List<ObjectStateModel>();
            int key = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select id, name, [key], purpose 
                                        from ObjectStates
                                        where [key]=@key or name like @name+'%'
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var stateModel = new ObjectStateModel();
                        stateModel.Id = (int)reader[0];
                        stateModel.Name = reader[1].ToString();
                        stateModel.Key = "ES-" + reader[2].ToString();
                        stateModel.Purpose = reader[3].ToString();
                        stateList.Add(stateModel);
                    }
                }
            }
            return stateList;
        }
    }
}
