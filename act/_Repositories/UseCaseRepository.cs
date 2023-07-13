using act.Models.UseCases;
using System.Data.SqlClient;
using System.Data;

namespace act._Repositories
{
    internal class UseCaseRepository : BaseRepository, IUseCaseRepository
    {
        private object sqlDbType;
        private int projectId;

        public UseCaseRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from UseCases where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IUseCaseRepository.Add(UseCaseModel useCaseModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //TODO: Corregir queries o parámetros nose
                command.CommandText = "Insert into UseCases values (@projectId, @key, @name, @flowChartPath,1,1)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = useCaseModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = useCaseModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = useCaseModel.FlowChartPath;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IUseCaseRepository.Edit(UseCaseModel useCaseModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update UseCases set name=@name, [key]=@key, flowChartPath=@flowChartPath where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = useCaseModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = useCaseModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = useCaseModel.Key;
                command.Parameters.Add("@flowChartPath", SqlDbType.NVarChar).Value = useCaseModel.FlowChartPath;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<UseCaseModel> IUseCaseRepository.GetAll()
        {
            var useCaseList = new List<UseCaseModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select Id, name, [key], flowchartpath, projectId from UseCases where projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var useCaseModel = new UseCaseModel();
                        useCaseModel.Id = (int)reader[0];
                        useCaseModel.Name = reader[1].ToString();
                        useCaseModel.Key = reader[2].ToString();
                        useCaseModel.FlowChartPath = reader[3].ToString();
                        useCaseModel.ProjectId = (int)reader[4];
                        useCaseList.Add(useCaseModel);
                    }
                }
            }
            return useCaseList;
        }

        IEnumerable<UseCaseModel> IUseCaseRepository.GetByValue(string value)
        {
            var useCaseList = new List<UseCaseModel>();
            int key = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from UseCases
                                        where [key]=@key or name like @name+'%'
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var useCaseModel = new UseCaseModel();
                        useCaseModel.Id = (int)reader[0];
                        useCaseModel.Name = reader[1].ToString();
                        useCaseModel.Key = reader[2].ToString();
                        useCaseModel.FlowChartPath = reader[3].ToString();
                        useCaseList.Add(useCaseModel);
                    }
                }
            }
            return useCaseList;
        }
    }
}
