﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using act.Models.Rules;
using act.Models.Roles;

namespace act._Repositories
{
    internal class RuleRepository : BaseRepository, IRuleRepository
    {
        private object sqlDbType;
        private int projectId;

        public RuleRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from BusinessRules where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IRuleRepository.Add(BusinessRuleModel ruleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into BusinessRules([Key],Description,projectId,DiagramElementStateId,ScreenElementStateId) values (@key, @description, @projectId,1,1)";

                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = ruleModel.Key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = ruleModel.Description;

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;


                command.ExecuteNonQuery();
            }
        }

        void IRuleRepository.Edit(BusinessRuleModel ruleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update BusinessRules set [key]=@key, description=@description where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = ruleModel.Id;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = ruleModel.Key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = ruleModel.Description;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<BusinessRuleModel> IRuleRepository.GetAll()
        {
            var ruleList = new List<BusinessRuleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select r.Id as Id, r.[Key] as keyN, r.Description as description, " +
                    "p.Name as projectName from BusinessRules r, Projects p where r.projectId=@projectId and p.Id=r.projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ruleModel = new BusinessRuleModel();
                        ruleModel.Id = (int)reader["Id"];
                        ruleModel.Key = "RN-" + reader["keyN"].ToString();
                        ruleModel.Description = reader["description"].ToString();
                        ruleModel.Project = reader["projectName"].ToString();
                        ruleList.Add(ruleModel);
                    }
                }
            }
            return ruleList;
        }

        IEnumerable<BusinessRuleModel> IRuleRepository.GetByValue(string value)
        {
            var ruleList = new List<BusinessRuleModel>();
            int key = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select r.Id as Id, r.[Key] as keyN, 
                r.Description as description, p.Name as projectName from BusinessRules r, Projects p where p.Id=r.projectId 
                and (r.[Key] like '%'+@key+'%' or r.Description like '%'+@description+'%') order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ruleModel = new BusinessRuleModel();
                        ruleModel.Id = (int)reader["Id"];
                        ruleModel.Key = "RN-" + reader["keyN"].ToString();
                        ruleModel.Description = reader["description"].ToString();
                        ruleModel.Project = reader["projectName"].ToString();
                        ruleList.Add(ruleModel);
                    }
                }
            }
            return ruleList;
        }
    }
}
