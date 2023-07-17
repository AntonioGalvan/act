using act.Models.Screens;
using System.Data.SqlClient;
using System.Data;

namespace act._Repositories
{
    internal class ScreenRepository : BaseRepository, IScreenRepository
    {
        private object sqlDbType;
        private int projectId;

        public ScreenRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from Screens where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IScreenRepository.Add(ScreenModel screenModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Screens([Key],Name,ImagePath,projectId,DiagramElementStateId,ScreenElementStateId) values (@key, @name, @imagePath, @projectId,1,1)";


                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = screenModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = screenModel.Key;
                command.Parameters.Add("@imagePath", SqlDbType.NVarChar).Value = screenModel.ImagePath;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IScreenRepository.Edit(ScreenModel screenModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Screens set name=@name, [Key]=@key, ImagePath=@imagePath where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = screenModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = screenModel.Name;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = screenModel.Key;
                command.Parameters.Add("@imagePath", SqlDbType.NVarChar).Value = screenModel.ImagePath;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<ScreenModel> IScreenRepository.GetAll()
        {
            var screenList = new List<ScreenModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select s.Id as Id, s.[Key] as keyN, s.Name as name, s.ImagePath as imagePath," +
                    " p.Name as projectName from Screens s, Projects p where s.projectId=@projectId and p.Id=s.projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var screenModel = new ScreenModel();
                        screenModel.Id = (int)reader["Id"];
                        screenModel.Key = "PA-" + reader["keyN"].ToString();
                        screenModel.Name = reader["name"].ToString();
                        screenModel.ImagePath = reader["imagePath"].ToString();
                        screenModel.Project = reader["projectName"].ToString();
                        screenList.Add(screenModel);
                    }
                }
            }
            return screenList;
        }

        IEnumerable<ScreenModel> IScreenRepository.GetByValue(string value)
        {
            var screenList = new List<ScreenModel>();
            string key = value;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select s.Id as Id, s.[Key] as keyN, s.Name as name, s.Purpose as purpose, p.Name as projectName from Screens s, Projects p 
                    where p.Id=s.projectId and (s.[Key] like '%'+@key+'%' or s.name like '%'+@name+'%')
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var screenModel = new ScreenModel();
                        screenModel.Id = (int)reader["Id"];
                        screenModel.Key = "PA-" + reader["keyN"].ToString();
                        screenModel.Name = reader["name"].ToString();
                        screenModel.ImagePath = reader["imagePath"].ToString();
                        screenModel.Project = reader["projectName"].ToString();
                        screenList.Add(screenModel);
                    }
                }
            }
            return screenList;
        }
    }
}
