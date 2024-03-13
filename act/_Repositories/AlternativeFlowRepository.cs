using act.Models.AlternativeFlows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.BaseFlows;

namespace act._Repositories
{
    internal class AlternativeFlowRepository : BaseRepository, IAlternativeFlowRepository
    {
        private int projectId;

        public AlternativeFlowRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from AlternativeFlows where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IAlternativeFlowRepository.Add(AlternativeFlowModel aFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Insert into AlternativeFlows(ProjectId, [Key], Name, FlowChartPath, DiagramElementStateId, ScreenElementStateId) values (@projectId, @key, @name, @flowChartPath,1,1)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = aFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = aFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = aFlowModel.FlowChartPath;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;

                command.ExecuteNonQuery();
            }
        }

        void IAlternativeFlowRepository.Edit(AlternativeFlowModel aFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Update AlternativeFlows set name=@name, [key]=@key, flowChartPath=@flowChartPath where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = aFlowModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = aFlowModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = aFlowModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = aFlowModel.FlowChartPath;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<AlternativeFlowModel> IAlternativeFlowRepository.GetAll()
        {
            var aFLowList = new List<AlternativeFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select af.Id as id, af.name as name, " +
                    "af.[key] as keyN, af.flowchartpath as flowchart " +
                    "from AlternativeFlows af " +
                    "where af.projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var aFlowModel = new AlternativeFlowModel();
                        aFlowModel.Id = (int)reader["id"];
                        aFlowModel.Name = reader["name"].ToString();
                        aFlowModel.Key = "FA-" + reader["keyN"].ToString();
                        aFlowModel.FlowChartPath = reader["flowchart"].ToString();
                        aFLowList.Add(aFlowModel);
                    }
                }
            }
            return aFLowList;
        }

        IEnumerable<AlternativeFlowModel> IAlternativeFlowRepository.GetByValue(string value)
        {
            var aflowList = new List<AlternativeFlowModel>();
            string key = value;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //Buscamos por key o por nombre
                command.CommandText = @"Select af.Id as id, af.name as name, 
                    af.[key] as keyN, af.flowchartpath as flowchart 
                    from AlternativeFlows af where af.projectId=@projectId and 
                    (af.[key] like '%'+@key+'%' or af.name like '%'+@name+'%')";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var aFlowModel = new AlternativeFlowModel();
                        aFlowModel.Id = (int)reader["id"];
                        aFlowModel.Name = reader["name"].ToString();
                        aFlowModel.Key = "FA-" + reader["keyN"].ToString();
                        aFlowModel.FlowChartPath = reader["flowchart"].ToString();
                        aflowList.Add(aFlowModel);
                        //bFlowModel.useCaseId = (int)reader["useCaseId"];
                    }
                }
            }
            return aflowList;
        }
    }
}
