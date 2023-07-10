using act.Models.Roles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Views;
using act.Models.BaseFlows;

namespace act._Repositories
{
    internal class BaseFlowsRRepository: BaseRepository, IBaseFlowsRRepository
    {
        private object sqlDbType;
        private int projectId;

        public BaseFlowsRRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from BaseFlows where Id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
            }
        }

        void IBaseFlowsRRepository.Add(BaseFlowModel bFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into BaseFlows values (@projectId, @key, @name, @flowChartPath,1,1,1 )";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = bFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = bFlowModel.FlowChartPath;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IBaseFlowsRRepository.Edit(BaseFlowModel bFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update BaseFlows set name=@name, [key]=@key, flowChartPath=@flowChartPath where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = bFlowModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = bFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = bFlowModel.FlowChartPath;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<BaseFlowModel> IBaseFlowsRRepository.GetAll()
        {
            var bFlowList = new List<BaseFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select Key, Name, FlowChartPath from Roles where projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bFlowModel = new BaseFlowModel();
                        bFlowModel.Id = (int)reader[0];
                        bFlowModel.Key = reader[1].ToString();
                        bFlowModel.Name = reader[2].ToString();
                        bFlowModel.FlowChartPath = reader[3].ToString();
                        bFlowList.Add(bFlowModel);
                    }
                }
            }
            return bFlowList;
        }
    }
}
