using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using act.Models.Projects;

namespace act._Repositories
{
    internal class ProjectRepository : BaseRepository, IProjectRepository
    {
        private object sqlDbType;

        public ProjectRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete from Projects where id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
            }
        }

        void IProjectRepository.Add(ProjectModel projectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Projects values (@name, @description, @startDate, @endDate)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = projectModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = projectModel.Description;
                command.Parameters.Add("@startDate", SqlDbType.DateTime).Value = projectModel.StartDate;
                command.Parameters.Add("@endDate", SqlDbType.DateTime).Value = projectModel.EndDate;

                command.ExecuteNonQuery();
            }
        }

        void IProjectRepository.Edit(ProjectModel projectModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Projects set name=@name, description=@description, startDate=@startDate, endDate=@endDate where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = projectModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = projectModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = projectModel.Description;
                command.Parameters.Add("@startDate", SqlDbType.DateTime).Value = projectModel.StartDate;
                command.Parameters.Add("@endDate", SqlDbType.DateTime).Value = projectModel.EndDate;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<ProjectModel> IProjectRepository.GetAll()
        {
            var projectList = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Projects";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new ProjectModel();
                        projectModel.Id = (int)reader[0];
                        projectModel.Name = reader[1].ToString();
                        projectModel.Description = reader[2].ToString();
                        projectModel.StartDate = (DateTime)reader[3];
                        projectModel.EndDate = (DateTime)reader[4];
                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }

        IEnumerable<ProjectModel> IProjectRepository.GetByValue(string value)
        {
            var projectList = new List<ProjectModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Projects
                                        where id=@id or name like @name+'%'
                                        order by id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new ProjectModel();
                        projectModel.Id = (int)reader[0];
                        projectModel.Name = reader[1].ToString();
                        projectModel.Description = reader[2].ToString();
                        projectModel.StartDate = (DateTime)reader[3];
                        projectModel.EndDate = (DateTime)reader[4];
                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }
    }
}
