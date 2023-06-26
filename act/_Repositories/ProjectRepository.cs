using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using act.Models;
using System.Data;

namespace act._Repositories
{
    public class ProjectRepository : BaseRepository, IProjectRepository
    {
        private object sqlDbType;

        public ProjectRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IProjectRepository.Add(ProjectModel projectModel)
        {
            throw new NotImplementedException();
        }

        void IProjectRepository.Edit(ProjectModel projectModel)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProjectModel> IProjectRepository.GetAll()
        {
            var projectList = new List<ProjectModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Projects order by id desc";
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
                command.Parameters.Add("@name", SqlDbType.Int).Value = name;

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
