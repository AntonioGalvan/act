using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Objects;

namespace act._Repositories
{
    internal class ObjectRepository : BaseRepository, IObjectRepository
    {
        private object sqlDbType;
        private int projectId;

        public ObjectRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from Objects where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IObjectRepository.Add(ObjectModel objectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Objects([Key],Name,Purpose,projectId,ObjectTypeId,DiagramElementStateId,ScreenElementStateId) values (@key, @name, @purpose, @projectId, @type,1,1)";


                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = objectModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = objectModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = objectModel.Purpose;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;
                command.Parameters.Add("@type", SqlDbType.Int).Value = objectModel.ObjectTypeId;


                command.ExecuteNonQuery();
            }
        }

        void IObjectRepository.Edit(ObjectModel objectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Objects set name=@name, [Key]=@key, purpose=@purpose, ObjectTypeId=@type where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = objectModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = objectModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = objectModel.Key;
                command.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = objectModel.Purpose;
                command.Parameters.Add("@type", SqlDbType.Int).Value = objectModel.ObjectTypeId;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<ObjectModel> IObjectRepository.GetAll()
        {
            var objectList = new List<ObjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select o.Id as Id, o.[Key] as keyN, o.Name as name, o.Purpose as purpose, t.Name as type, t.id as typeid, p.Name as projectName from Objects o, ObjectTypes t, Projects p where o.projectId=@projectId and p.Id=o.projectId and o.ObjectTypeId = t.Id";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var objectModel = new ObjectModel();
                        objectModel.Id = (int)reader["Id"];
                        objectModel.Key = reader["keyN"].ToString();
                        objectModel.Name = reader["name"].ToString();
                        objectModel.Purpose = reader["purpose"].ToString();
                        objectModel.ObjectTypeName = reader["type"].ToString();
                        objectModel.ObjectTypeId = (int)reader["typeId"];
                        objectModel.ProjectName = reader["projectName"].ToString();
                        objectList.Add(objectModel);
                    }
                }
            }
            return objectList;
        }

        IEnumerable<ObjectTypeModel> IObjectRepository.GetAllTypes()
        {
            var typeList = new List<ObjectTypeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select id,name from ObjectTypes";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var typeModel = new ObjectTypeModel();
                        typeModel.Id = (int)reader["id"];
                        typeModel.Name = reader["name"].ToString();
                        typeList.Add(typeModel);
                    }
                }
            }
            return typeList;
        }

        IEnumerable<ObjectModel> IObjectRepository.GetByValue(string value)
        {
            var objectList = new List<ObjectModel>();
            string key = value;
            string name = value;
            int type = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select o.Id as Id, o.[Key] as keyN, o.Name as name, o.Purpose as purpose, t.Name as type, p.Name as projectName from Objects o, ObjectTypes t, Projects p where o.projectId=@projectId and p.Id=r.projectId and o.ObjectTypeId = t.Id
                                        (o.[Key] like '%'+@key+'%' or o.name like '%'+@name+'%' or t.name like '%'+@type+'%')
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@type", SqlDbType.Int).Value = type;


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var objectModel = new ObjectModel();
                        objectModel.Id = (int)reader["Id"];
                        objectModel.Key = reader["keyN"].ToString();
                        objectModel.Name = reader["name"].ToString();
                        objectModel.Purpose = reader["purpose"].ToString();
                        objectModel.ObjectTypeName = reader["type"].ToString();
                        objectModel.ProjectName = reader["projectName"].ToString();
                        objectList.Add(objectModel);
                    }
                }
            }
            return objectList;
        }
    }
}
