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
using act.Models.UseCases;

namespace act._Repositories
{
    internal class BaseFlowsRRepository: BaseRepository, IBaseFlowsRRepository
    {
        private object sqlDbType;
        private int projectId;
        private int UseCaseId;

        public BaseFlowsRRepository(string connectionString, int pProjectId, int pUseCaseId)
        {
            this.connectionString = connectionString;
            this.projectId = pProjectId;
            UseCaseId = pUseCaseId;
        }

        public bool Check()
        {
            var bFlowList = new List<BaseFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select id from BaseFlows where projectId=@projectId and UseCaseId=@useCaseId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = this.UseCaseId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bUseCaseModel = new BaseFlowModel();
                        bUseCaseModel.Id = (int)reader[0];

                        bFlowList.Add(bUseCaseModel);
                    }
                }
            }
            if(bFlowList.Count >= 1)
                return true;
            else
                return false;
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
                command.CommandText = "Insert into BaseFlows values (@projectId, @key, @name, @flowChartPath,1,1,@useCaseId )";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = bFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = bFlowModel.FlowChartPath;

                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = this.UseCaseId;
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
                command.CommandText = "Select id, [Key], Name, FlowChartPath from BaseFlows where projectId=@projectId and UseCaseId=@useCaseId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = this.UseCaseId;
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
