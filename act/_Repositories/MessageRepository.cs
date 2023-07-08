using System.Data.SqlClient;
using System.Data;
using act.Models.Messages;

namespace act._Repositories
{
    internal class MessageRepository : BaseRepository, IMessageRepository
    {
        private object sqlDbType;
        private int projectId;

        public MessageRepository(string connectionString, int pProjectId)
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
                command.CommandText = "Delete from Messages where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }

        void IMessageRepository.Add(MessageModel messageModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Messages values (@projectId, @key, @description)";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = this.projectId;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = messageModel.Key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = messageModel.Description;

                command.ExecuteNonQuery();
            }
        }

        void IMessageRepository.Edit(MessageModel messageModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update Messages set [key]=@key, description=@description where id=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = messageModel.Id;
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = messageModel.Key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = messageModel.Description;

                command.ExecuteNonQuery();
            }
        }

        IEnumerable<MessageModel> IMessageRepository.GetAll()
        {
            var messageList = new List<MessageModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Messages where projectId=@projectId";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var messageModel = new MessageModel();
                        messageModel.Id = (int)reader[0];
                        messageModel.ProjectId = (int)reader[1];
                        messageModel.Key = reader[2].ToString();
                        messageModel.Description = reader[3].ToString();
                        
                        messageList.Add(messageModel);
                    }
                }
            }
            return messageList;
        }

        IEnumerable<MessageModel> IMessageRepository.GetByValue(string value)
        {
            var messageList = new List<MessageModel>();
            int key = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Messages
                                        where keyN=@key or description like @description+'%'
                                        order by id desc";
                command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var messageModel = new MessageModel();
                        messageModel.Id = (int)reader[0];
                        messageModel.Key = reader[1].ToString();
                        messageModel.Description = reader[2].ToString();
                        messageList.Add(messageModel);
                    }
                }
            }
            return messageList;
        }
    }
}
