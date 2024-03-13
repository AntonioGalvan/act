using act.Models.BaseFlows;
using act.Models.UseCases;
using System.Data;
using System.Data.SqlClient;

namespace act._Repositories
{
    //El repositorio realiza las consultas a BD y la mayor parte de la lógica

    //Heredamos de BaseRepository que incluye la cadena de conexión, además de implementar la interfaz para este elemento
    internal class BaseFlowRepository : BaseRepository, IBaseFlowRepository
    {
        private object sqlDbType;

        //Incluimos como atributo el id del proyecto al que pertenece este objeto
        private int projectId;

        //Para crear un flujo base necesitamos la cadena de conexión y el id del proyecto en el que estamos trabajando
        public BaseFlowRepository(string connectionString, int pProjectId)
        {
            this.connectionString = connectionString;
            this.projectId = pProjectId;
        }

        //Verifica que el flujo base que se esta por agregar o editar no use un caso de uso que ya tenga flujo base
        //Le enviamos como parámetros el id del flujo base y del caso de uso al que se quiere vincular
        public bool Check(int id, int? useCaseId)
        {
            //Creamos una lista para guardar los flujos base que obtendremos del query
            var bFlowList = new List<BaseFlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //Buscamos si otros flujos base que no sean el actual ya están vinculados al caso de uso que queremos usar
                command.CommandText = "Select id from BaseFlows where projectId=@projectId and UseCaseId=@useCaseId and id!=@id";

                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = useCaseId;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //creamos un objeto de tipo flujo base por cada registro y obtenemos sus atributos
                        var bUseCaseModel = new BaseFlowModel();
                        bUseCaseModel.Id = (int)reader[0];

                        //Agregamos cada objeto encontrado a la lista de flujos base
                        bFlowList.Add(bUseCaseModel);
                    }
                }
            }

            //Si encontramos otros flujos base que ya tienen el caso de uso registrado regresamos true, lo que evitará la acción
            //En caso de no encontrar otros flujos que utilicen el caso de uso regresmos false, lo que permitirá la acción
            if (bFlowList.Count >= 1)
                return true;
            else
                return false;
        }

        //Borrar flujo base
        //Pasamos como parámetro del id del flujo que deseamos eliminar
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //Borramos el flujo base que corresponda el id que indicamos y al proyecto actual
                command.CommandText = "Delete from BaseFlows where id = @id and projectId=@projectId";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@projectId", SqlDbType.Int).Value = projectId;
                command.ExecuteNonQuery();
            }
        }


        //Agregar flujo base
        //Pasamos como parámetro el objeto de tipo flujo base que deseamos guardar
        void IBaseFlowRepository.Add(BaseFlowModel bFlowModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //TODO: Corregir queries o parámetros nose

                //Si agregamos el flujo base con caso de uso
                if (bFlowModel.useCaseId != null)
                {
                    command.CommandText = "Insert into BaseFlows(ProjectId, [Key], Name, FlowChartPath, DiagramElementStateId, ScreenElementStateId, UseCaseId) values (@projectId, @key, @name, @flowChartPath,1,1, @useCaseId)";
                    command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = bFlowModel.useCaseId;
                }
                //Si agregamos el flujo base pero no indicamos el caso de uso
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

        //Editar flujo base
        //Pasamos como parámetro el objeto de tipo flujo base que deseamos guardar
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
                command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = (object)bFlowModel.useCaseId ?? DBNull.Value;

                command.ExecuteNonQuery();
            }
        }

        //Obtenemos todos los flujos base
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
                        //Leemos el id del caso de uso como null en caso de ser y como número en caso de tener un valor
                        bFlowModel.useCaseId = Convert.IsDBNull(reader["useCaseId"]) ? null : (int?)reader["useCaseId"];
                    }
                }
            }
            return bFLowList;
        }

        //Obtenemos todos los casos de uso para selección mediante lista
        IEnumerable<UseCaseModel> IBaseFlowRepository.GetAllUseCases(int? useCaseId)
        {

            var useCaseList = new List<UseCaseModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                //Si el flujo base seleccionado para editar no cuenta con caso de uso se usará el siguiente comando
                if (useCaseId == null)
                {
                    //Seleccionamos los casos de uso en los que no están incluido en los flujos base donde el id del caso de uso no es nulo
                    command.CommandText = "Select id,name from UseCases where id NOT IN " +
                    "(select UseCaseId from Baseflows where not useCaseId IS NULL)";
                }
                //Si el flujo base seleccionado para editar tiene un caso de uso no nulo se usará el siguiente comando
                else
                {
                    command.CommandText = "Select id,name from UseCases where id NOT IN " +
                    "(select useCaseId from BaseFlows where useCaseId!=@useCaseId and useCaseId NOT IN (select useCaseId from Baseflows where useCaseId != null))";

                    command.Parameters.Add("@useCaseId", SqlDbType.Int).Value = useCaseId;
                }

                using (var reader = command.ExecuteReader())
                {
                    //Creamos un objeto de tipo caso de uso con id 0 que simule ser la opción de "Ninguno" y lo añadimos a la lista
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

        //Obtenemos los flujos base por valor
        //Pedimos un string como parámetro
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
                //Buscamos por key o por nombre
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
