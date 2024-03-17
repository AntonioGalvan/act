using act.Models.AlternativeFlows;
using act.Models.BaseAlternativeFlows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.BaseFlows;
using act.Models.UseCases;

namespace act._Repositories
{
    internal class BaseAlternativeRepository : BaseRepository, IBaseAlternativeRepository
    {
        private object sqlDbType;
        private int projectId;
        private int bFlowId;

        public BaseAlternativeRepository(string connectionString, int pProjectId, int pBFlowId)
        {
            this.connectionString = connectionString;
            this.projectId = pProjectId;
            this.bFlowId = pBFlowId;
        }

        public void Add(BaseAlternativeModel baFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Insert into BaseAlternativeFlows(ProjectId, BaseFlowId, AlternativeFlowId) values (@projectId, @baseFlowId, @alternativeFlowId)";
                command.Parameters.Add("@baseFlowId", SqlDbType.Int).Value = this.bFlowId;
                command.Parameters.Add("@alternativeFlowId", SqlDbType.NVarChar).Value = baFlowModel.AlternativeFlowId;


                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;

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
                
                command.CommandText = "Delete from BaseAlternativeFlows where id = @id and ProjectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<BaseAlternativeModel> GetAll()
        {
            var baFLowList = new List<BaseAlternativeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select baf.Id as Id, bf.[key] as BaseFlowKey, bf.name as BaseFlowName, " +
                    "af.[Key] as AlternativeFlowKey, af.name as AlternativeFlowName " +
                    "from BaseFlows bf, AlternativeFlows af, BaseAlternativeFlows baf " +
                    "where baf.BaseFlowId = bf.Id and baf.AlternativeFlowId = af.Id and baf.ProjectId = @projectId and bf.Id = @bFlowId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@bFlowId", SqlDbType.Int).Value = this.bFlowId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var baFlowModel = new BaseAlternativeModel();
                        baFlowModel.Id = (int)reader["Id"];
                        baFlowModel.baseFlowKey = "FB-" + reader["BaseFlowKey"].ToString();
                        baFlowModel.baseFlowName = reader["BaseFlowName"].ToString();
                        baFlowModel.alternativeFlowKey = "FA-" +  reader["AlternativeFlowKey"].ToString();
                        baFlowModel.alternativeFlowName = reader["AlternativeFlowName"].ToString();
                        baFLowList.Add(baFlowModel);
                    }
                }
            }
            return baFLowList;
        }

        public IEnumerable<AlternativeFlowModel> GetAllAlternativeFlows()
        {
            var aFlowList = new List<AlternativeFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Select Id, Name from AlternativeFlows " +
                    "where ProjectId = @projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    var empty = new AlternativeFlowModel();

                    while (reader.Read())
                    {
                        var aFlowModel = new AlternativeFlowModel();
                        aFlowModel.Id = (int)reader["Id"];
                        aFlowModel.Name = reader["Name"].ToString();
                        aFlowList.Add(aFlowModel);
                    }
                }
            }
            return aFlowList;
        }

        public IEnumerable<BaseAlternativeModel> GetByValue(string value)
        {
            var baFlowList = new List<BaseAlternativeModel>();
            string key = value;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //Buscamos por key o por nombre
                command.CommandText = @"Select baf.Id as Id, bf.[key] as BaseFlowKey, bf.name as BaseFlowName, " +
                    "af.[Key] as AlternativeFlowKey, af.name as AlternativeFlowName " +
                    "from BaseFlows bf, AlternativeFlows af, BaseAlternativeFlows baf " +
                    "where baf.BaseFlowId = bf.Id and baf.AlternativeFlowId = af.Id and baf.ProjectId = @projectId and bf.Id = @bFlowId and " +
                    "(af.[key] like '%'+@key+'%' or af.name like '%'+@name+'%')";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@bFlowId", SqlDbType.Int).Value = this.bFlowId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var baFlowModel = new BaseAlternativeModel();
                        baFlowModel.Id = (int)reader["Id"];
                        baFlowModel.baseFlowKey = "FB-" + reader["BaseFlowKey"].ToString();
                        baFlowModel.baseFlowName = reader["BaseFlowName"].ToString();
                        baFlowModel.alternativeFlowKey = "FA-" + reader["AlternativeFlowKey"].ToString();
                        baFlowModel.alternativeFlowName = reader["AlternativeFlowName"].ToString();
                        baFlowList.Add(baFlowModel);
                    }
                }
            }
            return baFlowList;
        }
    }
}
