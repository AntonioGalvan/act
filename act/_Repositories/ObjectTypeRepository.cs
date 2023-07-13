using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Roles;
using act.Models.Objects;

namespace act._Repositories
{
    internal class ObjectTypeRepository : BaseRepository, IObjectTypeRepository
    {
        private object sqlDbType;

        public ObjectTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        IEnumerable<ObjectTypeModel> IObjectTypeRepository.GetAll()
        {
            var typeList = new List<ObjectTypeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select id,name,purpose from ObjectTypes";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var typeModel = new ObjectTypeModel();
                        typeModel.Id = (int)reader[0];
                        typeModel.Name = reader[1].ToString();
                        typeModel.Purpose = reader[2].ToString();
                        typeList.Add(typeModel);
                    }
                }
            }
            return typeList;
        }

    }
}
