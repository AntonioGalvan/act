using act.Models.UseCases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.BaseFlows;
using act.Models.Objects;

namespace act._Repositories
{
    internal class BaseFlowRepository : BaseRepository, IBaseFlowRepository
    {
        private object sqlDbType;
        private int projectId;

        public BaseFlowRepository(string connectionString, int pProjectId)
        {
            this.connectionString = connectionString;
            this.projectId = pProjectId;
        }

        public bool Check(int id, int? useCaseId)
        {
            var bFlowList = new List<BaseFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select id from BaseFlows where projectId=@projectId and UseCaseId=@useCaseId and id!=@id";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = useCaseId;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
            if (bFlowList.Count >= 1)
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
                command.CommandText = "Delete from BaseFlows where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IBaseFlowRepository.Add(BaseFlowModel bFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //TODO: Corregir queries o parámetros nose
                

                if(bFlowModel.useCaseId != null)
                {
                    command.CommandText = "Insert into BaseFlows(ProjectId, [Key], Name, FlowChartPath, DiagramElementStateId, ScreenElementStateId, UseCaseId) values (@projectId, @key, @name, @flowChartPath,1,1, @useCaseId)";
                    command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = bFlowModel.useCaseId;
                }
                else
                {
                    command.CommandText = "Insert into BaseFlows(ProjectId, [Key], Name, FlowChartPath, DiagramElementStateId, ScreenElementStateId) values (@projectId, @key, @name, @flowChartPath,1,1)";
                }
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = bFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = bFlowModel.FlowChartPath;
                

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;

                command.ExecuteNonQuery();
            }
        }

        void IBaseFlowRepository.Edit(BaseFlowModel bFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update BaseFlows set name=@name, [key]=@key, useCaseId=@useCaseId, flowChartPath=@flowChartPath where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = bFlowModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = bFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = bFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = bFlowModel.FlowChartPath;
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = bFlowModel.useCaseId;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<BaseFlowModel> IBaseFlowRepository.GetAll()
        {
            var bFLowList = new List<BaseFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select bf.Id as id, bf.name as name, " +
                    "bf.[key] as keyN, bf.flowchartpath as flowchart, uc.name as useCaseName, " +
                    "bf.useCaseId as useCaseId from BaseFlows bf LEFT JOIN UseCases uc ON uc.id = bf.useCaseId " +
                    "where bf.projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bFlowModel = new BaseFlowModel();
                        bFlowModel.Id = (int)reader["id"];
                        bFlowModel.Name = reader["name"].ToString();
                        bFlowModel.Key = "FB-" + reader["keyN"].ToString();
                        bFlowModel.useCaseName = reader["useCaseName"].ToString();
                        bFlowModel.FlowChartPath = reader["flowchart"].ToString();
                        bFLowList.Add(bFlowModel);
                        bFlowModel.useCaseId = Convert.IsDBNull(reader["useCaseId"]) ? null : (int?)reader["useCaseId"];
                    }
                }
            }
            return bFLowList;
        }

        IEnumerable<UseCaseModel> IBaseFlowRepository.GetAllUseCases(bool exclude, int? useCaseId)
        {

            var useCaseList = new List<UseCaseModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                

                if(useCaseId == null)
                {
                    command.CommandText = "Select id,name from UseCases where id NOT IN " +
                    "(select UseCaseId from Baseflows where not useCaseId IS NULL)";
                }
                else
                {
                    command.CommandText = "Select id,name from UseCases where id NOT IN " +
                    "(select useCaseId from BaseFlows where useCaseId!=@useCaseId and useCaseId NOT IN (select useCaseId from Baseflows where useCaseId != null))";

                    command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = useCaseId;
                }

                using (var reader = command.ExecuteReader())
                {
                    var empty = new UseCaseModel();
                    empty.Id = 0;
                    empty.Name = "Ninguno";
                    useCaseList.Add(empty);
                    while (reader.Read())
                    {
                        var useCaseModel = new UseCaseModel();
                        useCaseModel.Id = (int)reader["id"];
                        useCaseModel.Name = reader["name"].ToString();
                        useCaseList.Add(useCaseModel);
                    }
                }
            }
            return useCaseList;
        }

        IEnumerable<BaseFlowModel> IBaseFlowRepository.GetByValue(string value)
        {
            var bflowList = new List<BaseFlowModel>();
            string key = value;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select bf.Id as id, bf.name as name, 
                    bf.[key] as keyN, bf.flowchartpath as flowchart, 
                    uc.name as useCaseName, bf.useCaseId as useCaseId from BaseFlows bf
                    LEFT JOIN UseCases uc ON uc.id = bf.useCaseId where
                    bf.projectId=@projectId and 
                    (bf.[key] like '%'+@key+'%' or bf.name like '%'+@name+'%')";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bFlowModel = new BaseFlowModel();
                        bFlowModel.Id = (int)reader["id"];
                        bFlowModel.Name = reader["name"].ToString();
                        bFlowModel.Key = "FB-" + reader["keyN"].ToString();
                        bFlowModel.useCaseName = reader["useCaseName"].ToString();
                        bFlowModel.FlowChartPath = reader["flowchart"].ToString();
                        bflowList.Add(bFlowModel);
                        //bFlowModel.useCaseId = (int)reader["useCaseId"];
                    }
                }
            }
            return bflowList;
        }
    }
}
