using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Roles;

namespace act._Repositories
{
    internal class RoleRepository : BaseRepository, IRoleRepository
    {
        private object sqlDbType;
        private int projectId;

        public RoleRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from Roles where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IRoleRepository.Add(RoleModel roleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Roles values (@name, @key, @purpose, @projectId)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roleModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = roleModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = roleModel.Purpose;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IRoleRepository.Edit(RoleModel roleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Roles set name=@name, [Key]=@key, purpose=@purpose where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = roleModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = roleModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = roleModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = roleModel.Purpose;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<RoleModel> IRoleRepository.GetAll()
        {
            var roleList = new List<RoleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Roles where projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var roleModel = new RoleModel();
                        roleModel.Id = (int)reader[0];
                        roleModel.Name = reader[1].ToString();
                        roleModel.Key = reader[2].ToString();
                        roleModel.Purpose = reader[3].ToString();
                        roleModel.ProjectId = (int)reader[4];
                        roleList.Add(roleModel);
                    }
                }
            }
            return roleList;
        }

        IEnumerable<RoleModel> IRoleRepository.GetByValue(string value)
        {
            var roleList = new List<RoleModel>();
            int key = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Roles
                                        where keyN=@key or name like @name+'%'
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var roleModel = new RoleModel();
                        roleModel.Id = (int)reader[0];
                        roleModel.Name = reader[1].ToString();
                        roleModel.Key = reader[2].ToString();
                        roleModel.Purpose = reader[3].ToString();
                        roleList.Add(roleModel);
                    }
                }
            }
            return roleList;
        }
    }
}
